using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmTable : Form
    {
        TableBUS tableBus = new TableBUS();
        DataTable dtTable = null;
        public frmTable()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                dtTable = new DataTable();
                dtTable.Clear();
                dtTable = tableBus.GetAllTables();
                dgvTable.DataSource = dtTable;
                // Thay đổi độ rộng cột
                dgvTable.AutoResizeColumns();

            }
            catch (SqlException e)
            {
                MessageBox.Show("Không lấy được nội dung trong table SANPHAM. Lỗi: " + e);
            }
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string selectedMaBan = dgvTable.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrWhiteSpace(selectedMaBan))
            {
                MessageBox.Show("Bàn không hợp lệ");
            }
            else
            {
                frmTableAdd frmTableAdd = new frmTableAdd(selectedMaBan);
                frmTableAdd.ShowDialog();
            }
        }
    }
}
