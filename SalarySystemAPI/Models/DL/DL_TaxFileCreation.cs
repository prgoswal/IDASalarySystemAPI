using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Models.DL
{
    public class DL_TaxFileCreation
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        internal DataTable FillTaxtFile(int Ind = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("Sp_BankTextFile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", Ind);
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

        internal DataTable DL_TaxtFileData(PL_BankTextFileCreation plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("Sp_BankTextFile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Flag", plobj.Flag);
                cmd.Parameters.AddWithValue("@BnkCd", plobj.BnkCd);
                cmd.Parameters.AddWithValue("@BrCd", plobj.BrCd);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@DeptCd", plobj.DeptCd);
                cmd.Parameters.AddWithValue("@LotNoF", plobj.LotNoF);
                cmd.Parameters.AddWithValue("@LotNoTo", plobj.LotNoTo);

                cmd.Parameters.AddWithValue("@Classind", plobj.ClassInd);
                cmd.Parameters.AddWithValue("@Emptype", plobj.EmpType);

                cmd.Parameters.AddWithValue("@SubDeptCd", plobj.SubDeptCd);
                cmd.Parameters.AddWithValue("@MOnth", plobj.MOnth);
                cmd.Parameters.AddWithValue("@Ward", plobj.Ward);
                cmd.Parameters.AddWithValue("@Zone", plobj.Zone);
                cmd.Parameters.AddWithValue("@TextFileType", plobj.TextFileType);
                cmd.Parameters.AddWithValue("@Narration", plobj.Narration);
                cmd.Parameters.AddWithValue("@LoanCode", plobj.LoanCode);
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