using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_MonthImport
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable DL_ImportData(PL_MonthImport plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpImportMonth", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", plobj.Ind);
                cmd.Parameters.AddWithValue("@MOnth", plobj.month);
                cmd.Parameters.AddWithValue("@MOnthCd", plobj.Monthcd);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch { return dt; }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}