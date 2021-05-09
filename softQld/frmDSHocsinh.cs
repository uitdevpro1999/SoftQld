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
//using Microsoft.Office.Interop.Excel;


namespace softQld
{
    public partial class frmDSHocsinh : Form
    {
        public frmDSHocsinh()
        {
            InitializeComponent();
        }
        SqlCommand cm;
        DatabaseConnection cls = new DatabaseConnection();
        class clsItem
        {
            private string pstrValue = "";
            private string pstrName = "";
            public clsItem() { }
            public clsItem(string clvalue, string clname)
            {
                pstrName = clname;
                pstrValue = clvalue;
            }
            //Download source code FREE tai Sharecode.vn
            public string Name
            {
                get { return pstrName; }
                set { pstrName = value; }
            }

            public string Value
            {
                get { return pstrValue; }
                set { pstrValue = value; }
            }
        }
        private void dienVaocbLop()
        {

            ArrayList arr = new ArrayList();
            clsItem item;
            DatabaseConnection.ketnoi();
            string strsql = "select Malop, Tenlop from Lop where Nienkhoa=N'" + cbnienkhoa.Text + "'";
            cm = new SqlCommand(strsql, DatabaseConnection.sqlcon);
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                item = new clsItem(dr[0].ToString(), dr[1].ToString());
                arr.Add(item);
            }
            cboLophocsinh.DataSource = arr;
            cboLophocsinh.ValueMember = "Value";
            cboLophocsinh.DisplayMember = "Name";
            dr.Close();
            dr.Dispose();
            DatabaseConnection.ngatketnoi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDSHocsinh_Load(object sender, EventArgs e)
        {
            cls.Data2Combobox(cbnienkhoa, "select distinct Nienkhoa from Lop");
        }

        private void cboLophocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loaddatagridview(grvDSHocSinh, "select * from Hocsinh where Malop=N'" + cboLophocsinh.SelectedValue.ToString() + "'");
        }

        private void cbnienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            dienVaocbLop();
        }

        private void butInds_Click(object sender, EventArgs e)
        {
            ExportToExcelDSHocSinh excel = new ExportToExcelDSHocSinh();
            excel.nam = cbnienkhoa.Text;
            DataTable dt = (DataTable)grvDSHocSinh.DataSource;
            excel.Export(dt, "DS Diem", "DANH SÁCH HỌC SINH LỚP: "+ cboLophocsinh.Text.ToString());
        }
    }
}
