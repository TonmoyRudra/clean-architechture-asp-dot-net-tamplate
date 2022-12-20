using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<BMSecUser> BMSecUsers { get; set; }
        public DbSet<UM_MENU_ACCESS_V> UM_MENU_ACCESS_V { get; set; }
        public DbSet<HrEmployee> HrEmployees { get; set; }
        public DbSet<UmResponsibilityAssign> UmResponsibilityAssigns { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
            builder.Entity<BMSecUser>().HasKey(x => x.BM_UserID);
            builder.Entity<BMSecUser>().Property(x => x.UserName).IsRequired();
            builder.Entity<BMSecUser>().Property(x => x.HR_EmployeeID).IsRequired(false);
            builder.Entity<BMSecUser>(b =>
            {
                b.ToTable("BM_SecUser");
            });

            builder.Entity<HrEmployee>().HasKey(x => x.HR_EmployeeID);
            builder.Entity<HrEmployee>(x => x.ToTable("HR_Employee"));


            builder.Entity<UmResponsibilityAssign>().HasKey(x => x.RSPAGID);

            builder.Entity<UmResponsibilityAssign>(b =>
            {
                b.ToTable("UM_RESPONSIBILITYASSIGN");
            });

           

            //
            builder.Entity<BMConcurrentRequest>().HasKey(x => x.PID);

            builder.Entity<BMConcurrentRequest>(b =>
            {
                b.ToTable("BM_ConcurrentRequest");
            });


            builder.Entity<BMCompanyBranch>().HasKey(x => x.BM_BranchID);
           

            builder.Entity<BMCompanyBranch>(b =>
            {
                b.ToTable("BM_CompanyBranch");
            });

            builder.Entity<UM_MENU_ACCESS_V>().HasNoKey();
           
        }
    }
}
