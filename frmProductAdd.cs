using BUS;
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
using DTO;
namespace QLNH_DBMS
{
    public partial class frmProductAdd : Form
    {
     
        ProductBUS productbus;
        ProductDTO productDTO;
        public frmProductAdd()
        {
            InitializeComponent();
            productbus = new ProductBUS();
            productDTO = new ProductDTO();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Trim() == "" || txtProductName.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtImage.Image == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
                return;
            }
            if (txtProductID.ReadOnly == true) //Chỉnh sửa món 
            {

                try
                {
                    /*string displayValue = cbbCateID.Text;
                    string[] splitValues = displayValue.Split('-');
                    string madm = splitValues[0];
                    string tendm = splitValues[1];*/
                    productDTO = new ProductDTO(txtProductID.Text, txtProductName.Text, txtCategory.Text, cbbState.Text, float.Parse(txtPrice.Text), txtImage.Image);
                    if (productbus.updateProduct(productDTO))
                    {
                        MessageBox.Show("Đã sửa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công. Lỗi: '" + productbus.err + "'");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Sửa không thành công. Lỗi: '" + ex.Message + "'");
                }
            }

            else //Thêm món
            {
                try
                {
                    productDTO = new ProductDTO(txtProductID.Text, txtProductName.Text, txtCategory.Text,cbbState.Text, float.Parse(txtPrice.Text), txtImage.Image);
                    if (productbus.addProduct(productDTO))
                    {
                        MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công. Lỗi: '" + productbus.err);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Thêm không thành công. Lỗi: '" + ex.Message + "'");
                }
            }
            this.Close();

        }

        string filepath;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png) | * .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtImage.Image = new Bitmap(filepath);
            }
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
