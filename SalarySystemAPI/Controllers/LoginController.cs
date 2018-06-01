using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalarySystemAPI.Models.DL;
using System.Data;

namespace SalarySystemAPI.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public DataSet CheckLoginInfo(int Ind = 0, string UserName = "", string Password = "")
        {
            DL_Login dlobj = new DL_Login();
            DataSet ds = new DataSet();
            ds = dlobj.DL_CheckLoginInfo(Ind, UserName, Password);
            return ds;
        }

        [HttpGet]
        public DataTable LogOut(int Ind = 0, string UserName = "", string Password = "")
        {
            DL_Login dlobj = new DL_Login();
            DataTable dt = new DataTable();
            dt = dlobj.DL_LogOut(Ind, UserName, Password);
            return dt;
        }

        [HttpGet]
        public DataTable FillMonth(int Ind = 0, int CityCode=0)
        {
            DL_Login dlobj = new DL_Login();
            DataTable dt = new DataTable();
            dt = dlobj.DL_FillMonth(Ind, CityCode);
            return dt;
        }

        [HttpGet]
        public DataTable FillMonthYear(int Ind = 0, int CityCode = 0,int MonthCd=0)
        {
            DL_Login dlobj = new DL_Login();
            DataTable dt = new DataTable();
            dt = dlobj.DL_FillMonthYear(Ind, CityCode, MonthCd);
            return dt;
        }
    }
}
