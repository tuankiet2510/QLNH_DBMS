using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmShiftAdd : Form
    {
        ShiftBUS shiftBUS = new ShiftBUS();
        public frmShiftAdd()
        {
            InitializeComponent();
        }

        private void btnCreateShift_Click(object sender, EventArgs e)
        {
            string shiftId = txtShiftId.Text;
            DateTime date = dpDate.Value;
            string startTime = txtStartTime.Text;
            string endTime = txtEndTime.Text;
            ShiftDTO shiftDTO = new ShiftDTO(shiftId, date, startTime, endTime);
            bool success = shiftBUS.createShift(shiftDTO);
            if (success)
                MessageBox.Show("Create shift Successfully");
            else
                MessageBox.Show("Create shift Failed");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string shiftId = txtShiftId.Text;
            string employeeId = txtNvId.Text;
            DateTime date = dpDate.Value;
            AssignmentDTO assignmentDTO = new AssignmentDTO(shiftId, employeeId, date);
            bool success = shiftBUS.createAssignment(assignmentDTO);
            if (success)
                MessageBox.Show("Assign Successfully");
            else
                MessageBox.Show("Assign Failed");
        }
    }
}
