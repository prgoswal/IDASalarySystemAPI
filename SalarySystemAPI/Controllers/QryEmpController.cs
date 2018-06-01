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
    public class QryEmpController : ApiController
    {
        [HttpGet]
        public DataTable Bind_Section(int Ind = 0, int CityCode = 0)
        {
            DL_QryEmp dlobj = new DL_QryEmp();
            DataTable dt = new DataTable();
            dt = dlobj.FillSection(Ind, CityCode);
            return dt;
        }

        [HttpGet]
        public DataTable Bind_Designation(int Ind = 0, int CityCode = 0)
        {
            DL_QryEmp dlobj = new DL_QryEmp();
            DataTable dt = new DataTable();
            dt = dlobj.FillDesignation(Ind, CityCode);
            return dt;
        }


        [HttpPost]
        public DataTable Get_QtyDetails(PL_QryEmp plobj)
        {
            DL_QryEmp objdl = new DL_QryEmp();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_GetQtyDetails(plobj);
                return dt;
            }
        }
    }
}
