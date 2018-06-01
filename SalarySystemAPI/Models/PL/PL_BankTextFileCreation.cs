using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.PL
{
    public class PL_BankTextFileCreation
    {

        public int TextFileType { get; set; }
        public string Narration { get; set; }

        public int Flag { get; set; }

        public string MOnth { get; set; }
        public string CityCode
        {
            get;
            set;
        }
        public string BnkCd
        {
            get;
            set;
        }
        public string BrCd
        {
            get;
            set;
        }
        public string LotNoF
        {
            get;
            set;
        }
        public string LotNoTo
        {
            get;
            set;
        }
        public string Zone
        {
            get;
            set;
        }
        public string Ward
        {
            get;
            set;
        }
        public string DeptCd
        {
            get;
            set;
        }
        public string SubDeptCd
        {
            get;
            set;
        }
        public string LoanCode
        {
            get;
            set;
        }

        public string ClassInd
        {
            get;
            set;
        }

        public string EmpType
        {
            get;
            set;
        }
    }
}