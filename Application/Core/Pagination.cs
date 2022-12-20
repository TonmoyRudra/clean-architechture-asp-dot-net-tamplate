using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core
{
    public class Pagination
    {
        public Pagination(int pageSize, int pageNumber, int total)
        {
            this.PageSize = pageSize;
            this.PageIndex = pageNumber;
            this.Total = total;

        }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public int Total { get; set; }
        //public IReadOnlyList<T> Data { get; set; }
    }
}
