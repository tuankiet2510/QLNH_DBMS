namespace GUI
{
    partial class frmShiftSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShift = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.dpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgvMaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayTrongTuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AllowUserToDeleteRows = false;
            this.dgvShift.AllowUserToResizeColumns = false;
            this.dgvShift.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShift.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShift.ColumnHeadersHeight = 40;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaCa,
            this.dgvNgayLam,
            this.dgvTenNV,
            this.dgvHoNV,
            this.dgvNgayTrongTuan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShift.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShift.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShift.Location = new System.Drawing.Point(3, 203);
            this.dgvShift.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShift.RowHeadersVisible = false;
            this.dgvShift.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.dgvShift.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShift.RowTemplate.Height = 35;
            this.dgvShift.Size = new System.Drawing.Size(1585, 821);
            this.dgvShift.TabIndex = 13;
            this.dgvShift.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShift.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvShift.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvShift.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvShift.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvShift.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvShift.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShift.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvShift.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvShift.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShift.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvShift.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShift.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvShift.ThemeStyle.ReadOnly = true;
            this.dgvShift.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShift.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvShift.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShift.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvShift.ThemeStyle.RowsStyle.Height = 35;
            this.dgvShift.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShift.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(68, 68);
            this.btnAdd.Image = global::GUI.Properties.Resources.add_button;
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageRotate = 0F;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(50, 65);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.Size = new System.Drawing.Size(117, 128);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(48, 14);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(119, 45);
            this.lblShift.TabIndex = 14;
            this.lblShift.Text = "Ca làm";
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(1134, 14);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(113, 29);
            this.lblSearchProduct.TabIndex = 17;
            this.lblSearchProduct.Text = "Tìm kiếm";
            // 
            // dpDate
            // 
            this.dpDate.Checked = true;
            this.dpDate.FillColor = System.Drawing.Color.PaleGreen;
            this.dpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDate.Location = new System.Drawing.Point(1140, 65);
            this.dpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(300, 55);
            this.dpDate.TabIndex = 19;
            this.dpDate.Value = new System.DateTime(2023, 11, 6, 15, 38, 45, 313);
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
            // 
            // dgvMaCa
            // 
            this.dgvMaCa.DataPropertyName = "MaCa";
            this.dgvMaCa.HeaderText = "Mã Ca";
            this.dgvMaCa.MinimumWidth = 6;
            this.dgvMaCa.Name = "dgvMaCa";
            this.dgvMaCa.ReadOnly = true;
            // 
            // dgvNgayLam
            // 
            this.dgvNgayLam.DataPropertyName = "NgayLam";
            this.dgvNgayLam.HeaderText = "Ngày làm";
            this.dgvNgayLam.MinimumWidth = 6;
            this.dgvNgayLam.Name = "dgvNgayLam";
            this.dgvNgayLam.ReadOnly = true;
            // 
            // dgvTenNV
            // 
            this.dgvTenNV.DataPropertyName = "TenNV";
            this.dgvTenNV.HeaderText = "Tên nhân viên";
            this.dgvTenNV.MinimumWidth = 8;
            this.dgvTenNV.Name = "dgvTenNV";
            this.dgvTenNV.ReadOnly = true;
            // 
            // dgvHoNV
            // 
            this.dgvHoNV.DataPropertyName = "HoNV";
            this.dgvHoNV.HeaderText = "Họ nhân viên";
            this.dgvHoNV.MinimumWidth = 8;
            this.dgvHoNV.Name = "dgvHoNV";
            this.dgvHoNV.ReadOnly = true;
            // 
            // dgvNgayTrongTuan
            // 
            this.dgvNgayTrongTuan.HeaderText = "Ngày trong tuần";
            this.dgvNgayTrongTuan.MinimumWidth = 8;
            this.dgvNgayTrongTuan.Name = "dgvNgayTrongTuan";
            this.dgvNgayTrongTuan.ReadOnly = true;
            // 
            // frmShiftSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1600, 1022);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lblSearchProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.dgvShift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmShiftSchedule";
            this.Text = "frmShift";
            this.Load += new System.EventHandler(this.frmShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvShift;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblSearchProduct;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayTrongTuan;
    }
}