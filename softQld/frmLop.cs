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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        DatabaseConnection cls = new DatabaseConnection();
        private Boolean kiemtra = false;

        // lấy dữ liệu từ Database lên ComboBox
        public void LoadcomMaGV(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select MaGV from Giaovien");
            cls.Data2Combobox(comten, "select Hoten from Giaovien");
        }


        private void bttMoi_Click(object sender, EventArgs e)
        {
             kiemtra = !kiemtra;
             if (kiemtra)
             {
                 //cls.Data2DataGridView(DgvLop, "select * from Lop");
                 string sql = "select Malop from Lop";
                 // Lấy DataTable từ câu truy vấn truyền vào (Apdapter Fill DataTable)
                 DataTable tb = cls.getDataTable(sql);
                 double[] arrCode = new double[tb.Rows.Count];
                 int code;
                 for (int i = 0; i < tb.Rows.Count; i++)
                 {
                     code = int.Parse(tb.Rows[i]["Malop"].ToString().Remove(0, 1));
                     arrCode[i] = code;
                 }
                 code = int.Parse((arrCode.Max() + 1).ToString());
                 string nextID = "L" + code.ToString();
                 txtMaLop.Text = nextID;
                 txtTenLop.Text = "";
                 bttMoi.Text = "Lưu";
                 btSua.Enabled = false;
                 btXoa.Enabled = false;
                 cbGiaoVien.Text = "";
                 cbNienKhoa.Text = "";
                 txtTenLop.Focus();
             }
             else
             {
                 try
                 {
                     string insert = "insert into Lop values(N'" + txtMaLop.Text + "','" + txtTenLop.Text + "',N'" + cbNienKhoa.Text + "','" + cbGiaoVien.Text + "')";
                     if (txtTenLop.Text.Trim() == "" || cbGiaoVien.Text.Trim() == "" || cbNienKhoa.Text.Trim() == "")
                     {
                         MessageBox.Show("bạn chưa nhập đầy đủ thông tin.", "Thông báo");
                         return;
                     }
                     else
                     {
                         cls.thucthiketnoi(insert);
                         DgvLop.Refresh();
                         cls.loaddatagridview(DgvLop, "select * from Lop");
                         MessageBox.Show("Lớp mới đã được thêm!", "Thông báo!");
                     }

                 }
                 catch
                 {
                     MessageBox.Show("Dữ liệu đầu vào không đúng!", "Thông báo");
                 }
                 bttMoi.Text = "Thêm";
                 btSua.Enabled = true;
                 btXoa.Enabled = true;
             }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update Lop set Tenlop=N'" + txtTenLop.Text + "',Nienkhoa='" + cbNienKhoa.Text + "',MaGV='"+cbGiaoVien.Text+"' where(Malop=N'" + txtMaLop.Text + "')";
                if (txtTenLop.Text.Trim() == "" || cbGiaoVien.Text.Trim() == "" || cbNienKhoa.Text.Trim() == "")
                {
                    MessageBox.Show("bạn chưa nhập đầy đủ thông tin.", "Thông báo");
                    return;
                }
                else
                {
                    cls.thucthiketnoi(update);
                    DgvLop.Refresh();
                    cls.loaddatagridview(DgvLop, "select * from Lop");
                    MessageBox.Show("Sửa thông tin lớp thành công!", "Thông báo!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                LinkLabel tam = new LinkLabel();
                string delete = "delete from Lop where Malop=N'" + txtMaLop.Text + "'";
                if (txtMaLop.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa chọn lớp để xóa!", "Thông báo!");
                else
                {
                    cls.loadlinklabel(tam, "select Malop from Lop where Malop=N'" + txtMaLop.Text + "'");
                    if (tam.Text == "")
                    {
                        MessageBox.Show("Lớp này chưa tồn tại!", "Chú ý!");
                    }
                    else
                        if (MessageBox.Show("Bạn chắc chắn muốn xóa Lớp này??", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cls.thucthiketnoi(delete);
                            DgvLop.Refresh();
                            cls.loaddatagridview(DgvLop, "select * from Lop");
                            MessageBox.Show("Lớp bạn chọn đã được xóa!");
                        }
                }
            }
            catch
            {

            }
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            cls.Data2DataGridView(DgvLop, "select * from Lop");
            LoadcomMaGV(cbGiaoVien, cbTengvcn);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaLop.Text = DgvLop.Rows[hang].Cells["Malop"].Value.ToString();
            txtTenLop.Text = DgvLop.Rows[hang].Cells["Tenlop"].Value.ToString();
            cbNienKhoa.SelectedValue = DgvLop.Rows[hang].Cells["Nienkhoa"].Value.ToString();
            cbNienKhoa.Text = DgvLop.Rows[hang].Cells["Nienkhoa"].Value.ToString();
            cbGiaoVien.SelectedValue = DgvLop.Rows[hang].Cells["MaGV"].Value.ToString();
            cbGiaoVien.Text = DgvLop.Rows[hang].Cells["MaGV"].Value.ToString();
        }

        private void cbGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTengvcn.Text=cbTengvcn.Items[cbGiaoVien.Items.IndexOf(cbGiaoVien.Text)].ToString();
        }

        private void cbTengvcn_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGiaoVien.Text=cbGiaoVien.Items[cbTengvcn.Items.IndexOf(cbTengvcn.Text)].ToString();
        }
    }
}
