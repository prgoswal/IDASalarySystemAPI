using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalarySystemAPI.Models.DL;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Controllers
{
    public class EmployeeMasterController : ApiController
    {
        [HttpGet]
        public DataSet BindAll(int Ind = 0, int CityCode = 0)
        {
            Dl_EmployeeMaster dlobj = new Dl_EmployeeMaster();
            DataSet ds = new DataSet();
            if (Ind == 0)
            {
                return ds;
            }
            else
            {
                ds = dlobj.Dl_FillAllDropDown(Ind, CityCode);
                return ds;
            }
        }

        [HttpPost]
        public DataTable SaveAllInformation(PL_EmpMaster plobj)
        {
            Dl_EmployeeMaster dlobj = new Dl_EmployeeMaster();
            DataTable dt = new DataTable();
            dt = dlobj.Dl_SaveAllInfo(plobj);
            return dt;
        }

        [HttpGet]
        public DataTable FillClassDesc(int Ind = 0, int DesgCd = 0)
        {
            Dl_EmployeeMaster dlobj = new Dl_EmployeeMaster();
            DataTable dt = new DataTable();
            dt = dlobj.Dl_FillClassDesc(Ind, DesgCd);
            return dt;
        }

        [HttpGet]
        public DataSet SearchEmpInformation(int Ind = 0, int EmpNo = 0, int CityCode = 0)
        {
            Dl_EmployeeMaster dlobj = new Dl_EmployeeMaster();
            DataSet ds = new DataSet();
            ds = dlobj.Dl_FillEmpInformation(Ind, EmpNo, CityCode);
            return ds;
        }




        [HttpGet]
        public DataTable FillSection(int Ind = 0, int CityCode = 0, int CCCode = 0)
        {
            Dl_EmployeeMaster dlobj = new Dl_EmployeeMaster();
            DataTable dt = new DataTable();
            dt = dlobj.Dl_FillSection(Ind, CityCode, CCCode);
            return dt;
        }

        [HttpGet]
        public DataTable FillGrade(int Ind = 0, int CityCode = 0, int SalaryTypeInd = 0)
        {
            Dl_EmployeeMaster dlobj = new Dl_EmployeeMaster();
            DataTable dt = new DataTable();
            dt = dlobj.Dl_FillGrade(Ind, CityCode, SalaryTypeInd);
            return dt;
        }

        [HttpGet]
        public DataTable FillBranchAndIFSC(int Ind = 0, int BankCd = 0, int BranchCd = 0)
        {
            Dl_EmployeeMaster dlobj = new Dl_EmployeeMaster();
            DataTable dt = new DataTable();
            dt = dlobj.Dl_FillBranchAndIFSC(Ind, BankCd, BranchCd);
            return dt;
        }

        [HttpGet]
        public DataTable GetRetirmentDate(int Ind = 0, int RetirmentYear = 0, string Dob = "")
        {
            Dl_EmployeeMaster dlobj = new Dl_EmployeeMaster();
            DataTable dt = new DataTable();
            dt = dlobj.Dl_GetRetirmentDate(Ind, RetirmentYear, Dob);
            return dt;
        }

    }
}
