using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.PL
{
    public class PL_RrdIndication
    {
        public int Ind { get; set; }
        public int RrdtInd { get; set; }
        public string RRDDesc { get; set; }
        public Int32 CityCode { get; set; }
        public Int32 selecttype { get; set; }
        public string Date { get; set; }
        public int EmpNo { get; set; }
        public string month { get; set; }
        public DataTable dt = new DataTable();
    }
}