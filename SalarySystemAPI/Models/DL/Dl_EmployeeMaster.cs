using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SalarySystemAPI.Models.PL;

namespace SalarySystemAPI.Models.DL
{
    public class Dl_EmployeeMaster
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        internal DataSet Dl_FillAllDropDown(int Ind = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpEmployeeMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
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

        internal DataTable Dl_FillClassDesc(int Ind = 0, int DesgCd = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpEmployeeMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
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

        internal DataSet Dl_FillEmpInformation(int Ind = 0, int EmpNo = 0, int CityCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpEmployeeMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@Empno", EmpNo);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
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

        internal DataTable Dl_FillSection(int Ind = 0, int CityCode = 0, int CCCode = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpEmployeeMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@CCCode", CCCode);
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

        internal DataTable Dl_FillGrade(int Ind = 0, int CityCode = 0, int SalaryTypeInd = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpEmployeeMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@CityCode", CityCode);
                cmd.Parameters.AddWithValue("@SalaryTypeInd", SalaryTypeInd);
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

        internal DataTable Dl_FillBranchAndIFSC(int Ind = 0, int BankCd = 0, int BranchCd = 0)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpEmployeeMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@BnkCd", BankCd);
                cmd.Parameters.AddWithValue("@BrCd", BranchCd);
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

        internal DataTable Dl_GetRetirmentDate(int Ind = 0, int RetirmentYear = 0, string Dob = "")
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpEmployeeMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ind", Ind);
                cmd.Parameters.AddWithValue("@RetirmentYear", RetirmentYear);
                cmd.Parameters.AddWithValue("@Dob", Dob);
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

        internal DataTable Dl_SaveAllInfo(PL_EmpMaster plobj)
        {
            try
            {
                con = Connection.SetConnection();
                cmd = new SqlCommand("SpEmployeeMaster", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Ind", plobj.Ind);
                cmd.Parameters.AddWithValue("@CityCode", plobj.CityCode);
                cmd.Parameters.AddWithValue("@FormNo", plobj.FormNo);
                cmd.Parameters.AddWithValue("@Zone", plobj.Zone);
                cmd.Parameters.AddWithValue("@WardNo", plobj.WardNo);
                cmd.Parameters.AddWithValue("@Empno", plobj.Empno);
                cmd.Parameters.AddWithValue("@Sex", plobj.Sex);
                cmd.Parameters.AddWithValue("@EmpType", plobj.EmpType);
                cmd.Parameters.AddWithValue("@SalaryTypeInd", plobj.SalaryTypeInd);
                cmd.Parameters.AddWithValue("@Init", plobj.Init);
                cmd.Parameters.AddWithValue("@LastUpdDt", plobj.LastUpdDt);
                cmd.Parameters.AddWithValue("@FirstName", plobj.FirstName);
                cmd.Parameters.AddWithValue("@LastName", plobj.LastName);
                cmd.Parameters.AddWithValue("@FHName", plobj.FHName);
                cmd.Parameters.AddWithValue("@FirstNameH", plobj.FirstNameH);
                cmd.Parameters.AddWithValue("@LastNameH", plobj.LastNameH);
                cmd.Parameters.AddWithValue("@FhnameH", plobj.FhnameH);
                cmd.Parameters.AddWithValue("@NomineeName", plobj.NomineeName);
                cmd.Parameters.AddWithValue("@NomineeRel", plobj.NomineeRel);
                cmd.Parameters.AddWithValue("@NomineePer", plobj.NomineePer);
                cmd.Parameters.AddWithValue("@GPFNomineeName", plobj.GPFNomineeName);
                cmd.Parameters.AddWithValue("@GPFNomineeRel", plobj.GPFNomineeRel);
                cmd.Parameters.AddWithValue("@GPFNomineePer", plobj.GPFNomineePer);
                cmd.Parameters.AddWithValue("@RefNo", plobj.RefNo);
                cmd.Parameters.AddWithValue("@SrNo", plobj.SrNo);
                cmd.Parameters.AddWithValue("@SubSrNo", plobj.SubSrNo);
                cmd.Parameters.AddWithValue("@DesgCd", plobj.DesgCd);
                cmd.Parameters.AddWithValue("@GrdCd", plobj.GrdCd);
                cmd.Parameters.AddWithValue("@DeptCd1", plobj.DeptCd1);
                cmd.Parameters.AddWithValue("@DeptCd2", plobj.DeptCd2);
                cmd.Parameters.AddWithValue("@ClassInd", plobj.ClassInd);
                cmd.Parameters.AddWithValue("@aadhaarno", plobj.aadhaarno);
                cmd.Parameters.AddWithValue("@VoterId", plobj.VoterId);
                cmd.Parameters.AddWithValue("@Ctg", plobj.Ctg);
                cmd.Parameters.AddWithValue("@Dob", plobj.Dob);
                cmd.Parameters.AddWithValue("@Doj", plobj.Doj);
                cmd.Parameters.AddWithValue("@Doc", plobj.Doc);
                cmd.Parameters.AddWithValue("@Dop", plobj.Dop);
                cmd.Parameters.AddWithValue("@IncrDt", plobj.IncrDt);
                cmd.Parameters.AddWithValue("@IstIncremtDesg", plobj.IstIncremtDesg);
                cmd.Parameters.AddWithValue("@IncrDueDt", plobj.IncrDueDt);
                cmd.Parameters.AddWithValue("@Add1", plobj.Add1);
                cmd.Parameters.AddWithValue("@Add2", plobj.Add2);
                cmd.Parameters.AddWithValue("@Place1", plobj.Place1);
                cmd.Parameters.AddWithValue("@Place2", plobj.Place2);
                cmd.Parameters.AddWithValue("@Phone1", plobj.Phone1);
                cmd.Parameters.AddWithValue("@Phone2", plobj.Phone2);
                cmd.Parameters.AddWithValue("@BnkCd", plobj.BnkCd);
                cmd.Parameters.AddWithValue("@BrCd", plobj.BrCd);
                cmd.Parameters.AddWithValue("@BnkAcNo", plobj.BnkAcNo);
                cmd.Parameters.AddWithValue("@IFSCCODE", plobj.IFSCCODE);
                cmd.Parameters.AddWithValue("@MStatus", plobj.MStatus);
                cmd.Parameters.AddWithValue("@FamPlan", plobj.FamPlan);
                cmd.Parameters.AddWithValue("@NoOfChild", plobj.NoOfChild);
                cmd.Parameters.AddWithValue("@FemalChild", plobj.FemalChild);
                cmd.Parameters.AddWithValue("@BGroup", plobj.BGroup);
                cmd.Parameters.AddWithValue("@Handicapped", plobj.Handicapped);
                cmd.Parameters.AddWithValue("@HandiPercent", plobj.HandiPercent);
                cmd.Parameters.AddWithValue("@Deputation", plobj.Deputation);
                cmd.Parameters.AddWithValue("@DepuDt", plobj.DepuDt);
                cmd.Parameters.AddWithValue("@RrdtInd", plobj.RrdtInd);
                cmd.Parameters.AddWithValue("@RrdtDt", plobj.RrdtDt);
                cmd.Parameters.AddWithValue("@GpfAcNo", plobj.GpfAcNo);
                cmd.Parameters.AddWithValue("@ESICAcNo", plobj.ESICAcNo);
                cmd.Parameters.AddWithValue("@UANNO", plobj.UANNO);
                cmd.Parameters.AddWithValue("@Qualification", plobj.Qualification);
                cmd.Parameters.AddWithValue("@Basic", plobj.Basic);
                cmd.Parameters.AddWithValue("@SupRetDt", plobj.SupRetDt);
                cmd.Parameters.AddWithValue("@Month", plobj.Month);
                cmd.Parameters.AddWithValue("@NoPtax", plobj.NoPtax);
                cmd.Parameters.AddWithValue("@NoGpf", plobj.NoGpf);
                cmd.Parameters.AddWithValue("@AddlGpf", plobj.AddlGpf);
                cmd.Parameters.AddWithValue("@GpfLpDt", plobj.GpfLpDt);
                cmd.Parameters.AddWithValue("@GpfRefNo", plobj.GpfRefNo);
                cmd.Parameters.AddWithValue("@Schno", plobj.Schno);
                cmd.Parameters.AddWithValue("@SubSchno", plobj.SubSchno);
                cmd.Parameters.AddWithValue("@RecordNo", plobj.RecordNo);
                cmd.Parameters.AddWithValue("@OldPay", plobj.OldPay);
                cmd.Parameters.AddWithValue("@FesInd", plobj.FesInd);
                cmd.Parameters.AddWithValue("@GrihaJila", plobj.GrihaJila);
                cmd.Parameters.AddWithValue("@DepuFrom", plobj.DepuFrom);
                cmd.Parameters.AddWithValue("@PayBillNo", plobj.PayBillNo);
                cmd.Parameters.AddWithValue("@QualifiDetail", plobj.QualifiDetail);
                cmd.Parameters.AddWithValue("@DeputationPlace", plobj.DeputationPlace);
                cmd.Parameters.AddWithValue("@PanNo", plobj.PanNo);
                cmd.Parameters.AddWithValue("@PrivilegeLeave", plobj.PrivilegeLeave);
                cmd.Parameters.AddWithValue("@HafePayLeave", plobj.HafePayLeave);
                cmd.Parameters.AddWithValue("@AditionalInfor", plobj.AditionalInfor);
                cmd.Parameters.AddWithValue("@ApplicationDate", plobj.ApplicationDate);
                cmd.Parameters.AddWithValue("@BasicIncrDt", plobj.BasicIncrDt);
                cmd.Parameters.AddWithValue("@FixPay", plobj.FixPay);
                cmd.Parameters.AddWithValue("@PF12", plobj.PF12);
                cmd.Parameters.AddWithValue("@GPFIND", plobj.GPFIND);
                cmd.Parameters.AddWithValue("@Pfind", plobj.Pfind);
                cmd.Parameters.AddWithValue("@FPFind", plobj.FPFind);
                cmd.Parameters.AddWithValue("@AdminChargeind", plobj.AdminChargeind);
                cmd.Parameters.AddWithValue("@PFhigpen", plobj.PFhigpen);
                if (plobj.dtTemp.Rows.Count > 0)
                {
                    cmd.Parameters.AddWithValue("@Temp_NomneeTbl", plobj.dtTemp);
                }


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