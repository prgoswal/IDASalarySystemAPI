using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.PL
{
    public class PL_Bank
    {
        public int Ind { get; set; }
        public Int64 CityCode { get; set; }
        public int BnkCd { get; set; }
        public int BrCd { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public Int64 AutoNo { get; set; }
    }
}