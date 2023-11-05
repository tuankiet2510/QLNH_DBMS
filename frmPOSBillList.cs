using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPOSBillList : Form
    {
        DataTable dtBillList = null;
        DataTable dtBillPrint = null;
        string err;
        public int MainID = 0;
        public bool bonus;
        public bool edit = false;
        public frmPOSBillList()
        {
            InitializeComponent();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
