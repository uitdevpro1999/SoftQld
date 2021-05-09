namespace softQld
{
    partial class frmTongketdiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttThoat = new DevComponents.DotNetBar.ButtonX();
            this.bttCapNhat = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbHocKTK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.I = new DevComponents.Editors.ComboItem();
            this.II = new DevComponents.Editors.ComboItem();
            this.cbTenLTK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbNamHTK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbMaLTK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dgrvTongket = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongketky1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongketky2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongketCanam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTongket)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.Class = "";
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX14.Location = new System.Drawing.Point(121, 23);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(374, 35);
            this.labelX14.TabIndex = 37;
            this.labelX14.Text = "TỔNG KẾT ĐIỂM HỌC SINH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttThoat);
            this.groupBox1.Controls.Add(this.bttCapNhat);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.cbHocKTK);
            this.groupBox1.Controls.Add(this.cbTenLTK);
            this.groupBox1.Controls.Add(this.cbNamHTK);
            this.groupBox1.Controls.Add(this.cbMaLTK);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(16, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 174);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin về lớp cần tổng kết điểm";
            // 
            // bttThoat
            // 
            this.bttThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttThoat.Image = global::softQld.Properties.Resources.Restart;
            this.bttThoat.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.bttThoat.Location = new System.Drawing.Point(303, 123);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(100, 30);
            this.bttThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttThoat.TabIndex = 5;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttCapNhat
            // 
            this.bttCapNhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttCapNhat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttCapNhat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttCapNhat.Image = global::softQld.Properties.Resources.script_add;
            this.bttCapNhat.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.bttCapNhat.Location = new System.Drawing.Point(185, 123);
            this.bttCapNhat.Name = "bttCapNhat";
            this.bttCapNhat.Size = new System.Drawing.Size(100, 30);
            this.bttCapNhat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttCapNhat.TabIndex = 4;
            this.bttCapNhat.Text = "Cập Nhật";
            this.bttCapNhat.Click += new System.EventHandler(this.bttCapNhat_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX4.Location = new System.Drawing.Point(348, 74);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(65, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Học Kỳ:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(44, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Tên Lớp:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(348, 36);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Năm Học:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(44, 37);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Mã Lớp:";
            // 
            // cbHocKTK
            // 
            this.cbHocKTK.DisplayMember = "Text";
            this.cbHocKTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHocKTK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbHocKTK.FocusHighlightEnabled = true;
            this.cbHocKTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHocKTK.FormattingEnabled = true;
            this.cbHocKTK.ItemHeight = 20;
            this.cbHocKTK.Items.AddRange(new object[] {
            this.I,
            this.II});
            this.cbHocKTK.Location = new System.Drawing.Point(424, 74);
            this.cbHocKTK.Name = "cbHocKTK";
            this.cbHocKTK.Size = new System.Drawing.Size(121, 26);
            this.cbHocKTK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbHocKTK.TabIndex = 3;
            this.cbHocKTK.SelectedIndexChanged += new System.EventHandler(this.cbHocKTK_SelectedIndexChanged);
            // 
            // I
            // 
            this.I.Text = "I";
            // 
            // II
            // 
            this.II.Text = "II";
            // 
            // cbTenLTK
            // 
            this.cbTenLTK.DisplayMember = "Text";
            this.cbTenLTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenLTK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbTenLTK.FocusHighlightEnabled = true;
            this.cbTenLTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenLTK.FormattingEnabled = true;
            this.cbTenLTK.ItemHeight = 20;
            this.cbTenLTK.Location = new System.Drawing.Point(120, 74);
            this.cbTenLTK.Name = "cbTenLTK";
            this.cbTenLTK.Size = new System.Drawing.Size(121, 26);
            this.cbTenLTK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTenLTK.TabIndex = 2;
            this.cbTenLTK.SelectedIndexChanged += new System.EventHandler(this.cbTenLTK_SelectedIndexChanged);
            // 
            // cbNamHTK
            // 
            this.cbNamHTK.DisplayMember = "Text";
            this.cbNamHTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNamHTK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbNamHTK.FocusHighlightEnabled = true;
            this.cbNamHTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbNamHTK.FormattingEnabled = true;
            this.cbNamHTK.ItemHeight = 20;
            this.cbNamHTK.Location = new System.Drawing.Point(424, 36);
            this.cbNamHTK.Name = "cbNamHTK";
            this.cbNamHTK.Size = new System.Drawing.Size(121, 26);
            this.cbNamHTK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbNamHTK.TabIndex = 1;
            this.cbNamHTK.SelectedIndexChanged += new System.EventHandler(this.cbNamHTK_SelectedIndexChanged);
            // 
            // cbMaLTK
            // 
            this.cbMaLTK.DisplayMember = "Text";
            this.cbMaLTK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaLTK.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbMaLTK.FocusHighlightEnabled = true;
            this.cbMaLTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaLTK.FormattingEnabled = true;
            this.cbMaLTK.ItemHeight = 20;
            this.cbMaLTK.Location = new System.Drawing.Point(120, 36);
            this.cbMaLTK.Name = "cbMaLTK";
            this.cbMaLTK.Size = new System.Drawing.Size(121, 26);
            this.cbMaLTK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMaLTK.TabIndex = 0;
            this.cbMaLTK.SelectedIndexChanged += new System.EventHandler(this.cbMaLTK_SelectedIndexChanged);
            // 
            // dgrvTongket
            // 
            this.dgrvTongket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrvTongket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvTongket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.Namhoc,
            this.DiemTongketky1,
            this.DiemTongketky2,
            this.DiemTongketCanam});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvTongket.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvTongket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgrvTongket.Location = new System.Drawing.Point(16, 256);
            this.dgrvTongket.Name = "dgrvTongket";
            this.dgrvTongket.Size = new System.Drawing.Size(589, 235);
            this.dgrvTongket.TabIndex = 39;
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
            // DiemTongketky1
            // 
            this.DiemTongketky1.DataPropertyName = "DiemTongketky1";
            this.DiemTongketky1.HeaderText = "Điểm tổng kết kỳ 1";
            this.DiemTongketky1.Name = "DiemTongketky1";
            // 
            // DiemTongketky2
            // 
            this.DiemTongketky2.DataPropertyName = "DiemTongketky2";
            this.DiemTongketky2.HeaderText = "Điểm tổng kết kỳ 1";
            this.DiemTongketky2.Name = "DiemTongketky2";
            // 
            // DiemTongketCanam
            // 
            this.DiemTongketCanam.DataPropertyName = "DiemTongketCanam";
            this.DiemTongketCanam.HeaderText = "Điểm tổng kết cả năm";
            this.DiemTongketCanam.Name = "DiemTongketCanam";
            // 
            // frmTongketdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 504);
            this.Controls.Add(this.dgrvTongket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelX14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTongketdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTongketdiem";
            this.Load += new System.EventHandler(this.frmTongketdiem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTongket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX14;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgrvTongket;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbHocKTK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTenLTK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbNamHTK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaLTK;
        private DevComponents.DotNetBar.ButtonX bttCapNhat;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX bttThoat;
        private DevComponents.Editors.ComboItem I;
        private DevComponents.Editors.ComboItem II;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongketky1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongketky2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongketCanam;
    }
}