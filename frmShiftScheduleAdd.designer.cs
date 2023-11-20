namespace GUI
{
    partial class frmShiftScheduleAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShiftScheduleAdd));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAdd = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCreateShift = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtEndTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.txtStartTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtShiftId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAssign = new Guna.UI2.WinForms.Guna2Button();
            this.lblIdNv = new System.Windows.Forms.Label();
            this.txtNvId = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblAdd);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1048, 165);
            this.guna2Panel1.TabIndex = 49;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(277, 44);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(276, 33);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "Phân công nhân viên";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(13, 5);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(193, 155);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnAssign);
            this.guna2Panel2.Controls.Add(this.btnCreateShift);
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 412);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1048, 111);
            this.guna2Panel2.TabIndex = 50;
            // 
            // btnCreateShift
            // 
            this.btnCreateShift.AutoRoundedCorners = true;
            this.btnCreateShift.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreateShift.BorderRadius = 32;
            this.btnCreateShift.CustomizableEdges.TopRight = false;
            this.btnCreateShift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateShift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateShift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateShift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateShift.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnCreateShift.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateShift.ForeColor = System.Drawing.Color.White;
            this.btnCreateShift.Location = new System.Drawing.Point(30, 16);
            this.btnCreateShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateShift.Name = "btnCreateShift";
            this.btnCreateShift.Size = new System.Drawing.Size(159, 67);
            this.btnCreateShift.TabIndex = 1;
            this.btnCreateShift.Text = "Tạo ca làm";
            this.btnCreateShift.Click += new System.EventHandler(this.btnCreateShift_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.BorderRadius = 32;
            this.btnClose.CustomizableEdges.TopLeft = false;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(831, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 67);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Trở về";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtEndTime
            // 
            this.txtEndTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndTime.DefaultText = "";
            this.txtEndTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndTime.Location = new System.Drawing.Point(677, 271);
            this.txtEndTime.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.PasswordChar = '\0';
            this.txtEndTime.PlaceholderText = "";
            this.txtEndTime.SelectedText = "";
            this.txtEndTime.SelectionStart = "".Length;
            this.txtEndTime.Size = new System.Drawing.Size(313, 36);
            this.txtEndTime.TabIndex = 57;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(538, 271);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(113, 25);
            this.lblEndTime.TabIndex = 56;
            this.lblEndTime.Text = "Giờ kết thúc";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartTime.DefaultText = "";
            this.txtStartTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStartTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStartTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartTime.Location = new System.Drawing.Point(167, 271);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.PasswordChar = '\0';
            this.txtStartTime.PlaceholderText = "";
            this.txtStartTime.SelectedText = "";
            this.txtStartTime.SelectionStart = "".Length;
            this.txtStartTime.Size = new System.Drawing.Size(313, 36);
            this.txtStartTime.TabIndex = 55;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(27, 271);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(110, 25);
            this.lblStartTime.TabIndex = 54;
            this.lblStartTime.Text = "Giờ bắt đầu";
            // 
            // txtShiftId
            // 
            this.txtShiftId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShiftId.DefaultText = "";
            this.txtShiftId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtShiftId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtShiftId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShiftId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShiftId.Enabled = false;
            this.txtShiftId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShiftId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShiftId.Location = new System.Drawing.Point(166, 202);
            this.txtShiftId.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtShiftId.Name = "txtShiftId";
            this.txtShiftId.PasswordChar = '\0';
            this.txtShiftId.PlaceholderText = "";
            this.txtShiftId.ReadOnly = true;
            this.txtShiftId.SelectedText = "";
            this.txtShiftId.SelectionStart = "".Length;
            this.txtShiftId.Size = new System.Drawing.Size(313, 36);
            this.txtShiftId.TabIndex = 53;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(28, 338);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 23);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Ngày làm";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(27, 202);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 25);
            this.lblID.TabIndex = 51;
            this.lblID.Text = "Mã Ca";
            // 
            // dpDate
            // 
            this.dpDate.Checked = true;
            this.dpDate.FillColor = System.Drawing.Color.White;
            this.dpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDate.Location = new System.Drawing.Point(166, 338);
            this.dpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(313, 36);
            this.dpDate.TabIndex = 59;
            this.dpDate.Value = new System.DateTime(2023, 11, 6, 15, 38, 45, 313);
            // 
            // btnAssign
            // 
            this.btnAssign.AutoRoundedCorners = true;
            this.btnAssign.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAssign.BorderRadius = 32;
            this.btnAssign.CustomizableEdges.TopRight = false;
            this.btnAssign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAssign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAssign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAssign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAssign.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(436, 16);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(159, 67);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Phân công";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblIdNv
            // 
            this.lblIdNv.AutoSize = true;
            this.lblIdNv.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNv.Location = new System.Drawing.Point(538, 202);
            this.lblIdNv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdNv.Name = "lblIdNv";
            this.lblIdNv.Size = new System.Drawing.Size(130, 25);
            this.lblIdNv.TabIndex = 60;
            this.lblIdNv.Text = "Mã Nhân viên";
            // 
            // txtNvId
            // 
            this.txtNvId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNvId.DefaultText = "";
            this.txtNvId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNvId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNvId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNvId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNvId.Enabled = false;
            this.txtNvId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNvId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNvId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNvId.Location = new System.Drawing.Point(677, 202);
            this.txtNvId.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txtNvId.Name = "txtNvId";
            this.txtNvId.PasswordChar = '\0';
            this.txtNvId.PlaceholderText = "";
            this.txtNvId.ReadOnly = true;
            this.txtNvId.SelectedText = "";
            this.txtNvId.SelectionStart = "".Length;
            this.txtNvId.Size = new System.Drawing.Size(313, 36);
            this.txtNvId.TabIndex = 61;
            // 
            // frmShiftAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 523);
            this.Controls.Add(this.lblIdNv);
            this.Controls.Add(this.txtNvId);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.txtShiftId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShiftAdd";
            this.Text = "frmShiftAdd";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Label lblAdd;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnCreateShift;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        public Guna.UI2.WinForms.Guna2TextBox txtEndTime;
        private System.Windows.Forms.Label lblEndTime;
        public Guna.UI2.WinForms.Guna2TextBox txtStartTime;
        private System.Windows.Forms.Label lblStartTime;
        public Guna.UI2.WinForms.Guna2TextBox txtShiftId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpDate;
        private Guna.UI2.WinForms.Guna2Button btnAssign;
        private System.Windows.Forms.Label lblIdNv;
        public Guna.UI2.WinForms.Guna2TextBox txtNvId;
    }
}