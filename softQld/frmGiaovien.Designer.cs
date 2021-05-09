namespace softQld
{
    partial class frmGiaovien
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
            this.txtghichu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbChuyenMon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbChucVuGv = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.mskCMNDGV = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.cboGioitinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.mskDienThoaiGV = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txtQueQuanGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHoTenGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtpNgaysinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtMaGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttThoat = new DevComponents.DotNetBar.ButtonX();
            this.bttXoa = new DevComponents.DotNetBar.ButtonX();
            this.bttSua = new DevComponents.DotNetBar.ButtonX();
            this.bttThem = new DevComponents.DotNetBar.ButtonX();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvGiaovien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quequan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.Nam = new DevComponents.Editors.ComboItem();
            this.Nu = new DevComponents.Editors.ComboItem();
            this.Hieutruong = new DevComponents.Editors.ComboItem();
            this.Hieupho = new DevComponents.Editors.ComboItem();
            this.Phohieutruong = new DevComponents.Editors.ComboItem();
            this.Totruong = new DevComponents.Editors.ComboItem();
            this.Topho = new DevComponents.Editors.ComboItem();
            this.Giaovien = new DevComponents.Editors.ComboItem();
            this.nhanvien = new DevComponents.Editors.ComboItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaysinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGiaovien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtghichu);
            this.groupBox1.Controls.Add(this.cbChuyenMon);
            this.groupBox1.Controls.Add(this.cbChucVuGv);
            this.groupBox1.Controls.Add(this.mskCMNDGV);
            this.groupBox1.Controls.Add(this.cboGioitinh);
            this.groupBox1.Controls.Add(this.mskDienThoaiGV);
            this.groupBox1.Controls.Add(this.txtQueQuanGV);
            this.groupBox1.Controls.Add(this.txtHoTenGV);
            this.groupBox1.Controls.Add(this.dtpNgaysinh);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(807, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về Giáo Viên";
            // 
            // txtghichu
            // 
            // 
            // 
            // 
            this.txtghichu.Border.Class = "TextBoxBorder";
            this.txtghichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtghichu.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtghichu.FocusHighlightEnabled = true;
            this.txtghichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtghichu.Location = new System.Drawing.Point(367, 131);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(396, 26);
            this.txtghichu.TabIndex = 9;
            // 
            // cbChuyenMon
            // 
            this.cbChuyenMon.DisplayMember = "Text";
            this.cbChuyenMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChuyenMon.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbChuyenMon.FocusHighlightEnabled = true;
            this.cbChuyenMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChuyenMon.FormattingEnabled = true;
            this.cbChuyenMon.ItemHeight = 20;
            this.cbChuyenMon.Location = new System.Drawing.Point(642, 96);
            this.cbChuyenMon.Name = "cbChuyenMon";
            this.cbChuyenMon.Size = new System.Drawing.Size(121, 26);
            this.cbChuyenMon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbChuyenMon.TabIndex = 8;
            // 
            // cbChucVuGv
            // 
            this.cbChucVuGv.DisplayMember = "Text";
            this.cbChucVuGv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChucVuGv.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbChucVuGv.FocusHighlightEnabled = true;
            this.cbChucVuGv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChucVuGv.FormattingEnabled = true;
            this.cbChucVuGv.ItemHeight = 20;
            this.cbChucVuGv.Items.AddRange(new object[] {
            this.Hieutruong,
            this.Hieupho,
            this.Phohieutruong,
            this.Totruong,
            this.Topho,
            this.Giaovien,
            this.nhanvien});
            this.cbChucVuGv.Location = new System.Drawing.Point(642, 60);
            this.cbChucVuGv.Name = "cbChucVuGv";
            this.cbChucVuGv.Size = new System.Drawing.Size(121, 26);
            this.cbChucVuGv.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbChucVuGv.TabIndex = 5;
            // 
            // mskCMNDGV
            // 
            // 
            // 
            // 
            this.mskCMNDGV.BackgroundStyle.Class = "TextBoxBorder";
            this.mskCMNDGV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskCMNDGV.ButtonClear.Visible = true;
            this.mskCMNDGV.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskCMNDGV.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mskCMNDGV.FocusHighlightEnabled = true;
            this.mskCMNDGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mskCMNDGV.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mskCMNDGV.Location = new System.Drawing.Point(642, 31);
            this.mskCMNDGV.Mask = "00000000000";
            this.mskCMNDGV.Name = "mskCMNDGV";
            this.mskCMNDGV.Size = new System.Drawing.Size(121, 22);
            this.mskCMNDGV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskCMNDGV.TabIndex = 2;
            this.mskCMNDGV.Text = "";
            this.mskCMNDGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mskCMNDGV.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.DisplayMember = "Text";
            this.cboGioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioitinh.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cboGioitinh.FocusHighlightEnabled = true;
            this.cboGioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboGioitinh.FormattingEnabled = true;
            this.cboGioitinh.ItemHeight = 20;
            this.cboGioitinh.Items.AddRange(new object[] {
            this.Nam,
            this.Nu});
            this.cboGioitinh.Location = new System.Drawing.Point(124, 94);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(121, 26);
            this.cboGioitinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGioitinh.TabIndex = 6;
            // 
            // mskDienThoaiGV
            // 
            // 
            // 
            // 
            this.mskDienThoaiGV.BackgroundStyle.Class = "TextBoxBorder";
            this.mskDienThoaiGV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskDienThoaiGV.ButtonClear.Visible = true;
            this.mskDienThoaiGV.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mskDienThoaiGV.FocusHighlightEnabled = true;
            this.mskDienThoaiGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mskDienThoaiGV.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mskDienThoaiGV.Location = new System.Drawing.Point(367, 100);
            this.mskDienThoaiGV.Mask = "00000000000";
            this.mskDienThoaiGV.Name = "mskDienThoaiGV";
            this.mskDienThoaiGV.Size = new System.Drawing.Size(156, 22);
            this.mskDienThoaiGV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskDienThoaiGV.TabIndex = 7;
            this.mskDienThoaiGV.Text = "";
            this.mskDienThoaiGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mskDienThoaiGV.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            // 
            // txtQueQuanGV
            // 
            // 
            // 
            // 
            this.txtQueQuanGV.Border.Class = "TextBoxBorder";
            this.txtQueQuanGV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtQueQuanGV.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtQueQuanGV.FocusHighlightEnabled = true;
            this.txtQueQuanGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtQueQuanGV.Location = new System.Drawing.Point(367, 63);
            this.txtQueQuanGV.Name = "txtQueQuanGV";
            this.txtQueQuanGV.Size = new System.Drawing.Size(156, 26);
            this.txtQueQuanGV.TabIndex = 4;
            // 
            // txtHoTenGV
            // 
            // 
            // 
            // 
            this.txtHoTenGV.Border.Class = "TextBoxBorder";
            this.txtHoTenGV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHoTenGV.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtHoTenGV.FocusHighlightEnabled = true;
            this.txtHoTenGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTenGV.Location = new System.Drawing.Point(367, 27);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(156, 26);
            this.txtHoTenGV.TabIndex = 1;
            this.txtHoTenGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTenGV_KeyPress);
            // 
            // dtpNgaysinh
            // 
            // 
            // 
            // 
            this.dtpNgaysinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgaysinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaysinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgaysinh.ButtonDropDown.Visible = true;
            this.dtpNgaysinh.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpNgaysinh.FocusHighlightEnabled = true;
            this.dtpNgaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaysinh.IsPopupCalendarOpen = false;
            this.dtpNgaysinh.Location = new System.Drawing.Point(124, 57);
            // 
            // 
            // 
            this.dtpNgaysinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaysinh.MonthCalendar.BackgroundStyle.Class = "";
            this.dtpNgaysinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaysinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgaysinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgaysinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaysinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgaysinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgaysinh.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtpNgaysinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaysinh.MonthCalendar.DisplayMonth = new System.DateTime(2012, 5, 1, 0, 0, 0, 0);
            this.dtpNgaysinh.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpNgaysinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpNgaysinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaysinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgaysinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaysinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgaysinh.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtpNgaysinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgaysinh.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgaysinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(121, 26);
            this.dtpNgaysinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgaysinh.TabIndex = 3;
            // 
            // txtMaGV
            // 
            // 
            // 
            // 
            this.txtMaGV.Border.Class = "TextBoxBorder";
            this.txtMaGV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaGV.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMaGV.FocusHighlightEnabled = true;
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaGV.Location = new System.Drawing.Point(124, 24);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(121, 26);
            this.txtMaGV.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttThoat);
            this.groupBox2.Controls.Add(this.bttXoa);
            this.groupBox2.Controls.Add(this.bttSua);
            this.groupBox2.Controls.Add(this.bttThem);
            this.groupBox2.Location = new System.Drawing.Point(132, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 55);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // bttThoat
            // 
            this.bttThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttThoat.Image = global::softQld.Properties.Resources.Restart;
            this.bttThoat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttThoat.Location = new System.Drawing.Point(416, 15);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(88, 30);
            this.bttThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttThoat.TabIndex = 13;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttXoa
            // 
            this.bttXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttXoa.Image = global::softQld.Properties.Resources.Delete;
            this.bttXoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttXoa.Location = new System.Drawing.Point(311, 15);
            this.bttXoa.Name = "bttXoa";
            this.bttXoa.Size = new System.Drawing.Size(88, 30);
            this.bttXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttXoa.TabIndex = 12;
            this.bttXoa.Text = "Xóa";
            this.bttXoa.Click += new System.EventHandler(this.bttXoa_Click);
            // 
            // bttSua
            // 
            this.bttSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttSua.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttSua.Image = global::softQld.Properties.Resources.config;
            this.bttSua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttSua.Location = new System.Drawing.Point(207, 15);
            this.bttSua.Name = "bttSua";
            this.bttSua.Size = new System.Drawing.Size(88, 30);
            this.bttSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttSua.TabIndex = 11;
            this.bttSua.Text = "Sửa";
            this.bttSua.Click += new System.EventHandler(this.bttSua_Click);
            // 
            // bttThem
            // 
            this.bttThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttThem.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttThem.Image = global::softQld.Properties.Resources.add;
            this.bttThem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttThem.Location = new System.Drawing.Point(90, 15);
            this.bttThem.Name = "bttThem";
            this.bttThem.Size = new System.Drawing.Size(100, 30);
            this.bttThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttThem.TabIndex = 10;
            this.bttThem.Text = "Tạo mới";
            this.bttThem.Click += new System.EventHandler(this.bttThem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(287, 133);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ghi chú:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(37, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giới  Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(37, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã GV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(554, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Chức Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(287, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(37, 60);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày Sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(554, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(554, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chuyên Môn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(287, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(285, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quê Quán";
            // 
            // DgvGiaovien
            // 
            this.DgvGiaovien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvGiaovien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGiaovien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.Hoten,
            this.Ngaysinh,
            this.Gioitinh,
            this.Quequan,
            this.Sodienthoai,
            this.Chucvu,
            this.SoCMND,
            this.ChuyenMon,
            this.Ghichu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvGiaovien.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGiaovien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DgvGiaovien.Location = new System.Drawing.Point(26, 316);
            this.DgvGiaovien.Name = "DgvGiaovien";
            this.DgvGiaovien.Size = new System.Drawing.Size(807, 201);
            this.DgvGiaovien.TabIndex = 11;
            this.DgvGiaovien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGiaovien_CellClick);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.Name = "Hoten";
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
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
            // Chucvu
            // 
            this.Chucvu.DataPropertyName = "Chucvu";
            this.Chucvu.HeaderText = "Chức vụ";
            this.Chucvu.Name = "Chucvu";
            // 
            // SoCMND
            // 
            this.SoCMND.DataPropertyName = "SoCMND";
            this.SoCMND.HeaderText = "Số CMND";
            this.SoCMND.Name = "SoCMND";
            // 
            // ChuyenMon
            // 
            this.ChuyenMon.DataPropertyName = "ChuyenMon";
            this.ChuyenMon.HeaderText = "Chuyên Môn";
            this.ChuyenMon.Name = "ChuyenMon";
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
            this.labelX3.Location = new System.Drawing.Point(190, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(481, 35);
            this.labelX3.TabIndex = 34;
            this.labelX3.Text = "CẬP NHẬT THÔNG TIN GIÁO VIÊN";
            // 
            // Nam
            // 
            this.Nam.Text = "Nam";
            // 
            // Nu
            // 
            this.Nu.Text = "Nữ";
            // 
            // Hieutruong
            // 
            this.Hieutruong.Text = "Hiệu trưởng";
            // 
            // Hieupho
            // 
            this.Hieupho.Text = "Hiệu phó";
            // 
            // Phohieutruong
            // 
            this.Phohieutruong.Text = "Phó hiệu trưởng";
            // 
            // Totruong
            // 
            this.Totruong.Text = "Tổ Trưởng";
            // 
            // Topho
            // 
            this.Topho.Text = "Tổ phó";
            // 
            // Giaovien
            // 
            this.Giaovien.Text = "Giáo viên";
            // 
            // nhanvien
            // 
            this.nhanvien.Text = "Nhân viên";
            // 
            // frmGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 537);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.DgvGiaovien);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiaovien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật các thông tin giáo viên";
            this.Load += new System.EventHandler(this.frmGiaovien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaysinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGiaovien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.DataGridViewX DgvGiaovien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaGV;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskDienThoaiGV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtQueQuanGV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTenGV;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgaysinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbChuyenMon;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbChucVuGv;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskCMNDGV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGioitinh;
        private DevComponents.DotNetBar.ButtonX bttThoat;
        private DevComponents.DotNetBar.ButtonX bttXoa;
        private DevComponents.DotNetBar.ButtonX bttSua;
        private DevComponents.DotNetBar.ButtonX bttThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtghichu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quequan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.Editors.ComboItem Hieutruong;
        private DevComponents.Editors.ComboItem Hieupho;
        private DevComponents.Editors.ComboItem Phohieutruong;
        private DevComponents.Editors.ComboItem Totruong;
        private DevComponents.Editors.ComboItem Topho;
        private DevComponents.Editors.ComboItem Giaovien;
        private DevComponents.Editors.ComboItem nhanvien;
        private DevComponents.Editors.ComboItem Nam;
        private DevComponents.Editors.ComboItem Nu;

    }
}