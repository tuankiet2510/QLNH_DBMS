using BUS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPOS : Form
    {

        public int MainID = 0;
        public string OrderType = "";
        public string TableName = "";
        public string TableID = "";
        public DateTime Date;
        public DateTime Time;
        public string CustomerName = "";
        public string CustomerPhone = "";
        DataTable dtDM;
        DataTable dtSP;
        ProductBUS productBus;
        double total;
        public bool Them = true; // CHo khởi tạo ban đầu bằng true 
        public frmPOS()
        {
            InitializeComponent();
            productBus = new ProductBUS();
            this.Controls.Add(hScrollBar1);
        }
        private void GetCategory()
        {
            try
            {
                dtDM = new DataTable();
                dtDM.Clear();

                dtDM = productBus.getAllCategory();
                pnlCategory.Controls.Clear();
                if (dtDM.Rows.Count > 0)
                {

                    Guna.UI2.WinForms.Guna2Button allButton = new Guna.UI2.WinForms.Guna2Button();
                    allButton.FillColor = Color.FromArgb(50, 55, 89);
                    allButton.Size = new Size(130, 45);
                    allButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    allButton.Text = "Tất cả";
                    allButton.TextAlign = HorizontalAlignment.Left;
                    allButton.Click += new EventHandler(_Click); // Gắn sự kiện click cho nút "Tất cả"
                    pnlCategory.Controls.Add(allButton);
                    foreach (DataRow row in dtDM.Rows)
                    {
                        Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                        b.FillColor = Color.FromArgb(50, 55, 89);
                        b.Size = new Size(120, 45);
                        b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                        b.Text = row["LoaiSP"].ToString();
                        b.TextAlign = HorizontalAlignment.Left;

                        //event for click
                        b.Click += new EventHandler(_Click);
                        pnlCategory.Controls.Add(b);
                    }
                }
                else
                {
                    Console.WriteLine("Sai");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không lấy được các danh mục trong TABLE DANHMUC. Lỗi: " + ex.Message);
            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            if (b.Text == "Tất cả")
            {
                foreach (var item in pnlProduct.Controls)
                {
                    var pro = (ucProduct)item;
                    pro.Visible = true; // Hiển thị tất cả các sản phẩm
                }
            }
            else // Lọc lấy các sản phẩm theo tên danh mục vd đồ ăn nhanh , món chính , rượu , bia
            {
                foreach (var item in pnlProduct.Controls)
                {
                    var pro = (ucProduct)item;
                    pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
                }
            }
        }

        private void LoadData()
        {

            LoadProducts();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            this.dgvPOS.BorderStyle = BorderStyle.FixedSingle;
            pnlCategory.Controls.Clear();
            pnlProduct.Controls.Clear();
            GetCategory();

            LoadData();
            Date = DateTime.Now;
            Time = DateTime.Now;
            DTPTime.Value = Time;
            DPTDate.Value = Date;
        }
        //Lấy các sản phẩm có trong database đưa lên pnlProduct
        private void LoadProducts()
        {
            try
            {
                dtSP = new DataTable();
                dtSP.Clear();

                dtSP = productBus.getAllProduct_POS();

                foreach (DataRow item in dtSP.Rows)
                {
                    Byte[] imagearray = (byte[])item["AnhSP"];
                    byte[] imagebytearray = imagearray;
                    AddItems(item["MaSP"].ToString(), item["TenSP"].ToString(), item["LoaiSP"].ToString(), float.Parse(item["DonGia"].ToString()), Image.FromStream(new MemoryStream(imagearray)));
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không lấy được các SẢN PHẨM trong Table SANPHAM. Lỗi: " + ex.Message);
            }
        }

        private void AddItems(string id, string name, string cat, float price, Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name, //Tên sản phẩm
                PPrice = price, //Gía
                PCategory = cat, // Tên loại sp ( Tên Danh mục)
                PImage = pimage,
                PId = id // Mã sp
            };
            pnlProduct.Controls.Add(w);

            //Nhấn vào ucProdcut bất kỳ sẽ đưa sản phẩm đó lên dgvPOS
            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                int d = dgvPOS.Rows.Count;
                foreach (DataGridViewRow item in dgvPOS.Rows)
                {
                    //Check if product already there then add one to quantity ad update price
                    object obj = item.Cells["dgvMaSP"].Value.ToString();
                    //     Console.WriteLine("*"+obj);
                    //    Console.WriteLine(obj.Equals(wdg.PId));
                    //  Console.WriteLine(obj + "><" + wdg.PId);
                    if (obj.Equals(wdg.PId))
                    {

                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) * double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        GetTotal();
                        //  total += double.Parse(item.Cells["dgvPrice"].Value.ToString());

                        return;// Thoát khỏi onSelct
                    }
                    //Nếu sản phẩm chưa có trong danh sách, thêm một dòng mới cho sản phẩm đó trong guna2DataGridView1.
                    //Add new Product

                }
             
                //Đưa dữ liệu ( sản phẩm) vừa bấm lên dgvPOS
                //   dgvPOS.Rows.Add(new object[] { wdg.PId, wdg.PName, wdg.PCategory, 1, wdg.PPrice, wdg.PPrice });
                //Tác dụng của PCategory trong form này chỉ có duy nhất để visible các sản phẩm theo tên danh mục ứng với button ấn vào
                //       s = false;
                dgvPOS.Rows.Add(new object[] { 0, wdg.PId, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                //Số 0 đầu tiên là DetailID , ta mặc định khi ấn chọn sản phẩm , DetailID đưa lên dgvPOS là 0 nhưng 0 qtrong lắm , vì khi chỉnh sửa là lúc database trong tblDetails đổ xuốngdgvPOS 
                //Gía trị trong cột dgvDetailID của dgvPOS sẽ trở nên khác ( vì trong tblDetails , cột DetailID là Indetity nên tự động sinh giá trị mỗi khi thêm record

                GetTotal();
                //   MessageBox.Show(lblTable.Text);
            };

        }
        private void GetTotal()
        {
            total = 0;
            //  lblTable.Text = "";
            foreach (DataGridViewRow item in dgvPOS.Rows)
            {
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = total.ToString("N2");
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDinIn_Click(object sender, EventArgs e)
        {

        }

        private void lblDriverName_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in pnlProduct.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearchProduct.Text.Trim().ToLower());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            //MainID = 0;
            Them = true;
            lblTotal.Text = "0.00";
            dgvPOS.Rows.Clear();
        }
    }
}
