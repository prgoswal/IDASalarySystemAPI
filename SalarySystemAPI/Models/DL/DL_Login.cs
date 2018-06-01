using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SalarySystemAPI.Models.DL
{
    public class DL_Login
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        internal DataSet DL_CheckLoginInfo(int Ind = 0, string UserName = "", string Password = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return ds;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        internal DataTable DL_LogOut(int Ind = 0, string UserName = "", string Password = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        internal DataTable DL_FillMonth(int Ind = 0, int CityCode=0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCD", CityCode);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        internal DataTable DL_FillMonthYear(int Ind = 0, int CityCode = 0,int MonthCd=0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCD", CityCode);
                cmd.Parameters.AddWithValue("@MonthCd", MonthCd);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

    }
}