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
    public partial class frmStaffDetail : Form
    {
        public EmployeeBUS employeeBUS;
        public EmployeeDTO employeeDTO;
        public frmStaffDetail()
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
        }

        public frmStaffDetail(EmployeeDTO employee)
        {
            InitializeComponent();
            employeeBUS = new EmployeeBUS();
            employeeDTO = employee;
            txtMaNV.Text = employee.MaNV;
            txtHoNV.Text = employee.HoNV;
            txtTenNV.Text = employee.TenNV;
            dtpNgaySinh.Value = employee.NgaySinh;
            txtSDT.Text = employee.SDT;
            txtMaCV.Text = employee.MaCV;
            txtSoCa.Text = employee.Soca.ToString();
            txtThuong.Text = employee.Thuong.ToString();
            dtpNgayTD.Value = employee.NgayTuyenDung;
            cmbHinhThuc.Text = employee.HTcongviec;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHoNV.Text.Trim() == "" || txtTenNV.Text.Trim() == "" || txtSDT.Text.Trim() == ""  || cmbHinhThuc.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
                return;
            }
            if (txtMaNV.ReadOnly == false) //Thêm nv
            {
                string displayValue = cbbMaCV.Text;
                string[] splitValues = displayValue.Split('-');
                string macv = splitValues[0];
                string tencv = splitValues[1];
                employeeDTO = new EmployeeDTO(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text, dtpNgaySinh.Value, txtSDT.Text,macv, 0, 0, 
                    dtpNgayTD.Value, cmbHinhThuc.Text);
                if (employeeBUS.addEmployee(employeeDTO))
                {
                    MessageBox.Show("Đã thêm xong!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else //Sua nv
            {
                if(employeeBUS.editEmployee(employeeDTO))
                {
                    MessageBox.Show("Đã chỉnh sửa xong!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa không thành công");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
