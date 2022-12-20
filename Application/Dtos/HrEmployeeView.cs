using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class HrEmployeeView
    {
        public long EmpID { get; set; }
        public string EmployeeName { get; set; }
    }

    public class NonMgtEmployeeView
    {
        public long EmpID { get; set; }
        public string EmployeeName { get; set; }
        public long ETIN { get; set; }
    }

    public class ExcludeToPayrollEmployeeView
    {
        public decimal EmpID { get; set; }
        public string EmployeeName { get; set; }
        public string ETIN { get; set; }
        public string Designation { get; set; }
        public string Location { get; set; }
    }
}
