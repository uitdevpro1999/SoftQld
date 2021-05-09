using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Threading;


namespace softQld
{
    public partial class frmHanhKiem : Form
    {
        public frmHanhKiem()
        {
            InitializeComponent();
        }
        DatabaseConnection cls = new DatabaseConnection();
        private Boolean kiemtra = false;
        public string hk = "I";
        //int kttt;
        //----------------------------------
        public void Kiemtratontai(int kt)
        {
            LinkLabel kt1 = new LinkLabel();
            LinkLabel kt2 = new LinkLabel();
            LinkLabel kt3 = new LinkLabel();
            cls.loadlinklabel(kt1, "select MaHS from Hanhkiem where MaHS=N'" + cbMaHSHK.Text + "'");
            cls.loadlinklabel(kt2, "select Namhoc from Hanhkiem where Namhoc=N'" + cbNamHocHK.Text + "'");
            cls.loadlinklabel(kt3, "select Hocky from Hanhkiem where Hocky=N'" + cbHocKyHK.Text + "'");
            if (kt1.Text != "" && kt2.Text != "" && kt3.Text != "")
                kt = 1;
            else
                kt = 0;
        }
        //----------------------------------
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
            Laynienkhoa(cbMaLopHK.Text, ref nienkhoa);
            foreach (string xc in nienkhoa.Split('-'))
            {
                namhoc = xc; break;
            }
            cbNamHocHK.Items.Clear();
            for (int i = int.Parse(namhoc); i < int.Parse(namhoc) + 4; i++)
                cbNamHocHK.Items.Add(i.ToString() + " - " + (i + 1).ToString());
            cbNamHocHK.Text = cbNamHocHK.Items[0].ToString();
        }
        public void LoadcomMalop(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Malop from Lop");
            cls.Data2Combobox(comten, "select Tenlop from Lop");
        }
        public void LoadcomMaHS(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select MaHS from Hocsinh where Malop=N'" + cbMaLopHK.SelectedItem.ToString() + "'");
            cls.Data2Combobox(comten, "select Hoten from Hocsinh where Malop=N'" + cbMaLopHK.SelectedItem.ToString() + "'");
        }
       
