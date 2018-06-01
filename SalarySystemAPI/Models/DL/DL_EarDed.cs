using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SalarySystemAPI.Models.PL;
using SalarySystemAPI.Models.DL;
using System.Data.SqlClient;


namespace SalarySystemAPI.Models.DL
{      
    public class DL_EarDed
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        internal DataTable FillddlGlCode(PL_EarDed plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpSalFillAllddl", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
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
        internal DataTable BindGrid(PL_EarDed plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPMstEarDed", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@Edcdind", plobj.Edcdind);
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

        internal DataTable SaveData(PL_EarDed plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPMstEarDed", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@Edcd", plobj.Edcd);
                cmd.Parameters.AddWithValue("@Desc", plobj.Desc);
                cmd.Parameters.AddWithValue("@AbrDesc", plobj.AbrDesc);
                cmd.Parameters.AddWithValue("@Priority", plobj.Priority);
                cmd.Parameters.AddWithValue("@Fixamt", plobj.Fixamt);
                cmd.Parameters.AddWithValue("@PerValue", plobj.PerValue);
                cmd.Parameters.AddWithValue("@GlCode", plobj.GlCode);
                cmd.Parameters.AddWithValue("@CarryCode", plobj.CarryCode);
                cmd.Parameters.AddWithValue("@Rangeind", plobj.Rangeind);
                cmd.Parameters.AddWithValue("@GROUPCODE", plobj.GROUPCODE);
                cmd.Parameters.AddWithValue("@AutoNo", plobj.AutoNo);
                cmd.Parameters.AddWithValue("@Edcdind", plobj.Edcdind);
                cmd.Parameters.AddWithValue("@Fixamt7", plobj.Fixamt7);
                cmd.Parameters.AddWithValue("@PerValue7", plobj.PerValue7);
                cmd.Parameters.AddWithValue("@PayInd", plobj.PayInd);
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