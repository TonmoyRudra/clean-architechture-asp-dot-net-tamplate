using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class PaginationParams
    {
        private const int MaxPageSize = 50;
        public string Sort { get; set; }
        public int? BranchId { get; set; }
        public string Branch { get; set; }
        public string SalaryMonth { get; set; }
        public int? SellerId { get; set; }
        public long? HrEmpId { get; set; }
        public int PageIndex { get; set; } = 1;
        public int FyId { get; set; }
        public string FY_Title { get; set; }

        public decimal? UserId { get; set; }
        public int? AppId { get; set; }

        private int _pageSize = 6;
        public int PageSize
        {
            get => _pageSize;
            set
            {
                _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
            }
        }

        private string _search;
        public string Search
        {
            get => _search;
            set
            {
                _search = value.ToLower();
            }
        }
    }

    public class ConcurrentRequestParams
    {
        public int FyId { get; set; }
        public string FiscalYear { get; set; }
        public string Branch { get; set; }
        public int BranchId { get; set; }
        public string SalaryMonth { get; set; }
        public string PaymentDate { get; set; }
        public DateTime DtPaymentDate { get; set; }
        public string PaymentDetails { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string RequestName { get; set; }
        public decimal HrEmployeeId { get; set; }

    }
}
