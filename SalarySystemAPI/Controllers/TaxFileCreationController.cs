using SalarySystemAPI.Models.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SalarySystemAPI.Models.PL;


namespace SalarySystemAPI.Controllers
{
    public class TaxFileCreationController : ApiController
    {
        [HttpGet]
        public DataTable BindTaxtFile(int Ind = 0)
        {
            DL_TaxFileCreation dlobj = new DL_TaxFileCreation();
            DataTable dt = new DataTable();
            dt = dlobj.FillTaxtFile(Ind);
            return dt;
        }

        [HttpPost]
        public DataTable TaxtFileData(PL_BankTextFileCreation plobj)
        {
            DL_TaxFileCreation dlobj = new DL_TaxFileCreation();
            DataTable dt = new DataTable();
            dt = dlobj.DL_TaxtFileData(plobj);
            return dt;
        }
    }
}
