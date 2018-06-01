using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using SalarySystemAPI.Models.PL;
using SalarySystemAPI.Models.DL;

namespace SalarySystemAPI.Controllers
{
    public class StopPaymentController : ApiController
    {

        [HttpGet]
        public DataTable SearchByEmpNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_StopPayment dlobj = new DL_StopPayment();
            DataTable dt = new DataTable();
            dt = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month);
            return dt;
        }

        [HttpPost]
        public DataTable SaveStopPayment(PL_StopPayment plobj)
        {
            DL_StopPayment objdl = new DL_StopPayment();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_SaveStopPayment(plobj);
                return dt;
            }
        }
    }
}
