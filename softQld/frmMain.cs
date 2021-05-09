using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace softQld
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        DatabaseConnection cls = new DatabaseConnection();
        public int k = 1;
        public LinkLabel quyen = new LinkLabel();
        public LinkLabel user = new LinkLabel();
        public string username;
        public string quyentk;
        List<Form> dsform = new List<Form>();
        void dongformcon()
        {
            //đóng tất cả các form MDIChildren hiện tại
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        //Các hàm ẩn hiên chức năng theo quyền hạn
        #region các hàm ẩn hiện Menu

        public void anchucnang()
        {
            if (k == 2)
            {              
                if (quyentk == "User")
                {
                    lblThongbao.Visible = false;
                    butCapnhatGV.Enabled = false;
                    butCapnhatHS.Enabled = false;
                    butCapnhatLop.Enabled = false;
                    butCapnhatMonH.Enabled = false;
                    butNhapdiemtuExcel.Enabled = false;
                    butDiem.Enabled = false;
                    butNhapHKtuExxcel.Enabled = false;
                    butNhaphsExcel.Enabled = false;
                    butHanhkiem.Enabled = false;

                   
                    butDSHS.Enabled = true;
                    butxemdiem.Enabled = true;
                    butTimkiem.Enabled = true;
                    butThongkediem.Enabled = true;
                    butThongkehanhkiem.Enabled = true;
                }
                else
                    if (quyentk == "Admin")
                    {
                        lblThongbao.Visible = false;
                        butCapnhatGV.Enabled = true;
                        butCapnhatHS.Enabled = true;
                        butCapnhatLop.Enabled = true;
                        butCapnhatMonH.Enabled = true;
                        butNhapdiemtuExcel.Enabled = true;
                        butDiem.Enabled = true;
                        butNhapHKtuExxcel.Enabled = true;
                        butNhaphsExcel.Enabled = true;
                        butHanhkiem.Enabled = true;

                      
                        butDSHS.Enabled = true;
                        butxemdiem.Enabled = true;
                        butTimkiem.Enabled = true;
                        butThongkediem.Enabled = true;
                        butThongkehanhkiem.Enabled = true;
                    }
                    else
                    {
                        if (quyentk == "Chua kich hoat")
                        {
                            lblThongbao.Text = "Tài khoản của bạn chưa được kích hoạt. Hãy liên hệ với Admin để được kích hoạt tài khoản!";
                            lblThongbao.Visible = true;
                            butCapnhatGV.Enabled = false;
                            butCapnhatHS.Enabled = false;
                            butCapnhatLop.Enabled = false;
                            butCapnhatMonH.Enabled = false;
                            butNhapdiemtuExcel.Enabled = false;
                            butDiem.Enabled = false;
                            butNhapHKtuExxcel.Enabled = false;
                            butNhaphsExcel.Enabled = false;
                            butHanhkiem.Enabled = false;

                          
                            butDSHS.Enabled = false;
                            butxemdiem.Enabled = false;
                            butTimkiem.Enabled = false;
                            butThongkediem.Enabled = false;
                            butThongkehanhkiem.Enabled = false;
                        }
                    }
            }
            else
                if (k == 1)
                {
                    butCapnhatGV.Enabled = false;
                    butCapnhatHS.Enabled = false;
                    butCapnhatLop.Enabled = false;
                    butCapnhatMonH.Enabled = false;
                    butNhapdiemtuExcel.Enabled = false;
                    butDiem.Enabled = false;
                    butNhapHKtuExxcel.Enabled = false;
                    butNhaphsExcel.Enabled = false;
                    butHanhkiem.Enabled = false;

                   
                    butDSHS.Enabled = false;
                    butxemdiem.Enabled = false;
                    butTimkiem.Enabled = false;
                    butThongkediem.Enabled = false;
                    butThongkehanhkiem.Enabled = false;
                }
        }

        public void anmennu()
        {

            if (k == 2)
            {
                butuser.Visible = true;
                butQuanlytaikhoan.Enabled = true;
                butThoat.Enabled = true;
                butDangky.Visible = false;
                butDangnhap.Visible = false;
                butThoat.Text = "Thoát: " + username;
                butuser.Visible = true;
                butuser.Text="User: "+ username;
            }
            else
                if (k == 1)
                {
                    butDangnhap.Visible = true;
                    butThoat.Visible = true;
                    butuser.Visible = false;
                    butDangky.Visible = true;
                    butDangky.Enabled =true;
                    butThoat.Text = "Thoát";
                }
        }
        #endregion

        private void butDangnhap_Click(object sender, EventArgs e)
        {
           
            frmDangnhap dangnhap = new frmDangnhap();
            dangnhap.Show();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            string delete = "delete from Userdangnhap";
            cls.thucthiketnoi(delete);
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cls.loadlinklabel(user, "select * from Userdangnhap");
            username = user.Text;
            cls.loadlinklabel(quyen, "select Quyen from Taikhoan where Tendangnhap=N'" + username + "'");
            quyentk = quyen.Text;
            if (user.Text != "")
            {
                k = 2;
                anmennu();
                anchucnang();
            }
            else
            {
                k = 1;
                anmennu();
                anchucnang();
            }
        }

        private void butDangky_Click(object sender, EventArgs e)
        {
            frmDangky dangky = new frmDangky();
            dangky.Show();
            this.Hide();
        }

        private void butQuanlytaikhoan_Click(object sender, EventArgs e)
        {
            frmQuanlytaikhoan qltk = new frmQuanlytaikhoan();
            qltk.Show();
            this.Hide();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            string delete = "delete from Userdangnhap";
            DialogResult rs = MessageBox.Show("Bạn thật sự muốn Logout???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                k = 1;
                anmennu();
                anchucnang();
            }
        }

       

        private void butCapnhatGV_Click(object sender, EventArgs e)
        {
            dongformcon();
            frmGiaovien giaovien = new frmGiaovien();
            giaovien.MdiParent = this;
            giaovien.Show();
        }

        private void butCapnhatLop_Click(object sender, EventArgs e)
        {
            dongformcon();
            frmLop lophoc = new frmLop();
            lophoc.MdiParent = this;
            lophoc.Show();
        }

       

        private void butCapnhatHS_Click(object sender, EventArgs e)
        {
            dongformcon();
            frmHocSinh hocsinh = new frmHocSinh();
            hocsinh.MdiParent = this;
            hocsinh.Show();
        }

        private void butDSHS_Click(object sender, EventArgs e)
        {
            dongformcon();
            frmDSHocsinh dshocsinh = new frmDSHocsinh();
            dshocsinh.MdiParent = this;
            dshocsinh.Show();
        }

        private void butDiem_Click(object sender, EventArgs e)
        {
            dongformcon();
            frmNhapDiem nhapdiem = new frmNhapDiem();
            nhapdiem.MdiParent = this;
            nhapdiem.Show();
        }

        private void butCapnhatMonH_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmMonhoc monhoc = new frmMonhoc();
            monhoc.MdiParent = this;
            monhoc.Show();
        }

        private void butHanhkiem_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmHanhKiem hanhkiem = new frmHanhKiem();
            hanhkiem.MdiParent = this;
            hanhkiem.Show();
        }

        private void butTimkiem_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmTimkiem timkiem = new frmTimkiem();
            timkiem.MdiParent = this;
            timkiem.Show();
        }

        private void butThongkediem_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmThongKeDiem tkdiem = new frmThongKeDiem();
            tkdiem.MdiParent = this;
            tkdiem.Show();
        }

        private void butThongkehanhkiem_Click(object sender, EventArgs e)
        {
            dongformcon();
            frmThongKeHanhKiem tkhanhkiem = new frmThongKeHanhKiem();
            tkhanhkiem.MdiParent = this;
            tkhanhkiem.Show();
        }

        
        private void butAbout_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            About frmAbout = new About();
            frmAbout.MdiParent = this;
            frmAbout.Show();
        }

        private void butNhapdiemtuExcel_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmNhaptuExcel diemexcel = new frmNhaptuExcel();
            diemexcel.MdiParent = this;
            diemexcel.Show();
        }

        private void butxemdiem_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmXemdiemHS bangdiem = new frmXemdiemHS();
            bangdiem.MdiParent = this;
            bangdiem.Show();
        }

        private void butNhaphsExcel_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmNhapDSHStuExcel nhapdshs = new frmNhapDSHStuExcel();
            nhapdshs.MdiParent = this;
            nhapdshs.Show();
        }

        private void butNhapHKtuExxcel_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmNhapHKtuExcel nhaphkhs = new frmNhapHKtuExcel();
            nhaphkhs.MdiParent = this;
            nhaphkhs.Show();
        }

        private void butuser_Click(object sender, EventArgs e)
        {
            dongformcon(); 
            frmuser user = new frmuser();
            user.MdiParent = this;
            user.Show();
        }
       
        private void butTongket_Click(object sender, EventArgs e)
        {
            dongformcon();
            frmTongketdiem tongket = new frmTongketdiem();
            tongket.MdiParent = this;
            tongket.Show();
        }

        private void butxemdiem_Click_2(object sender, EventArgs e)
        {
            dongformcon();
            frmXemdiemHS xemdiem = new frmXemdiemHS();
            xemdiem.MdiParent = this;
            xemdiem.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
