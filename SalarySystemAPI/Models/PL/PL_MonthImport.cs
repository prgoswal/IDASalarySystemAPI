using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.PL
{
    public class PL_MonthImport
    {
        public int Ind { get; set; }
        public int CityCode { get; set; }
        public int Monthcd { get; set; }
        public string month { get; set; }
        public int Saveind { get; set; }
    }
}