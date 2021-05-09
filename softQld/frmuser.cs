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
    public partial class frmuser : Form
    {
        public frmuser()
        {
            InitializeComponent();
        }
        int dem = 1;
        frmMain frm = new frmMain();
        string username;
        DatabaseConnection cls = new DatabaseConnection();
        public LinkLabel quyen = new LinkLabel();
        public LinkLabel user = new LinkLabel();
        private void frmuser_Load(object sender, EventArgs e)
        {
            cls.loadlinklabel(user, "select * from Userdangnhap");
            username = user.Text;
            cls.loadlinklabel(quyen, "select Quyen from Taikhoan where Tendangnhap=N'" + username + "'");
            labelX1.Text = "Tài khoản: "+user.Text.ToUpper()+" đăng nhập với quyền: "+quyen.Text.ToUpper();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dem++;
                if(dem==50)
                    this.Close();
        }
    }
}
