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
//using Microsoft.Office.Interop.Excel;


namespace softQld
{
    public partial class frmXemdiemHS : Form
    {
        public frmXemdiemHS()
        {
            InitializeComponent();
        }
        DatabaseConnection cls = new DatabaseConnection();

        //Hàm lấy niên khóa
        public void Laynienkhoa(string malop, ref string nienkhoa)
        {
            List<string> nk = new List<string>();
            cls.Loadlist("select Nienkhoa from Lop where Malop = '" + malop + "'", ref nk);
            nienkhoa = nk[0];
        }

        //Hàm lấy năm học cho Bảng điểm lớp
        void Laynamhoc()
        {
            string nienkhoa = "", namhoc = "";
            Laynienkhoa(cbMalop.Text, ref nienkhoa);
            foreach (string xc in nienkhoa.Split('-'))
            {
                namhoc = xc; break;
            }
            cbNamhoc.Items.Clear();
            for (int i = int.Parse(namhoc); i < int.Parse(namhoc) + 4; i++)
                cbNamhoc.Items.Add(i.ToString() + " - " + (i + 1).ToString());
            cbNamhoc.Text = cbNamhoc.Items[0].ToString();
        }

        //Hàm lấy năm học cho bảng điểm học sinh
        void LaynamhocHS()
        {
            string nienkhoa = "", namhoc = "";
            Laynienkhoa(cbMalopHS.Text, ref nienkhoa);
            foreach (string xc in nienkhoa.Split('-'))
            {
                namhoc = xc; break;
            }
            cbNamhocHS.Items.Clear();
            for (int i = int.Parse(namhoc); i < int.Parse(namhoc) + 4; i++)
                cbNamhocHS.Items.Add(i.ToString() + " - " + (i + 1).ToString());
            cbNamhocHS.Text = cbNamhocHS.Items[0].ToString();
        }

        //Hàm lấy năm học cho bảng điểm môn học

        void LaynamhocMH()
        {
            string nienkhoa = "", namhoc = "";
            Laynienkhoa(cbMalopM.Text, ref nienkhoa);
            foreach (string xc in nienkhoa.Split('-'))
            {
                namhoc = xc; break;
            }
            cbNamhocM.Items.Clear();
            for (int i = int.Parse(namhoc); i < int.Parse(namhoc) + 4; i++)
                cbNamhocM.Items.Add(i.ToString() + " - " + (i + 1).ToString());
            cbNamhocM.Text = cbNamhocM.Items[0].ToString();
        }

        public void LoadcomMalop(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Malop from Lop where Nienkhoa=N'" + cbnienkhoa.SelectedItem.ToString() + "'");
            cls.Data2Combobox(comten, "select Tenlop from Lop where Nienkhoa=N'" + cbnienkhoa.SelectedItem.ToString() + "'");
        }

        public void LoadcomMalopHS(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Malop from Lop where Nienkhoa=N'" + cbNienkhoaHS .SelectedItem.ToString() + "'");
            cls.Data2Combobox(comten, "select Tenlop from Lop where Nienkhoa=N'" + cbNienkhoaHS.SelectedItem.ToString() + "'");
        }
        public void LoadcomMalopMH(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Malop from Lop where Nienkhoa=N'" + cbNienkhoaM.SelectedItem.ToString() + "'");
            cls.Data2Combobox(comten, "select Tenlop from Lop where Nienkhoa=N'" + cbNienkhoaM.SelectedItem.ToString() + "'");
        }
        public void LoadcomMaHS(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select MaHS from Hocsinh where Malop=N'" + cbMalopHS.SelectedItem.ToString() + "'");
            cls.Data2Combobox(comten, "select Hoten from Hocsinh where Malop=N'" + cbMalopHS.SelectedItem.ToString() + "'");
        }
        public void LoadcomMamon(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Mamon from Monhoc");
            cls.Data2Combobox(comten, "select Tenmon from Monhoc");
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butExits_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXemdiemHS_Load(object sender, EventArgs e)
        {
            cls.Data2Combobox(cbnienkhoa, "select distinct Nienkhoa from Lop");
            cls.Data2Combobox(cbNienkhoaHS, "select distinct Nienkhoa from Lop");
            cls.Data2Combobox(cbNienkhoaM, "select distinct Nienkhoa from Lop");
            LoadcomMamon(cbMamon, cbTenmon);
            LoadcomMamon(cbMamonHS, cbTenmonHS);
            LoadcomMamon(cbMamonM,cbTenmonM);
        }

        private void cbnienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcomMalop(cbMalop, cbTenlop);
        }

