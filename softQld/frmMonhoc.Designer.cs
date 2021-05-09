namespace softQld
{
    partial class frmMonhoc
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butthoat = new DevComponents.DotNetBar.ButtonX();
            this.butxoa = new DevComponents.DotNetBar.ButtonX();
            this.butSua = new DevComponents.DotNetBar.ButtonX();
            this.butThem = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhichu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenmon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMamonhoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrvMonhoc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Mamon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvMonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.butthoat);
            this.groupBox2.Controls.Add(this.butxoa);
            this.groupBox2.Controls.Add(this.butSua);
            this.groupBox2.Controls.Add(this.butThem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // butthoat
            // 
            this.butthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butthoat.Image = global::softQld.Properties.Resources.power;
            this.butthoat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butthoat.Location = new System.Drawing.Point(395, 25);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(100, 30);
            this.butthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butthoat.TabIndex = 6;
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoa
            // 
            this.butxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butxoa.Image = global::softQld.Properties.Resources.Delete;
            this.butxoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butxoa.Location = new System.Drawing.Point(289, 25);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(100, 30);
            this.butxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butxoa.TabIndex = 5;
            this.butxoa.Text = "Xóa";
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butSua
            // 
            this.butSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butSua.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butSua.Image = global::softQld.Properties.Resources.config;
            this.butSua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butSua.Location = new System.Drawing.Point(183, 25);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(100, 30);
            this.butSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butSua.TabIndex = 4;
            this.butSua.Text = "Sửa";
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butThem.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butThem.Image = global::softQld.Properties.Resources.add;
            this.butThem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butThem.Location = new System.Drawing.Point(77, 25);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(100, 30);
            this.butThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butThem.TabIndex = 3;
            this.butThem.Text = "Thêm";
            this.butThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGhichu);
            this.groupBox1.Controls.Add(this.txtTenmon);
            this.groupBox1.Controls.Add(this.txtMamonhoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin môn học";
            // 
            // txtGhichu
            // 
            // 
            // 
            // 
            this.txtGhichu.Border.Class = "TextBoxBorder";
            this.txtGhichu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGhichu.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtGhichu.FocusHighlightEnabled = true;
            this.txtGhichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhichu.Location = new System.Drawing.Point(234, 94);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(167, 30);
            this.txtGhichu.TabIndex = 2;
            // 
            // txtTenmon
            // 
            // 
            // 
            // 
            this.txtTenmon.Border.Class = "TextBoxBorder";
            this.txtTenmon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenmon.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTenmon.FocusHighlightEnabled = true;
            this.txtTenmon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenmon.Location = new System.Drawing.Point(234, 62);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(167, 26);
            this.txtTenmon.TabIndex = 1;
            // 
            // txtMamonhoc
            // 
            // 
            // 
            // 
            this.txtMamonhoc.Border.Class = "TextBoxBorder";
            this.txtMamonhoc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMamonhoc.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMamonhoc.FocusHighlightEnabled = true;
            this.txtMamonhoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMamonhoc.Location = new System.Drawing.Point(234, 30);
            this.txtMamonhoc.Name = "txtMamonhoc";
            this.txtMamonhoc.ReadOnly = true;
            this.txtMamonhoc.Size = new System.Drawing.Size(167, 26);
            this.txtMamonhoc.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(123, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(123, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(123, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã môn học:";
            // 
            // GrvMonhoc
            // 
            this.GrvMonhoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GrvMonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvMonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mamon,
            this.Tenmon,
            this.Ghichu});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrvMonhoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.GrvMonhoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.GrvMonhoc.Location = new System.Drawing.Point(12, 307);
            this.GrvMonhoc.Name = "GrvMonhoc";
            this.GrvMonhoc.Size = new System.Drawing.Size(572, 208);
            this.GrvMonhoc.TabIndex = 3;
            this.GrvMonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrvMonhoc_CellClick);
            // 
            // Mamon
            // 
            this.Mamon.DataPropertyName = "Mamon";
            this.Mamon.HeaderText = "Mã môn";
            this.Mamon.Name = "Mamon";
            // 
            // Tenmon
            // 
            this.Tenmon.DataPropertyName = "Tenmon";
            this.Tenmon.HeaderText = "Tên môn";
            this.Tenmon.Name = "Tenmon";
            // 
            // Ghichu
            // 
            this.Ghichu.DataPropertyName = "Ghichu";
            this.Ghichu.HeaderText = "Ghi chú";
            this.Ghichu.Name = "Ghichu";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(76, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(447, 57);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "CẬP NHẬT THÔNG TIN MÔN HỌC";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 527);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.GrvMonhoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.frmMonhoc_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvMonhoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX GrvMonhoc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGhichu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenmon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMamonhoc;
        private DevComponents.DotNetBar.ButtonX butthoat;
        private DevComponents.DotNetBar.ButtonX butxoa;
        private DevComponents.DotNetBar.ButtonX butSua;
        private DevComponents.DotNetBar.ButtonX butThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mamon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghichu;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}