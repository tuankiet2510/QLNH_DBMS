using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.DBConnect;
using DTO;

namespace DAO
{
    public class TableDAO
    {
        public TableDAO() { }
        public DataTable GetAllTables()
        {
            DataTable dtTable = new DataTable();

            string query = "SELECT * FROM BAN";
            SqlConnection con = getConnection.GetSqlConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            con.Close();
            sda.Fill(dtTable);

            if (dtTable.Rows.Count > 0)
            {
                Console.WriteLine("cor");
            }
            else
            {
                Console.WriteLine("Sai ");
            }
            return dtTable;
        }
        public bool UpdateTrangThaiBan(string maBan, string trangThai)
        {
            string queryInsert = "proc_UpdateTrangThaiBan @MaBan, @TrangThai";
            SqlConnection con = getConnection.GetSqlConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryInsert, con);
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@MaBan", maBan),
                    new SqlParameter("@TrangThai", trangThai),
                });
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw(ex);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public void UpdateTrangThaiBan(string maBan, string trangThai, string tienDatCoc, string maKH)
        {
            string queryInsert = "proc_UpdateTrangThaiBan @MaBan @TrangThai";
            SqlConnection con = getConnection.GetSqlConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryInsert, con);
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@MaSP", maBan),
                    new SqlParameter("@TenSP", trangThai),
                });
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
