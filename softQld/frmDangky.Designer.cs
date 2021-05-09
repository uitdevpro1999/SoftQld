namespace softQld
{
    partial class frmDangky
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butthoat = new DevComponents.DotNetBar.ButtonX();
            this.butnhaplai = new DevComponents.DotNetBar.ButtonX();
            this.butDk = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmgv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmk2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmk1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttdn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Giáo Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập lại MK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(26, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 253);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng ký";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butthoat);
            this.groupBox3.Controls.Add(this.butnhaplai);
            this.groupBox3.Controls.Add(this.butDk);
            this.groupBox3.Location = new System.Drawing.Point(6, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 61);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // butthoat
            // 
            this.butthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butthoat.Image = global::softQld.Properties.Resources.Restart;
            this.butthoat.Location = new System.Drawing.Point(227, 16);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(98, 30);
            this.butthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.butthoat.TabIndex = 6;
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butnhaplai
            // 
            this.butnhaplai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butnhaplai.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butnhaplai.Image = global::softQld.Properties.Resources.WRI;
            this.butnhaplai.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.butnhaplai.Location = new System.Drawing.Point(113, 16);
            this.butnhaplai.Name = "butnhaplai";
            this.butnhaplai.Size = new System.Drawing.Size(108, 30);
            this.butnhaplai.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.butnhaplai.TabIndex = 5;
            this.butnhaplai.Text = "Nhập lại";
            this.butnhaplai.Click += new System.EventHandler(this.butnhaplai_Click);
            // 
            // butDk
            // 
            this.butDk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butDk.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butDk.Image = global::softQld.Properties.Resources._8Control_Panel;
            this.butDk.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butDk.Location = new System.Drawing.Point(6, 16);
            this.butDk.Name = "butDk";
            this.butDk.Size = new System.Drawing.Size(101, 30);
            this.butDk.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.butDk.TabIndex = 4;
            this.butDk.Text = "Đăng ký";
            this.butDk.Click += new System.EventHandler(this.butDk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmgv);
            this.groupBox2.Controls.Add(this.txtmk2);
            this.groupBox2.Controls.Add(this.txtmk1);
            this.groupBox2.Controls.Add(this.txttdn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 165);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtmgv
            // 
            // 
            // 
            // 
            this.txtmgv.Border.Class = "TextBoxBorder";
            this.txtmgv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmgv.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmgv.FocusHighlightEnabled = true;
            this.txtmgv.Location = new System.Drawing.Point(125, 116);
            this.txtmgv.Name = "txtmgv";
            this.txtmgv.Size = new System.Drawing.Size(179, 26);
            this.txtmgv.TabIndex = 3;
            this.txtmgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmgv_KeyPress);
            // 
            // txtmk2
            // 
            // 
            // 
            // 
            this.txtmk2.Border.Class = "TextBoxBorder";
            this.txtmk2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmk2.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmk2.FocusHighlightEnabled = true;
            this.txtmk2.Location = new System.Drawing.Point(125, 84);
            this.txtmk2.Name = "txtmk2";
            this.txtmk2.Size = new System.Drawing.Size(179, 26);
            this.txtmk2.TabIndex = 2;
            this.txtmk2.UseSystemPasswordChar = true;
            this.txtmk2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmk2_KeyPress);
            // 
            // txtmk1
            // 
            // 
            // 
            // 
            this.txtmk1.Border.Class = "TextBoxBorder";
            this.txtmk1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmk1.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmk1.FocusHighlightEnabled = true;
            this.txtmk1.Location = new System.Drawing.Point(125, 52);
            this.txtmk1.Name = "txtmk1";
            this.txtmk1.Size = new System.Drawing.Size(179, 26);
            this.txtmk1.TabIndex = 1;
            this.txtmk1.UseSystemPasswordChar = true;
            this.txtmk1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmk1_KeyPress);
            // 
            // txttdn
            // 
            // 
            // 
            // 
            this.txttdn.Border.Class = "TextBoxBorder";
            this.txttdn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttdn.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txttdn.FocusHighlightEnabled = true;
            this.txttdn.Location = new System.Drawing.Point(125, 20);
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(179, 26);
            this.txttdn.TabIndex = 0;
            this.txttdn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttdn_KeyPress);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(40, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(319, 35);
            this.labelX1.TabIndex = 30;
            this.labelX1.Text = "ĐĂNG KÝ NGƯỜI DÙNG";
            // 
            // frmDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 329);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký tài khoản người dùng";
            this.Load += new System.EventHandler(this.frmDangky_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX butthoat;
        private DevComponents.DotNetBar.ButtonX butnhaplai;
        private DevComponents.DotNetBar.ButtonX butDk;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmgv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmk2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmk1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttdn;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}