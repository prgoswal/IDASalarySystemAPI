using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SalarySystemAPI.Models.DL;
using SalarySystemAPI.Models.PL;
using System.Data;


namespace SalarySystemAPI.Controllers
{
    public class Proc_FrmSalaryProcessingController : ApiController
    {
        [HttpPost]
        public DataTable AmendmentProcessing(PL_Proc_FrmSalaryProcessing plobj)
        {
            DataTable dt = new DataTable();
            DL_Proc_FrmSalaryProcessing dlobj = new DL_Proc_FrmSalaryProcessing();
            dt = dlobj.DL_AmendmentProcessing(plobj);
            return dt;
        }

        [HttpPost]
        public DataSet SalProcessing(PL_Proc_FrmSalaryProcessing plobj)
        {
            DataSet ds = new DataSet();
            DL_Proc_FrmSalaryProcessing dlobj = new DL_Proc_FrmSalaryProcessing();
            ds = dlobj.DL_SalProcessing(plobj);
            return ds;
        }
    }
}
