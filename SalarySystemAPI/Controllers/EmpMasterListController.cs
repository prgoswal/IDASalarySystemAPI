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
    public class EmpMasterListController : ApiController
    {
        [HttpGet]
        public DataTable Bind_Zone(int Ind = 0, int CityCode = 0)
        {
            DL_EmpMasterList dlobj = new DL_EmpMasterList();
            DataTable dt = new DataTable();
            dt = dlobj.DL_FillZone(Ind, CityCode);
            return dt;
        }

        [HttpGet]
        public DataTable Bind_Ward(int Ind = 0, int CityCode = 0, int ZoneId = 0)
        {
            DL_EmpMasterList dlobj = new DL_EmpMasterList();
            DataTable dt = new DataTable();
            dt = dlobj.DL_FillWard(Ind, CityCode, ZoneId);
            return dt;
        }

        [HttpGet]
        public DataTable Bind_Section(int Ind = 0, int CityCode = 0)
        {
            DL_EmpMasterList dlobj = new DL_EmpMasterList();
            DataTable dt = new DataTable();
            dt = dlobj.DL_FillSection(Ind, CityCode);
            return dt;
        }

        [HttpGet]
        public DataTable Bind_SubSection(int Ind = 0, int CityCode = 0, int DeptCode = 0)
        {
            DL_EmpMasterList dlobj = new DL_EmpMasterList();
            DataTable dt = new DataTable();
            dt = dlobj.DL_FillSubsection(Ind, CityCode, DeptCode);
            return dt;
        }
    }
}
