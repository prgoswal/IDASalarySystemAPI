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
    public class AmendmentErDdController : ApiController
    {
        [HttpGet]
        public DataTable BindDeductionHead(int Ind = 0, int Edcd = 0, int CityCode = 0)
        {
            DL_AmendmentErDd dlobj = new DL_AmendmentErDd();
            DataTable dt = new DataTable();
            dt = dlobj.FillDeductionHead(Ind, Edcd, CityCode);
            return dt;
        }

        [HttpGet]
        public DataTable BindEmployee(int Ind = 0, int CityCode = 0)
        {
            DL_AmendmentErDd dlobj = new DL_AmendmentErDd();
            DataTable dt = new DataTable();
            dt = dlobj.FillEmployee(Ind, CityCode);
            return dt;
        }

        [HttpGet]
        public DataSet SearchByEmpNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_AmendmentErDd dlobj = new DL_AmendmentErDd();
            DataSet ds = new DataSet();
            ds = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month);
            return ds;
        }

        [HttpGet]
        public DataTable BindGrid(int Ind = 0, int CityCode = 0, int DesgCd = 0)
        {
            DL_AmendmentErDd dlobj = new DL_AmendmentErDd();
            DataTable dt = new DataTable();
            dt = dlobj.FillGrid(Ind, CityCode, DesgCd);
            return dt;
        }

        [HttpGet]
        public DataTable GetOldAmt(int Ind = 0, int Empno = 0, int Edcd = 0, int CityCode = 0, string Month = "")
        {
            DL_AmendmentErDd dlobj = new DL_AmendmentErDd();
            DataTable dt = new DataTable();
            dt = dlobj.Findoldvalue(Ind, Empno, Edcd, CityCode, Month);
            return dt;
        }

        [HttpPost]
        public DataTable SaveAmendmentData(PL_AmendmentErDd plobj)
        {
            DL_AmendmentErDd objdl = new DL_AmendmentErDd();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_SaveAmendmentErDd(plobj);
                return dt;
            }
        }


        [HttpPost]
        public DataTable UpdateAmendmentData(PL_AmendmentErDd plobj)
        {
            DL_AmendmentErDd objdl = new DL_AmendmentErDd();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_UpdateAmendmentErDd(plobj);
                return dt;
            }
        }

        [HttpPost]
        public DataTable SearchEmployee(PL_AmendmentErDd plobj)
        {
            DL_AmendmentErDd objdl = new DL_AmendmentErDd();
            DataTable dt = new DataTable();
            dt = objdl.DL_SearchEmployee(plobj);
            return dt;
        }

    }
}
