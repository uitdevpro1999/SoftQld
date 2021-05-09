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
using Excel = Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace softQld
{
    public partial class frmNhapHKtuExcel : Form
    {
        public frmNhapHKtuExcel()
        {
            InitializeComponent();
        }

        DatabaseConnection cls = new DatabaseConnection();
        //----------------------------------
        #region Hàm kiểm tra nhập Hạnh kiểm
        public bool KiemtraMaHS(string mhs, string nh, string hk)
        {
            //Trả về giá trị True khi học sinh đã có Hạnh kiểm
            LinkLabel ktmahocsinh = new LinkLabel();
            LinkLabel ktnamhoc = new LinkLabel();
            LinkLabel kthocky = new LinkLabel();
            cls.loadlinklabel(ktmahocsinh, "select MaHS from Hanhkiem where MaHS=N'" + mhs + "'");
            if (ktmahocsinh.Text != "")
            {
                cls.loadlinklabel(ktnamhoc, "select Namhoc from Hanhkiem where Namhoc=N'" + nh + "' and MaHS=N'" + mhs + "'");
                if (ktnamhoc.Text != "")
                {
                    cls.loadlinklabel(kthocky, "select Hocky from Hanhkiem where Hocky=N'" + hk + "' and Namhoc=N'" + nh + "' and MaHS=N'" + mhs + "'");
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

        #endregion

        public void loadfile(string FileName)
        {
            //OleDbConnection objConn;
            OleDbDataAdapter oleDA;
            DataSet ds;
            //Check Whether file is xls file or not
            if (Path.GetExtension(FileName) == ".xls" || Path.GetExtension(FileName) == ".xlsx")
            {
                try
                {
                    //Create a OLEDB connection for Excel file                
                    string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source=" + FileName + ";" + "Extended Properties=Excel 8.0;";
                    //objConn = new OleDbConnection(connectionString);
                    oleDA = new OleDbDataAdapter("select * from  [Sheet1$]", connectionString);
                    ds = new DataSet();
                    //Fill the Data Set
                    oleDA.Fill(ds);
                    //Set DataSource of DataGridView
                    dgvnhapExcel.DataSource = ds.Tables[0];
                    ds.Dispose();
                    oleDA.Dispose();
                    //objConn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn file Excel");
            }
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhapHKtuExcel_Load(object sender, EventArgs e)
        {

        }

        private void bttOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog mo = new OpenFileDialog();
            mo.Filter = "Excel Files|*.xls;*.xlsx";
            if (mo.ShowDialog() == DialogResult.OK)
            {
                txtOpenfile.Text = mo.FileName;
                loadfile(txtOpenfile.Text);
            }
            LinkLabel ktmalop = new LinkLabel();
            cls.loadlinklabel(ktmalop, "select Malop from Hocsinh where MaHS=N'" + dgvnhapExcel.Rows[0].Cells[0].Value.ToString() + "'");
            txtMalop.Text = ktmalop.Text;
            txtNamhoc.Text = dgvnhapExcel.Rows[0].Cells[1].Value.ToString();
            txtHocky.Text = dgvnhapExcel.Rows[0].Cells[2].Value.ToString();
        }

        private void bttGhidulieu_Click(object sender, EventArgs e)
        {
            int demdong = dgvnhapExcel.RowCount;
            int dem = 0;
            for (int i = 0; i < demdong - 1; i++)
            {
                if (KiemtraMaHS(dgvnhapExcel.Rows[i].Cells[0].Value.ToString(), dgvnhapExcel.Rows[i].Cells[1].Value.ToString(), dgvnhapExcel.Rows[i].Cells[2].Value.ToString()) == true)
                {
                    MessageBox.Show("Học sinh " + dgvnhapExcel.Rows[i].Cells[0].Value.ToString() + " Năm học " + dgvnhapExcel.Rows[i].Cells[1].Value.ToString() + " Học kỳ " + dgvnhapExcel.Rows[i].Cells[2].Value.ToString() + " đã được nhập!");
                }
                else
                {
                    string sql = "insert into Hanhkiem values('" + dgvnhapExcel.Rows[i].Cells[0].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[1].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[2].Value.ToString() +
                        "','" + dgvnhapExcel.Rows[i].Cells[3].Value.ToString() + "')";
                    cls.thucthiketnoi(sql);
                    dem++;
                }
            }
            MessageBox.Show(dem.ToString()+ " học sinh đã được cập nhật hạnh kiểm");
        }
    }
}
