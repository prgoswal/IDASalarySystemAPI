using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_AmendmentErDd
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable FillDeductionHead(int Ind = 0, int Edcd = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("AmendmentErDd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@Edcdind", Edcd);
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

        internal DataTable FillEmployee(int Ind = 0, int CityCode = 0)
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

        internal DataSet DL_SearchByEmployeeNo(int Ind = 0, int CityCode = 0, int Empno = 0, string month = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("AmendmentErDd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@empno", Empno);
                cmd.Parameters.AddWithValue("@month", month);
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


        internal DataTable FillGrid(int Ind = 0, int CityCode = 0, int DesgCd = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("AmendmentErDd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@DesgCd", DesgCd);
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

        internal DataTable Findoldvalue(int Ind = 0, int Empno = 0, int Edcd = 0, int CityCode = 0, string Month = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("AmendmentErDd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@Empno", Empno);
                cmd.Parameters.AddWithValue("@Edcd", Edcd);
                cmd.Parameters.AddWithValue("@Month", Month);
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

        internal DataTable DL_SaveAmendmentErDd(PL_AmendmentErDd plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("AmendmentErDd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@Month", plobj.Month);
                //cmd.Parameters.AddWithValue("@Empno", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@AmendmentErDd", plobj.dt);
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

        internal DataTable DL_UpdateAmendmentErDd(PL_AmendmentErDd plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("AmendmentErDd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@Empno", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@Edcd", plobj.Edcd);
                cmd.Parameters.AddWithValue("@Month", plobj.Month);
                cmd.Parameters.AddWithValue("@NewAmt", plobj.NewAmt);
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

        internal DataTable DL_SearchEmployee(PL_AmendmentErDd plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("AmendmentErDd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@Edcd", plobj.Edcd);

                cmd.Parameters.AddWithValue("@DesgCd", plobj.DesiCode);
                cmd.Parameters.AddWithValue("@DeptCd1", plobj.DeptCode);
                cmd.Parameters.AddWithValue("@Class", plobj.ClassCode);
                cmd.Parameters.AddWithValue("@EmpType", plobj.EmpType);

                cmd.Parameters.AddWithValue("@OldAmt", plobj.OldAmt);

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