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
    public class BankController : ApiController
    {
        [HttpPost]
        public DataTable FillddlBank(PL_Bank plobj)
        {
            DL_Bank objdl = new DL_Bank();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.FillddlBank(plobj);
                return dt;
            }
        }

        [HttpPost]
        public DataTable SaveData(PL_Bank plobj)
        {
            DL_Bank objdl = new DL_Bank();
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


        [HttpPost]
        public DataTable BindGrid(PL_Bank plobj)
        {
            DL_Bank objdl = new DL_Bank();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_BindGrid(plobj);
                return dt;
            }
        }
    }
}
