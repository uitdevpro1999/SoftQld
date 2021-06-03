using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
//using Microsoft.SqlServer.Management.Nmo;
//using Microsoft.SqlServer.Management.Smo;
namespace softQld
{
    class DatabaseConnection
    {
        public static string strconnect = @"Data Source=MYPC\SQLEXPRESS;Initial Catalog=SoftQLD;Integrated Security=True";
        public static SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();
        //SqlCommand sqlCom;
        //SqlDataReader sqlRd;
        //SqlDataAdapter sqlAdap;
        //SqlDataReader sqlRd;
        //DataSet ds = new DataSet();
        DataTable dt = new DataTable("DB");

        #region đóng mở kết nối
        public static void ketnoi()
        {
            sqlcon = new SqlConnection(strconnect);
            sqlcon.Open();
        }

        public static void ngatketnoi()
        {
            sqlcon.Close();
        }
        #endregion

        // Thực thi kết nối với cơ sở dữ liệu.
        public void thucthiketnoi(string strsql)
        {
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqlcom.ExecuteNonQuery();
            ngatketnoi();
        }

        #region các hàm kiểm tra CSDL
        public bool kt(string dauvao, string strsql, byte chiso)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[chiso].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            ngatketnoi();
            return ok;
        }
        public bool kttrungkhoa(string dauvao, string strsql)
        {
            bool ok = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    ok = true;
            }
            ngatketnoi();
            return ok;
        }
        public string thu(string dauvao, string strsql)
        {
            string strketqua = "";
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    strketqua = sqldr[0].ToString();
            }
            ngatketnoi();
            return strketqua;
        }
        #endregion
        public DataTable getDataTable(string strSelect)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //Fill vào DataTable
            sqlda = new SqlDataAdapter(strSelect, strconnect);
            sqlda.Fill(dt);
            //
            return dt;
        }



        #region các hàm đọc CSDL

        public void Data1DataGridView(DataGridView dg, string strSelect)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //Fill vào DataTable
            sqlda = new SqlDataAdapter(strSelect, strconnect);
            sqlda.Fill(dt);
            //
            dg.DataSource = dt;
        }
        public void Data2DataGridView(DataGridView dg, string strSelect)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //Fill vào DataTable
            sqlda = new SqlDataAdapter(strSelect, strconnect);
            sqlda.Fill(dt);
            //
            dg.DataSource = dt;
        }
        public void Data3DataGridView(DataGridView dg, string strSelect)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //Fill vào DataTable
            sqlda = new SqlDataAdapter(strSelect, strconnect);
            sqlda.Fill(dt);
            //
            dg.DataSource = dt;
        }
        public void Data4DataGridView(DataGridView dg, string strSelect)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            //Fill vào DataTable
            sqlda = new SqlDataAdapter(strSelect, strconnect);
            sqlda.Fill(dt);
            //
            dg.DataSource = dt;
        }
        public void loadtext(string username, string strselect)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                username = sqldr[0].ToString();
            }
            ngatketnoi();
        }

        //Load CSDL vào DataGridview
        public void loaddatagridview(DataGridView dg, string strselect)
        {
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, strconnect);
            sqlda.Fill(ds, "tenbang");
            dg.DataSource = ds.Tables[0];
        }
        public void loaddatagridview1(DataGridView dg, DataSet ds1, string strselect)
        {
            ds1.Clear();
            sqlda = new SqlDataAdapter(strselect, strconnect);
            sqlda.Fill(ds1, "tenbang");
            dg.DataSource = ds1.Tables[0];
        }
        public void getCombobox(string str, ComboBox cb, string value)
        {
            DataTable dt = new DataTable();
            dt = getDataTable(str);
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            cb.DataSource = dt;
            cb.ValueMember = value;

        }
        //public void LoadMangString(string[] mangMaHS, string strselect, int dem)
        //{
        //    ketnoi();
        //    //thực thi
        //    int i = 0;
        //    sqlcom = new SqlCommand(strselect, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        mangMaHS[i]=sqldr[0].ToString();
        //        i++;
        //        dem++;
        //    }
        //    //Đóng kết nối
        //    ngatketnoi();
        //}
        public void Data2Combobox(ComboBox cb, string strselect)
        {
            //Kết nối
            cb.Items.Clear();
            ketnoi();
            //Thực thi
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            
            //Load dữ liệu vào Combobox
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[0].ToString());
            }
            //Đóng kết nối
            ngatketnoi();
        }
        public void loadcombobox(ComboBox cb, string strselect, byte chiso)
        {
            cb.Items.Clear();
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            ngatketnoi();
        }
        public void getCombobox(string str, string value, ComboBox cb)
        {
            DataTable dt = new DataTable();
            dt = getDataTable(str);
            cb.DataSource = dt;
            cb.ValueMember = value;
            //cb.DisplayMember = "TenTB";          
        }

        public void loadtextbox(TextBox cb, string strselect)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[0].ToString();
            }
            ngatketnoi();
        }
        public void loadlinklabel(LinkLabel llbl, string strselect)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                llbl.Text = sqldr[0].ToString();
            }
            ngatketnoi();
        }
        public void loaddatetime(DateTimePicker cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            ngatketnoi();
        }

        public void loadtextboxchiso(TextBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            ngatketnoi();
        }

        public string getdata(string dauvao, string strsql)
        {
            string strketqua = "";
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    strketqua = sqldr[1].ToString();
            }
            ngatketnoi();
            return strketqua;
        }
        public void loatextbox(TextBox tb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                tb.Lines[0] = (sqldr[chiso].ToString());
            }
            ngatketnoi();
        }
        //Tra ve du lieu la 1 bang
        public DataTable GetDataTable(string sql)
        {
            try
            {
                SqlDataAdapter datA = new SqlDataAdapter(sql, sqlcon);
                DataTable datT = new DataTable();
                datA.Fill(datT);
                return datT;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public void Loadcombo(ComboBox com, string sql)
        {
            com.Items.Clear();
            foreach (DataRow r in GetDataTable(sql).Rows)
                com.Items.Add(r[0]);
        }

        public void Loadlist(string sql, ref List<string> ds)
        {
            ds.Clear();
            foreach (DataRow r in GetDataTable(sql).Rows)
                ds.Add(r[0].ToString());
        }

        #endregion
    }
}
