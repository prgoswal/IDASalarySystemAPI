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
    public class FilterInformationController : ApiController
    {

        [HttpGet]
        public DataSet Bind_Getdata(int Ind = 0)
        {
            DL_FilterInformation dlobj = new DL_FilterInformation();
            DataSet ds = new DataSet();
            ds = dlobj.DL_GetData(Ind);
            return ds;
        }

        [HttpPost]
        public DataTable FilterGetData(PL_FilterInformation plobj)
        {
            DL_FilterInformation objdl = new DL_FilterInformation();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.Dl_GetGridRecord(plobj);
                return dt;
            }
        }

    }
}
