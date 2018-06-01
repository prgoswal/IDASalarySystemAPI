using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Models.DL
{
    public class DL_LeaveMaster
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        internal DataTable BindGrid(int Ind = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLeaveMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
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

        internal DataTable Save_LeaveMaster(PL_LeaveMaster plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLeaveMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CITYCODE);
                cmd.Parameters.AddWithValue("@LvDesc", plobj.LvDesc);
                cmd.Parameters.AddWithValue("@LvAbrDesc", plobj.LvAbrDesc);
                cmd.Parameters.AddWithValue("@MaxLimitLife", plobj.MaxLimitLife);
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