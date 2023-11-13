using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class TableBUS
    {
        TableDAO tableDAO = new TableDAO();
        public DataTable GetAllTables()
        {
            return tableDAO.GetAllTables();
        }
        public bool UpdateTrangThaiBan(string maBan, string trangThai)
        {
            return tableDAO.UpdateTrangThaiBan(maBan, trangThai);
        }
    }
}
