using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SalarySystemAPI.Models.PL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SalarySystemAPI.Models.DL
{
    public class DL_Proc_FrmSalaryProcessing
    {
        DataTable dt;
        DataSet ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

        internal DataTable DL_AmendmentProcessing(PL_Proc_FrmSalaryProcessing plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpAMDProcessing", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", plobj.Flag);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@MonthCd", plobj.MonthCd);
                cmd.Parameters.AddWithValue("@DeptCd", plobj.DepartmentCd);
                cmd.Parameters.AddWithValue("@LotNoF", plobj.Lotnofrom);
                cmd.Parameters.AddWithValue("@LotNoTo", plobj.Lotnoto);
                cmd.Parameters.AddWithValue("@EmpNoFrom", plobj.Empnofrom);
                cmd.Parameters.AddWithValue("@EmpNoTo", plobj.Empnoto);
                cmd.Parameters.AddWithValue("@classind", plobj.ClassInd);
                cmd.Parameters.AddWithValue("@MOnth", plobj.Month);
                cmd.Parameters.AddWithValue("@EmpType", plobj.EmpType);

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch { return dt; }
            finally { con.Close(); con.Dispose(); }
        }

        internal DataSet DL_SalProcessing(PL_Proc_FrmSalaryProcessing plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("Sp_SalaryProcessing", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@MonthCd", plobj.MonthCd);
                cmd.Parameters.AddWithValue("@MOnth", plobj.Month);
                cmd.Parameters.AddWithValue("@DeptCd1", plobj.DepartmentCd);
                cmd.Parameters.AddWithValue("@LotNoF", plobj.Lotnofrom);
                cmd.Parameters.AddWithValue("@LotNoTo", plobj.Lotnoto);
                cmd.Parameters.AddWithValue("@EmpNoFrom", plobj.Empnofrom);
                cmd.Parameters.AddWithValue("@EmpNoTo", plobj.Empnoto);
                cmd.Parameters.AddWithValue("@Classind", plobj.ClassInd);
                cmd.Parameters.AddWithValue("@EmpType", plobj.EmpType);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch { return ds; }
            finally { con.Close(); con.Dispose(); }
        }
    }
}