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
    public partial class frmThongKeHanhKiem : Form
    {
       

        public frmThongKeHanhKiem()
        {
            InitializeComponent();
        }
        SqlCommand cm;

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
            cbNamHocLop.Items.Clear();
            for (int i = int.Parse(namhoc); i < int.Parse(namhoc) + 4; i++)
                cbNamHocLop.Items.Add(i.ToString() + " - " + (i + 1).ToString());
            cbNamHocLop.Text = cbNamHocLop.Items[0].ToString();
        }

        DatabaseConnection cls = new DatabaseConnection();
        private void frmThongKeHanhKiem_Load(object sender, EventArgs e)
        {
            cls.Data2Combobox(cbNamhocNam, "select distinct Namhoc from Hanhkiem");
            cls.Data2Combobox(cbNamHocHK, "select distinct Namhoc from Hanhkiem");
            cls.Data2Combobox(cbHocKy, "select distinct Hocky from Hanhkiem");
            //cls.Data2Combobox(cbNamHocLop, "select distinct Namhoc from Hanhkiem");
            LoadcomMalop(cbMaLop, cbTenLop);
        }

        public void LoadcomMalop(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Malop from Lop");
            cls.Data2Combobox(comten, "select Tenlop from Lop");
        }
        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttThongKeN_Click(object sender, EventArgs e)
        {
            DatabaseConnection.ketnoi();

            cls.Data1DataGridView(grvTKN, "Select MaHS,Namhoc,Hocky,Hanhkiem from  Hanhkiem where Namhoc='" + cbNamhocNam.Text.Trim()+ "'");
            int demsoluong = grvTKN.RowCount;
            int phantramXS = 0;
            int phantramtot = 0;
            int phantramkha = 0;
            int phantramtb = 0;
            int phantramyeu = 0;
            int phantramkem = 0;

            int xstam = 0;
            int tottam = 0;
            int khatam = 0;
            int tbtam = 0;
            int kemtam = 0;
            int yeutam = 0;
           
            //string kt = "";
            for (int i = 0; i < demsoluong - 1; i++)
            {
                //kt = kt + grvTKN.Rows[i].Cells[1].Value.ToString().Trim() + " , ";
                if ((grvTKN.Rows[i].Cells[3].Value.ToString()) == "Xuất Sắc")
                    xstam++;
                else
                    if ((grvTKN.Rows[i].Cells[3].Value.ToString()) == "Tốt")
                        tottam++;
                    else
                        if ((grvTKN.Rows[i].Cells[3].Value.ToString()) == "Khá")

                            khatam++;
                        else
                            if ((grvTKN.Rows[i].Cells[3].Value.ToString()) == "Trung bình")
                                tbtam++;
                            else
                                if ((grvTKN.Rows[i].Cells[3].Value.ToString()) == "Yếu")
                                    yeutam++;
                                else
                                    if((grvTKN.Rows[i].Cells[3].Value.ToString()) == "Kém")  
                                     kemtam++;
          
            }
            if (demsoluong - 1 == 0)
                MessageBox.Show("Không có học sinh nào trong năm học: " + cbNamhocNam.Text);
            else
            {
                phantramXS = (xstam * 100) / (demsoluong - 1);
                phantramtot = (tottam * 100) / (demsoluong - 1);
                phantramkha = (khatam * 100) / (demsoluong - 1);
                phantramtb = (tbtam * 100) / (demsoluong - 1);
                phantramyeu = (yeutam * 100) / (demsoluong - 1);
                phantramkem = (kemtam * 100) / (demsoluong - 1);
            }
            txtXS.Text = phantramXS.ToString() + " %";
            txTot.Text = phantramtot.ToString() + " %";
            txtKha.Text = phantramkha.ToString() + " %";
            txtTB.Text = phantramtb.ToString() + " %";
            txtYeu.Text = phantramyeu.ToString() + " %";
            txtKem.Text = phantramkem.ToString() + " %";
          

            DatabaseConnection.ngatketnoi();
        }

      

        private void bttThongKeHK_Click(object sender, EventArgs e)
        {
            DatabaseConnection.ketnoi();
            if (cbNamHocHK.Text.Trim() == "")
                MessageBox.Show("Bạn chưa chọn năm học!");
            else
                if (cbHocKy.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa chọn học kỳ!");
                else
                    if (cbHocKy.Text.Trim() == "I")
                    {
                        grvTKHK.Visible = true;
                        grvTKHK2.Visible = false;
                        cls.Data2DataGridView(grvTKHK, "Select MaHS,Namhoc,Hocky,Hanhkiem from  Hanhkiem where Namhoc='" + cbNamHocHK.Text.Trim() + "'and Hocky='" + cbHocKy.Text.Trim() + "'");
                        int demsoluonghk = grvTKHK.RowCount;
                        int phantramXShk = 0;
                        int phantramtothk = 0;
                        int phantramkhahk = 0;
                        int phantramtbhk = 0;
                        int phantramyeuhk = 0;
                        int phantramkemhk = 0;

                        int xstamhk = 0;
                        int tottamhk = 0;
                        int khatamhk = 0;
                        int tbtamhk = 0;
                        int kemtamhk = 0;
                        int yeutamhk = 0;

                        if (demsoluonghk - 1 == 0)
                            MessageBox.Show("Không có học sinh nào trong học kỳ: " + cbHocKy.Text + " của năm học: " + cbNamHocHK.Text);
                        else
                        {
                            for (int i = 0; i < demsoluonghk - 1; i++)
                            {

                                if ((grvTKHK.Rows[i].Cells[3].Value.ToString()) == "Xuất Sắc")
                                    xstamhk++;
                                else
                                    if ((grvTKHK.Rows[i].Cells[3].Value.ToString()) == "Tốt")
                                        tottamhk++;
                                    else
                                        if ((grvTKHK.Rows[i].Cells[3].Value.ToString()) == "Khá")

                                            khatamhk++;
                                        else
                                            if ((grvTKHK.Rows[i].Cells[3].Value.ToString()) == "Trung bình")
                                                tbtamhk++;
                                            else
                                                if ((grvTKHK.Rows[i].Cells[3].Value.ToString()) == "Yếu")
                                                    yeutamhk++;
                                                else
                                                    if ((grvTKHK.Rows[i].Cells[3].Value.ToString()) == "Kém")
                                                        kemtamhk++;
                            }
                        }

                        try
                        {
                            phantramXShk = (xstamhk * 100) / (demsoluonghk - 1);
                            phantramtothk = (tottamhk * 100) / (demsoluonghk - 1);
                            phantramkhahk = (khatamhk * 100) / (demsoluonghk - 1);
                            phantramtbhk = (tbtamhk * 100) / (demsoluonghk - 1);
                            phantramyeuhk = (yeutamhk * 100) / (demsoluonghk - 1);
                            phantramkemhk = (kemtamhk * 100) / (demsoluonghk - 1);

                            txtXSHocky.Text = phantramXShk.ToString() + " %";
                            txtTotHocky.Text = phantramtothk.ToString() + " %";
                            txtKhaHocky.Text = phantramkhahk.ToString() + " %";
                            txtTBHocky.Text = phantramtbhk.ToString() + " %";
                            txtYeuHocky.Text = phantramyeuhk.ToString() + " %";
                            txtKemHocky.Text = phantramkemhk.ToString() + " %";
                        }
                        catch
                        { }
                    }
                    else 
                    {
                        if (cbHocKy.Text.Trim() == "II")
                        {
                            grvTKHK.Visible = false;
                            grvTKHK2.Visible = true;
                            cls.Data3DataGridView(grvTKHK2, "Select MaHS,Namhoc,Hocky,Hanhkiem from  Hanhkiem where Namhoc='" + cbNamHocHK.Text.Trim() + "'and Hocky='" + cbHocKy.Text.Trim() + "'");
                            int demsoluonghk = grvTKHK2.RowCount;
                            int phantramXShk = 0;
                            int phantramtothk = 0;
                            int phantramkhahk = 0;
                            int phantramtbhk = 0;
                            int phantramyeuhk = 0;
                            int phantramkemhk = 0;

                            int xstamhk = 0;
                            int tottamhk = 0;
                            int khatamhk = 0;
                            int tbtamhk = 0;
                            int kemtamhk = 0;
                            int yeutamhk = 0;

                            if (demsoluonghk - 1 == 0)
                                MessageBox.Show("Không có học sinh nào trong học kỳ: " + cbHocKy.Text + " của năm học: " + cbNamHocHK.Text);
                            else
                            {
                                for (int i = 0; i < demsoluonghk - 1; i++)
                                {
                                    if ((grvTKHK2.Rows[i].Cells[3].Value.ToString()) == "Xuất Sắc")
                                        xstamhk++;
                                    else
                                        if ((grvTKHK2.Rows[i].Cells[3].Value.ToString()) == "Tốt")
                                            tottamhk++;
                                        else
                                            if ((grvTKHK2.Rows[i].Cells[3].Value.ToString()) == "Khá")

                                                khatamhk++;
                                            else
                                                if ((grvTKHK2.Rows[i].Cells[3].Value.ToString()) == "Trung bình")
                                                    tbtamhk++;
                                                else
                                                    if ((grvTKHK2.Rows[i].Cells[3].Value.ToString()) == "Yếu")
                                                        yeutamhk++;
                                                    else
                                                        if ((grvTKHK2.Rows[i].Cells[3].Value.ToString()) == "Kém")
                                                            kemtamhk++;
                                }
                            }
                            try
                            {
                                phantramXShk = (xstamhk * 100) / (demsoluonghk - 1);
                                phantramtothk = (tottamhk * 100) / (demsoluonghk - 1);
                                phantramkhahk = (khatamhk * 100) / (demsoluonghk - 1);
                                phantramtbhk = (tbtamhk * 100) / (demsoluonghk - 1);
                                phantramyeuhk = (yeutamhk * 100) / (demsoluonghk - 1);
                                phantramkemhk = (kemtamhk * 100) / (demsoluonghk - 1);

                                txtXSHocky.Text = phantramXShk.ToString() + " %";
                                txtTotHocky.Text = phantramtothk.ToString() + " %";
                                txtKhaHocky.Text = phantramkhahk.ToString() + " %";
                                txtTBHocky.Text = phantramtbhk.ToString() + " %";
                                txtYeuHocky.Text = phantramyeuhk.ToString() + " %";
                                txtKemHocky.Text = phantramkemhk.ToString() + " %";
                            }
                            catch { }
                        }
                    }
         
            DatabaseConnection.ngatketnoi();

        }

        private void bttThoatHK_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLop.Text != "")
                Laynamhoc();
                cbTenLop.Text = cbTenLop.Items[cbMaLop.Items.IndexOf(cbMaLop.Text)].ToString();
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbMaLop.Text = cbMaLop.Items[cbTenLop.Items.IndexOf(cbTenLop.Text)].ToString();
        }

        private void bttThoatLop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttThongKeLop_Click(object sender, EventArgs e)
        {
            DatabaseConnection.ketnoi();
            if (cbNamHocLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn năm học.");
            }
            else
                if (cbMaLop.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn lớp.");
                }
                else
                {
                    string strTKDLop = "select Hanhkiem.MaHS,Lop.Malop,Lop.Tenlop,Hanhkiem.Namhoc,Hanhkiem.Hocky, Hanhkiem.Hanhkiem from Lop,Hanhkiem,Hocsinh where Hocsinh.MaHS = Hanhkiem.MaHS and Lop.Malop = Hocsinh.Malop  and Namhoc='" +
                        cbNamHocLop.Text.Trim() + "' and Lop.Malop='" + cbMaLop.Text.Trim() + "'";
                    cls.Data4DataGridView(grvThongkeLop, strTKDLop);
                    
                    int demsoluonghkl = grvThongkeLop.RowCount;
                    int phantramXShkl = 0;
                    int phantramtothkl = 0;
                    int phantramkhahkl = 0;
                    int phantramtbhkl = 0;
                    int phantramyeuhkl = 0;
                    int phantramkemhkl = 0;

                    int xstamhkl = 0;
                    int tottamhkl = 0;
                    int khatamhkl = 0;
                    int tbtamhkl = 0;
                    int kemtamhkl = 0;
                    int yeutamhkl = 0;

                    if (demsoluonghkl - 1 == 0)
                        MessageBox.Show("Không có học sinh nào của lớp: " + cbMaLop.Text + " trong năm học: " + cbNamHocLop.Text);
                    else
                    {
                        for (int i = 0; i < demsoluonghkl - 1; i++)
                        {
                            if ((grvThongkeLop.Rows[i].Cells[5].Value.ToString()) == "Xuất Sắc")
                                xstamhkl++;
                            else
                                if ((grvThongkeLop.Rows[i].Cells[5].Value.ToString()) == "Tốt")
                                    tottamhkl++;
                                else
                                    if ((grvThongkeLop.Rows[i].Cells[5].Value.ToString()) == "Khá")
                                        khatamhkl++;
                                    else
                                        if ((grvThongkeLop.Rows[i].Cells[5].Value.ToString()) == "TB")
                                            tbtamhkl++;
                                        else
                                            if ((grvThongkeLop.Rows[i].Cells[5].Value.ToString()) == "Yếu")
                                                yeutamhkl++;
                                            else
                                                if ((grvThongkeLop.Rows[i].Cells[5].Value.ToString()) == "Kém")
                                                    kemtamhkl++;
                        }
                    }
                    try
                    {
                        phantramXShkl = (xstamhkl * 100) / (demsoluonghkl - 1);
                        phantramtothkl = (tottamhkl * 100) / (demsoluonghkl - 1);
                        phantramkhahkl = (khatamhkl * 100) / (demsoluonghkl - 1);
                        phantramtbhkl = (tbtamhkl * 100) / (demsoluonghkl - 1);
                        phantramyeuhkl = (yeutamhkl * 100) / (demsoluonghkl - 1);
                        phantramkemhkl = (kemtamhkl * 100) / (demsoluonghkl - 1);

                        txtXSLop.Text = phantramXShkl.ToString() + " %";
                        txtTotLop.Text = phantramtothkl.ToString() + " %";
                        txtKhaLop.Text = phantramkhahkl.ToString() + " %";
                        txtTBLop.Text = phantramtbhkl.ToString() + " %";
                        txtYeuLop.Text = phantramyeuhkl.ToString() + " %";
                        txtKemLop.Text = phantramkemhkl.ToString() + " %";
                    }
                    catch { }

                    DatabaseConnection.ngatketnoi();
                }
        }

        private void bttBaoCao_Click(object sender, EventArgs e)
        {
            ExportToExcelHanhKiem excel = new ExportToExcelHanhKiem();
            excel.nam = cbNamhocNam.Text;
            excel.xs= txtXS.Text;
            excel.tot = txTot.Text;
            excel.kha = txtKha.Text;
            excel.tb = txtTB.Text;
            excel.yeu = txtYeu.Text;
            excel.kem = txtKem.Text;

            DataTable dt = (DataTable)grvTKN.DataSource;

            excel.Export(dt, "DS HK", "DANH SÁCH THỐNG KÊ HẠNH KIỂM");
           
            
        }

        private void bttBaoCaoHK_Click(object sender, EventArgs e)
        {
            ExportToExcelHanhKiemHK excel = new ExportToExcelHanhKiemHK();
            excel.hk = cbHocKy.Text;
            excel.namHK = cbNamHocHK.Text;
            excel.xsHK = txtXSHocky.Text;
            excel.totHK = txtTotHocky.Text;
            excel.khaHK = txtKhaHocky.Text;
            excel.tbHK = txtTBHocky.Text;
            excel.yeuHK = txtYeuHocky.Text;
            excel.kemHK = txtKemHocky.Text;
            if (cbHocKy.Text.Trim() == "I")
            {
                DataTable dt = (DataTable)grvTKHK.DataSource;
                excel.Export(dt, "Danh Sach", "DANH SÁCH HẠNH KIỂM");
            }
             else
                if (cbHocKy.Text.Trim() == "II")
                {
                    DataTable dt = (DataTable)grvTKHK2.DataSource;
                    excel.Export(dt, "DS Diem", "DANH SÁCH THỐNG KÊ ĐIỂM KỲ II");
                }
        }

        private void bttBaoCaoLop_Click(object sender, EventArgs e)
        {
            ExportToExcelHanhKiemLop excel = new ExportToExcelHanhKiemLop();
            excel.naml = cbNamHocLop.Text;
            excel.xsl = txtXSLop.Text;
            excel.totl = txtTotLop.Text;
            excel.khal = txtKhaLop.Text;
            excel.tbl = txtTBLop.Text;
            excel.yeul = txtYeuLop.Text;
            excel.keml = txtKemLop.Text;
            DataTable dt = (DataTable)grvThongkeLop.DataSource;
            excel.Export(dt, "Danh Sach", "DANH SÁCH HẠNH KIỂM");
        }

       

          
    }
}
