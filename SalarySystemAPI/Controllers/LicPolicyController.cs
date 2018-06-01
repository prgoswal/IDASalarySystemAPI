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
    public class LicPolicyController : ApiController
    {
        [HttpGet]
        public DataTable Bind_Lictype(int Ind = 0, int CityCode = 0)
        {
            DL_LicPolicy dlobj = new DL_LicPolicy();
            DataTable dt = new DataTable();
            dt = dlobj.Fill_LICType(Ind, CityCode);
            return dt;
        }

        [HttpGet]
        public DataTable Bind_Division(int Ind = 0)
        {
            DL_LicPolicy dlobj = new DL_LicPolicy();
            DataTable dt = new DataTable();
            dt = dlobj.Fill_Division(Ind);
            return dt;
        }

        [HttpGet]
        public DataTable Bind_PolicyType(int Ind = 0)
        {
            DL_LicPolicy dlobj = new DL_LicPolicy();
            DataTable dt = new DataTable();
            dt = dlobj.Fill_PolicyType(Ind);
            return dt;
        }

        [HttpGet]
        public DataTable Bind_Grid(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_LicPolicy dlobj = new DL_LicPolicy();
            DataTable dt = new DataTable();
            dt = dlobj.Fill_Grid(Ind, CityCode, Empno, month);
            return dt;
        }


        [HttpPost]
        public DataTable Save_PolicyType(PL_LicPolicy plobj)
        {
            DL_LicPolicy objdl = new DL_LicPolicy();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_SaveLicPolicy(plobj);
                return dt;
            }
        }

        [HttpPost]
        public DataTable StatusUpdate_PolicyType(PL_LicPolicy plobj)
        {
            DL_LicPolicy objdl = new DL_LicPolicy();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_StatusLicPolicy(plobj);
                return dt;
            }
        }


        [HttpPost]
        public DataTable Delete_PolicyType(PL_LicPolicy plobj)
        {
            DL_LicPolicy objdl = new DL_LicPolicy();
            DataTable dt = new DataTable();
            if (plobj.Ind == 0)
            {
                return dt;
            }
            else
            {
                dt = objdl.DL_DeleteLicPolicy(plobj);
                return dt;
            }
        }
    }
}
