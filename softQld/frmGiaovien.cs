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
    public partial class frmGiaovien : Form
    {
        public frmGiaovien()
        {
            InitializeComponent();
        }
        // Tạo đối tượng kết nối đến CSDL
        DatabaseConnection cls = new DatabaseConnection();
        //Tạo biến kiểm tra nút nhấn Thêm mới
        private Boolean kiemtra = false;
        //Hàm xóa dữ liệu trong các điều khiển
        void clearText()
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is ComboBox || ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            dtpNgaysinh.Text = "";
            mskCMNDGV.Text = "";
            mskDienThoaiGV.Text = "";
        }
        //Code cho nút them dữ liệu
        private void bttThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra tình trạng của nút nhấn
            kiemtra = !kiemtra;
            if (kiemtra)
            {
                //Nếu nút được nhấn gọi hàm xóa dữ liệu trong các điều khiển
                clearText();
                string sql = "select MaGV from Giaovien";
                // Lấy DataTable từ câu truy vấn truyền vào (Apdapter Fill DataTable)
                DataTable tb = cls.getDataTable(sql);
                double[] arrCode = new double[tb.Rows.Count];
                int code;
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    code = int.Parse(tb.Rows[i]["MaGV"].ToString().Remove(0, 2));
                    arrCode[i] = code;
                }
                code = int.Parse((arrCode.Max() + 1).ToString());
                string nextID = "GV" + code.ToString();
                txtMaGV.Text = nextID;
                DgvGiaovien.Enabled = false;
                bttThem.Text = "Lưu";
                txtHoTenGV.Focus();
                bttSua.Enabled = false;
                bttXoa.Enabled = false;
            }
            else
            {
                string insert = "insert into Giaovien values(N'" + txtMaGV.Text + "',N'" + txtHoTenGV.Text + "',N'" + dtpNgaysinh.Text + "',N'" + cboGioitinh.Text + "',N'" + txtQueQuanGV.Text + "',N'" + mskDienThoaiGV.Text + "',N'" + cbChucVuGv.Text + "',N'" + mskCMNDGV.Text + "',N'" + cbChuyenMon.Text + "',N'" + txtghichu.Text + "')";
                if (txtMaGV.Text.Trim() == "" || txtHoTenGV.Text.Trim() == "" || txtQueQuanGV.Text.Trim() == "" ||
               mskCMNDGV.Text.Trim() == "" || mskDienThoaiGV.Text.Trim() == "" ||
           dtpNgaysinh.Text.Trim() == "" || cbChucVuGv.Text.Trim() == "" || cbChuyenMon.Text.Trim() == "" || cboGioitinh.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.", "Thông báo");
                    return;
                }
                else
                {
                    try
                    {
                        cls.thucthiketnoi(insert);
                        cls.Data2DataGridView(DgvGiaovien, "select * from Giaovien");
                        DgvGiaovien.Refresh();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                }
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                        ctr.Text = "";
                }
                txtMaGV.Focus();
                DgvGiaovien.Enabled = true;
                bttThem.Text = "Tạo Mới";
                bttSua.Enabled = true;
                bttXoa.Enabled = true;
            }
        }

        private void frmGiaovien_Load(object sender, EventArgs e)
        {
            cls.Data2DataGridView(DgvGiaovien, "select * from Giaovien");
            cls.Data2Combobox(cbChuyenMon, "select distinct ChuyenMon from Giaovien");
        }

        private void DgvGiaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaGV.Text = DgvGiaovien.Rows[hang].Cells["MaGV"].Value.ToString();
            txtHoTenGV.Text = DgvGiaovien.Rows[hang].Cells["Hoten"].Value.ToString();
            txtQueQuanGV.Text = DgvGiaovien.Rows[hang].Cells["Quequan"].Value.ToString();
            mskCMNDGV.Text = DgvGiaovien.Rows[hang].Cells["SoCMND"].Value.ToString();
            mskDienThoaiGV.Text = DgvGiaovien.Rows[hang].Cells["Sodienthoai"].Value.ToString();
            dtpNgaysinh.Text = DgvGiaovien.Rows[hang].Cells["Ngaysinh"].Value.ToString();
            cbChucVuGv.Text = DgvGiaovien.Rows[hang].Cells["Chucvu"].Value.ToString();
            cbChuyenMon.Text = DgvGiaovien.Rows[hang].Cells["ChuyenMon"].Value.ToString();
            cboGioitinh.Text = DgvGiaovien.Rows[hang].Cells["Gioitinh"].Value.ToString();
            txtghichu.Text = DgvGiaovien.Rows[hang].Cells["Ghichu"].Value.ToString();
        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            string strCapNhat = "update Giaovien set Hoten=N'" + txtHoTenGV.Text + "',Ngaysinh='" + dtpNgaysinh.Text + "',Gioitinh='" + cboGioitinh.Text + "',Quequan=N'" + txtQueQuanGV.Text
              + "',Sodienthoai='" + mskDienThoaiGV.Text + "',Chucvu='" + cbChucVuGv.Text + "',SoCMND='" + mskCMNDGV.Text
              + "',ChuyenMon='" + cbChuyenMon.Text + "',Ghichu=N'" + txtghichu.Text + "' where MaGV=N'" + txtMaGV.Text + "' ";
            cls.thucthiketnoi(strCapNhat);
            MessageBox.Show("Bạn đã cập nhật dữ liệu thành công.");
            cls.loaddatagridview(DgvGiaovien, "Select * from Giaovien");
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                LinkLabel tam = new LinkLabel();
                string delete = "delete from Giaovien where MaGV=N'" + txtMaGV.Text + "'";
                if (txtMaGV.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa chọn Giáo viên để xóa!", "Thông báo!");
                else
                {
                    cls.loadlinklabel(tam, "select MaGV from Giaovien where MaGV=N'" + txtMaGV.Text + "'");
                    if (tam.Text == "")
                    {
                        MessageBox.Show("Giáo viên này không có trong CSDL!", "Chú ý!");
                    }
                    else
                        if (MessageBox.Show("Bạn chắc chắn muốn xóa Giáo Vên này??", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cls.thucthiketnoi(delete);
                            DgvGiaovien.Refresh();
                            cls.loaddatagridview(DgvGiaovien, "select * from Giaovien");
                            MessageBox.Show("Giáo viên bạn chọn đã được xóa!");
                        }
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng!", "Thông báo");
            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoTenGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }
    }
}