        private void cbMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMalop.Text != "")
                Laynamhoc();
            cbTenlop.Text = cbTenlop.Items[cbMalop.Items.IndexOf(cbMalop.Text)].ToString();
            //cls.Data2DataGridView(dgrvBangdiemLop, "select Malop,Hocsinh.MaHS,Hoten,Mamon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh where Hocsinh.MaHS = Diem.MaHS and Malop=N'" + cbMalop.SelectedItem.ToString() + "'");
        }

        private void cbMamon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenmon.Text = cbTenmon.Items[cbMamon.Items.IndexOf(cbMamon.Text)].ToString();
            //cls.Data2DataGridView(dgrvBangdiemLop, "select Malop,Hocsinh.MaHS,Hoten,Mamon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh where Hocsinh.MaHS = Diem.MaHS and Malop=N'" + cbMalop.SelectedItem.ToString() + "' and Mamon=N'" + cbMamon.SelectedItem.ToString() + "'");
        }

        private void cbTenmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMamon.Text = cbMamon.Items[cbTenmon.Items.IndexOf(cbTenmon.Text)].ToString();
        }

        private void cbTenlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMalop.Text = cbMalop.Items[cbTenlop.Items.IndexOf(cbTenlop.Text)].ToString();
        }

        private void cbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbHocky_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butXem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxX1.Checked == true && chbHocky.Checked == true)
                {
                    if (cbMamon.Text.Trim() == "")
                        MessageBox.Show("Bạn chưa chọn môn học!", "Chú ý dữ liệu đầu vào! ");
                    else
                        if (cbHocky.Text.Trim() == "")
                            MessageBox.Show("Bạn chưa chọn học kỳ!", "Chú ý dữ liệu đầu vào! ");
                        else
                        {
                            cls.Data2DataGridView(dgrvBangdiemLop, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Malop=N'" + cbMalop.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhoc.SelectedItem.ToString() + "' and Diem.Mamon=N'" + cbMamon.SelectedItem.ToString() + "' and Hocky=N'" + cbHocky.SelectedItem.ToString() + "'");
                        }
                }
                else
                    if (checkBoxX1.Checked == false && chbHocky.Checked == true)
                    {
                        if (cbHocky.Text.Trim() == "")
                            MessageBox.Show("Bạn chưa chọn học kỳ!", "Chú ý dữ liệu đầu vào! ");
                        else
                        {
                            cls.Data2DataGridView(dgrvBangdiemLop, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Malop=N'" + cbMalop.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhoc.SelectedItem.ToString() + "' and Hocky=N'" + cbHocky.SelectedItem.ToString() + "'");
                        }
                    }
                    else
                        if (checkBoxX1.Checked == true && chbHocky.Checked == false)
                        {
                            if (cbMamon.Text.Trim() == "")
                                MessageBox.Show("Bạn chưa chọn môn học!", "Chú ý dữ liệu đầu vào! ");
                            else
                            {
                                cls.Data2DataGridView(dgrvBangdiemLop, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Malop=N'" + cbMalop.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhoc.SelectedItem.ToString() + "' and Diem.Mamon=N'" + cbMamon.SelectedItem.ToString() + "'");
                            }
                        }
                        else
                        {
                            if (checkBoxX1.Checked == false && chbHocky.Checked == false)
                                cls.Data2DataGridView(dgrvBangdiemLop, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Malop=N'" + cbMalop.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhoc.SelectedItem.ToString() + "'");
                        }
            }
            catch
            {}
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            cbMamon.Enabled = true;
            cbTenmon.Enabled = true;
            if (checkBoxX1.Checked == false)
            {
                cbMamon.Enabled = false;
                cbTenmon.Enabled = false;
            }
        }

        private void butThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbHocky_CheckedChanged(object sender, EventArgs e)
        {
            cbHocky.Enabled = true;
            if(chbHocky.Checked==false)
                cbHocky.Enabled = false;
        }

        private void butInDiem_Click(object sender, EventArgs e)
        {
            ExportToExcelBangdiemlop excel = new ExportToExcelBangdiemlop();
            DataTable dt = (DataTable)dgrvBangdiemHS.DataSource;
            excel.Export(dt, "Bang Diem", "BẢNG ĐIỂM CỦA HỌC SINH");
        }

        private void butXemDiemHS_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbTheomon.Checked == true && chbTheohocky.Checked == true)
                {
                    if (cbMamonHS.Text.Trim() == "")
                        MessageBox.Show("Bạn chưa chọn môn học!", "Chú ý dữ liệu đầu vào! ");
                    else
                        if (cbHockyHS.Text.Trim() == "")
                            MessageBox.Show("Bạn chưa chọn học kỳ!", "Chú ý dữ liệu đầu vào! ");
                        else
                        {
                            cls.Data2DataGridView(dgrvBangdiemHS, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Diem.MaHS=N'" + cbMaHS.SelectedItem.ToString() + "' and Malop=N'" + cbMalopHS.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhocHS.SelectedItem.ToString() + "' and Diem.Mamon=N'" + cbMamonHS.SelectedItem.ToString() + "' and Hocky=N'" + cbHockyHS.Text + "'");
                        }
                }
                else
                    if (chbTheomon.Checked == false && chbTheohocky.Checked == true)
                    {
                        if (cbHockyHS.Text.Trim() == "")
                            MessageBox.Show("Bạn chưa chọn học kỳ!", "Chú ý dữ liệu đầu vào! ");
                        else
                        {
                            cls.Data2DataGridView(dgrvBangdiemHS, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Diem.MaHS=N'" + cbMaHS.SelectedItem.ToString() + "' and Malop=N'" + cbMalopHS.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhocHS.SelectedItem.ToString() + "' and Hocky=N'" + cbHockyHS.Text + "'");
                        }
                    }
                    else
                        if (chbTheomon.Checked == true && chbTheohocky.Checked == false)
                        {
                            if (cbMamonHS.Text.Trim() == "")
                                MessageBox.Show("Bạn chưa chọn môn học!", "Chú ý dữ liệu đầu vào! ");
                            else
                            {
                                cls.Data2DataGridView(dgrvBangdiemHS, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Diem.MaHS=N'" + cbMaHS.SelectedItem.ToString() + "' and Malop=N'" + cbMalopHS.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhocHS.SelectedItem.ToString() + "' and Diem.Mamon=N'" + cbMamonHS.SelectedItem.ToString() + "'");
                            }
                        }
                        else
                            if (chbTheomon.Checked == false && chbTheohocky.Checked == false)
                            {
                                cls.Data2DataGridView(dgrvBangdiemHS, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,DiemTBhocky,DiemTBC from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Diem.MaHS=N'" + cbMaHS.SelectedItem.ToString() + "' and Malop=N'" + cbMalopHS.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhocHS.SelectedItem.ToString() + "'");
                            }
            }
            catch
            {
                MessageBox.Show("Có lỗi xẩy ra!","Chú ý!");
            }
        }

        private void chbTheomon_CheckedChanged_1(object sender, EventArgs e)
        {
            cbMamonHS.Enabled = true;
            cbTenmonHS.Enabled = true;
            if (chbTheomon.Checked == false)
            {
                cbMamonHS.Enabled = false;
                cbTenmonHS.Enabled = false;
            }
        }

        private void chbTheohocky_CheckedChanged_1(object sender, EventArgs e)
        {
            cbHockyHS.Enabled = true;
            if (chbTheohocky.Checked == false)
                cbHockyHS.Enabled = false;
        }

        private void cbNienkhoaHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcomMalopHS(cbMalopHS, cbTenlopHS);
        }

        private void cbMalopHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMalopHS.Text != "")
                LaynamhocHS();
            cbTenlopHS.Text=cbTenlopHS.Items[cbMalopHS.Items.IndexOf(cbMalopHS.Text)].ToString();
            LoadcomMaHS(cbMaHS,cbTenHS);
        }

        private void cbTenlopHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMalopHS.Text = cbMalopHS.Items[cbTenlopHS.Items.IndexOf(cbTenlopHS.Text)].ToString();
        }

        private void cbMaHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenHS.Text = cbTenHS.Items[cbMaHS.Items.IndexOf(cbMaHS.Text)].ToString();
        }

        private void cbTenHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaHS.Text = cbMaHS.Items[cbTenHS.Items.IndexOf(cbTenHS.Text)].ToString();
        }

        private void butIn_Click(object sender, EventArgs e)
        {
            ExportToExcelBangdiemlop excel = new ExportToExcelBangdiemlop();
            DataTable dt = (DataTable)dgrvBangdiemLop.DataSource;         
            excel.Export(dt, "Bang Diem", "BẢNG ĐIỂM CỦA LỚP");
        }

        private void butThoatM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butInDSM_Click(object sender, EventArgs e)
        {
            ExportToExcelBangdiemmon excel = new ExportToExcelBangdiemmon();
            DataTable dt = (DataTable)dgrvBangdiemMon.DataSource;
            excel.Export(dt, "Bang Diem", "BẢNG ĐIỂM CỦA HỌC SINH");
        }

        private void butXemM_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbNienkhoaM.Text.Trim() == "" || cbMalopM.Text.Trim() == "" || cbNamhocM.Text.Trim() == "" || cbMamonM.Text.Trim() == "" || cbHockyM.Text.Trim() == "")
                    MessageBox.Show("Có trường dữ liệu chưa được chọn!", "Chú ý!");
                else
                {
                    cls.Data2DataGridView(dgrvBangdiemMon, "select Malop,Hocsinh.MaHS,Hoten,Monhoc.Mamon,Tenmon,Namhoc,Hocky,Diemmieng,Diemmiengl2,Diem15phut,Diem15phutl2,Diem45phut,Diemhocky,DiemTBhocky from Diem,Hocsinh,Monhoc where Monhoc.Mamon=Diem.Mamon and Hocsinh.MaHS = Diem.MaHS and Malop=N'" + cbMalopM.SelectedItem.ToString() + "' and Namhoc=N'" + cbNamhocM.SelectedItem.ToString() + "' and Diem.Mamon=N'" + cbMamonM.SelectedItem.ToString() + "' and Hocky=N'" + cbHockyM.Text.Trim() + "'");
                }
            }
            catch
            { }
        }

        private void cbMamonHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenmonHS.Text = cbTenmonHS.Items[cbMamonHS.Items.IndexOf(cbMamonHS.Text)].ToString();
        }

        private void cbTenmonHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMamonHS.Text = cbMamonHS.Items[cbTenmonHS.Items.IndexOf(cbTenmonHS.Text)].ToString();
        }

        private void cbNienkhoaM_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcomMalopMH(cbMalopM, cbTenlopM);
        }

        private void cbMalopM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMalopM.Text != "")
                LaynamhocMH();
            cbTenlopM.Text = cbTenlopM.Items[cbMalopM.Items.IndexOf(cbMalopM.Text)].ToString();
        }

        private void cbTenlopM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMalopM.Text = cbMalopM.Items[cbTenlopM.Items.IndexOf(cbTenlopM.Text)].ToString();
        }

        private void cbMamonM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenmonM.Text = cbTenmonM.Items[cbMamonM.Items.IndexOf(cbMamonM.Text)].ToString();
        }

        private void cbTenmonM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMamonM.Text = cbMamonM.Items[cbTenmonM.Items.IndexOf(cbTenmonM.Text)].ToString();
        }
    }
}
