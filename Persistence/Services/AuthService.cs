using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;

        public AuthService(DataContext context)
        {
            _context = context;
        }

        public async Task<BMSecUser> Login(string username, string password)
        {
            var user = await _context.BMSecUsers.FirstOrDefaultAsync(u => u.LogUserID == username && u.EmailPassword == password);

            if (user == null)
                return null;

            return user;
        }

        public async Task<BMSecUser> LoginWithEmpID(decimal empId,decimal? userID)
        {
            var user = await _context.BMSecUsers.FirstOrDefaultAsync(u => u.HR_EmployeeID == empId && u.BM_UserID == (userID??0));

            if (user == null)
                return null;

            return user;
        }

        public async Task<BMSecUser> LoginWithHrEmpID(decimal empId)
        {
            var user = await _context.BMSecUsers.FirstOrDefaultAsync(u => u.HR_EmployeeID == empId);

            if (user == null)
                return null;

            return user;
        }


        public async Task<BMSecUser> LoginWithUserID(decimal userID)
        {
            var user = await _context.BMSecUsers.FirstOrDefaultAsync(u => u.BM_UserID == userID);

            if (user == null)
                return null;

            return user;
        }


        public async Task<BMSecUser> FindByEmailAsync(string email)
        {
            var user = await _context.BMSecUsers.FirstOrDefaultAsync(u => u.BM_UserID.ToString() == email);

            if (user == null)
                return null;

            return user;
        }


        public List<int> GetUserAccessFileLocationList(decimal? userId)
        {
            var query = @"SELECT BM_SecRoleUserStatus.EmployeeFileLocationBM_ItemIDUsers
FROM BM_SecUserGrantRole INNER JOIN
BM_SecRole ON BM_SecUserGrantRole.RoleID = BM_SecRole.RoleID INNER JOIN
BM_SecRoleUserStatus ON BM_SecRole.RoleID = BM_SecRoleUserStatus.RoleID INNER JOIN
BM_GeneralSetupUsers ON BM_SecRoleUserStatus.EmployeeFileLocationBM_ItemIDUsers = BM_GeneralSetupUsers.BM_ItemIDUsers
 Where (BM_SecUserGrantRole.BM_UserID =" + userId + ") AND BM_GeneralSetupUsers.Status='EmployeeFileLocation'";

            var usersWithRoles = new List<int>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                _context.Database.OpenConnection();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usersWithRoles.Add(reader.GetFieldValueAsync<int>(0).Result);

                    }
                }
            }

            return usersWithRoles;

            //return _context.Set<string>().FromSqlRaw("select itemValue from SSO_Essentials where itemKey='AES_KEY_REDIRECT'").FirstOrDefault();
        }


        public Task<List<HrEmployee>> GetAllEmployee(decimal? userId)
        {
            //var user = await _context.BMSecUsers.Where(x=>x.HR_EmployeeID != null && x.HR_EmployeeID.ToString().Contains(search)).Take(10).ToListAsync();
            var user = _context.HrEmployees.Where(x=>x.HR_EmployeeID > 0).Select(x =>
                new HrEmployee
                {
                    Email = x.Email,
                    HR_EmployeeID = x.HR_EmployeeID,
                    HR_EmployeeName = x.HR_EmployeeName,
                    EmployeeFileLocationBM_ItemIDUsers=x.EmployeeFileLocationBM_ItemIDUsers
                });

            //var list = user.ToList();

            //var user = await _context.BMSecUsers.ToListAsync();

            if (user == null)
                return null;

            var fileLocationList = GetUserAccessFileLocationList(userId);

            var userToReturn = user.ToList().FindAll(x => fileLocationList.Contains(x.EmployeeFileLocationBM_ItemIDUsers??0)).ToList();

            return Task.FromResult(userToReturn);
        }


        public Task<HrEmployee> GetEmployeeByHrId(decimal? empId)
        {
            //var user = await _context.BMSecUsers.Where(x=>x.HR_EmployeeID != null && x.HR_EmployeeID.ToString().Contains(search)).Take(10).ToListAsync();
            var user = _context.HrEmployees.Where(x => x.HR_EmployeeID == empId).Select(x =>
                new HrEmployee
                {
                    Email = x.Email,
                    HR_EmployeeID = x.HR_EmployeeID,
                    HR_EmployeeName = x.HR_EmployeeName,
                    EmployeeFileLocationBM_ItemIDUsers = x.EmployeeFileLocationBM_ItemIDUsers
                }).FirstOrDefault();

            //var list = user.ToList();

            //var user = await _context.BMSecUsers.ToListAsync();


            return Task.FromResult(user);
        }




        public async Task<string> CheckLoginAttemps(string username, string password)
        {
            try
            {
                var errorReturnMessage = string.Empty;


                var user = await _context.BMSecUsers.FirstOrDefaultAsync(u => u.LogUserID == username);
                if (user == null)
                {
                    errorReturnMessage = "Invalid username or password";
                }
                else
                {
                    var FailedAttemptTime = user.FailedAttemptsTime ?? DateTime.Now;
                    var FailedAttempts = user.FailedAttempts ?? 0;


                    errorReturnMessage = GetMessage(FailedAttempts, FailedAttemptTime);

                    if (string.IsNullOrEmpty(errorReturnMessage))
                    {
                        if (user.EmailPassword.Equals(password))
                        {
                            user.FailedAttempts = null;
                            user.FailedAttemptsTime = null;
                        }
                        else
                        {
                            user.FailedAttempts = (FailedAttempts + 1);
                            user.FailedAttemptsTime = FailedAttemptTime;
                        }

                        _context.Entry(user).State = EntityState.Modified;
                        _context.SaveChanges();
                    }
                }

                return errorReturnMessage;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static string GetMessage(decimal FailedAttempts, DateTime FailedAttemptTime)
        {
            var errorReturnMessage = string.Empty;

            if (FailedAttempts == 5 && (DateTime.Now.Subtract(FailedAttemptTime).TotalMinutes < 5))
            {
                errorReturnMessage = "Account Locked for 5 minutes";
            }
            else if (FailedAttempts == 10 && (DateTime.Now.Subtract(FailedAttemptTime).TotalMinutes < 30))
            {
                errorReturnMessage = "Account Locked for 30 minutes";
            }
            else if (FailedAttempts == 11)
            {
                errorReturnMessage = "Account Locked permanently";
            }
            return errorReturnMessage;

        }

        public async Task<List<UmResponsibilityAssign>> GetRolesAsync(long userId)
        {
            var roles = await _context.UmResponsibilityAssigns.Where(x=>x.USERID == userId).ToListAsync();

            return roles;
        }
    }
}
