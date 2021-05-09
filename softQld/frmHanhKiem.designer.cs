namespace softQld
{
    partial class frmHanhKiem
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
            this.cbHanhkiem = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.XS = new DevComponents.Editors.ComboItem();
            this.T = new DevComponents.Editors.ComboItem();
            this.K = new DevComponents.Editors.ComboItem();
            this.TB = new DevComponents.Editors.ComboItem();
            this.Y = new DevComponents.Editors.ComboItem();
            this.Kem = new DevComponents.Editors.ComboItem();
            this.cbHoTenHK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbMaHSHK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttXoa = new DevComponents.DotNetBar.ButtonX();
            this.bttSua = new DevComponents.DotNetBar.ButtonX();
            this.bttThoat = new DevComponents.DotNetBar.ButtonX();
            this.bttThem = new DevComponents.DotNetBar.ButtonX();
            this.cbHocKyHK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.I = new DevComponents.Editors.ComboItem();
            this.II = new DevComponents.Editors.ComboItem();
            this.cbNamHocHK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbTenLopHK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbMaLopHK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dgvHanhkiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hanhkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbHanhkiem);
            this.groupBox1.Controls.Add(this.cbHoTenHK);
            this.groupBox1.Controls.Add(this.cbMaHSHK);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbHocKyHK);
            this.groupBox1.Controls.Add(this.cbNamHocHK);
            this.groupBox1.Controls.Add(this.cbTenLopHK);
            this.groupBox1.Controls.Add(this.cbMaLopHK);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(550, 170);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về hạnh kiểm";
            // 
            // cbHanhkiem
            // 
            this.cbHanhkiem.DisplayMember = "Text";
            this.cbHanhkiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHanhkiem.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbHanhkiem.FocusHighlightEnabled = true;
            this.cbHanhkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHanhkiem.FormattingEnabled = true;
            this.cbHanhkiem.ItemHeight = 20;
            this.cbHanhkiem.Items.AddRange(new object[] {
            this.XS,
            this.T,
            this.K,
            this.TB,
            this.Y,
            this.Kem});
            this.cbHanhkiem.Location = new System.Drawing.Point(409, 52);
            this.cbHanhkiem.Name = "cbHanhkiem";
            this.cbHanhkiem.Size = new System.Drawing.Size(121, 26);
            this.cbHanhkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbHanhkiem.TabIndex = 6;
            // 
            // XS
            // 
            this.XS.Text = "Xuất Sắc";
            // 
            // T
            // 
            this.T.Text = "Tốt";
            // 
            // K
            // 
            this.K.Text = "Khá";
            // 
            // TB
            // 
            this.TB.Text = "Trung bình";
            // 
            // Y
            // 
            this.Y.Text = "Yếu";
            // 
            // Kem
            // 
            this.Kem.Text = "Kém";
            // 
            // cbHoTenHK
            // 
            this.cbHoTenHK.DisplayMember = "Text";
            this.cbHoTenHK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHoTenHK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbHoTenHK.FocusHighlightEnabled = true;
            this.cbHoTenHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHoTenHK.FormattingEnabled = true;
            this.cbHoTenHK.ItemHeight = 20;
            this.cbHoTenHK.Location = new System.Drawing.Point(283, 80);
            this.cbHoTenHK.Name = "cbHoTenHK";
            this.cbHoTenHK.Size = new System.Drawing.Size(100, 26);
            this.cbHoTenHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbHoTenHK.TabIndex = 5;
            this.cbHoTenHK.SelectedIndexChanged += new System.EventHandler(this.cbHoTenHK_SelectedIndexChanged);
            // 
            // cbMaHSHK
            // 
            this.cbMaHSHK.DisplayMember = "Text";
            this.cbMaHSHK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaHSHK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbMaHSHK.FocusHighlightEnabled = true;
            this.cbMaHSHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaHSHK.FormattingEnabled = true;
            this.cbMaHSHK.ItemHeight = 20;
            this.cbMaHSHK.Location = new System.Drawing.Point(88, 79);
            this.cbMaHSHK.Name = "cbMaHSHK";
            this.cbMaHSHK.Size = new System.Drawing.Size(100, 26);
            this.cbMaHSHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMaHSHK.TabIndex = 4;
            this.cbMaHSHK.SelectedIndexChanged += new System.EventHandler(this.cbMaHSHK_SelectedIndexChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX7.Location = new System.Drawing.Point(207, 80);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(73, 23);
            this.labelX7.TabIndex = 42;
            this.labelX7.Text = "Họ Tên";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX5.Location = new System.Drawing.Point(9, 77);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(73, 23);
            this.labelX5.TabIndex = 41;
            this.labelX5.Text = "Mã HS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttXoa);
            this.groupBox2.Controls.Add(this.bttSua);
            this.groupBox2.Controls.Add(this.bttThoat);
            this.groupBox2.Controls.Add(this.bttThem);
            this.groupBox2.Location = new System.Drawing.Point(34, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 55);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // bttXoa
            // 
            this.bttXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttXoa.Image = global::softQld.Properties.Resources.Delete;
            this.bttXoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttXoa.Location = new System.Drawing.Point(279, 19);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(80, 30);
            this.bttXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttXoa.TabIndex = 9;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttSua
            // 
            this.bttSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttSua.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttSua.Image = global::softQld.Properties.Resources.config;
            this.bttSua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttSua.Location = new System.Drawing.Point(181, 19);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(80, 30);
            this.bttSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttSua.TabIndex = 8;
            this.bttSua.Text = "Sửa";
            this.bttSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttThoat
            // 
            this.bttThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttThoat.Image = global::softQld.Properties.Resources.Restart;
            this.bttThoat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttThoat.Location = new System.Drawing.Point(376, 19);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(80, 30);
            this.bttThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttThoat.TabIndex = 10;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttThem
            // 
            this.bttThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttThem.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttThem.Image = global::softQld.Properties.Resources.add;
            this.bttThem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttThem.Location = new System.Drawing.Point(84, 19);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(80, 30);
            this.bttThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttThem.TabIndex = 7;
            this.bttThem.Text = "Thêm";
            this.bttThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // cbHocKyHK
            // 
            this.cbHocKyHK.DisplayMember = "Text";
            this.cbHocKyHK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHocKyHK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbHocKyHK.FocusHighlightEnabled = true;
            this.cbHocKyHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKyHK.FormattingEnabled = true;
            this.cbHocKyHK.ItemHeight = 20;
            this.cbHocKyHK.Items.AddRange(new object[] {
            this.I,
            this.II});
            this.cbHocKyHK.Location = new System.Drawing.Point(283, 51);
            this.cbHocKyHK.Name = "cbHocKyHK";
            this.cbHocKyHK.Size = new System.Drawing.Size(100, 26);
            this.cbHocKyHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbHocKyHK.TabIndex = 3;
            this.cbHocKyHK.SelectedIndexChanged += new System.EventHandler(this.cbHocKyHK_SelectedIndexChanged);
            // 
            // I
            // 
            this.I.Text = "I";
            // 
            // II
            // 
            this.II.Text = "II";
            // 
            // cbNamHocHK
            // 
            this.cbNamHocHK.DisplayMember = "Text";
            this.cbNamHocHK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNamHocHK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbNamHocHK.FocusHighlightEnabled = true;
            this.cbNamHocHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNamHocHK.FormattingEnabled = true;
            this.cbNamHocHK.ItemHeight = 20;
            this.cbNamHocHK.Location = new System.Drawing.Point(283, 21);
            this.cbNamHocHK.Name = "cbNamHocHK";
            this.cbNamHocHK.Size = new System.Drawing.Size(100, 26);
            this.cbNamHocHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNamHocHK.TabIndex = 1;
            this.cbNamHocHK.SelectedIndexChanged += new System.EventHandler(this.cbNamHocHK_SelectedIndexChanged);
            // 
            // cbTenLopHK
            // 
            this.cbTenLopHK.DisplayMember = "Text";
            this.cbTenLopHK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenLopHK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbTenLopHK.FocusHighlightEnabled = true;
            this.cbTenLopHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenLopHK.FormattingEnabled = true;
            this.cbTenLopHK.ItemHeight = 20;
            this.cbTenLopHK.Location = new System.Drawing.Point(89, 51);
            this.cbTenLopHK.Name = "cbTenLopHK";
            this.cbTenLopHK.Size = new System.Drawing.Size(100, 26);
            this.cbTenLopHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTenLopHK.TabIndex = 2;
            this.cbTenLopHK.SelectedIndexChanged += new System.EventHandler(this.cbTenLopHK_SelectedIndexChanged);
            // 
            // cbMaLopHK
            // 
            this.cbMaLopHK.DisplayMember = "Text";
            this.cbMaLopHK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaLopHK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbMaLopHK.FocusHighlightEnabled = true;
            this.cbMaLopHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaLopHK.FormattingEnabled = true;
            this.cbMaLopHK.ItemHeight = 20;
            this.cbMaLopHK.Location = new System.Drawing.Point(89, 22);
            this.cbMaLopHK.Name = "cbMaLopHK";
            this.cbMaLopHK.Size = new System.Drawing.Size(100, 26);
            this.cbMaLopHK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMaLopHK.TabIndex = 0;
            this.cbMaLopHK.SelectedIndexChanged += new System.EventHandler(this.cbMaLopHK_SelectedIndexChanged);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.Location = new System.Drawing.Point(210, 51);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(73, 23);
            this.labelX4.TabIndex = 28;
            this.labelX4.Text = "Học Kỳ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(7, 51);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(73, 23);
            this.labelX3.TabIndex = 31;
            this.labelX3.Text = "Tên Lớp";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX6.Location = new System.Drawing.Point(429, 19);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(80, 23);
            this.labelX6.TabIndex = 30;
            this.labelX6.Text = "Hạnh Kiểm";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(210, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(73, 23);
            this.labelX1.TabIndex = 30;
            this.labelX1.Text = "Năm Học";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(10, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(62, 23);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "Mã Lớp";
            // 
            // dgvHanhkiem
            // 
            this.dgvHanhkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHanhkiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHanhkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhkiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.Namhoc,
            this.Hocky,
            this.Hanhkiem});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHanhkiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHanhkiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvHanhkiem.Location = new System.Drawing.Point(9, 244);
            this.dgvHanhkiem.Name = "dgvHanhkiem";
            this.dgvHanhkiem.Size = new System.Drawing.Size(551, 237);
            this.dgvHanhkiem.TabIndex = 22;
            this.dgvHanhkiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanhkiem_CellClick);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            // 
            // Namhoc
            // 
            this.Namhoc.DataPropertyName = "Namhoc";
            this.Namhoc.HeaderText = "Năm học";
            this.Namhoc.Name = "Namhoc";
            // 
            // Hocky
            // 
            this.Hocky.DataPropertyName = "Hocky";
            this.Hocky.HeaderText = "Học kỳ";
            this.Hocky.Name = "Hocky";
            // 
            // Hanhkiem
            // 
            this.Hanhkiem.DataPropertyName = "Hanhkiem";
            this.Hanhkiem.HeaderText = "Hạnh kiểm";
            this.Hanhkiem.Name = "Hanhkiem";
            this.Hanhkiem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX8.Location = new System.Drawing.Point(53, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(467, 35);
            this.labelX8.TabIndex = 35;
            this.labelX8.Text = "CẬP NHẬT HẠNH KIỂM HỌC SINH";
            // 
            // frmHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 493);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.dgvHanhkiem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHanhKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật hạnh kiểm học sinh";
            this.Load += new System.EventHandler(this.frmHanhKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbHocKyHK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNamHocHK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTenLopHK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaLopHK;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX bttThoat;
        private DevComponents.DotNetBar.ButtonX bttThem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHanhkiem;
        private DevComponents.Editors.ComboItem I;
        private DevComponents.Editors.ComboItem II;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbHoTenHK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaHSHK;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX bttXoa;
        private DevComponents.DotNetBar.ButtonX bttSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hanhkiem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbHanhkiem;
        private DevComponents.Editors.ComboItem XS;
        private DevComponents.Editors.ComboItem T;
        private DevComponents.Editors.ComboItem K;
        private DevComponents.Editors.ComboItem TB;
        private DevComponents.Editors.ComboItem Y;
        private DevComponents.Editors.ComboItem Kem;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX8;
    }
}