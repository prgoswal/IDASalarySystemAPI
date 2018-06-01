using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_FilterInformation
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataSet DL_GetData(int Ind = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("Sp_SelectCrt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
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


        internal DataTable Dl_GetGridRecord(PL_FilterInformation plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("Sp_SelectCrt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@MonthCd", plobj.MonthCd);
                cmd.Parameters.AddWithValue("@SelectStringParameter", plobj.SelectStringParameter);
                cmd.Parameters.AddWithValue("@FilterStringParameter", plobj.FilterStringParameter);
                cmd.Parameters.AddWithValue("@OrderByStringParameter", plobj.OrderByStringParameter);
                
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