using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_StopPayment
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable DL_SaveStopPayment(PL_StopPayment plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPStopPayment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@Date", plobj.Date);
                cmd.Parameters.AddWithValue("@Empno", plobj.Empno);
                cmd.Parameters.AddWithValue("@Month", plobj.Month);
                cmd.Parameters.AddWithValue("@StopReason", plobj.StopReason);
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

        internal DataTable DL_SearchByEmployeeNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPStopPayment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@Empno", Empno);
                cmd.Parameters.AddWithValue("@Month", month);
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