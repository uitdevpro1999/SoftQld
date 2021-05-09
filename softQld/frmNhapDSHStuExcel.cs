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
    public partial class frmNhapDSHStuExcel : Form
    {
        public frmNhapDSHStuExcel()
        {
            InitializeComponent();
        }

        DatabaseConnection cls = new DatabaseConnection();

        #region Hàm kiểm tra nhập HS
        public bool KiemtraMaHS(string mhs)
        {
            //Trả về giá trị True khi học sinh đã tồn tại
            LinkLabel ktmahocsinh = new LinkLabel();
            cls.loadlinklabel(ktmahocsinh, "select MaHS from Hocsinh where MaHS=N'" + mhs + "'");
            if (ktmahocsinh.Text != "")
            {
                return true;
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

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog mo = new OpenFileDialog();
            mo.Filter = "Excel Files|*.xls;*.xlsx";
            if (mo.ShowDialog() == DialogResult.OK)
            {
                txtOpenfile.Text = mo.FileName;
                loadfile(txtOpenfile.Text);
                txtMalop.Text = dgvnhapExcel.Rows[0].Cells[2].Value.ToString();
                LinkLabel ktmalop = new LinkLabel();
                cls.loadlinklabel(ktmalop, "select Nienkhoa from Lop where Malop=N'" + dgvnhapExcel.Rows[0].Cells[2].Value.ToString() + "'");
                txtNienkhoa.Text = ktmalop.Text;
            }
        }

        private void bttGhidulieu_Click(object sender, EventArgs e)
        {
            int demdong = dgvnhapExcel.RowCount;
            int dem = 0;
            for (int i = 0; i < demdong - 1; i++)
            {
                if (KiemtraMaHS(dgvnhapExcel.Rows[i].Cells[0].Value.ToString()) == true)
                {
                    MessageBox.Show("Học sinh " + dgvnhapExcel.Rows[i].Cells[0].Value.ToString() + " đã được nhập!");
                }
                else
                {
                    string sql = "insert into Hocsinh values('" + dgvnhapExcel.Rows[i].Cells[0].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[1].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[2].Value.ToString() +
                        "','" + dgvnhapExcel.Rows[i].Cells[3].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[4].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[5].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[6].Value.ToString() +
                        "','" + dgvnhapExcel.Rows[i].Cells[7].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[8].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[9].Value.ToString() + "','" + dgvnhapExcel.Rows[i].Cells[10].Value.ToString() +
                        "','" + dgvnhapExcel.Rows[i].Cells[11].Value.ToString() + "')";
                    cls.thucthiketnoi(sql);
                    dem++;
                }
            }
            MessageBox.Show(dem.ToString() + " học sinh đã được cập nhật thành công");
        }

        private void frmNhapDSHStuExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
