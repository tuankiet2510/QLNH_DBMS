using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.DBConnect;
using DTO;
using System.IO;

namespace DAO
{
    public class ShiftDAO
    {
        public ShiftDAO() { }
        public DataTable GetAllShifts(string dateTime)
        {
            DataTable dtTable = new DataTable();

            string query = $"proc_GetCaLamViecByDate @NgayLam = '{dateTime}'";
            SqlConnection con = getConnection.GetSqlConnection();
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dtTable);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                con.Close();
            }
            return dtTable;    
        }
        public bool createShift(ShiftDTO shiftDTO)
        {
            string queryInsert = "proc_ThemCaLam @MaCa, @NgayLam, @BatDau, @KetThuc";
            SqlConnection con = getConnection.GetSqlConnection();
            try
            {
                MemoryStream ms = new MemoryStream();
                con.Open();
                SqlCommand cmd = new SqlCommand(queryInsert, con);
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@MaCa", shiftDTO.Id),
                    new SqlParameter("@NgayLam", shiftDTO.WorkingDate.ToString("yyyy-MM-dd")),
                    new SqlParameter("@BatDau", shiftDTO.StartTime),
                    new SqlParameter("@KetThuc", shiftDTO.EndTime)
                });
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public bool createAssigment(AssignmentDTO assignmentDTO)
        {
            string queryInsert = "proc_PhanCong @MaCa, @MaNV, @NgayLam";
            SqlConnection con = getConnection.GetSqlConnection();
            try
            {
                MemoryStream ms = new MemoryStream();
                con.Open();
                SqlCommand cmd = new SqlCommand(queryInsert, con);
                cmd.Parameters.AddRange(new[]
                {
                    new SqlParameter("@MaCa", assignmentDTO.ShiftId),
                    new SqlParameter("@MaNV", assignmentDTO.EmployeeId),
                    new SqlParameter("@NgayLam", assignmentDTO.WorkingDate.ToString("yyyy-MM-dd"))
                });
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }
            return false;
        }
    }
}
