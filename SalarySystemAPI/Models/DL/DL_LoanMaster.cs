using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Models.DL
{
    public class DL_LoanMaster
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable Save_LoanMaster(PL_LoanMaster plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLoanMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@Edcd", plobj.Edcd);
                cmd.Parameters.AddWithValue("@LoanDesc", plobj.LoanDesc);
                cmd.Parameters.AddWithValue("@Avrdesc", plobj.Avrdesc);
                cmd.Parameters.AddWithValue("@IntRate", plobj.IntRate);
                cmd.Parameters.AddWithValue("@NoOfInst", plobj.NoOfInst);
                cmd.Parameters.AddWithValue("@LoanAmtRange1", plobj.LoanAmtRange1);
                cmd.Parameters.AddWithValue("@LoanAmtRange2", plobj.LoanAmtRange2);
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

       
        internal DataTable BindGrid(int Ind = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SPLoanMaster", con);
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

        internal DataTable FillLoanDescription(int Ind = 0)
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
    }
}