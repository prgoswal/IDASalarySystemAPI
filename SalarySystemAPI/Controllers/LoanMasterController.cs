using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using SalarySystemAPI.Models;
using SalarySystemAPI.Models.DL;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Controllers
{
    public class LoanMasterController : ApiController
    {

        [HttpPost]
        public DataTable SaveData(PL_LoanMaster plobj)
        {
            DL_LoanMaster objdl = new DL_LoanMaster();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.Save_LoanMaster(plobj);
                return dt;
            }
        }


        [HttpGet]
        public DataTable LoadBindGridview(int Ind = 0, int CityCode = 0)
        {
            DL_LoanMaster dlobj = new DL_LoanMaster();
            DataTable dt = new DataTable();
            dt = dlobj.BindGrid(Ind, CityCode);
            return dt;
        }

        [HttpGet]
        public DataTable BindLoanDescription(int Ind = 0)
        {
            DL_LoanMaster dlobj = new DL_LoanMaster();
            DataTable dt = new DataTable();
            dt = dlobj.FillLoanDescription(Ind);
            return dt;
        }
    }
}
