namespace GUI
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.dgvCustomer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cbbFindType = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(24, 156);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1449, 12);
            this.guna2Separator1.TabIndex = 15;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Constantia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(121, 9);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(333, 39);
            this.lblProduct.TabIndex = 12;
            this.lblProduct.Text = "Danh sách khách hàng";
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(643, 28);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(172, 29);
            this.lblSearchProduct.TabIndex = 13;
            this.lblSearchProduct.Text = "Tìm kiếm theo ";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomer.ColumnHeadersHeight = 40;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKH,
            this.dgvTenKH,
            this.dgvSDT,
            this.dgvDiem,
            this.dgvEdit,
            this.dgvDel});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomer.Location = new System.Drawing.Point(35, 187);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 51;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCustomer.RowTemplate.Height = 35;
            this.dgvCustomer.Size = new System.Drawing.Size(1532, 798);
            this.dgvCustomer.TabIndex = 16;
            this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomer.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCustomer.ThemeStyle.ReadOnly = true;
            this.dgvCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomer.ThemeStyle.RowsStyle.Height = 35;
            this.dgvCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // dgvMaKH
            // 
            this.dgvMaKH.DataPropertyName = "MaKH";
            this.dgvMaKH.HeaderText = "Mã khách hàng";
            this.dgvMaKH.MinimumWidth = 6;
            this.dgvMaKH.Name = "dgvMaKH";
            this.dgvMaKH.ReadOnly = true;
            // 
            // dgvTenKH
            // 
            this.dgvTenKH.DataPropertyName = "TenKH";
            this.dgvTenKH.HeaderText = "Tên khách hàng";
            this.dgvTenKH.MinimumWidth = 6;
            this.dgvTenKH.Name = "dgvTenKH";
            this.dgvTenKH.ReadOnly = true;
            // 
            // dgvSDT
            // 
            this.dgvSDT.DataPropertyName = "SDT";
            this.dgvSDT.HeaderText = "Số điện thoại";
            this.dgvSDT.MinimumWidth = 6;
            this.dgvSDT.Name = "dgvSDT";
            this.dgvSDT.ReadOnly = true;
            // 
            // dgvDiem
            // 
            this.dgvDiem.DataPropertyName = "DiemThuong";
            this.dgvDiem.HeaderText = "Điểm thưởng";
            this.dgvDiem.MinimumWidth = 6;
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            // 
            // dgvEdit
            // 
            this.dgvEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvEdit.FillWeight = 50F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = global::GUI.Properties.Resources.edit;
            this.dgvEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvEdit.MinimumWidth = 50;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            this.dgvEdit.Width = 50;
            // 
            // dgvDel
            // 
            this.dgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDel.FillWeight = 50F;
            this.dgvDel.HeaderText = "";
            this.dgvDel.Image = global::GUI.Properties.Resources.delete;
            this.dgvDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDel.MinimumWidth = 50;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            this.dgvDel.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.FillWeight = 50F;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::GUI.Properties.Resources.edit;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 50;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn4.FillWeight = 50F;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::GUI.Properties.Resources.delete;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 50;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Width = 50;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomer.DefaultText = "";
            this.txtSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearchCustomer.IconLeft")));
            this.txtSearchCustomer.Location = new System.Drawing.Point(639, 87);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PlaceholderText = "";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.Size = new System.Drawing.Size(414, 60);
            this.txtSearchCustomer.TabIndex = 11;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(68, 68);
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageRotate = 0F;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(94, 61);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.Size = new System.Drawing.Size(116, 98);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbFindType
            // 
            this.cbbFindType.BackColor = System.Drawing.Color.Transparent;
            this.cbbFindType.BorderColor = System.Drawing.Color.Transparent;
            this.cbbFindType.BorderThickness = 0;
            this.cbbFindType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFindType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFindType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFindType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFindType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbFindType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbFindType.ItemHeight = 30;
            this.cbbFindType.Items.AddRange(new object[] {
            "SĐT",
            "Mã khách hàng"});
            this.cbbFindType.Location = new System.Drawing.Point(811, 28);
            this.cbbFindType.Name = "cbbFindType";
            this.cbbFindType.Size = new System.Drawing.Size(242, 36);
            this.cbbFindType.TabIndex = 17;
            // 
            // frmCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1579, 998);
            this.Controls.Add(this.cbbFindType);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblSearchProduct);
            this.Controls.Add(this.dgvCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSearchProduct;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiem;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFindType;
    }
}