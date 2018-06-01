using SalarySystemAPI.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models.DL
{
    public class DL_QryEmp
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable FillSection(int Ind = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpQueryEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                //cmd.Parameters.AddWithValue("@CityCode", CityCode);
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

        internal DataTable FillDesignation(int Ind = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpQueryEmp", con);
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

        internal DataTable DL_GetQtyDetails(PL_QryEmp plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpQueryEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@FirstName", plobj.FirstName);
                cmd.Parameters.AddWithValue("@FHName", plobj.FHName);
                cmd.Parameters.AddWithValue("@EmpNo", plobj.EmpNo);
                cmd.Parameters.AddWithValue("@DeptCd1", plobj.DeptCd);
                cmd.Parameters.AddWithValue("@SrNo", plobj.SrNo);
                cmd.Parameters.AddWithValue("@Dob", plobj.Dob);
                cmd.Parameters.AddWithValue("@Designation", plobj.DesignationCD);
                cmd.Parameters.AddWithValue("@SubSrNo", plobj.SubSrNo);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@Month", plobj.month);
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