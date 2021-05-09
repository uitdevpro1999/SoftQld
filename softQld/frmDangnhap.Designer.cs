namespace softQld
{
    partial class frmDangnhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.butthoat = new DevComponents.DotNetBar.ButtonX();
            this.butDn = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txttdn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmk = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên đăng Nhập :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtmk);
            this.groupBox5.Controls.Add(this.txttdn);
            this.groupBox5.Controls.Add(this.butthoat);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.butDn);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(33, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 154);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // butthoat
            // 
            this.butthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butthoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.butthoat.Image = global::softQld.Properties.Resources.Restart;
            this.butthoat.Location = new System.Drawing.Point(178, 102);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(102, 32);
            this.butthoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butthoat.TabIndex = 3;
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butDn
            // 
            this.butDn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.butDn.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.butDn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.butDn.Image = global::softQld.Properties.Resources.MSN_Messenger1_AKKASONE;
            this.butDn.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.butDn.Location = new System.Drawing.Point(63, 102);
            this.butDn.Name = "butDn";
            this.butDn.Size = new System.Drawing.Size(109, 32);
            this.butDn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.butDn.TabIndex = 2;
            this.butDn.Text = "Đăng Nhập";
            this.butDn.Click += new System.EventHandler(this.butDn_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(102, 19);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(178, 35);
            this.labelX1.TabIndex = 29;
            this.labelX1.Text = "ĐĂNG NHẬP";
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
            this.txttdn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttdn.Location = new System.Drawing.Point(135, 31);
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(145, 26);
            this.txttdn.TabIndex = 0;
            // 
            // txtmk
            // 
            // 
            // 
            // 
            this.txtmk.Border.Class = "TextBoxBorder";
            this.txtmk.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmk.FocusHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmk.FocusHighlightEnabled = true;
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(135, 63);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(145, 26);
            this.txtmk.TabIndex = 1;
            this.txtmk.UseSystemPasswordChar = true;
            this.txtmk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmk_KeyPress_1);
            // 
            // frmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 226);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevComponents.DotNetBar.ButtonX butthoat;
        private DevComponents.DotNetBar.ButtonX butDn;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmk;
        private DevComponents.DotNetBar.Controls.TextBoxX txttdn;
    }
}