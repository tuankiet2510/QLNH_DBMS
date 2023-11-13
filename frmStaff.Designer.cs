namespace GUI
{
    partial class frmStaff
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
            this.dgvStaff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblStaff = new System.Windows.Forms.Label();
            this.cmbSearchType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtSearchStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEdit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnWage = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStaff.ColumnHeadersHeight = 40;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStaff.Location = new System.Drawing.Point(8, 189);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            this.dgvStaff.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStaff.RowTemplate.Height = 35;
            this.dgvStaff.Size = new System.Drawing.Size(1540, 607);
            this.dgvStaff.TabIndex = 15;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStaff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStaff.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvStaff.ThemeStyle.ReadOnly = true;
            this.dgvStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStaff.ThemeStyle.RowsStyle.Height = 35;
            this.dgvStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvDel
            // 
            this.dgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDel.FillWeight = 50F;
            this.dgvDel.HeaderText = "";
            this.dgvDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDel.MinimumWidth = 50;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            this.dgvDel.Width = 50;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(8, 167);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1780, 10);
            this.guna2Separator1.TabIndex = 14;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(684, 23);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(284, 38);
            this.lblStaff.TabIndex = 11;
            this.lblStaff.Text = "Danh sách Nhân Viên";
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.AutoRoundedCorners = true;
            this.cmbSearchType.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearchType.BorderRadius = 17;
            this.cmbSearchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSearchType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSearchType.ItemHeight = 30;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Mã NV",
            "SĐT",
            "Tên CV",
            "Tên NV"});
            this.cmbSearchType.Location = new System.Drawing.Point(1477, 106);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(140, 36);
            this.cmbSearchType.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 21;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.LightCoral;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1637, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 45);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDelete.Image = global::GUI.Properties.Resources.delete;
            this.btnDelete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDelete.ImageRotate = 0F;
            this.btnDelete.ImageSize = new System.Drawing.Size(50, 50);
            this.btnDelete.IndicateFocus = true;
            this.btnDelete.Location = new System.Drawing.Point(300, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDelete.Size = new System.Drawing.Size(81, 81);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAdd.Image = global::GUI.Properties.Resources.add_button;
            this.btnAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAdd.ImageRotate = 0F;
            this.btnAdd.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(76, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAdd.Size = new System.Drawing.Size(81, 81);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearchStaff
            // 
            this.txtSearchStaff.AutoRoundedCorners = true;
            this.txtSearchStaff.BorderRadius = 21;
            this.txtSearchStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchStaff.DefaultText = "";
            this.txtSearchStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchStaff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchStaff.IconLeft = global::GUI.Properties.Resources.magnifying_glass;
            this.txtSearchStaff.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearchStaff.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearchStaff.Location = new System.Drawing.Point(1150, 104);
            this.txtSearchStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchStaff.MaximumSize = new System.Drawing.Size(286, 45);
            this.txtSearchStaff.Name = "txtSearchStaff";
            this.txtSearchStaff.PasswordChar = '\0';
            this.txtSearchStaff.PlaceholderText = "";
            this.txtSearchStaff.SelectedText = "";
            this.txtSearchStaff.Size = new System.Drawing.Size(286, 45);
            this.txtSearchStaff.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEdit.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEdit.Image = global::GUI.Properties.Resources.category__1_;
            this.btnEdit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEdit.ImageRotate = 0F;
            this.btnEdit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEdit.IndicateFocus = true;
            this.btnEdit.Location = new System.Drawing.Point(189, 80);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEdit.Size = new System.Drawing.Size(81, 81);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.UseTransparentBackground = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnWage
            // 
            this.btnWage.AutoRoundedCorners = true;
            this.btnWage.BorderRadius = 21;
            this.btnWage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWage.FillColor = System.Drawing.Color.PeachPuff;
            this.btnWage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWage.ForeColor = System.Drawing.Color.Black;
            this.btnWage.Location = new System.Drawing.Point(745, 104);
            this.btnWage.Name = "btnWage";
            this.btnWage.Size = new System.Drawing.Size(168, 45);
            this.btnWage.TabIndex = 20;
            this.btnWage.Text = "Bảng lương";
            this.btnWage.Click += new System.EventHandler(this.btnWage_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1799, 820);
            this.Controls.Add(this.btnWage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbSearchType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.txtSearchStaff);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvStaff;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private System.Windows.Forms.Label lblStaff;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchStaff;
        private Guna.UI2.WinForms.Guna2ImageButton btnEdit;
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearchType;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2Button btnWage;
    }
}