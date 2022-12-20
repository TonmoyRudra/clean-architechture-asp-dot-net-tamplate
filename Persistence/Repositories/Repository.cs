using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class Repository<T> : IReposotory<T> where T : class
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetByExpressionAsync(Expression<Func<T,bool>> expression)
        {
            return await _context.Set<T>().Where(expression).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public IQueryable<T> GetQueryAble()
        {
            return _context.Set<T>().AsQueryable();
        }

        public IQueryable<T> FindListAllAsync(Expression<Func<T, bool>> expression)
        {
            var result = _context.Set<T>().Where(expression);

            return result.AsQueryable();
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
    }
}
