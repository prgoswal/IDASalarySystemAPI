using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_PFCharges
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable DL_SearchByEmployeeNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "", int LvCd = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SP_PFCharges", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@empno", Empno);
                cmd.Parameters.AddWithValue("@month", month);
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

        internal DataTable DL_Save(PL_PFCharges plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SP_PFCharges", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@month", plobj.month);
                cmd.Parameters.AddWithValue("@empno", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@Basic", plobj.Basic);
                cmd.Parameters.AddWithValue("@Grade", plobj.Grade);
                cmd.Parameters.AddWithValue("@DA", plobj.DA);
                cmd.Parameters.AddWithValue("@PF", plobj.PF);
                cmd.Parameters.AddWithValue("@AdminCharge", plobj.AdminCharge);
                cmd.Parameters.AddWithValue("@SalTypeInd", plobj.SalTypeInd);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch { return dt; }
            finally { con.Close(); con.Dispose(); }
        }
    }
}