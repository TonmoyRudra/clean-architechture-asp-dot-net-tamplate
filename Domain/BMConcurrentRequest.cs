using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BMConcurrentRequest
    {
        public long PID { get; set; }

        public string Application { get; set; }

        public string RequestName { get; set; }

        public string RequestParameter { get; set; }

        public string ProcessStatus { get; set; }

        public string ExecutableString { get; set; }

        public DateTime? ProcessStartTime { get; set; }

        public DateTime? ProcessEndTime { get; set; }

        public string ErrorSummary { get; set; }

        public string IsActive { get; set; }

        public decimal CreatedByUserID { get; set; }

        public DateTime CreateDate { get; set; }

        public decimal? LastUpdateByUserID { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public string Remarks { get; set; }

        public int? NotifyUser { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public string RequestClassName { get; set; }
        public string TargetProcessManager { get; set; }
        public string RequestType { get; set; }
        public int? ReferenceID { get; set; }
        public string ReferenceDetails { get; set; }
        public string OutputFilePath { get; set; }
        public string OutputFileURL { get; set; }
        public string OutputText { get; set; }
    }
}
