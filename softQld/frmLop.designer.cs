namespace softQld
{
    partial class frmLop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTengvcn = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbGiaoVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbNienKhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.bttMoi = new DevComponents.DotNetBar.ButtonX();
            this.txtTenLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.DgvLop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nienkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbTengvcn);
            this.groupBox1.Controls.Add(this.cbGiaoVien);
            this.groupBox1.Controls.Add(this.cbNienKhoa);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Location = new System.Drawing.Point(8, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về lớp";
            // 
            // cbTengvcn
            // 
            this.cbTengvcn.DisplayMember = "Text";
            this.cbTengvcn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTengvcn.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbTengvcn.FocusHighlightEnabled = true;
            this.cbTengvcn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTengvcn.FormattingEnabled = true;
            this.cbTengvcn.ItemHeight = 20;
            this.cbTengvcn.Location = new System.Drawing.Point(350, 59);
            this.cbTengvcn.Name = "cbTengvcn";
            this.cbTengvcn.Size = new System.Drawing.Size(124, 26);
            this.cbTengvcn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTengvcn.TabIndex = 3;
            this.cbTengvcn.SelectedIndexChanged += new System.EventHandler(this.cbTengvcn_SelectedIndexChanged);
            // 
            // cbGiaoVien
            // 
            this.cbGiaoVien.DisplayMember = "Text";
            this.cbGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGiaoVien.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbGiaoVien.FocusHighlightEnabled = true;
            this.cbGiaoVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbGiaoVien.FormattingEnabled = true;
            this.cbGiaoVien.ItemHeight = 20;
            this.cbGiaoVien.Location = new System.Drawing.Point(105, 59);
            this.cbGiaoVien.Name = "cbGiaoVien";
            this.cbGiaoVien.Size = new System.Drawing.Size(124, 26);
            this.cbGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbGiaoVien.TabIndex = 2;
            this.cbGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cbGiaoVien_SelectedIndexChanged);
            // 
            // cbNienKhoa
            // 
            this.cbNienKhoa.DisplayMember = "Text";
            this.cbNienKhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNienKhoa.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbNienKhoa.FocusHighlightEnabled = true;
            this.cbNienKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNienKhoa.FormattingEnabled = true;
            this.cbNienKhoa.ItemHeight = 20;
            this.cbNienKhoa.Location = new System.Drawing.Point(105, 91);
            this.cbNienKhoa.Name = "cbNienKhoa";
            this.cbNienKhoa.Size = new System.Drawing.Size(124, 26);
            this.cbNienKhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNienKhoa.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.bttMoi);
            this.groupBox2.Location = new System.Drawing.Point(41, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Image = global::softQld.Properties.Resources.Restart;
            this.btThoat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btThoat.Location = new System.Drawing.Point(328, 16);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(80, 30);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Image = global::softQld.Properties.Resources.Delete;
            this.btXoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btXoa.Location = new System.Drawing.Point(232, 15);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 30);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.Image = global::softQld.Properties.Resources.config;
            this.btSua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btSua.Location = new System.Drawing.Point(137, 16);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(80, 30);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // bttMoi
            // 
            this.bttMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttMoi.Image = global::softQld.Properties.Resources.add;
            this.bttMoi.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttMoi.Location = new System.Drawing.Point(42, 16);
            this.bttMoi.Name = "bttMoi";
            this.bttMoi.Size = new System.Drawing.Size(80, 30);
            this.bttMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttMoi.TabIndex = 5;
            this.bttMoi.Text = "Thêm";
            this.bttMoi.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.bttMoi.Click += new System.EventHandler(this.bttMoi_Click);
            // 
            // txtTenLop
            // 
            // 
            // 
            // 
            this.txtTenLop.Border.Class = "TextBoxBorder";
            this.txtTenLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLop.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTenLop.FocusHighlightEnabled = true;
            this.txtTenLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenLop.Location = new System.Drawing.Point(350, 27);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(124, 26);
            this.txtTenLop.TabIndex = 1;
            // 
            // txtMaLop
            // 
            // 
            // 
            // 
            this.txtMaLop.Border.Class = "TextBoxBorder";
            this.txtMaLop.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLop.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMaLop.FocusHighlightEnabled = true;
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLop.Location = new System.Drawing.Point(105, 25);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(124, 26);
            this.txtMaLop.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(268, 59);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Tên GVCN";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.Location = new System.Drawing.Point(28, 59);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(71, 23);
            this.labelX5.TabIndex = 3;
            this.labelX5.Text = "Mã GVCN";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.Location = new System.Drawing.Point(28, 88);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(71, 23);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Niên Khóa";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(268, 28);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(62, 23);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Tên Lớp";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(28, 28);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(62, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Mã Lớp";
            // 
            // DgvLop
            // 
            this.DgvLop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvLop.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malop,
            this.Tenlop,
            this.Nienkhoa,
            this.MaGV});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLop.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DgvLop.Location = new System.Drawing.Point(8, 271);
            this.DgvLop.Name = "DgvLop";
            this.DgvLop.Size = new System.Drawing.Size(526, 187);
            this.DgvLop.TabIndex = 9;
            this.DgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLop_CellClick);
            // 
            // Malop
            // 
            this.Malop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Malop.DataPropertyName = "Malop";
            this.Malop.Frozen = true;
            this.Malop.HeaderText = "Mã lớp";
            this.Malop.Name = "Malop";
            // 
            // Tenlop
            // 
            this.Tenlop.DataPropertyName = "Tenlop";
            this.Tenlop.FillWeight = 150F;
            this.Tenlop.HeaderText = "Tên lớp";
            this.Tenlop.Name = "Tenlop";
            // 
            // Nienkhoa
            // 
            this.Nienkhoa.DataPropertyName = "Nienkhoa";
            this.Nienkhoa.FillWeight = 150F;
            this.Nienkhoa.HeaderText = "Niên khóa";
            this.Nienkhoa.Name = "Nienkhoa";
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX14.Location = new System.Drawing.Point(51, 20);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(445, 35);
            this.labelX14.TabIndex = 37;
            this.labelX14.Text = "CẬP NHẬT THÔNG TIN LỚP HỌC";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 470);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.DgvLop);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin về lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX bttMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbGiaoVien;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNienKhoa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLop;
        private DevComponents.DotNetBar.Controls.DataGridViewX DgvLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTengvcn;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nienkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private DevComponents.DotNetBar.LabelX labelX14;
    }
}