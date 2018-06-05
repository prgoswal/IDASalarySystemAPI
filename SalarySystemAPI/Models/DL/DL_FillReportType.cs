using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SalarySystemAPI.Models.DL
{
    public class DL_FillReportType
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        internal DataSet Dl_FillSelectType(int Ind = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpFillReportType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch { return ds; }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        
         internal DataSet Dl_FillSelectTypes(int Ind = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpFillReportType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch { return ds; }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }


}
