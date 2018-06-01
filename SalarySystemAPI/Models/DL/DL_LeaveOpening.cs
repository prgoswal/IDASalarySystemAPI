using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_LeaveOpening
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
                cmd = new SqlCommand("SPLeaveOpening", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@EmpNo", Empno);
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

       internal DataTable DL_SaveRecord(PL_LeaveOpening plobj)
        {
           try
           {
               con = Connection.SetConnection();
               cmd =new SqlCommand("SPLeaveOpening", con);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@Ind", plobj.ind);
               cmd.Parameters.AddWithValue("@CITYCODE", plobj.CityCode);
               cmd.Parameters.AddWithValue("@month", plobj.Month);
               cmd.Parameters.AddWithValue("@empno", plobj.EmpNo);
               cmd.Parameters.AddWithValue("@LvCd", plobj.LvCd);
               cmd.Parameters.AddWithValue("@NoOfLv", plobj.NoOfLeave);
               cmd.Parameters.AddWithValue("@Narr", plobj.Narration);
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