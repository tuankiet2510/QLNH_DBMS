using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmShift : Form
    {
        ShiftBUS shiftBUS = new ShiftBUS();
        DataTable dtTable = null;
        public frmShift()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtTable = new DataTable();
                dtTable.Clear();
                dtTable = shiftBUS.GetAllShifts(DateTime.Now.ToString("yyyy-MM-dd"));
                dgvShift.DataSource = dtTable;
                dgvShift.AutoResizeColumns();

            }
            catch (SqlException e)
            {
                MessageBox.Show("Không lấy được nội dung trong table SANPHAM. Lỗi: " + e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmShiftAdd frmShiftAdd = new frmShiftAdd();
            frmShiftAdd.ShowDialog();
        }

        private void frmShift_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dpDate.Value;
            dtTable = shiftBUS.GetAllShifts(selectedDateTime.ToString("yyyy-MM-dd"));
            dgvShift.DataSource = dtTable;
            dgvShift.AutoResizeColumns();
        }
    }
}