        #endregion
        //----------------------------------

        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            cls.Data2DataGridView(dgvHanhkiem, "select * from Hanhkiem");
            LoadcomMalop(cbMaLopHK, cbTenLopHK);
            cbTenLopHK.Text = "";
            cbTenLopHK.Enabled = false;
            cbMaLopHK.Text = "";
            cbMaLopHK.Enabled = false;
        }

        private void cbMaLopHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLopHK.Text != "")
                Laynamhoc();
            LoadcomMaHS(cbMaHSHK, cbHoTenHK);
            cbTenLopHK.Text = cbTenLopHK.Items[cbMaLopHK.Items.IndexOf(cbMaLopHK.Text)].ToString();
        }

        private void cbTenLopHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaLopHK.Text=cbMaLopHK.Items[cbTenLopHK.Items.IndexOf(cbTenLopHK.Text)].ToString();
        }

        private void cbNamHocHK_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbHocKyHK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttThem_Click(object sender, EventArgs e)
        {
           kiemtra = !kiemtra;
           if (kiemtra)
           {
               cbTenLopHK.Text = "";
               cbTenLopHK.Enabled = true;
               cbMaLopHK.Text = "";
               cbMaLopHK.Enabled = true;
               bttThem.Text = "Lưu";
               bttSua.Enabled = false;
               bttXoa.Enabled = false;
               cbMaHSHK.Enabled = true;
               cbHocKyHK.Enabled = true;
               cbNamHocHK.Enabled = true;
               cbHoTenHK.Enabled = true;
               cbMaHSHK.Text = "";
               cbHocKyHK.Text = "";
               cbHoTenHK.Text = "";
               cbNamHocHK.Text = "";
           }
           else
           {
               bttThem.Text = "Thêm";
               bttSua.Enabled = true;
               bttXoa.Enabled = true;
               try
               {
                   string insert = "insert into Hanhkiem values(N'" + cbMaHSHK.SelectedItem.ToString() + "',N'" + cbNamHocHK.Text + "',N'" + cbHocKyHK.Text + "',N'" + cbHanhkiem.Text + "')";
                   if (cbHanhkiem.Text.Trim() == "" || cbHocKyHK.Text.Trim() == "" || cbNamHocHK.Text.Trim() == "" || cbMaHSHK.Text.Trim() == "")
                   {
                       MessageBox.Show("Dữ liệu chưa được nhập đầy đủ!");
                       cbMaHSHK.Focus();
                   }
                   else
                   {
                       cls.thucthiketnoi(insert);
                       dgvHanhkiem.Refresh();
                       cls.Data2DataGridView(dgvHanhkiem, "select * from Hanhkiem");
                       MessageBox.Show("Dữ liệu được thêm thành công!");
                   }
               }
               catch
               {
                   MessageBox.Show("Dữ liệu đã tồn tại");
               }             
           }
        }

        private void cbMaHSHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHoTenHK.Text = cbHoTenHK.Items[cbMaHSHK.Items.IndexOf(cbMaHSHK.Text)].ToString();
        }

        private void cbHoTenHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaHSHK.Text = cbMaHSHK.Items[cbHoTenHK.Items.IndexOf(cbHoTenHK.Text)].ToString();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update Hanhkiem set Hanhkiem=N'" + cbHanhkiem.Text + "' where(MaHS=N'" + cbMaHSHK.Text + "' and Hocky=N'"+cbHocKyHK.Text+"' and Namhoc=N'"+cbNamHocHK.Text+"')";
                if (cbHanhkiem.Text.Trim() == "")
                {
                    MessageBox.Show("bạn chưa nhập đầy đủ thông tin.", "Thông báo");
                    return;
                }
                else
                {
                    cls.thucthiketnoi(update);
                    dgvHanhkiem.Refresh();
                    cls.Data2DataGridView(dgvHanhkiem, "select * from Hanhkiem");
                    MessageBox.Show("Sửa thông tin Hạnh kiểm thành công!", "Thông báo!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHanhkiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbTenLopHK.Text = "";
            cbTenLopHK.Enabled = false;
            cbMaLopHK.Text = "";
            cbMaLopHK.Enabled = false;
            cbMaHSHK.Enabled = false;
            cbHocKyHK.Enabled = false;
            cbNamHocHK.Enabled = false;
            cbHoTenHK.Enabled = false;
            int hang = e.RowIndex;
            cbMaHSHK.Text = dgvHanhkiem.Rows[hang].Cells["MaHS"].Value.ToString();
            cbNamHocHK.Text = dgvHanhkiem.Rows[hang].Cells["Namhoc"].Value.ToString();
            cbHocKyHK.Text = dgvHanhkiem.Rows[hang].Cells["Hocky"].Value.ToString();
            cbHanhkiem.Text = dgvHanhkiem.Rows[hang].Cells["Hanhkiem"].Value.ToString();                
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //LinkLabel tam = new LinkLabel();
                string delete = "delete from Hanhkiem where MaHS=N'" + cbMaHSHK.Text + "' and Hocky=N'"+cbHocKyHK.Text+"' and Namhoc=N'"+cbNamHocHK.Text+"'";
                if (cbMaHSHK.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa chọn hoc sinh để xóa!", "Thông báo!");
                else
                {                    
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa hạnh kiểm của học sinh này??", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cls.thucthiketnoi(delete);
                        dgvHanhkiem.Refresh();
                        cls.Data2DataGridView(dgvHanhkiem, "select * from Hanhkiem");
                        MessageBox.Show("Học sinh bạn chọn đã được xóa Hạnh kiểm!");
                    }
                }
            }
            catch
            {

            }
        }
    }
}
