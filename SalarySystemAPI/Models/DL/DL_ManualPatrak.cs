using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using SalarySystemAPI.Models.PL;


namespace SalarySystemAPI.Models.DL
{
    public class DL_ManualPatrak
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        internal DataSet DL_FillAllLoadFun(int Flag = 0, int CityCode = 0, int MonthCd = 0, string Month = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpManualPatrak", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", Flag);
                cmd.Parameters.AddWithValue("@citycode", CityCode);
                cmd.Parameters.AddWithValue("@MonthCd", MonthCd);
                cmd.Parameters.AddWithValue("@month", Month);
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

        internal DataTable DL_FillEmp(int Flag = 0, int CityCode = 0, int EmpNo = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpManualPatrak", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", Flag);
                cmd.Parameters.AddWithValue("@Citycode", CityCode);
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch { return dt; }
            finally { con.Close(); con.Dispose(); }
        }

        internal DataTable DL_FillEdCd(int Flag = 0, int CityCode = 0, int EmpNo = 0, int Indication = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpManualPatrak", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", Flag);
                cmd.Parameters.AddWithValue("@Citycode", CityCode);
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);
                cmd.Parameters.AddWithValue("@Indication", Indication);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch { return dt; }
            finally { con.Close(); con.Dispose(); }
        }

        internal DataTable DL_Save(PL_ManualPatrak plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpManualPatrak", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", plobj.flag);
                cmd.Parameters.AddWithValue("@citycode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@Month", plobj.Month);
                cmd.Parameters.AddWithValue("@EmpNo", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@EffMonth", plobj.EffectiveMonth);
                cmd.Parameters.AddWithValue("@tblTypeManualPatrak", plobj.dt_Grid);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch { return dt; }
            finally { con.Close(); con.Dispose(); }
        }

        internal DataTable DL_CalculateFun(PL_ManualPatrak plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpManualPatrakCalculate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", plobj.flag);
                cmd.Parameters.AddWithValue("@citycode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@MonthCd", plobj.Month);

                cmd.Parameters.AddWithValue("@EmpNo", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@Sus", plobj.SuspendLeave);
                cmd.Parameters.AddWithValue("@totalLeave", plobj.TotalNoOfLeave);

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch { return dt; }
            finally { con.Close(); con.Dispose(); }
        }

        internal DataTable DL_GetData(int flag = 0, int CityCode = 0, int EmpNo = 0, string Month = "", string EffMonth = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpManualPatrak", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flag", flag);
                cmd.Parameters.AddWithValue("@citycode", CityCode);
                cmd.Parameters.AddWithValue("@empno", EmpNo);
                cmd.Parameters.AddWithValue("@month", Month);
                cmd.Parameters.AddWithValue("@EffMonth", EffMonth);
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