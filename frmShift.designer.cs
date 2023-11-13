namespace GUI
{
    partial class frmShift
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvShift = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvMaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.dpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AllowUserToDeleteRows = false;
            this.dgvShift.AllowUserToResizeColumns = false;
            this.dgvShift.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvShift.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShift.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvShift.ColumnHeadersHeight = 40;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaCa,
            this.dgvNgayLam,
            this.dgvGioBatDau,
            this.dgvGioKetThuc,
            this.dgvTenNV,
            this.dgvMaCV,
            this.dgvTenCV});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShift.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvShift.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvShift.Location = new System.Drawing.Point(0, 132);
            this.dgvShift.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShift.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvShift.RowHeadersVisible = false;
            this.dgvShift.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.dgvShift.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvShift.RowTemplate.Height = 35;
            this.dgvShift.Size = new System.Drawing.Size(1049, 523);
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
            // dgvGioBatDau
            // 
            this.dgvGioBatDau.DataPropertyName = "GioBatDau";
            this.dgvGioBatDau.HeaderText = "Giờ bắt đầu";
            this.dgvGioBatDau.MinimumWidth = 6;
            this.dgvGioBatDau.Name = "dgvGioBatDau";
            this.dgvGioBatDau.ReadOnly = true;
            // 
            // dgvGioKetThuc
            // 
            this.dgvGioKetThuc.DataPropertyName = "GioKetThuc";
            this.dgvGioKetThuc.HeaderText = "Giờ kết thúc";
            this.dgvGioKetThuc.MinimumWidth = 6;
            this.dgvGioKetThuc.Name = "dgvGioKetThuc";
            this.dgvGioKetThuc.ReadOnly = true;
            // 
            // dgvTenNV
            // 
            this.dgvTenNV.DataPropertyName = "TenNV";
            this.dgvTenNV.HeaderText = "Tên nhân viên";
            this.dgvTenNV.Name = "dgvTenNV";
            this.dgvTenNV.ReadOnly = true;
            // 
            // dgvMaCV
            // 
            this.dgvMaCV.DataPropertyName = "MaCV";
            this.dgvMaCV.HeaderText = "Mã Công việc";
            this.dgvMaCV.Name = "dgvMaCV";
            this.dgvMaCV.ReadOnly = true;
            // 
            // dgvTenCV
            // 
            this.dgvTenCV.DataPropertyName = "TenCV";
            this.dgvTenCV.HeaderText = "Tên công việc";
            this.dgvTenCV.Name = "dgvTenCV";
            this.dgvTenCV.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(68, 68);
            this.btnAdd.Image = global::GUI.Properties.Resources.add_button;
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageRotate = 0F;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(33, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.Size = new System.Drawing.Size(78, 83);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(32, 9);
            this.lblShift.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(79, 30);
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
            this.lblSearchProduct.Location = new System.Drawing.Point(756, 9);
            this.lblSearchProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(71, 20);
            this.lblSearchProduct.TabIndex = 17;
            this.lblSearchProduct.Text = "Tìm kiếm";
            // 
            // dpDate
            // 
            this.dpDate.Checked = true;
            this.dpDate.FillColor = System.Drawing.Color.PaleGreen;
            this.dpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDate.Location = new System.Drawing.Point(760, 42);
            this.dpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(200, 36);
            this.dpDate.TabIndex = 19;
            this.dpDate.Value = new System.DateTime(2023, 11, 6, 15, 38, 45, 313);
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
            // 
            // frmShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 651);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lblSearchProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.dgvShift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShift";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenCV;
        private System.Windows.Forms.Label lblSearchProduct;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpDate;
    }
}