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
    public class RrdIndicationController : ApiController
    {
        [HttpGet]
        public DataTable SearchByEmpNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_RrdIndication dlobj = new DL_RrdIndication();
            DataTable dt = new DataTable();
            dt = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month);
            return dt;
        }

        [HttpGet]
        public DataTable BindRRDType(int Ind = 0)
        {
            DL_RrdIndication dlobj = new DL_RrdIndication();
            DataTable dt = new DataTable();
            dt = dlobj.Dl_FillRRDtype(Ind);
            return dt;
        }

        [HttpPost]
        public DataTable UpdateRrdUP(PL_RrdIndication plobj)
        {
            DL_RrdIndication objdl = new DL_RrdIndication();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_UpdateRrdIndication(plobj);
                return dt;
            }
        }

    }
}
