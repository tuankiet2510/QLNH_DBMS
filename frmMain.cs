using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

namespace QLNH_DBMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void AddControls(Form frm)
        {
            CenterPanel.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            CenterPanel.Controls.Add(frm);
            frm.Show();
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaff());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new frmProduct());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Load();
        }

        public void Load()
        {
            frmHome frm = new frmHome();
            //Dung sau khi co database dangnhap
            //frm.lblHello.Text += dbTK.TimKiemTen(user);
            //frm.lblQuyen.Text += dbTK.LayQuyen(user);
            AddControls(frm);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxSize_Click(object sender, EventArgs e)
        {

        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            AddControls(new frmTable());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            AddControls(new frmPOS());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AddControls(new frmAccount());
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            AddControls(new frmShift());
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void pnlControlBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinSize_Click(object sender, EventArgs e)
        {

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.WindowState = FormWindowState.Maximized;
            AddControls(frm);
        }
    }
}
