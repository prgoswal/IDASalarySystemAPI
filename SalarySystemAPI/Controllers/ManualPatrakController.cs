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
    public class ManualPatrakController : ApiController
    {
        [HttpGet]
        public DataSet BindAllLoad(int Flag = 0, int CityCode = 0, int MonthCd = 0, string Month = "")
        {
            DataSet ds = new DataSet();
            DL_ManualPatrak dlobj = new DL_ManualPatrak();
            ds = dlobj.DL_FillAllLoadFun(Flag, CityCode, MonthCd, Month);
            return ds;
        }
        [HttpGet]
        public DataTable FillEmp(int Flag = 0, int CityCode = 0, int EmpNo = 0)
        {
            DataTable dt = new DataTable();
            DL_ManualPatrak dlobj = new DL_ManualPatrak();
            dt = dlobj.DL_FillEmp(Flag, CityCode, EmpNo);
            return dt;
        }
        [HttpGet]
        public DataTable FillEdCd(int Flag = 0, int CityCode = 0, int EmpNo = 0, int Indication = 0)
        {
            DataTable dt = new DataTable();
            DL_ManualPatrak dlobj = new DL_ManualPatrak();
            dt = dlobj.DL_FillEdCd(Flag, CityCode, EmpNo, Indication);
            return dt;
        }

        [HttpPost]
        public DataTable SaveManualPatrak(PL_ManualPatrak plobj)
        {
            DataTable dt = new DataTable();
            DL_ManualPatrak dlobj = new DL_ManualPatrak();
            dt = dlobj.DL_Save(plobj);
            return dt;
        }

        [HttpPost]
        public DataTable CalculateFun(PL_ManualPatrak plobj)
        {
            DataTable dt = new DataTable();
            DL_ManualPatrak dlobj = new DL_ManualPatrak();
            dt = dlobj.DL_CalculateFun(plobj);
            return dt;
        }


        [HttpGet]
        public DataTable GetData(int flag = 0, int CityCode = 0, int EmpNo = 0, string Month = "", string EffMonth = "")
        {
            DataTable dt = new DataTable();
            DL_ManualPatrak dlobj = new DL_ManualPatrak();
            dt = dlobj.DL_GetData(flag, CityCode, EmpNo, Month, EffMonth);
            return dt;
        }

    }
}
