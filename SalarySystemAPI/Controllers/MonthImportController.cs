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
    public class MonthImportController : ApiController
    {
        [HttpPost]
        public DataTable Importdata(PL_MonthImport plobj)
        {
            DL_MonthImport objdl = new DL_MonthImport();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_ImportData(plobj);
                return dt;
            }
        }
    }
}
