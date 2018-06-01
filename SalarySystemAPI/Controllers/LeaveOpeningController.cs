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
    public class LeaveOpeningController : ApiController
    {
        [HttpGet]
        public DataTable SearchByEmpNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_LeaveOpening dlobj = new DL_LeaveOpening();
            DataTable dt = new DataTable();
            dt = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month);
            return dt;
        }

        
        [HttpPost]
        public DataTable SaveData(PL_LeaveOpening plobj)
        {
            DL_LeaveOpening dl = new DL_LeaveOpening();
            DataTable dt = new DataTable();
            if(plobj.ind==0)
            {
                return dt;
            }
            else
            {
                dt = dl.DL_SaveRecord(plobj);
                return dt;
            }

        }
    }
}
