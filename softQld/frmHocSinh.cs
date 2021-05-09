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
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }
        DatabaseConnection cls = new DatabaseConnection();
        private Boolean kiemtra = false;

        // lấy dữ liệu từ Database lên ComboBox
        public void LoadcomMaHS(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Malop from Lop");
            cls.Data2Combobox(comten, "select Tenlop from Lop");
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            kiemtra = !kiemtra;
            if (kiemtra)
            {
                string sql = "select MaHS from Hocsinh";
                // Lấy DataTable từ câu truy vấn truyền vào (Apdapter Fill DataTable)
                DataTable tb = cls.getDataTable(sql);
                double[] arrCode = new double[tb.Rows.Count];
                int code;
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    code = int.Parse(tb.Rows[i]["MaHS"].ToString().Remove(0, 2));
                    arrCode[i] = code;
                }
                code = int.Parse((arrCode.Max() + 1).ToString());
                string nextID = "HS" + code.ToString();

                txtMaHS.Text = nextID;
                bttThem.Text = "Lưu";
                txtHoTenHS.Text = "";
                txtHoTenPhuHuynh.Text = "";
                mkDTPhuHuynh.Text = "";
                mskDienThoaiHS.Text = "";
                dtNgaySinh.Text = "";
                txtQueQuanHS.Text = "";
                txtDCLienHe.Text = "";
                txtGhiChu.Text = "";
                cbChucvuHS.Text = "";
                txtHoTenHS.Focus();
                bttSua.Enabled = false;
                bttXoa.Enabled = false;
            }
            else
            {
                string strGioiTinh = null;

                try
                {
                    if (rdGTHSNam.Checked)
                        strGioiTinh = "Nam";
                    else
                        if (rdGTHSNu.Checked)
                            strGioiTinh = "Nu";
                    string insert = "insert into Hocsinh values(N'" + txtMaHS.Text + "','" + txtHoTenHS.Text + "','"+cbMalop.Text+"',N'" + dtNgaySinh.Text + "','" + strGioiTinh + "',N'" + txtQueQuanHS.Text
                        + "','" + mskDienThoaiHS.Text + "',N'" + txtHoTenPhuHuynh.Text + "',N'" + txtDCLienHe.Text + "','" + mkDTPhuHuynh.Text + "','" + cbChucvuHS.Text + "','" + txtGhiChu.Text + "')";
                    if (txtHoTenHS.Text.Trim() == "" || dtNgaySinh.Text.Trim() == "" || txtQueQuanHS.Text.Trim() == "" || txtHoTenPhuHuynh.Text.Trim() == "" || txtDCLienHe.Text.Trim() == "")
                    {
                        MessageBox.Show("bạn chưa nhập đầy đủ thông tin.", "Thông báo");
                        return;
                    }
                    else
                    {
                        cls.thucthiketnoi(insert);
                        grvHocSinh.Refresh();
                        cls.loaddatagridview(grvHocSinh, "select * from Hocsinh");
                        MessageBox.Show("đã thêm học sinh!", "Thông báo!");
                    }

                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không đúng!", "Thông báo");
                }
                bttThem.Text = "Thêm mới";
                bttSua.Enabled = true;
                bttXoa.Enabled = true;
            }
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            string strGioiTinh = null;
            if (rdGTHSNam.Checked)
                strGioiTinh = "Nam";
            else
                if (rdGTHSNu.Checked)
                    strGioiTinh = "Nu";
            string strCapNhat = "update Hocsinh set Hoten=N'" + txtHoTenHS.Text + "',Malop='"+cbMalop.Text+"',Ngaysinh='" + dtNgaySinh.Text + "',Gioitinh='" + strGioiTinh + "',Quequan=N'" + txtQueQuanHS.Text
               + "',Sodienthoai='" + mskDienThoaiHS.Text + "',Phuhuynh=N'" + txtHoTenPhuHuynh.Text + "',DCphuhuynh=N'" + txtDCLienHe.Text
               + "',soDTphuhuynh='" + mkDTPhuHuynh.Text + "',chucvu='" + cbChucvuHS.Text + "' where MaHS=N'" + txtMaHS.Text + "' ";
            cls.thucthiketnoi(strCapNhat);
            MessageBox.Show("Bạn đã cập nhật dữ liệu thành công.");
            cls.loaddatagridview(grvHocSinh, "Select * from Hocsinh");
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                LinkLabel tam = new LinkLabel();
                string delete = "delete from Hocsinh where MaHS=N'" + txtMaHS.Text + "'";
                if (txtMaHS.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa chọn học sinh cần xóa!", "Thông báo!");
                else
                {
                    cls.loadlinklabel(tam, "select MaHS from Hocsinh where MaHS=N'" + txtMaHS.Text + "'");
                    if (tam.Text == "")
                    {
                        MessageBox.Show("hoc sinh này chưa tồn tại!", "Chú ý!");
                    }
                    else
                        if (MessageBox.Show("Bạn chắc chắn muốn xóa học sinh này??", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cls.thucthiketnoi(delete);
                            grvHocSinh.Refresh();
                            cls.loaddatagridview(grvHocSinh, "select * from Hocsinh");
                            MessageBox.Show("Học sinh bạn chọn đã được xóa!");
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

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            cls.Data2DataGridView(grvHocSinh, "select * from Hocsinh");
            LoadcomMaHS(cbMalop, cbTenlop);

        }

        private void grvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bttThem.Text == "Lưu")
                MessageBox.Show("Bạn chưa lưu dữ liệu!");
            else
            {
                int hang = e.RowIndex;
                txtMaHS.Text = grvHocSinh.Rows[hang].Cells["MaHS"].Value.ToString();
                txtHoTenHS.Text = grvHocSinh.Rows[hang].Cells["Hoten"].Value.ToString();
                dtNgaySinh.Text = grvHocSinh.Rows[hang].Cells["Ngaysinh"].Value.ToString();

                if (grvHocSinh.Rows[hang].Cells["Gioitinh"].Value.ToString() == "Nam")
                {
                    rdGTHSNam.Checked = true;
                }
                else
                    rdGTHSNu.Checked = true;

                txtQueQuanHS.Text = grvHocSinh.Rows[hang].Cells["Quequan"].Value.ToString();
                mskDienThoaiHS.Text = grvHocSinh.Rows[hang].Cells["Sodienthoai"].Value.ToString();
                txtHoTenPhuHuynh.Text = grvHocSinh.Rows[hang].Cells["Phuhuynh"].Value.ToString();
                txtDCLienHe.Text = grvHocSinh.Rows[hang].Cells["DCphuhuynh"].Value.ToString();
                mkDTPhuHuynh.Text = grvHocSinh.Rows[hang].Cells["soDTphuhuynh"].Value.ToString();
                cbChucvuHS.Text = grvHocSinh.Rows[hang].Cells["Chucvu"].Value.ToString();
                txtGhiChu.Text = grvHocSinh.Rows[hang].Cells["Ghichu"].Value.ToString();
                cbMalop.Text = grvHocSinh.Rows[hang].Cells["Malop"].Value.ToString();
            }
        }

        private void cbMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenlop.Text=cbTenlop.Items[cbMalop.Items.IndexOf(cbMalop.Text)].ToString();
        }

        private void cbTenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMalop.Text=cbMalop.Items[cbTenlop.Items.IndexOf(cbTenlop.Text)].ToString();
        }

        private void txtHoTenHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtHoTenPhuHuynh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
