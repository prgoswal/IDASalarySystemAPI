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
    public class EarDedController : ApiController
    {
        public DataTable FillddlGlCode(PL_EarDed plobj)
        {
            DL_EarDed objdl = new DL_EarDed();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.FillddlGlCode(plobj);
                return dt;
            }
        }

        public DataTable BindGrid(PL_EarDed plobj)
        {
            DL_EarDed objdl = new DL_EarDed();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.BindGrid(plobj);
                return dt;
            }
        }
        public DataTable SaveData(PL_EarDed plobj)
        {
            DL_EarDed objdl = new DL_EarDed();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.SaveData(plobj);
                return dt;
            }
        }
    }
}
