using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmStaff : Form
    {
        public EmployeeBUS employeeBUS;
        public EmployeeDTO employeeDTO;
        public JobBUS jobBUS;
        public frmStaff()
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
            jobBUS = new JobBUS();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStaffDetail frm = new frmStaffDetail();
            frm.cbbMaCV.DataSource = jobBUS.MaTenCongViec();
            frm.cbbMaCV.ValueMember = "ID";
            frm.cbbMaCV.DisplayMember = "Display";
            frm.txtMaNV.ReadOnly = false;
            frm.Show();
            frmStaff_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string manv = dgvStaff.CurrentRow.Cells[0].Value.ToString();
            string honv = dgvStaff.CurrentRow.Cells[1].Value.ToString();
            string tennv = dgvStaff.CurrentRow.Cells[2].Value.ToString();
            DateTime ngaysinh = Convert.ToDateTime(dgvStaff.CurrentRow.Cells[3].Value);
            string sdt = dgvStaff.CurrentRow.Cells[4].Value.ToString();
            string macv = dgvStaff.CurrentRow.Cells[5].Value.ToString();
            int soca = Convert.ToInt32(dgvStaff.CurrentRow.Cells[6].Value);
            int thuong = Convert.ToInt32(dgvStaff.CurrentRow.Cells[7].Value);
            DateTime ngaytd = Convert.ToDateTime(dgvStaff.CurrentRow.Cells[8].Value);
            string hinhthuc = dgvStaff.CurrentRow.Cells[9].Value.ToString();
            employeeDTO = new EmployeeDTO(manv, honv, tennv, ngaysinh, sdt, macv, soca, thuong, ngaytd, hinhthuc);
            frmStaffDetail frm = new frmStaffDetail(employeeDTO);
            frm.txtMaNV.ReadOnly = true;
            frm.Show();
            frmStaff_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Remove Employee",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                string ID = dgvStaff.CurrentRow.Cells[0].Value.ToString();
                employeeDTO = new EmployeeDTO(ID);
                if(employeeBUS.deleteEmployee(employeeDTO))
                {
                    MessageBox.Show("Xóa thành công");
                    frmStaff_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }    
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string type = cmbSearchType.Text;
            employeeDTO = new EmployeeDTO(txtSearchStaff.Text, txtSearchStaff.Text, txtSearchStaff.Text, txtSearchStaff.Text);
            DataTable dt = employeeBUS.searchEmployee(employeeDTO, type);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tìm thành công");
                Load_data(dt);
            }
            else
            {
                MessageBox.Show("Không có nhân viên cần tìm");
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            Load_data(employeeBUS.getAllEmployee());
        }

        private void Load_data(DataTable temp)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = temp;
                dgvStaff.DataSource = dt;
                dgvStaff.AutoResizeColumns();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi: " + e);
            }
        }

        private void btnWage_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = employeeBUS.CalWageEmployee();
            FWage fwage = new FWage(dt);
            fwage.Show();
        }
    }
}
