using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UM_MENU_ACCESS_V
    {
        public long RSPID { get; set; }

        public string RSPNAME { get; set; }

        public string RSPDESC { get; set; }

        public long LOOKUP_ID { get; set; }

        public string APP_NAME { get; set; }

        public string APP_SHORTCODE { get; set; }

        public string APP_ICONNAME { get; set; }

        public long AGID { get; set; }

        public string AGNAME { get; set; }

        public string AGDESCHELP { get; set; }

        public long MGID { get; set; }

        public string MGNAME { get; set; }

        public string SHORTCODE_MG { get; set; }

        public string ICONNAME_MG { get; set; }

        public string MGTOOLTIP { get; set; }

        public string MGRUOUTENAME { get; set; }

        public int? MGSERIALNO { get; set; }

        public long MID { get; set; }

        public string MENUNAME { get; set; }

        public string MENUTOOLTIP { get; set; }

        public string MENUSHORTNAME { get; set; }

        public string MENUDESCHELP { get; set; }

        public string ROUTINGNAME { get; set; }

        public string ICONNAME { get; set; }

        public long? SERIAL_NO { get; set; }

        public int CANVIEW { get; set; }

        public int CANINSERT { get; set; }

        public int CANUPDATE { get; set; }

        public int CANDELETE { get; set; }

        public decimal USERID { get; set; }

        public string LOGINNAME { get; set; }

        public string ADDRESSMENAME { get; set; }

        public string LOGINID { get; set; }

        public string EMAIL { get; set; }

        public decimal? EMP_ID { get; set; }

        public bool? INACTIVE_USER { get; set; }

        public bool? INACTIVE_RSP_ASSIGNMENT { get; set; }

        public bool? INCATIVE_ACCESS_GP { get; set; }

        public bool? INCATIVE_RSP { get; set; }

        public bool? INACTIVE_MENU { get; set; }

        public bool? INACTIVE_MENUGROUP { get; set; }
    }
}
