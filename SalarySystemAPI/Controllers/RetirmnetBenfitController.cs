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
    public class RetirmnetBenfitController : ApiController
    {
        [HttpGet]
        public DataTable SearchByEmpNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_RetirmnetBenfit dlobj = new DL_RetirmnetBenfit();
            DataTable dt = new DataTable();
            dt = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month);
            return dt;
        }

        [HttpGet]
        public DataTable GetYYYYmmdd(int Ind = 0, int CityCode = 0, int Empno = 0, string DOR = "")
        {
            DL_RetirmnetBenfit dlobj = new DL_RetirmnetBenfit();
            DataTable dt = new DataTable();
            dt = dlobj.DL_GetYYYYmmdd(Ind, CityCode, Empno, DOR);
            return dt;
        }


        [HttpPost]
        public DataTable SaveData(PL_RetirmnetBenfit plobj)
        {
            DL_RetirmnetBenfit dl = new DL_RetirmnetBenfit();
            DataTable dt = new DataTable();
            dt = dl.DL_SaveRecord(plobj);
            return dt;
        }
    }
}
