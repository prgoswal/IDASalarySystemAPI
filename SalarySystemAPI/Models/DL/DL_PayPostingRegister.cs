using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_PayPostingRegister
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        internal DataSet BindGrid(PL_PayPostingRegister plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpPayPostingRegister", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@Edcdind", plobj.Edcdind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
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
        internal DataTable FillFyr(int Ind = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpPayPostingRegister", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
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