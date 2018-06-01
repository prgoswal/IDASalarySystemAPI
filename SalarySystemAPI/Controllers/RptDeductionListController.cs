using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalarySystemAPI.Models.DL;

namespace SalarySystemAPI.Controllers
{
    public class RptDeductionListController : ApiController
    {
        [HttpGet]
        public DataTable FilterHead(int Ind = 0, int CityCode = 0)
        {
            DataTable dt = new DataTable();
            DL_RptDeductionList dlobj = new DL_RptDeductionList();
            dt = dlobj.DL_FilterHead(Ind, CityCode);
            return dt;
        }
    }
}
