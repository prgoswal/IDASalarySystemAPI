using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SalarySystemAPI.Models
{
    public class Connection
    {
        static SqlConnection con;
        public static SqlConnection SetConnection()
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }
            catch
            {
                con.Close();
                return con;
            }
        }
    }
}