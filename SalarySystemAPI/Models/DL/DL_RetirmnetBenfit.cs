using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_RetirmnetBenfit
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable DL_SearchByEmployeeNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPRetirmentBenfit", con);
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

        internal DataTable DL_GetYYYYmmdd(int Ind = 0, int CityCode = 0, int Empno = 0, string DOR = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPRetirmentBenfit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@DOR", DOR);
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

        internal DataTable DL_SaveRecord(PL_RetirmnetBenfit plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPRetirmentBenfit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@Month", plobj.Month);
                cmd.Parameters.AddWithValue("@GraduityTotalMonth", plobj.GraduityTotalMonth);
                cmd.Parameters.AddWithValue("@EmpNo", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@BasicAmt", plobj.BasicAmt);
                cmd.Parameters.AddWithValue("@GradePayAmt", plobj.GradePayAmt);
                cmd.Parameters.AddWithValue("@SelectType", plobj.SelectType);
                cmd.Parameters.AddWithValue("@DOJ", plobj.DOJ);
                cmd.Parameters.AddWithValue("@DOR", plobj.DOR);
                cmd.Parameters.AddWithValue("@NoOfLeave", plobj.NoOfLeave);
                cmd.Parameters.AddWithValue("@DaPer", plobj.DaPer);
                cmd.Parameters.AddWithValue("@PayableAmt", plobj.PayableAmt);
                cmd.Parameters.AddWithValue("@DaAmt", plobj.DaAmt);
                cmd.Parameters.AddWithValue("@NoOfYears", plobj.NoOfYears);
                cmd.Parameters.AddWithValue("@NoOfMonths", plobj.NoOfMonths);
                cmd.Parameters.AddWithValue("@NoOfDays", plobj.NoOfDays);
                cmd.Parameters.AddWithValue("@Status", plobj.Status);
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