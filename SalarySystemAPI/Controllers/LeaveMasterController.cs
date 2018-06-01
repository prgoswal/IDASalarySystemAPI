using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using SalarySystemAPI.Models.DL;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Controllers
{
    public class LeaveMasterController : ApiController
    {
        [HttpPost]
        public DataTable SaveData(PL_LeaveMaster plobj)
        {
            DL_LeaveMaster objdl = new DL_LeaveMaster();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.Save_LeaveMaster(plobj);
                return dt;
            }
        }


        [HttpGet]
        public DataTable LoadBindGridview(int Ind = 0, int CityCode = 0)
        {
            DL_LeaveMaster dlobj = new DL_LeaveMaster();
            DataTable dt = new DataTable();
            dt = dlobj.BindGrid(Ind, CityCode);
            return dt;
        }
    }
}
