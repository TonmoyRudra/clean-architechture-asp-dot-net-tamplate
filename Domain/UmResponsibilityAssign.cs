using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UmResponsibilityAssign
    {
        public long RSPAGID { get; set; }

        public long USERID { get; set; }

        public long RSPID { get; set; }

        public string REMARKS { get; set; }

        public long? CREATED_BY { get; set; }

        public DateTime CREATION_DATE { get; set; }

        public long? LAST_UPDATE_BY { get; set; }

        public DateTime? LAST_UPDATE_DATE { get; set; }

        public bool? IS_INACTIVE { get; set; }
    }
}
