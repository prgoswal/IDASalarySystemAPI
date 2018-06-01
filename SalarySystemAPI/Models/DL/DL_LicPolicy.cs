using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_LicPolicy
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable Fill_LICType(int Ind = 0, int CityCode = 0)
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

        internal DataTable Fill_Division(int Ind = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpSalFillAllddl", con);
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

        internal DataTable Fill_PolicyType(int Ind = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpSalFillAllddl", con);
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

        internal DataTable Fill_Grid(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLICPolicyentry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode",CityCode);
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

        internal DataTable DL_SaveLicPolicy(PL_LicPolicy plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLICPolicyentry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@EmpNo", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@PolicyNo", plobj.PolicyNo);
                cmd.Parameters.AddWithValue("@PolicyAmt", plobj.PolicyAmt);
                cmd.Parameters.AddWithValue("@PolicyType", plobj.PolicyType);
                cmd.Parameters.AddWithValue("@PolicyTypeDese", plobj.PolicyTypeDese);
                cmd.Parameters.AddWithValue("@Installment", plobj.Installment);
                cmd.Parameters.AddWithValue("@StartDate", plobj.StartDate);
                cmd.Parameters.AddWithValue("@MaturityDate", plobj.MaturityDate);
                cmd.Parameters.AddWithValue("@DivCode", plobj.DivCode);
                cmd.Parameters.AddWithValue("@DivCodeDese", plobj.DivCodeDese);
                cmd.Parameters.AddWithValue("@Stop", plobj.Stop);
                cmd.Parameters.AddWithValue("@EDCD", plobj.Edcd);
                cmd.Parameters.AddWithValue("@EDDesc", plobj.EDDesc);
                cmd.Parameters.AddWithValue("@Month", plobj.Month);
                cmd.Parameters.AddWithValue("@CityCode", plobj.citycode);
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

        internal DataTable DL_StatusLicPolicy(PL_LicPolicy plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLICPolicyentry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@EmpNo", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@PolicyNo", plobj.PolicyNo);
                cmd.Parameters.AddWithValue("@CityCode", plobj.citycode);
                cmd.Parameters.AddWithValue("@Stop", plobj.Stop);
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

        internal DataTable DL_DeleteLicPolicy(PL_LicPolicy plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLICPolicyentry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@EmpNo", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@PolicyNo", plobj.PolicyNo);
                cmd.Parameters.AddWithValue("@Month", plobj.Month);
                cmd.Parameters.AddWithValue("@CityCode", plobj.citycode);
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