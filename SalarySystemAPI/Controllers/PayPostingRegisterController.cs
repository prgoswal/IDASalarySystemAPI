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
    public class PayPostingRegisterController : ApiController
    {
        public DataSet BindGrid(PL_PayPostingRegister plobj)
        {
            DL_PayPostingRegister objdl = new DL_PayPostingRegister();
            DataSet ds = new DataSet();
            if (plobj.Ind == 0)
            {
                return ds;
            }
            else
            {
                ds = objdl.BindGrid(plobj);
                return ds;
            }
        }

        [HttpGet]
        public DataTable BindFyr(int Ind = 0)
        {
            DL_PayPostingRegister dlobj = new DL_PayPostingRegister();
            DataTable dt = new DataTable();
            dt = dlobj.FillFyr(Ind);
            return dt;
        }
    }
}
