using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_LoanOpening
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
                cmd = new SqlCommand("SPLoanOpening", con);
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

        internal DataSet DL_GetLoanType(int Ind = 0, int CityCode = 0,int MonthCd=0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLoanOpening", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CITYCODE", CityCode);
                cmd.Parameters.AddWithValue("@MonthCd", MonthCd);
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


        internal DataTable DL_InterestRate(int Ind = 0, int CityCode = 0, int Edcd = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLoanOpening", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@Edcd", Edcd);
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

        internal DataTable DL_SaveRecord(PL_LoanOpening plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLoanOpening", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.ind);
                cmd.Parameters.AddWithValue("@CITYCODE", plobj.CityCode);
                cmd.Parameters.AddWithValue("@empno", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@LoanCd", plobj.LoanCd);
                cmd.Parameters.AddWithValue("@LoanSenctionDate", plobj.LoanSenctionDate);
                cmd.Parameters.AddWithValue("@ActualLoanAmt", plobj.ActualLoanAmt);
                cmd.Parameters.AddWithValue("@IntrestRate", plobj.IntrestRate);
                cmd.Parameters.AddWithValue("@InterstAmt", plobj.InterstAmt);
                cmd.Parameters.AddWithValue("@MonthlyInstalment", plobj.MonthlyInstalment);
                cmd.Parameters.AddWithValue("@NoOfInstalment", plobj.NoOfInstalment);
                cmd.Parameters.AddWithValue("@month", plobj.Month);
                cmd.Parameters.AddWithValue("@MonthCd", plobj.MonthCd);
                cmd.Parameters.AddWithValue("@FinYear", plobj.FinYear);
                cmd.Parameters.AddWithValue("@UserId", plobj.UserId);
                cmd.Parameters.AddWithValue("@Vno", plobj.Vno);
                cmd.Parameters.AddWithValue("@RefNo", plobj.RefNo);
                cmd.Parameters.AddWithValue("@Narration", plobj.Narration);
                cmd.Parameters.AddWithValue("@DeductionMonth", plobj.DeductionMonth);
                cmd.Parameters.AddWithValue("@UT_BulkLoanOpening", plobj.dtEmp);
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