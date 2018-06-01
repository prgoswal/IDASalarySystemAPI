using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.PL
{
    public class PL_Proc_FrmSalaryProcessing
    {
        public int Ind { set; get; }
        public int Flag { set; get; }
        public int CityCode { set; get; }
        public int MonthCd { set; get; }
        public int UserId { set; get; }
        public string Month { set; get; }

        // public int SelectType { set; get; }
        public int DepartmentCd { set; get; }
        public string Lotnofrom { set; get; }
        public string Lotnoto { set; get; }
        public string Empnofrom { set; get; }
        public string Empnoto { set; get; }
        public int ClassInd { set; get; }
        public int EmpType { set; get; }
        
    }
}