using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace softQld
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        frmMain fm = new frmMain();
        private void butthoat_Click(object sender, EventArgs e)
        {
            fm.Visible = true;
            fm.Show();
            this.Close();
        }

        private void butDn_Click(object sender, EventArgs e)
        {
            DatabaseConnection cls = new DatabaseConnection();
            string insert = "insert into Userdangnhap values(N'" + txttdn.Text + "')";
            if (txttdn.Text == "" || txtmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập user name hoặc mật khẩu!");
                txttdn.Focus();
            }
            else
                if ((cls.kt(txttdn.Text, "select * from Taikhoan", 0) == true) && (cls.kt(txtmk.Text, "select * from Taikhoan", 1) == true))
                {
                    cls.thucthiketnoi(insert);
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.k = 2;
                    fm.anmennu();
                    MessageBox.Show("Bạn đã đăng nhập thành công");
                    fm.ShowDialog();

                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

       private void txtmk_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                butDn_Click(null, null);
            }
        }
    }
}
