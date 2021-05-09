using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace softQld
{
    public partial class frmThongKeDiem : Form
    {
        public frmThongKeDiem()
        {
            InitializeComponent();
        }
        DatabaseConnection cls = new DatabaseConnection();

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
        

        private void frmThongKeDiem_Load(object sender, EventArgs e)
        {
            cls.Data2Combobox(cbNamhocNam, "select distinct Namhoc from DiemTongket");
            cls.Data2Combobox(cbNamHocHK, "select distinct Namhoc from DiemTongket");
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

        private void bttThongKe_Click(object sender, EventArgs e)
        {
            cls.Data4DataGridView(grvTKN, "select MaHS,Namhoc,DiemTongketCanam from Diemtongket where Namhoc=N'" + cbNamhocNam.Text + "'");
            int demsoluong = grvTKN.RowCount;
            int phantramgioi = 0;
            int phantramkha = 0;
            int phantramtb = 0;
            int phantramyeu = 0;
            int khatam = 0;
            int gioitam = 0;
            int tbtam = 0;
            int yeutam = 0;
            //string kt = "";
            if (demsoluong - 1 == 0)
                MessageBox.Show("Không có học sinh nào trong năm học: " + cbNamhocNam.Text);
            else
            {
                for (int i = 0; i < demsoluong - 1; i++)
                {
                    //kt = kt + grvTKN.Rows[i].Cells[1].Value.ToString().Trim() + " , ";
                    if (double.Parse(grvTKN.Rows[i].Cells[2].Value.ToString().Trim()) >= 8 && double.Parse(grvTKN.Rows[i].Cells[2].Value.ToString().Trim()) <= 10)
                        gioitam++;
                    else
                        if (double.Parse(grvTKN.Rows[i].Cells[2].Value.ToString().Trim()) >= 6.5 && double.Parse(grvTKN.Rows[i].Cells[2].Value.ToString().Trim()) < 8)
                            khatam++;
                        else
                            if (double.Parse(grvTKN.Rows[i].Cells[2].Value.ToString().Trim()) >= 5 && double.Parse(grvTKN.Rows[i].Cells[2].Value.ToString().Trim()) < 6.5)
                                tbtam++;
                            else
                                if (double.Parse(grvTKN.Rows[i].Cells[2].Value.ToString().Trim()) >= 0 && double.Parse(grvTKN.Rows[i].Cells[2].Value.ToString().Trim()) < 5)
                                    yeutam++;
                }
            }
            try
            {
                phantramgioi = (gioitam * 100) / (demsoluong - 1);
                phantramkha = (khatam * 100) / (demsoluong - 1);
                phantramtb = (tbtam * 100) / (demsoluong - 1);
                phantramyeu = (yeutam * 100) / (demsoluong - 1);

                txtGioi.Text = phantramgioi.ToString() + " %";
                txtKha.Text = phantramkha.ToString() + " %";
                txtTB.Text = phantramtb.ToString() + " %";
                txtYeu.Text = phantramyeu.ToString() + " %";
            }
            catch
            { }
         }

        private void bttThongKeHK_Click(object sender, EventArgs e)
        {

        DatabaseConnection.ketnoi();
           
        if (cbHocKy.Text == "I")
        {
            grvTKHK1.Visible = true;
            grvTKHK2.Visible = false;
            cls.Data1DataGridView(grvTKHK1, "select MaHS,Namhoc,DiemTongketky1 from Diemtongket where Namhoc=N'" + cbNamHocHK.Text + "'");

            int ptgioi = 0;
            int ptkha = 0;
            int pttb = 0;
            int ptyeu = 0;
            int khatamhk = 0;
            int gioitamhk = 0;
            int tbtamhk = 0;
            int yeutamhk = 0;
            int dem = grvTKHK1.RowCount;

            if (dem - 1 == 0)
                MessageBox.Show("Không có học sinh nào trong học kỳ: " + cbHocKy.Text + " của năm học: " + cbNamHocHK.Text);
            else
            {
                for (int i = 0; i < dem - 1; i++)
                {
                
                        //kt = kt + grvTKN.Rows[i].Cells[1].Value.ToString().Trim() + " , ";
                        if (double.Parse(grvTKHK1.Rows[i].Cells[2].Value.ToString().Trim()) >= 8 && double.Parse(grvTKHK1.Rows[i].Cells[2].Value.ToString().Trim()) <= 10)
                            gioitamhk++;
                        else
                            if (double.Parse(grvTKHK1.Rows[i].Cells[2].Value.ToString().Trim()) >= 6.5 && double.Parse(grvTKHK1.Rows[i].Cells[2].Value.ToString().Trim()) < 8)
                                khatamhk++;
                            else
                                if (double.Parse(grvTKHK1.Rows[i].Cells[2].Value.ToString().Trim()) >= 5 && double.Parse(grvTKHK1.Rows[i].Cells[2].Value.ToString().Trim()) < 6.5)
                                    tbtamhk++;
                                else
                                    if (double.Parse(grvTKHK1.Rows[i].Cells[2].Value.ToString().Trim()) >= 0 && double.Parse(grvTKHK1.Rows[i].Cells[2].Value.ToString().Trim()) < 5)
                                        yeutamhk++;
                
                }
            }
            
            try
                {
            
                    ptgioi = (gioitamhk * 100) / (dem - 1);
                    ptkha = (khatamhk * 100) / (dem - 1);
                    pttb = (tbtamhk * 100) / (dem - 1);
                    ptyeu = (yeutamhk * 100) / (dem - 1);
            
                    txtGioiHK.Text = ptgioi.ToString() + " %";
                    txtKhaHK.Text = ptkha.ToString() + " %";
                    txtTBHK.Text = pttb.ToString() + " %";
                    txtYeuHK.Text = ptyeu.ToString() + " %";
                }
            catch
            { }             
        }
        else
            if (cbHocKy.Text == "II")
            {
                grvTKHK1.Visible = false;
                grvTKHK2.Visible = true;
                cls.Data2DataGridView(grvTKHK2, "select MaHS,Namhoc,DiemTongketky2 from Diemtongket where Namhoc=N'" + cbNamHocHK.Text + "'");                                  
                 
                int ptgioi = 0;
                int ptkha = 0;
                int pttb = 0;
                int ptyeu = 0;
                int khatamhk = 0;
                int gioitamhk = 0;
                int tbtamhk = 0;
                int yeutamhk = 0;
                int dem = grvTKHK2.RowCount;

                if (dem - 1 == 0)
                    MessageBox.Show("Không có học sinh nào trong học kỳ: " + cbHocKy.Text + " của năm học: " + cbNamHocHK.Text);
                else
                {
                    for (int i = 0; i < dem - 1; i++)
                    {
                   
                            //kt = kt + grvTKN.Rows[i].Cells[1].Value.ToString().Trim() + " , ";
                            if (double.Parse(grvTKHK2.Rows[i].Cells[2].Value.ToString().Trim()) >= 8 && double.Parse(grvTKHK2.Rows[i].Cells[2].Value.ToString().Trim()) <= 10)
                                gioitamhk++;
                            else
                                if (double.Parse(grvTKHK2.Rows[i].Cells[2].Value.ToString().Trim()) >= 6.5 && double.Parse(grvTKHK2.Rows[i].Cells[2].Value.ToString().Trim()) < 8)
                                    khatamhk++;
                                else
                                    if (double.Parse(grvTKHK2.Rows[i].Cells[2].Value.ToString().Trim()) >= 5 && double.Parse(grvTKHK2.Rows[i].Cells[2].Value.ToString().Trim()) < 6.5)
                                        tbtamhk++;
                                    else
                                        if (double.Parse(grvTKHK2.Rows[i].Cells[2].Value.ToString().Trim()) >= 0 && double.Parse(grvTKHK2.Rows[i].Cells[2].Value.ToString().Trim()) < 5)
                                            yeutamhk++;
                  
                    }
                }
             try
             {
                ptgioi = (gioitamhk * 100) / (dem - 1);
                ptkha = (khatamhk * 100) / (dem - 1);
                pttb = (tbtamhk * 100) / (dem - 1);
                ptyeu = (yeutamhk * 100) / (dem - 1);
               
                txtGioiHK.Text = ptgioi.ToString() + " %";
                txtKhaHK.Text = ptkha.ToString() + " %";
                txtTBHK.Text = pttb.ToString() + " %";
                txtYeuHK.Text = ptyeu.ToString() + " %";
             }
             catch
             { }
            }
    
        DatabaseConnection.ngatketnoi();
       
        }

        private void bttThoatHK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttThoatLop_Click(object sender, EventArgs e)
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
     //day la phan load ma mon ten mon
      

     
        private void bttThongKeLop_Click(object sender, EventArgs e)
        {

            DatabaseConnection.ketnoi();

            cls.Data3DataGridView(grvThongkeLop, "select Diemtongket.MaHS,Lop.Malop,Lop.Tenlop, Diemtongket.DiemTongketCanam from Lop,Diemtongket,Hocsinh where Hocsinh.MaHS = Diemtongket.MaHS and Lop.Malop = Hocsinh.Malop  and Namhoc='" +
                cbNamHocLop.Text.Trim() + "' and Lop.Malop='" + cbMaLop.Text.Trim() +"'");
            int demsoluong = grvThongkeLop.RowCount;
            int phantramgioi = 0;
            int phantramkha = 0;
            int phantramtb = 0;
            int phantramyeu = 0;
            int khatam = 0;
            int gioitam = 0;
            int tbtam = 0;
            int yeutam = 0;
            //string kt = "";
            if (demsoluong - 1 == 0)
                MessageBox.Show("Không tồn tại dữ liệu");
            else
            {
                for (int i = 0; i < demsoluong - 1; i++)
                {
                    //kt = kt + grvTKN.Rows[i].Cells[1].Value.ToString().Trim() + " , ";
                    if (double.Parse(grvThongkeLop.Rows[i].Cells[3].Value.ToString().Trim()) >= 8 && double.Parse(grvThongkeLop.Rows[i].Cells[3].Value.ToString().Trim()) <= 10)
                        gioitam++;
                    else
                        if (double.Parse(grvThongkeLop.Rows[i].Cells[3].Value.ToString().Trim()) >= 6.5 && double.Parse(grvThongkeLop.Rows[i].Cells[3].Value.ToString().Trim()) < 8)
                            khatam++;
                        else
                            if (double.Parse(grvThongkeLop.Rows[i].Cells[3].Value.ToString().Trim()) >= 5 && double.Parse(grvThongkeLop.Rows[i].Cells[3].Value.ToString().Trim()) < 6.5)
                                tbtam++;
                            else
                                if (double.Parse(grvThongkeLop.Rows[i].Cells[3].Value.ToString().Trim()) >= 0 && double.Parse(grvThongkeLop.Rows[i].Cells[3].Value.ToString().Trim()) < 5)
                                    yeutam++;
                }
            }
            try
            {               
                phantramgioi = (gioitam * 100) / (demsoluong - 1);
                phantramkha = (khatam * 100) / (demsoluong - 1);
                phantramtb = (tbtam * 100) / (demsoluong - 1);
                phantramyeu = (yeutam * 100) / (demsoluong - 1);
                
                txtGioiL.Text = phantramgioi.ToString() + " %";
                txtKhaL.Text = phantramkha.ToString() + " %";
                txtTBL.Text = phantramtb.ToString() + " %";
                txtYeuL.Text = phantramyeu.ToString() + " %";
            }
            catch
            {
                MessageBox.Show("Lớp '" + cbTenLop.Text + "'chưa cập nhật điểm.");
            }
          
          
            DatabaseConnection.ngatketnoi();
        } 

    

     

        private void bttBaoCao_Click(object sender, EventArgs e)
        {
            
            ExportToExcelDiem excel = new ExportToExcelDiem();
            excel.nam = cbNamhocNam.Text;
            excel.gioi = txtGioi.Text;
            excel.kha = txtKha.Text;
            excel.tb = txtTB.Text;
            excel.yeu = txtYeu.Text;
            DataTable dt = (DataTable)grvTKN.DataSource;
         
            excel.Export(dt, "DS Diem", "DANH SÁCH THỐNG KÊ ĐIỂM TỔNG KẾT");
        }

        private void bttBaoCaoHK_Click(object sender, EventArgs e)
        {
            ExportToExcelDiemHK excel = new ExportToExcelDiemHK();
            excel.hk = cbHocKy.Text;
            excel.namhk = cbNamHocHK.Text;
            excel.gioihk = txtGioiHK.Text;
            excel.khahk = txtKhaHK.Text;
            excel.tbhk = txtTBHK.Text;
            excel.yeuhk = txtYeuHK.Text;
            if (cbHocKy.Text.Trim() == "I")
            {
                DataTable dt = (DataTable)grvTKHK1.DataSource;
                excel.Export(dt, "DS Diem", "DANH SÁCH THỐNG KÊ ĐIỂM KỲ I");
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
            ExportToExcelDiemLop excel = new ExportToExcelDiemLop();
           
            excel.namlop = cbNamHocLop.Text;
            excel.lop = cbTenLop.Text;
            excel.gioil = txtGioiL.Text;
            excel.khal = txtKhaL.Text;
            excel.tbl = txtTBL.Text;
            excel.yeul = txtYeuL.Text;
            DataTable dt = (DataTable)grvThongkeLop.DataSource;
            excel.Export(dt, "DS Diem", "DANH SÁCH THỐNG KÊ ĐIỂM");
        }

     
      

      

        

   }
}
