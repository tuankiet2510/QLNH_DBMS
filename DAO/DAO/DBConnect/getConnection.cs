using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DBConnect
{
    class getConnection
    {
        private const string sqlconnectstaff = @"Data Source=DESKTOP-EHURID8\SQLEXPRESS;Initial Catalog=QLNH;User ID=Staff;Password=123456;Integrated Security=true";
        private const string sqlconnectadmin = @"Data Source=DESKTOP-EHURID8\SQLEXPRESS;Initial Catalog=QLNH;User ID=Admin;Password=123456;Integrated Security=true";
        private const string sa = @"Data Source=DESKTOP-EHURID8\SQLEXPRESS;Initial Catalog=QLNH;User ID=sa;Password=123456;Integrated Security=true";
        

        public static SqlConnection GetSqlConnection(string role = null)
        {
            //SqlConnection conn = null;
            /* if (role.TrimEnd() == "AD")
             {
                 // Create connection
                 SqlConnection conn = new SqlConnection(sqlconnectadmin);
                 return conn;
             }
             else if (role == "NVNH" || role == "NVBH")
             {
                 SqlConnection conn = new SqlConnection(sqlconnectstaff);
                 return conn;
             }
             else
             {
                 SqlConnection conn = new SqlConnection(sqlconnectstaff);
                 return conn;
             }*/
            SqlConnection conn = new SqlConnection(sa);
            return conn;
        }
    }
}
