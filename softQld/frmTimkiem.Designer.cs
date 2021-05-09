namespace softQld
{
    partial class frmTimkiem
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
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttThoat = new DevComponents.DotNetBar.ButtonX();
            this.bttIN = new DevComponents.DotNetBar.ButtonX();
            this.bttTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.rdQueQuan = new System.Windows.Forms.RadioButton();
            this.rdTenHS = new System.Windows.Forms.RadioButton();
            this.rdMaHS = new System.Windows.Forms.RadioButton();
            this.grvTimKiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rdQueQuan);
            this.groupBox1.Controls.Add(this.rdTenHS);
            this.groupBox1.Controls.Add(this.rdMaHS);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(641, 171);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yêu cầu tìm kiếm";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusHighlightEnabled = true;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(118, 61);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(386, 26);
            this.txtTimKiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttThoat);
            this.groupBox2.Controls.Add(this.bttIN);
            this.groupBox2.Controls.Add(this.bttTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(88, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 70);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // bttThoat
            // 
            this.bttThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttThoat.Image = global::softQld.Properties.Resources.power;
            this.bttThoat.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttThoat.Location = new System.Drawing.Point(303, 24);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(87, 30);
            this.bttThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttThoat.TabIndex = 3;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // bttIN
            // 
            this.bttIN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttIN.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttIN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttIN.Image = global::softQld.Properties.Resources.print_view;
            this.bttIN.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttIN.Location = new System.Drawing.Point(194, 24);
            this.bttIN.Name = "bttIN";
            this.bttIN.Size = new System.Drawing.Size(86, 30);
            this.bttIN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttIN.TabIndex = 2;
            this.bttIN.Text = "In";
            this.bttIN.Click += new System.EventHandler(this.bttIN_Click);
            // 
            // bttTimKiem
            // 
            this.bttTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bttTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttTimKiem.Image = global::softQld.Properties.Resources.search0001;
            this.bttTimKiem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.bttTimKiem.Location = new System.Drawing.Point(63, 24);
            this.bttTimKiem.Name = "bttTimKiem";
            this.bttTimKiem.Size = new System.Drawing.Size(109, 30);
            this.bttTimKiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bttTimKiem.TabIndex = 1;
            this.bttTimKiem.Text = "Tìm kiếm";
            this.bttTimKiem.Click += new System.EventHandler(this.bttTimKiem_Click);
            // 
            // rdQueQuan
            // 
            this.rdQueQuan.AutoSize = true;
            this.rdQueQuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdQueQuan.Location = new System.Drawing.Point(414, 27);
            this.rdQueQuan.Name = "rdQueQuan";
            this.rdQueQuan.Size = new System.Drawing.Size(90, 23);
            this.rdQueQuan.TabIndex = 3;
            this.rdQueQuan.TabStop = true;
            this.rdQueQuan.Text = "Quê Quán";
            this.rdQueQuan.UseVisualStyleBackColor = true;
            // 
            // rdTenHS
            // 
            this.rdTenHS.AutoSize = true;
            this.rdTenHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdTenHS.Location = new System.Drawing.Point(258, 27);
            this.rdTenHS.Name = "rdTenHS";
            this.rdTenHS.Size = new System.Drawing.Size(110, 23);
            this.rdTenHS.TabIndex = 3;
            this.rdTenHS.TabStop = true;
            this.rdTenHS.Text = "Tên Học Sinh";
            this.rdTenHS.UseVisualStyleBackColor = true;
            // 
            // rdMaHS
            // 
            this.rdMaHS.AutoSize = true;
            this.rdMaHS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdMaHS.Location = new System.Drawing.Point(118, 27);
            this.rdMaHS.Name = "rdMaHS";
            this.rdMaHS.Size = new System.Drawing.Size(108, 23);
            this.rdMaHS.TabIndex = 3;
            this.rdMaHS.TabStop = true;
            this.rdMaHS.Text = "Mã Học Sinh";
            this.rdMaHS.UseVisualStyleBackColor = true;
            // 
            // grvTimKiem
            // 
            this.grvTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvTimKiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.grvTimKiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grvTimKiem.Location = new System.Drawing.Point(11, 237);
            this.grvTimKiem.Name = "grvTimKiem";
            this.grvTimKiem.Size = new System.Drawing.Size(641, 212);
            this.grvTimKiem.TabIndex = 15;
            // 
            // labelX16
            // 
            // 
            // 
            // 
            this.labelX16.BackgroundStyle.Class = "";
            this.labelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX16.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX16.Location = new System.Drawing.Point(110, 19);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(449, 35);
            this.labelX16.TabIndex = 41;
            this.labelX16.Text = "TÌM KIẾM THÔNG TIN HỌC SINH";
            // 
            // frmTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 461);
            this.Controls.Add(this.labelX16);
            this.Controls.Add(this.grvTimKiem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTimkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm thông tin học sinh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdQueQuan;
        private System.Windows.Forms.RadioButton rdTenHS;
        private System.Windows.Forms.RadioButton rdMaHS;
        private DevComponents.DotNetBar.Controls.DataGridViewX grvTimKiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.ButtonX bttThoat;
        private DevComponents.DotNetBar.ButtonX bttIN;
        private DevComponents.DotNetBar.ButtonX bttTimKiem;
        private DevComponents.DotNetBar.LabelX labelX16;
    }
}