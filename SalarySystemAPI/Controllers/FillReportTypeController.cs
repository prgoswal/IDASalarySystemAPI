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
    public class FillReportTypeController : ApiController
    {
        [HttpGet]
        public DataSet FillSelectType(int Ind = 0, int CityCode = 0)
        {
            DL_FillReportType dlobj = new DL_FillReportType();
            DataSet ds = new DataSet();

            if (Ind == 0)
            {
                return ds;
            }
            else
            {
                ds = dlobj.Dl_FillSelectType(Ind,CityCode);
                return ds;
            }
        }


    }
}
