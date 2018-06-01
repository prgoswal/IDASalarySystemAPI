using SalarySystemAPI.Models.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalarySystemAPI.Controllers
{
    public class RptquarterlyController : ApiController
    {
        [HttpGet]
        public DataTable FillMonth(int Ind = 0)
        {
            DL_Rptquarterly dlobj = new DL_Rptquarterly();
            DataTable dt = new DataTable();
            dt = dlobj.DL_GetMonth(Ind);
            return dt;
        }
    }
}
