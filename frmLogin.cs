using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH_DBMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearForm()
        {
            this.txtUser.Text = string.Empty;
            this.txtPass.Text = string.Empty;
            this.txtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
