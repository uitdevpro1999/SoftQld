namespace softQld
{
    partial class frmDSHocsinh
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbnienkhoa = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboLophocsinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.butInds = new DevComponents.DotNetBar.ButtonX();
            this.button1 = new DevComponents.DotNetBar.ButtonX();
            this.grvDSHocSinh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phuhuynh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCphuhuynh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDTphuhuynh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.cbnienkhoa);
            this.groupBox1.Controls.Add(this.cboLophocsinh);
            this.groupBox1.Controls.Add(this.butInds);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(73, 25);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(113, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Chọn niên khóa";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(355, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Chọn lớp";
            // 
            // cbnienkhoa
            // 
            this.cbnienkhoa.DisplayMember = "Text";
            this.cbnienkhoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbnienkhoa.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbnienkhoa.FocusHighlightEnabled = true;
            this.cbnienkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbnienkhoa.FormattingEnabled = true;
            this.cbnienkhoa.ItemHeight = 20;
            this.cbnienkhoa.Location = new System.Drawing.Point(192, 27);
            this.cbnienkhoa.Name = "cbnienkhoa";
            this.cbnienkhoa.Size = new System.Drawing.Size(121, 26);
            this.cbnienkhoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbnienkhoa.TabIndex = 0;
            this.cbnienkhoa.SelectedIndexChanged += new System.EventHandler(this.cbnienkhoa_SelectedIndexChanged);
            // 
            // cboLophocsinh
            // 
            this.cboLophocsinh.DisplayMember = "Text";
            this.cboLophocsinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLophocsinh.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cboLophocsinh.FocusHighlightEnabled = true;
            this.cboLophocsinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLophocsinh.FormattingEnabled = true;
            this.cboLophocsinh.ItemHeight = 20;
            this.cboLophocsinh.Location = new System.Drawing.Point(426, 27);
            this.cboLophocsinh.Name = "cboLophocsinh";
            this.cboLophocsinh.Size = new System.Drawing.Size(121, 26);
            this.cboLophocsinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLophocsinh.TabIndex = 1;
            this.cboLophocsinh.SelectedIndexChanged += new System.EventHandler(this.cboLophocsinh_SelectedIndexChanged);
            // 
            // butInds
            // 
            this.butInds.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butInds.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butInds.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butInds.Image = global::softQld.Properties.Resources.print_view;
            this.butInds.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butInds.Location = new System.Drawing.Point(624, 23);
            this.butInds.Name = "butInds";
            this.butInds.Size = new System.Drawing.Size(95, 30);
            this.butInds.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butInds.TabIndex = 2;
            this.butInds.Text = "In DS";
            this.butInds.Click += new System.EventHandler(this.butInds_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button1.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = global::softQld.Properties.Resources.Restart;
            this.button1.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.button1.Location = new System.Drawing.Point(723, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grvDSHocSinh
            // 
            this.grvDSHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grvDSHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDSHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.Hoten,
            this.Malop,
            this.Ngaysinh,
            this.Gioitinh,
            this.Quequan,
            this.Sodienthoai,
            this.Phuhuynh,
            this.DCphuhuynh,
            this.soDTphuhuynh,
            this.Chucvu,
            this.Ghichu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDSHocSinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.grvDSHocSinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grvDSHocSinh.Location = new System.Drawing.Point(12, 127);
            this.grvDSHocSinh.Name = "grvDSHocSinh";
            this.grvDSHocSinh.Size = new System.Drawing.Size(925, 318);
            this.grvDSHocSinh.TabIndex = 19;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã Học sinh";
            this.MaHS.Name = "MaHS";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.Name = "Hoten";
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "Malop";
            this.Malop.HeaderText = "Mã Lớp";
            this.Malop.Name = "Malop";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày Sinh";
            this.Ngaysinh.Name = "Ngaysinh";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // Quequan
            // 
            this.Quequan.DataPropertyName = "Quequan";
            this.Quequan.HeaderText = "Quê quán";
            this.Quequan.Name = "Quequan";
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.DataPropertyName = "Sodienthoai";
            this.Sodienthoai.HeaderText = "Số điện thoại";
            this.Sodienthoai.Name = "Sodienthoai";
            // 
            // Phuhuynh
            // 
            this.Phuhuynh.DataPropertyName = "Phuhuynh";
            this.Phuhuynh.HeaderText = "Phụ huynh";
            this.Phuhuynh.Name = "Phuhuynh";
            // 
            // DCphuhuynh
            // 
            this.DCphuhuynh.DataPropertyName = "DCphuhuynh";
            this.DCphuhuynh.HeaderText = "Địa chỉ phụ huynh";
            this.DCphuhuynh.Name = "DCphuhuynh";
            // 
            // soDTphuhuynh
            // 
            this.soDTphuhuynh.DataPropertyName = "soDTphuhuynh";
            this.soDTphuhuynh.HeaderText = "STD phụ huynh";
            this.soDTphuhuynh.Name = "soDTphuhuynh";
            // 
            // Chucvu
            // 
            this.Chucvu.DataPropertyName = "Chucvu";
            this.Chucvu.HeaderText = "Chức vụ";
            this.Chucvu.Name = "Chucvu";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(305, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(320, 35);
            this.labelX3.TabIndex = 32;
            this.labelX3.Text = "DANH SÁCH HỌC SINH";
            // 
            // frmDSHocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 457);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.grvDSHocSinh);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDSHocsinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.frmDSHocsinh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDSHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grvDSHocSinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLophocsinh;
        private DevComponents.DotNetBar.ButtonX button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phuhuynh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCphuhuynh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTphuhuynh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbnienkhoa;
        private DevComponents.DotNetBar.ButtonX butInds;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}