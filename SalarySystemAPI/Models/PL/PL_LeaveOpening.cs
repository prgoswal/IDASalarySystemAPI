using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.PL
{
    public class PL_LeaveOpening
    {
        public int ind { set; get; }
        public Int64 CityCode { set; get; }
        public string Month { set; get; }
        public Int64 EmpNo { set; get; }
        public int LvCd { set; get; }
        public decimal NoOfLeave { set; get; }
        public string Narration { set; get; }
        public string EnteryDateTime { set; get; }

    }
}