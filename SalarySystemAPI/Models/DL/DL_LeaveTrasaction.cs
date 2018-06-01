using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Models.DL
{
    public class DL_LeaveTrasaction
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable Fill_TypeOfLeave(int Ind = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpSalFillAllddl", con);
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

        internal DataTable DL_SearchByEmployeeNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "", int LvCd=0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLeaveTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@empno", Empno);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@LvCd", LvCd);
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

        internal DataTable DL_BindSuspendCase(int Ind = 0, int CityCode = 0, string month = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLeaveTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CITYCODE", CityCode);
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

        internal DataTable DL_DeleteSuspenCase(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "", string Narration = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLeaveTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@empno", Empno);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@Narr", Narration);
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


        internal DataTable DL_SaveTransMaster(PL_LeaveTrasaction plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLeaveTransaction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CITYCODE", plobj.CityCode);
                cmd.Parameters.AddWithValue("@empno", plobj.Empno);
                cmd.Parameters.AddWithValue("@LvCd", plobj.LvCd);
                cmd.Parameters.AddWithValue("@NoOfLv", plobj.NoOfLv);
                cmd.Parameters.AddWithValue("@DateFrom", plobj.DateFrom);
                cmd.Parameters.AddWithValue("@DateTo", plobj.DateTo);
                cmd.Parameters.AddWithValue("@month", plobj.Month);
                cmd.Parameters.AddWithValue("@Upd_Ind", plobj.Upd_Ind);
                cmd.Parameters.AddWithValue("@Narr", plobj.Narr);
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