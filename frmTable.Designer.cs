namespace GUI
{
    partial class frmTable
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
            this.btnDatBan = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTTBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTienDatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatBan
            // 
            this.btnDatBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDatBan.ForeColor = System.Drawing.Color.White;
            this.btnDatBan.Location = new System.Drawing.Point(22, 12);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(164, 45);
            this.btnDatBan.TabIndex = 0;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTable.ColumnHeadersHeight = 40;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaBan,
            this.dgvTTBan,
            this.dgvTienDatCoc,
            this.dgvMaKH});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTable.Location = new System.Drawing.Point(0, 83);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.dgvTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTable.RowTemplate.Height = 35;
            this.dgvTable.Size = new System.Drawing.Size(999, 499);
            this.dgvTable.TabIndex = 11;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTable.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTable.ThemeStyle.ReadOnly = true;
            this.dgvTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTable.ThemeStyle.RowsStyle.Height = 35;
            this.dgvTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvMaBan
            // 
            this.dgvMaBan.DataPropertyName = "MaBan";
            this.dgvMaBan.HeaderText = "Mã Bàn";
            this.dgvMaBan.MinimumWidth = 6;
            this.dgvMaBan.Name = "dgvMaBan";
            this.dgvMaBan.ReadOnly = true;
            // 
            // dgvTTBan
            // 
            this.dgvTTBan.DataPropertyName = "TrangThai";
            this.dgvTTBan.HeaderText = "Trạng thái bàn";
            this.dgvTTBan.MinimumWidth = 6;
            this.dgvTTBan.Name = "dgvTTBan";
            this.dgvTTBan.ReadOnly = true;
            // 
            // dgvTienDatCoc
            // 
            this.dgvTienDatCoc.DataPropertyName = "TienDatCoc";
            this.dgvTienDatCoc.HeaderText = "Tiền đặt cọc";
            this.dgvTienDatCoc.MinimumWidth = 6;
            this.dgvTienDatCoc.Name = "dgvTienDatCoc";
            this.dgvTienDatCoc.ReadOnly = true;
            // 
            // dgvMaKH
            // 
            this.dgvMaKH.DataPropertyName = "MaKH";
            this.dgvMaKH.HeaderText = "Khách hàng (đã đặt)";
            this.dgvMaKH.MinimumWidth = 6;
            this.dgvMaKH.Name = "dgvMaKH";
            this.dgvMaKH.ReadOnly = true;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 594);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnDatBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDatBan;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTTBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTienDatCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKH;
    }
}