namespace softQld
{
    partial class frmQuanlytaikhoan
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtquyen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttaikhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.butCancel = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVtaikhoan = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.txttaikhoanxoa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.butXoatk = new DevComponents.DotNetBar.ButtonX();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.txtmkmoi2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmkmoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmkcu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butDoimk = new DevComponents.DotNetBar.ButtonX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.cboquyenduoccap = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Admin = new DevComponents.Editors.ComboItem();
            this.User = new DevComponents.Editors.ComboItem();
            this.Guest = new DevComponents.Editors.ComboItem();
            this.txtquyenhientai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttkCansua = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butCapquyen = new DevComponents.DotNetBar.ButtonX();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel3.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtquyen);
            this.groupBox1.Controls.Add(this.txttaikhoan);
            this.groupBox1.Controls.Add(this.butCancel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // txtquyen
            // 
            // 
            // 
            // 
            this.txtquyen.Border.Class = "TextBoxBorder";
            this.txtquyen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtquyen.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtquyen.FocusHighlightEnabled = true;
            this.txtquyen.Location = new System.Drawing.Point(91, 56);
            this.txtquyen.Name = "txtquyen";
            this.txtquyen.ReadOnly = true;
            this.txtquyen.Size = new System.Drawing.Size(212, 26);
            this.txtquyen.TabIndex = 1;
            // 
            // txttaikhoan
            // 
            // 
            // 
            // 
            this.txttaikhoan.Border.Class = "TextBoxBorder";
            this.txttaikhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttaikhoan.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txttaikhoan.FocusHighlightEnabled = true;
            this.txttaikhoan.Location = new System.Drawing.Point(91, 24);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.ReadOnly = true;
            this.txttaikhoan.Size = new System.Drawing.Size(212, 26);
            this.txttaikhoan.TabIndex = 0;
            // 
            // butCancel
            // 
            this.butCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butCancel.Image = global::softQld.Properties.Resources.Restart;
            this.butCancel.Location = new System.Drawing.Point(313, 36);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(109, 31);
            this.butCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Thoát";
            this.butCancel.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quyền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản:";
            // 
            // DGVtaikhoan
            // 
            this.DGVtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVtaikhoan.Location = new System.Drawing.Point(25, 343);
            this.DGVtaikhoan.Name = "DGVtaikhoan";
            this.DGVtaikhoan.Size = new System.Drawing.Size(441, 169);
            this.DGVtaikhoan.TabIndex = 6;
            this.DGVtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVtaikhoan_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Location = new System.Drawing.Point(25, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(441, 159);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.txttaikhoanxoa);
            this.tabControlPanel3.Controls.Add(this.label10);
            this.tabControlPanel3.Controls.Add(this.butXoatk);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(441, 130);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // txttaikhoanxoa
            // 
            // 
            // 
            // 
            this.txttaikhoanxoa.Border.Class = "TextBoxBorder";
            this.txttaikhoanxoa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttaikhoanxoa.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txttaikhoanxoa.FocusHighlightEnabled = true;
            this.txttaikhoanxoa.Location = new System.Drawing.Point(100, 50);
            this.txttaikhoanxoa.Name = "txttaikhoanxoa";
            this.txttaikhoanxoa.Size = new System.Drawing.Size(203, 26);
            this.txttaikhoanxoa.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(22, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tài khoản:";
            // 
            // butXoatk
            // 
            this.butXoatk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butXoatk.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butXoatk.Image = global::softQld.Properties.Resources.delete_user;
            this.butXoatk.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butXoatk.Location = new System.Drawing.Point(313, 46);
            this.butXoatk.Name = "butXoatk";
            this.butXoatk.Size = new System.Drawing.Size(108, 34);
            this.butXoatk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butXoatk.TabIndex = 5;
            this.butXoatk.Text = "Thực hiện";
            this.butXoatk.Click += new System.EventHandler(this.butXoatk_Click);
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Xóa tài khoản";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.txtmkmoi2);
            this.tabControlPanel2.Controls.Add(this.txtmkmoi);
            this.tabControlPanel2.Controls.Add(this.txtmkcu);
            this.tabControlPanel2.Controls.Add(this.label9);
            this.tabControlPanel2.Controls.Add(this.label8);
            this.tabControlPanel2.Controls.Add(this.label7);
            this.tabControlPanel2.Controls.Add(this.butDoimk);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(441, 130);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // txtmkmoi2
            // 
            // 
            // 
            // 
            this.txtmkmoi2.Border.Class = "TextBoxBorder";
            this.txtmkmoi2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmkmoi2.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmkmoi2.FocusHighlightEnabled = true;
            this.txtmkmoi2.Location = new System.Drawing.Point(140, 83);
            this.txtmkmoi2.Name = "txtmkmoi2";
            this.txtmkmoi2.Size = new System.Drawing.Size(153, 26);
            this.txtmkmoi2.TabIndex = 12;
            // 
            // txtmkmoi
            // 
            // 
            // 
            // 
            this.txtmkmoi.Border.Class = "TextBoxBorder";
            this.txtmkmoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmkmoi.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmkmoi.FocusHighlightEnabled = true;
            this.txtmkmoi.Location = new System.Drawing.Point(140, 51);
            this.txtmkmoi.Name = "txtmkmoi";
            this.txtmkmoi.Size = new System.Drawing.Size(153, 26);
            this.txtmkmoi.TabIndex = 11;
            // 
            // txtmkcu
            // 
            // 
            // 
            // 
            this.txtmkcu.Border.Class = "TextBoxBorder";
            this.txtmkcu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmkcu.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmkcu.FocusHighlightEnabled = true;
            this.txtmkcu.Location = new System.Drawing.Point(140, 19);
            this.txtmkcu.Name = "txtmkcu";
            this.txtmkcu.Size = new System.Drawing.Size(153, 26);
            this.txtmkcu.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(16, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nhập lại MK mới:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(16, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mật khẩu mới:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mật khẩu cũ:";
            // 
            // butDoimk
            // 
            this.butDoimk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butDoimk.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butDoimk.Image = global::softQld.Properties.Resources.save;
            this.butDoimk.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butDoimk.Location = new System.Drawing.Point(307, 46);
            this.butDoimk.Name = "butDoimk";
            this.butDoimk.Size = new System.Drawing.Size(115, 40);
            this.butDoimk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butDoimk.TabIndex = 9;
            this.butDoimk.Text = "Thực hiện";
            this.butDoimk.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.butDoimk.Click += new System.EventHandler(this.butDoimk_Click);
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Đổi mật khẩu";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.cboquyenduoccap);
            this.tabControlPanel1.Controls.Add(this.txtquyenhientai);
            this.tabControlPanel1.Controls.Add(this.txttkCansua);
            this.tabControlPanel1.Controls.Add(this.label6);
            this.tabControlPanel1.Controls.Add(this.label5);
            this.tabControlPanel1.Controls.Add(this.label4);
            this.tabControlPanel1.Controls.Add(this.butCapquyen);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(441, 130);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // cboquyenduoccap
            // 
            this.cboquyenduoccap.DisplayMember = "Text";
            this.cboquyenduoccap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboquyenduoccap.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cboquyenduoccap.FocusHighlightEnabled = true;
            this.cboquyenduoccap.FormattingEnabled = true;
            this.cboquyenduoccap.ItemHeight = 20;
            this.cboquyenduoccap.Items.AddRange(new object[] {
            this.Admin,
            this.User,
            this.Guest});
            this.cboquyenduoccap.Location = new System.Drawing.Point(147, 85);
            this.cboquyenduoccap.Name = "cboquyenduoccap";
            this.cboquyenduoccap.Size = new System.Drawing.Size(150, 26);
            this.cboquyenduoccap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboquyenduoccap.TabIndex = 13;
            // 
            // Admin
            // 
            this.Admin.Text = "Admin";
            // 
            // User
            // 
            this.User.Text = "User";
            // 
            // Guest
            // 
            this.Guest.Text = "Guest";
            // 
            // txtquyenhientai
            // 
            // 
            // 
            // 
            this.txtquyenhientai.Border.Class = "TextBoxBorder";
            this.txtquyenhientai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtquyenhientai.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtquyenhientai.FocusHighlightEnabled = true;
            this.txtquyenhientai.Location = new System.Drawing.Point(147, 53);
            this.txtquyenhientai.Name = "txtquyenhientai";
            this.txtquyenhientai.ReadOnly = true;
            this.txtquyenhientai.Size = new System.Drawing.Size(150, 26);
            this.txtquyenhientai.TabIndex = 12;
            // 
            // txttkCansua
            // 
            // 
            // 
            // 
            this.txttkCansua.Border.Class = "TextBoxBorder";
            this.txttkCansua.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttkCansua.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txttkCansua.FocusHighlightEnabled = true;
            this.txttkCansua.Location = new System.Drawing.Point(147, 21);
            this.txttkCansua.Name = "txttkCansua";
            this.txttkCansua.ReadOnly = true;
            this.txttkCansua.Size = new System.Drawing.Size(150, 26);
            this.txttkCansua.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(43, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quyền hiên tại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(33, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quyền được cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(50, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tài khoản:";
            // 
            // butCapquyen
            // 
            this.butCapquyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butCapquyen.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butCapquyen.Image = global::softQld.Properties.Resources.save;
            this.butCapquyen.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butCapquyen.Location = new System.Drawing.Point(313, 39);
            this.butCapquyen.Name = "butCapquyen";
            this.butCapquyen.Size = new System.Drawing.Size(109, 37);
            this.butCapquyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butCapquyen.TabIndex = 11;
            this.butCapquyen.Text = "Thực hiện";
            this.butCapquyen.Click += new System.EventHandler(this.butCapquyen_Click);
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Cấp Quyền";
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX16.Location = new System.Drawing.Point(97, 12);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(295, 35);
            this.labelX16.TabIndex = 41;
            this.labelX16.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // frmQuanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 529);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVtaikhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanlytaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanlytaikhoan";
            this.Load += new System.EventHandler(this.frmQuanlytaikhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel3.ResumeLayout(false);
            this.tabControlPanel3.PerformLayout();
            this.tabControlPanel2.ResumeLayout(false);
            this.tabControlPanel2.PerformLayout();
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVtaikhoan;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtquyen;
        private DevComponents.DotNetBar.Controls.TextBoxX txttaikhoan;
        private DevComponents.DotNetBar.ButtonX butCancel;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboquyenduoccap;
        private DevComponents.Editors.ComboItem Admin;
        private DevComponents.Editors.ComboItem User;
        private DevComponents.Editors.ComboItem Guest;
        private DevComponents.DotNetBar.Controls.TextBoxX txtquyenhientai;
        private DevComponents.DotNetBar.Controls.TextBoxX txttkCansua;
        private DevComponents.DotNetBar.ButtonX butCapquyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmkmoi2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmkmoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmkcu;
        private DevComponents.DotNetBar.ButtonX butDoimk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txttaikhoanxoa;
        private DevComponents.DotNetBar.ButtonX butXoatk;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.LabelX labelX16;
    }
}