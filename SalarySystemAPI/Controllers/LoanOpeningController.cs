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
    public class LoanOpeningController : ApiController
    {
        [HttpGet]
        public DataTable SearchByEmpNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            DL_LoanOpening dlobj = new DL_LoanOpening();
            DataTable dt = new DataTable();
            dt = dlobj.DL_SearchByEmployeeNo(Ind, CityCode, Empno, month);
            return dt;
        }

        [HttpGet]
        public DataSet GetLoanType(int Ind = 0, int CityCode = 0,int MonthCd=0)
        {
            DL_LoanOpening dlobj = new DL_LoanOpening();
            DataSet ds = new DataSet();
            ds = dlobj.DL_GetLoanType(Ind, CityCode,MonthCd);
            return ds;
        }

        [HttpGet]
        public DataTable GetInterestRate(int Ind = 0, int CityCode = 0, int Edcd = 0)
        {
            DL_LoanOpening dlobj = new DL_LoanOpening();
            DataTable dt = new DataTable();
            dt = dlobj.DL_InterestRate(Ind, CityCode, Edcd);
            return dt;
        }

        [HttpPost]
        public DataTable SaveData(PL_LoanOpening plobj)
        {
            DL_LoanOpening dl = new DL_LoanOpening();
            DataTable dt = new DataTable();
            if (plobj.ind == 0)
            {
                return dt;
            }
            else
            {
                dt = dl.DL_SaveRecord(plobj);
                return dt;
            }

        }
    }
}
