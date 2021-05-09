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
    public partial class frmDangky : Form
    {
        public frmDangky()
        {
            InitializeComponent();
        }
        DatabaseConnection cls = new DatabaseConnection();
        string User = "Chua kich hoat";
        frmMain frm = new frmMain();
        private void butthoat_Click(object sender, EventArgs e)
        {
            frm.Visible = true;
            frm.Show();
            this.Close();
        }

        private void butnhaplai_Click(object sender, EventArgs e)
        {
            txtmgv.Text = "";
            txtmk1.Text = "";
            txtmk2.Text = "";
            txttdn.Text = "";
            txttdn.Focus();
        }

       

        private void butDk_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into Taikhoan values(N'" + txttdn.Text + "','" + txtmk1.Text + "',N'" + User + "','" + txtmgv.Text + "')";
                if (txtmk1.Text == "" || txtmgv.Text == "")
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu đang bị bỏ trống!");
                    txttdn.Focus();
                }
                else
                    if (txtmk1.Text != txtmk2.Text || txtmk1.Text.Length < 5)
                    {
                        MessageBox.Show("Mật khẩu không giống nhau hoặc quá ngắn!");
                        txtmk1.Focus();
                    }
                    else
                        if (cls.kttrungkhoa(txtmgv.Text, "select * from Giaovien") == false)
                        {
                            MessageBox.Show("Giáo viên này không tồn tại! Bạn hãy kiểm tra lại!");
                            txtmgv.Focus();
                        }
                        else
                            if (cls.kttrungkhoa(txttdn.Text, "select * from Taikhoan") == true)
                                MessageBox.Show("Tài khoản này đã có người dùng! Bạn hãy chọn Tài khoản khác!");
                            else
                            {
                                cls.thucthiketnoi(insert);
                                MessageBox.Show("Bạn đã đăng ký thành công!");
                                frm.k = 2;
                                frm.username = txttdn.Text.ToString();
                                frm.anmennu();
                                frm.Show();
                                this.Close();
                            }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }

        }

        #region Bắt sự kiện nhấn phím Enter
        private void txtmgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                butDk_Click(null, null);
            }
        }
        private void txttdn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                butDk_Click(null, null);
            }
        }

        private void txtmk1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                butDk_Click(null, null);
            }
        }

        private void txtmk2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                butDk_Click(null, null);
            }
        }
        #endregion

        private void frmDangky_Load(object sender, EventArgs e)
        {

        }
    }
}
