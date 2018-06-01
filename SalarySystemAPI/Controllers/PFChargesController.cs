using SalarySystemAPI.Models.DL;
using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalarySystemAPI.Controllers
{
    public class PFChargesController : ApiController
    {
        [HttpGet]
        public DataTable SearchByEmpNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_PFCharges dlobj = new DL_PFCharges();
            DataTable dt = new DataTable();
            dt = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month);
            return dt;
        }

        [HttpPost]
        public DataTable SavePFCharges(PL_PFCharges plobj)
        {
            DataTable dt = new DataTable();
            DL_PFCharges dlobj = new DL_PFCharges();
            dt = dlobj.DL_Save(plobj);
            return dt;
        }
    }
}
