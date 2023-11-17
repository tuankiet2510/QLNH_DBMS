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
                Load_data();
            }
            else
            {
                MessageBox.Show("Không có nhân viên cần tìm");
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void Load_data()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                dt = employeeBUS.getAllEmployee();
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

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvStaff.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                frmStaffDetail frm = new frmStaffDetail();
                frm.txtMaNV.ReadOnly = true;
                frm.txtMaNV.Text = dgvStaff.CurrentRow.Cells["dgvManv"].Value.ToString();
                frm.txtHoNV.Text = dgvStaff.CurrentRow.Cells["dgvHoNV"].Value.ToString();
                frm.txtTenNV.Text = dgvStaff.CurrentRow.Cells["dgvTenNV"].Value.ToString();
                frm.dtpNgaySinh.Value = (DateTime)dgvStaff.CurrentRow.Cells["dgvNgaySinh"].Value;
                frm.txtSDT.Text = dgvStaff.CurrentRow.Cells["dgvSDT"].Value.ToString();
                frm.txtMaCV.Text = dgvStaff.CurrentRow.Cells["dgvMaCV"].Value.ToString();
                frm.txtSoCa.Text = dgvStaff.CurrentRow.Cells["dgvSoCa"].Value.ToString();
                frm.txtThuong.Text = dgvStaff.CurrentRow.Cells["dgvThuong"].Value.ToString();
                frm.dtpNgayTD.Value = (DateTime)dgvStaff.CurrentRow.Cells["dgvNgayTuyenDung"].Value;
                frm.cmbHinhThuc.SelectedIndex = frm.cmbHinhThuc.Items.IndexOf(dgvStaff.CurrentRow.Cells["dgvHTCongViec"].Value.ToString());
                frm.ShowDialog();
                if (txtSearchStaff.Text != "")
                {
                    //dgvStaff.DataSource = employeeBUS.searchEmployee(txtSearchStaff.Text);
                }
                else
                {
                    Load_data();
                }
            }
            else if (dgvStaff.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xoá dòng này không?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Chú ý ở đây cần thực hiện thêm việc xóa tài khoản theo Manv
                    if (employeeBUS.deleteEmployee(dgvStaff.CurrentRow.Cells["dgvManv"].Value.ToString()))
                    {
                        txtSearchStaff.Text = "";
                        Load_data();
                        MessageBox.Show("Xoá thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công. Lỗi: '" + employeeBUS.err + "'");
                    }
                }
            }

        }
    }
}
