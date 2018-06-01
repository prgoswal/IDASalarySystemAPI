using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using SalarySystemAPI.Models.DL;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Controllers
{
    public class LeaveTrasactionController : ApiController
    {

        [HttpGet]
        public DataTable Bind_TypeOfLeave(int Ind = 0, int CityCode = 0)
        {
            DL_LeaveTrasaction dlobj = new DL_LeaveTrasaction();
            DataTable dt = new DataTable();
            dt = dlobj.Fill_TypeOfLeave(Ind, CityCode);
            return dt;
        }


        [HttpGet]
        public DataTable SearchByEmpNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_LeaveTrasaction dlobj = new DL_LeaveTrasaction();
            DataTable dt = new DataTable();
            dt = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month);
            return dt;
        }

        [HttpPost]
        public DataTable SaveData(PL_LeaveTrasaction plobj)
        {
            DL_LeaveTrasaction objdl = new DL_LeaveTrasaction();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_SaveTransMaster(plobj);
                return dt;
            }
        }

        [HttpPost]
        public DataTable UpdateData(PL_LeaveTrasaction plobj)
        {
            DL_LeaveTrasaction objdl = new DL_LeaveTrasaction();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_SaveTransMaster(plobj);
                return dt;
            }
        }

        [HttpGet]
        public DataTable DeleteData(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "", int LvCd = 0)
        {
            DL_LeaveTrasaction dlobj = new DL_LeaveTrasaction();
            DataTable dt = new DataTable();
            dt = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month, LvCd);
            return dt;
        }

        [HttpGet]
        public DataTable BindSuspendCase(int Ind = 0, int CityCode = 0, string month = "")
        {
            DL_LeaveTrasaction dlobj = new DL_LeaveTrasaction();
            DataTable dt = new DataTable();
            dt = dlobj.DL_BindSuspendCase(Ind, CityCode, month);
            return dt;
        }

        [HttpGet]
        public DataTable DeleteSuspenCase(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "", string Narration = "")
        {
            DL_LeaveTrasaction dlobj = new DL_LeaveTrasaction();
            DataTable dt = new DataTable();
            dt = dlobj.DL_DeleteSuspenCase(Ind, CityCode, Empno, month, Narration);
            return dt;
        }
    }
}
