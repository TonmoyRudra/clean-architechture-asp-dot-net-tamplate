using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAuthService
    {
        Task<BMSecUser> Login(string username, string password);
        Task<BMSecUser> LoginWithEmpID(decimal empId,decimal? userID);
        Task<string> CheckLoginAttemps(string username, string password);
        Task<List<UmResponsibilityAssign>> GetRolesAsync(long userId);
        Task<BMSecUser> FindByEmailAsync(string email);
        Task<List<HrEmployee>> GetAllEmployee(decimal? userId);
        List<int> GetUserAccessFileLocationList(decimal? userId);
        Task<BMSecUser> LoginWithUserID(decimal userID);
        Task<BMSecUser> LoginWithHrEmpID(decimal empId);
        Task<HrEmployee> GetEmployeeByHrId(decimal? empId);
    }
}
