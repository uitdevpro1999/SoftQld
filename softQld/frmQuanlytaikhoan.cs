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
    public partial class frmQuanlytaikhoan : Form
    {
        public frmQuanlytaikhoan()
        {
            InitializeComponent();
        }

        string q;
        LinkLabel quyen = new LinkLabel();
        LinkLabel user = new LinkLabel();
        frmMain frm = new frmMain();
        DatabaseConnection cls = new DatabaseConnection();

        private void butCancel_Click(object sender, EventArgs e)
        {
            frm.Visible = true;
            frm.Show();
            this.Close();
        }

        private void frmQuanlytaikhoan_Load(object sender, EventArgs e)
        {
            cls.loadlinklabel(user, "select * from Userdangnhap");
            frm.username = user.Text;
            cls.loadlinklabel(quyen, "select Quyen from Taikhoan where Tendangnhap=N'" + frm.username + "'");
            frm.quyentk = quyen.Text;
            txttaikhoan.Text = frm.username;
            txtquyen.Text = frm.quyentk;
            cls.loaddatagridview(DGVtaikhoan, "select * from Taikhoan");
        }

        private void DGVtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txttkCansua.Text = DGVtaikhoan.Rows[hang].Cells[0].Value.ToString();
            txttaikhoanxoa.Text = DGVtaikhoan.Rows[hang].Cells[0].Value.ToString();
            txtquyenhientai.Text = DGVtaikhoan.Rows[hang].Cells[2].Value.ToString();
            q = DGVtaikhoan.Rows[hang].Cells[2].Value.ToString();
        }

        private void butCapquyen_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update Taikhoan set Quyen='" + cboquyenduoccap.SelectedItem.ToString() + "' where(Tendangnhap=N'" + txttkCansua.Text + "')";
                if (txtquyen.Text == "User" || txtquyen.Text == "Guest")
                {
                    MessageBox.Show("Tài khoản " + txttaikhoan.Text + " không có quyền thực hiện công việc này!");
                }
                else
                    if (txtquyen.Text == "Admin")
                    {
                        cls.thucthiketnoi(update);
                        DGVtaikhoan.Refresh();
                        cls.loaddatagridview(DGVtaikhoan, "select * from Taikhoan");
                        MessageBox.Show("Công việc đã được thực hiện!");
                    }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } 
        }

        private void butDoimk_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update Taikhoan set Matkhau='" + txtmkmoi.Text + "' where(Tendangnhap=N'" + txttaikhoan.Text + "' and Matkhau='" + txtmkcu.Text + "')";
                if ((cls.kt(txtmkcu.Text, "select * from Taikhoan", 1) == false))
                {
                    MessageBox.Show("Mật khẩu cũ không đúng xin nhập lại!");
                    txtmkcu.Text = "";
                    txtmkcu.Focus();
                }
                else
                    if (txtmkcu.Text == "" || txtmkmoi.Text == "" || txtmkmoi2.Text == "")
                        MessageBox.Show("Các trường dữ liệu đang bị bỏ trống!");
                    else
                        if (txtmkmoi.Text != txtmkmoi2.Text)
                            MessageBox.Show("Mật khẩu mới nhập không khớp nhau!");
                        else
                            if (txtmkmoi.Text.Length < 5)
                                MessageBox.Show("Mât khẩu mới tối thiểu là 5 ký tự!");
                            else
                            {
                                cls.thucthiketnoi(update);
                                txtmkcu.Text = "";
                                txtmkmoi.Text = "";
                                txtmkmoi2.Text = "";
                                txtmkcu.Focus();
                                DGVtaikhoan.Refresh();
                                cls.loaddatagridview(DGVtaikhoan, "select * from Taikhoan");
                                MessageBox.Show("Công việc đã được thực hiện!");
                            }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }   
        }

        private void butXoatk_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from Taikhoan where Tendangnhap=N'" + txttaikhoanxoa.Text + "'";
                if (txttaikhoanxoa.Text == "")
                    MessageBox.Show("Bạn chưa chọn tài khoản cần xóa!");
                else
                    if (txttaikhoan.Text == txttaikhoanxoa.Text)
                    {
                        if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản của chính mình??", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cls.thucthiketnoi(delete);
                            MessageBox.Show("Chương trình sẻ quay lại giao diện chính!", "Tài khoản của bạn đã được xóa!");
                            string deletedangnhap = "delete from Userdangnhap";
                            cls.thucthiketnoi(deletedangnhap);
                            butCancel_Click(null, null);
                        }
                    }
                    else
                        if (txtquyen.Text == "User" || txtquyen.Text == "Guest")
                            MessageBox.Show("Tài khoản " + txttaikhoan.Text + " không có quyền thực hiện công việc này!");
                        else
                            if (txtquyen.Text == q)
                                MessageBox.Show("Bạn không được xóa tài khoản cùng cấp với bạn!");
                            else
                                if (txtquyen.Text == "Admin")
                                {
                                    if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này??", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        cls.thucthiketnoi(delete);
                                        DGVtaikhoan.Refresh();
                                        cls.loaddatagridview(DGVtaikhoan, "select * from Taikhoan");
                                        MessageBox.Show("Công việc đã được thực hiện!");
                                    }
                                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } 
        }
    }
}
