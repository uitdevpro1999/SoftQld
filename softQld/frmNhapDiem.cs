using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace softQld
{
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        DatabaseConnection cls = new DatabaseConnection();
        private Boolean kiemtra = false;
        LinkLabel Diemtam = new LinkLabel();
        string tbc;
        string dtbccanam;
        public string hk = "I";

        //----------------------------------
        #region hàm ẩn hiện các điều khiển
        void andieukhien()
        {
            cbMaLop.Enabled = false;
            cbTenLopD.Enabled = false;
            cbMaHSD.Enabled = false;
            cbHoTenD.Enabled = false;
            cbNamhocD.Enabled = false;
            cbHocKyD.Enabled = false;
            cbMaMonD.Enabled = false;
            cbTenMonD.Enabled = false;
        }
        void hiendieukhien()
        {
            cbMaLop.Enabled = true;
            cbTenLopD.Enabled = true;
            cbMaHSD.Enabled = true;
            cbHoTenD.Enabled = true;
            cbNamhocD.Enabled = true;
            cbHocKyD.Enabled = true;
            cbMaMonD.Enabled = true;
            cbTenMonD.Enabled = true;
        }
        #endregion
        //----------------------------------
        void clearText()
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
            foreach (Control ctr in this.groupBox3.Controls)
            {
                if ((ctr is TextBox) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }
        //----------------------------------
#region các hàm tính điểm
        public void Tinhdiemtheomon(string miengl1, string miengl2, string d15ph1, string d15ph2, string d45ph1, string dhocki, ref string tbhk)
        {
            //Dung try cath de bat' truog hop datagridview khong co du lieu
            try
            {
                if (miengl2 != "")
                    miengl1 = ((double.Parse(miengl1) + double.Parse(miengl2)) / 2).ToString();
                if (d15ph2 != "")
                    d15ph1 = ((double.Parse(d15ph1) + double.Parse(d15ph2)) / 2).ToString();
                double tb = Math.Round(((double.Parse(miengl1) + double.Parse(d15ph1) + (double.Parse(d45ph1) * 2) + (double.Parse(dhocki) * 3)) / 7), 2);
                tbhk = tb.ToString();
            }
            catch { }
        }
#endregion
        //----------------------------------
#region các hàm lấy dữ liệu 
        public void Laynienkhoa(string malop, ref string nienkhoa)
        {
            List<string> nk = new List<string>();
            cls.Loadlist("select Nienkhoa from Lop where Malop = '" + malop + "'", ref nk);
            nienkhoa = nk[0];
        }

        void Laynamhoc()
        {
            string nienkhoa = "", namhoc = "";
            Laynienkhoa(cbMaLop.Text, ref nienkhoa);
            foreach (string xc in nienkhoa.Split('-'))
            {
                namhoc = xc; break;
            }
            cbNamhocD.Items.Clear();
            for (int i = int.Parse(namhoc); i < int.Parse(namhoc) + 4; i++)
                cbNamhocD.Items.Add(i.ToString() + " - " + (i + 1).ToString());
            cbNamhocD.Text = cbNamhocD.Items[0].ToString();
        }
        public void LoadcomMalop(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Malop from Lop");
            cls.Data2Combobox(comten, "select Tenlop from Lop");
        }
       
        public void LoadcomMaHS(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select MaHS from Hocsinh where Malop=N'" + cbMaLop.SelectedItem.ToString() + "'");
            cls.Data2Combobox(comten, "select Hoten from Hocsinh where Malop=N'" + cbMaLop.SelectedItem.ToString() + "'");
        }
        public void LoadcomMamon(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Mamon from Monhoc");
            cls.Data2Combobox(comten, "select Tenmon from Monhoc");
        }
        #endregion
        //----------------------------------
#region Hàm kiểm tra nhập điểm
        public bool KiemtraMaHS(string mhs, string mm, string nh, string hk)
        {
            //Trả về giá trị True khi học sinh đã có điểm
            LinkLabel ktmahocsinh = new LinkLabel();
            LinkLabel ktmamonhoc = new LinkLabel();
            LinkLabel ktnamhoc = new LinkLabel();
            LinkLabel kthocky = new LinkLabel();
            cls.loadlinklabel(ktmahocsinh, "select MaHS from Diem where MaHS=N'" + mhs + "'");
            if (ktmahocsinh.Text != "")
            {
                cls.loadlinklabel(ktmamonhoc, "select Mamon from Diem where Mamon=N'" + mm + "' and MaHS=N'" + mhs + "'");
                if (ktmamonhoc.Text != "")
                {
                    cls.loadlinklabel(ktnamhoc, "select Namhoc from Diem where Namhoc=N'" + nh + "' and Mamon=N'" + mm + "' and MaHS=N'" + mhs + "'");
                    if (ktnamhoc.Text != "")
                    {
                        cls.loadlinklabel(kthocky, "select Hocky from Diem where Hocky=N'" + hk + "' and Namhoc=N'" + nh + "' and Mamon=N'" + mm + "' and MaHS=N'" + mhs + "'");
                        if (kthocky.Text != "")
                            return true;
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;

        }
       
#endregion

        //----------------------------------
        private void bttThem_Click(object sender, EventArgs e)
        {
             kiemtra = !kiemtra;
             if (kiemtra)
             {
                 hiendieukhien();
                 clearText();
                 bttSua.Enabled = false;
                 bttXoa.Enabled = false;
                 bttThem.Text = "Lưu";
             }
             else
             {
                 bttSua.Enabled = true;
                 bttXoa.Enabled = true;
                 if (cbMaLop.Text == "")
                     MessageBox.Show("Bạn chưa chọn lớp để nhập điểm.");
                 else
                 {
                     if (cbMaHSD.Text == "")
                         MessageBox.Show("Bạn chưa chọn học sinh để nhập điểm");
                     else
                     {
                         if (cbNamhocD.Text == "")
                             MessageBox.Show("Bạn chưa chọn năm học cần nhập điểm");
                         else
                         {
                             if (cbHocKyD.Text == "")
                                 MessageBox.Show("Bạn chưa chọn học kỳ cần nhập điểm");
                             else
                             {
                                 if (cbMaMonD.Text == "")
                                     MessageBox.Show("Bạn chưa chọn môn học cần nhập điểm");
                                 else
                                 {
                                     if (KiemtraMaHS(cbMaHSD.Text, cbMaMonD.Text, cbNamhocD.Text, cbHocKyD.Text) == true)
                                         MessageBox.Show("Học sinh này đã được nhập điểm rồi!");
                                     else
                                     {
                                         if (cbDiem15L1.Text == "" || cbDiem45.Text == "" || cbDiemML1.Text == "" || cbDiemHK.Text == "")
                                         {
                                             MessageBox.Show("Bạn chưa nhập các điểm bắt buộc phải có!");
                                         }
                                         else
                                         {
                                             Tinhdiemtheomon(cbDiemML1.Text, cbDiemML2.Text, cbDiem15L1.Text, cbDiem15L2.Text, cbDiem45.Text, cbDiemHK.Text, ref tbc);
                                             txtDiemTBC.Text = tbc;
                                             try
                                             {
                                                 //insert dữ liệu vào nếu nhập điểm cho học kỳ 1
                                                 if (cbHocKyD.Text == "I")
                                                 {
                                                     string insertk1 = "insert into Diem (MaHS,Mamon,Namhoc,Hocky,Diemmieng,Diemmiengl2,Diem15phut,Diem15phutl2,Diem45phut,Diemhocky,DiemTBhocky) values(N'" + cbMaHSD.Text + "','" + cbMaMonD.Text + "','" + cbNamhocD.Text + "','" + cbHocKyD.Text +
                                                     "','" + cbDiemML1.Text + "','" + cbDiemML2.Text + "','" + cbDiem15L1.Text + "','" + cbDiem15L2.Text + "','" + cbDiem45.Text + "','" + cbDiemHK.Text + "','" + Convert.ToDouble(tbc) + "')";
                                                     cls.thucthiketnoi(insertk1);
                                                     dgvDiem.Refresh();
                                                     cls.Data2DataGridView(dgvDiem, "select * from Diem");
                                                 }
                                                 else
                                                     //insert dữ liệu vào nếu nhập điểm cho học kỳ 2
                                                     if (cbHocKyD.Text == "II")
                                                     {
                                                         cls.loadlinklabel(Diemtam, "select DiemTBhocky from Diem where(MaHS=N'" + cbMaHSD.Text + "' and Mamon=N'" + cbMaMonD.Text + "' and Namhoc=N'" + cbNamhocD.Text + "' and Hocky=N'" + hk + "') ");
                                                         dtbccanam = (Math.Round((double.Parse(txtDiemTBC.Text.Trim()) * 2 + double.Parse(Diemtam.Text.Trim())) / 3, 2)).ToString();
                                                         string insertk2 = "insert into Diem (MaHS,Mamon,Namhoc,Hocky,Diemmieng,Diemmiengl2,Diem15phut,Diem15phutl2,Diem45phut,Diemhocky,DiemTBhocky,DiemTBC) values(N'" + cbMaHSD.Text + "','" + cbMaMonD.Text + "','" + cbNamhocD.Text + "','" + cbHocKyD.Text +
                                                         "','" + cbDiemML1.Text + "','" + cbDiemML2.Text + "','" + cbDiem15L1.Text + "','" + cbDiem15L2.Text + "','" + cbDiem45.Text + "','" + cbDiemHK.Text + "','" + double.Parse(txtDiemTBC.Text) + "','" + double.Parse(dtbccanam) + "')";
                                                         cls.thucthiketnoi(insertk2);
                                                         dgvDiem.Refresh();
                                                         cls.Data2DataGridView(dgvDiem, "select * from Diem");
                                                         //MessageBox.Show(dtbccanam);
                                                     }
                                             }
                                             catch (SqlException ex)
                                             {
                                                 MessageBox.Show(ex.StackTrace);
                                             }
                                         }
                                         
                                     }
                                 }
                             }
                         }
                     }
                 }
                 bttThem.Text = "Thêm";
                 //andieukhien();
                 //clearText();
             }
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            andieukhien();
            clearText();
            cls.Data2DataGridView(dgvDiem, "select * from Diem");
            LoadcomMalop(cbMaLop, cbTenLopD);
            LoadcomMamon(cbMaMonD, cbTenMonD);
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLop.Text != "")
                Laynamhoc();
            LoadcomMaHS(cbMaHSD, cbHoTenD);
            cbTenLopD.Text = cbTenLopD.Items[cbMaLop.Items.IndexOf(cbMaLop.Text)].ToString();
        }

        private void cbTenLopD_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcomMaHS(cbMaHSD, cbHoTenD);
            cbMaLop.Text = cbMaLop.Items[cbTenLopD.Items.IndexOf(cbTenLopD.Text)].ToString();
        }

        private void cbMaHSD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHoTenD.Text = cbHoTenD.Items[cbMaHSD.Items.IndexOf(cbMaHSD.Text)].ToString();
        }

        private void cbHoTenD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaHSD.Text = cbMaHSD.Items[cbHoTenD.Items.IndexOf(cbHoTenD.Text)].ToString();
        }

        private void cbMaMonD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenMonD.Text = cbTenMonD.Items[cbMaMonD.Items.IndexOf(cbMaMonD.Text)].ToString();
        }

        private void cbTenMonD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaMonD.Text = cbMaMonD.Items[cbTenMonD.Items.IndexOf(cbTenMonD.Text)].ToString();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (cbDiem15L1.Text == "" || cbDiem45.Text == "" || cbDiemML1.Text == "" || cbDiemHK.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập các điểm bắt buộc phải có!");
                }
                else
                {
                    Tinhdiemtheomon(cbDiemML1.Text, cbDiemML2.Text, cbDiem15L1.Text, cbDiem15L2.Text, cbDiem45.Text, cbDiemHK.Text, ref tbc);
                    txtDiemTBC.Text = tbc;
                    //insert dữ liệu vào nếu nhập điểm cho học kỳ 1
                    if (cbHocKyD.Text == "I")
                    {
                        string update = "update Diem set Diemmieng=N'" + cbDiemML1.Text + "', Diemmiengl2=N'" + cbDiemML2.Text + "', Diem15phut=N'" + cbDiem15L1.Text +
                            "', Diem15phutl2=N'" + cbDiem15L2.Text + "',Diem45phut=N'" + cbDiem45.Text + "', Diemhocky=N'" + cbDiemHK.Text + "', DiemTBhocky=N'" + Convert.ToDouble(txtDiemTBC.Text) +
                            "' where(MaHS=N'" + cbMaHSD.Text + "' and Mamon=N'" + cbMaMonD.Text + "' and Namhoc=N'" + cbNamhocD.Text + "' and Hocky=N'" + cbHocKyD.Text + "')";
                        cls.thucthiketnoi(update);
                        dgvDiem.Refresh();
                        cls.Data2DataGridView(dgvDiem, "select * from Diem");
                    }
                    else
                        //insert dữ liệu vào nếu nhập điểm cho học kỳ 2
                        if (cbHocKyD.Text == "II")
                        {
                            cls.loadlinklabel(Diemtam, "select DiemTBhocky from Diem where(MaHS=N'" + cbMaHSD.Text + "' and Mamon=N'" + cbMaMonD.Text + "' and Namhoc=N'" + cbNamhocD.Text + "' and Hocky=N'" + hk + "') ");
                            dtbccanam = (Math.Round((double.Parse(txtDiemTBC.Text.Trim()) * 2 + double.Parse(Diemtam.Text.Trim())) / 3, 2)).ToString();
                            string updatek2 = "update Diem set Diemmieng=N'" + cbDiemML1.Text + "', Diemmiengl2=N'" + cbDiemML2.Text + "', Diem15phut=N'" + cbDiem15L1.Text +
                                "', Diem15phutl2=N'" + cbDiem15L2.Text + "',Diem45phut=N'" + cbDiem45.Text + "', Diemhocky=N'" + cbDiemHK.Text + "', DiemTBhocky=N'" + Convert.ToDouble(txtDiemTBC.Text) +
                                "','" + Convert.ToDouble(dtbccanam) + "' where(MaHS=N'" + cbMaHSD.Text + "' and Mamon=N'" + cbMaMonD.Text + "' and Namhoc=N'" + cbNamhocD.Text + "' and Hocky=N'" + cbHocKyD.Text + "')";
                            cls.thucthiketnoi(updatek2);
                            dgvDiem.Refresh();
                            cls.Data2DataGridView(dgvDiem, "select * from Diem");
                        }
                }
                
            }
            catch
            {
                MessageBox.Show("Có lỗi xẩy ra!");
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //LinkLabel tam = new LinkLabel();
                string delete = "delete from Diem where MaHS=N'" + cbMaHSD.Text + "' and Mamon=N'" + cbMaMonD.Text + "' and Namhoc=N'" + cbNamhocD.Text + "' and Hocky=N'" + cbHocKyD.Text + "'";
                if (cbMaHSD.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa chọn hoc sinh để xóa!", "Thông báo!");
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa điểm của học sinh này??", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cls.thucthiketnoi(delete);
                        dgvDiem.Refresh();
                        cls.Data2DataGridView(dgvDiem, "select * from Diem");
                        MessageBox.Show("Học sinh bạn chọn đã được xóa điểm!");
                    }
                }
            }
            catch
            {

            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHocKyD_Click(object sender, EventArgs e)
        {
        }

        private void cbHocKyD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

     
        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bttThem.Text == "Lưu")
                MessageBox.Show("Bạn chưa lưu dữ liệu!", "Chú ý");
            else
            {
                andieukhien();
                int hang = e.RowIndex;
                cbMaHSD.Text = dgvDiem.Rows[hang].Cells["MaHS"].Value.ToString();
                cbMaMonD.Text = dgvDiem.Rows[hang].Cells["Mamon"].Value.ToString();
                cbNamhocD.Text = dgvDiem.Rows[hang].Cells["Namhoc"].Value.ToString();
                cbHocKyD.Text = dgvDiem.Rows[hang].Cells["Hocky"].Value.ToString();
                cbDiemML1.Text = dgvDiem.Rows[hang].Cells["Diemmieng"].Value.ToString();
                cbDiemML2.Text = dgvDiem.Rows[hang].Cells["Diemmiengl2"].Value.ToString();
                cbDiem15L1.Text = dgvDiem.Rows[hang].Cells["Diem15phut"].Value.ToString();
                cbDiem15L2.Text = dgvDiem.Rows[hang].Cells["Diem15phutl2"].Value.ToString();
                cbDiem45.Text = dgvDiem.Rows[hang].Cells["Diem45phut"].Value.ToString();
                cbDiemHK.Text = dgvDiem.Rows[hang].Cells["Diemhocky"].Value.ToString();
                txtDiemTBC.Text = dgvDiem.Rows[hang].Cells["DiemTBhocky"].Value.ToString();
            }
        }
    }
}
