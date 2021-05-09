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
    public partial class frmMonhoc : Form
    {
        public frmMonhoc()
        {
            InitializeComponent();
        }

        DatabaseConnection cls = new DatabaseConnection();
        private Boolean kiemtra = false;

        private void butThem_Click(object sender, EventArgs e)
        {
            kiemtra = !kiemtra;
            if (kiemtra)
            {
                string sql = "select Mamon from Monhoc";
                // Lấy DataTable từ câu truy vấn truyền vào (Apdapter Fill DataTable)
                DataTable tb = cls.getDataTable(sql);
                double[] arrCode = new double[tb.Rows.Count];
                int code;
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    code = int.Parse(tb.Rows[i]["Mamon"].ToString().Remove(0, 1));
                    arrCode[i] = code;
                }
                code = int.Parse((arrCode.Max() + 1).ToString());
                string nextID = "M" + code.ToString();
                txtMamonhoc.Text = nextID;
                butThem.Text = "Lưu";
                butSua.Enabled = false;
                butxoa.Enabled = false;
            }
            else
            {
                try
                {
                    string insert = "insert into Monhoc values(N'" + txtMamonhoc.Text + "','" + txtTenmon.Text + "',N'" + txtGhichu.Text + "')";
                    if (txtMamonhoc.Text.Trim() == "" || txtTenmon.Text.Trim() == "")
                    {
                        MessageBox.Show("bạn chưa nhập đầy đủ thông tin.", "Thông báo");
                        return;
                    }
                    else
                    {
                        cls.thucthiketnoi(insert);
                        GrvMonhoc.Refresh();
                        cls.Data2DataGridView(GrvMonhoc, "select * from Monhoc");
                        MessageBox.Show("Lớp mới đã được thêm!", "Thông báo!");
                    }

                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không đúng!", "Thông báo");
                }

                butThem.Text = "Thêm";
                butxoa.Enabled = true;
                butSua.Enabled = true;
            }
        }

        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            cls.Data2DataGridView(GrvMonhoc, "select * from Monhoc");
        }

        private void GrvMonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (butThem.Text == "Lưu")
            {
                MessageBox.Show("Bạn chưa lưu dữ liệu!");
            }
            else
            {
                int hang = e.RowIndex;
                txtMamonhoc.Text = GrvMonhoc.Rows[hang].Cells["Mamon"].Value.ToString();
                txtTenmon.Text = GrvMonhoc.Rows[hang].Cells["Tenmon"].Value.ToString();
                txtGhichu.Text = GrvMonhoc.Rows[hang].Cells["Ghichu"].Value.ToString();
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            try
            {
                LinkLabel tam = new LinkLabel();
                string delete = "delete from Monhoc where Mamon=N'" + txtMamonhoc.Text + "'";
                if (txtMamonhoc.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa chọn môn học để xóa!", "Thông báo!");
                else
                {
                    cls.loadlinklabel(tam, "select Mamon from Monhoc where Mamon=N'" + txtMamonhoc.Text + "'");
                    if (tam.Text == "")
                    {
                        MessageBox.Show("Môn học này chưa tồn tại!", "Chú ý!");
                    }
                    else
                        if (MessageBox.Show("Bạn chắc chắn muốn xóa Môn học này??", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            cls.thucthiketnoi(delete);
                            GrvMonhoc.Refresh();
                            cls.Data2DataGridView(GrvMonhoc, "select * from Monhoc");
                            MessageBox.Show("Môn học bạn chọn đã được xóa!");
                        }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Chú ý");
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
             try
            {
                string update = "update Monhoc set Tenmon=N'" + txtTenmon.Text + "',Ghichu='" + txtGhichu.Text + "' where(Mamon=N'" + txtMamonhoc.Text + "')";
                if (txtMamonhoc.Text.Trim() == "" || txtTenmon.Text.Trim() == "")
                {
                    MessageBox.Show("bạn chưa nhập đầy đủ thông tin.", "Thông báo");
                    return;
                }
                else
                {
                    cls.thucthiketnoi(update);
                    GrvMonhoc.Refresh();
                    cls.Data2DataGridView(GrvMonhoc, "select * from Monhoc");
                    MessageBox.Show("Sửa thông tin Môn học thành công!", "Thông báo!");
                }

            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng!", "Thông báo");
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
