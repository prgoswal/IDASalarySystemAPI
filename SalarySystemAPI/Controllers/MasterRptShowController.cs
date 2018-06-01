using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using SalarySystemAPI.Models.DL;

namespace SalarySystemAPI.Controllers
{
    public class MasterRptShowController : ApiController
    {
        [HttpGet]
        public DataTable BindSelectReport(int Ind = 0)
        {
            DL_MasterRptShow dlobj = new DL_MasterRptShow();
            DataTable dt = new DataTable();
            dt = dlobj.DL_FillSelectReport(Ind);
            return dt;
        }
    }
}
