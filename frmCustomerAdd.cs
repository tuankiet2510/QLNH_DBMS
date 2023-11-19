using BUS;
using DTO;
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

namespace GUI
{
    public partial class frmCustomerAdd : Form
    {

        CustomerBUS customerBUS;
        public CustomerDTO customerDTO { get; set; }
        public frmCustomerAdd()
        {
            InitializeComponent();
            customerBUS = new CustomerBUS();
            customerDTO = new CustomerDTO();
            txtCustomerLoyaltyPoint.Text = "0";
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Trim() == "" || txtCustomerName.Text.Trim() == "" || txtCustomerLoyaltyPoint.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
                return;
            }
            customerDTO = new CustomerDTO(txtCustomerID.Text, txtCustomerName.Text, txtCustomerPhone.Text, int.Parse(txtCustomerLoyaltyPoint.Text));
            if (txtCustomerID.ReadOnly == true) //Sửa khách hàng
            {
           //     customerDTO = new CustomerDTO(txtCustomerID.Text, txtCustomerName.Text, txtCustomerPhone.Text,int.Parse(txtCustomerLoyaltyPoint.Text));
                if (customerBUS.updateCustomer(customerDTO))
                {
                    MessageBox.Show("Đã sửa xong!");
                }
                else
                {
                    MessageBox.Show("Sửa không thành công. Lỗi: '" + customerBUS.err + "'");
                }
            }
            else //thêm khách hàng
            {
               
                    if (customerBUS.addCustomer(customerDTO))
                    {
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công. Lỗi: '" + customerBUS.err + "'");

                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
                
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
