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
    public partial class frmTongketdiem : Form
    {
        public frmTongketdiem()
        {
            InitializeComponent();
        }
        DatabaseConnection cls = new DatabaseConnection();
        List<string> Mhs = new List<string>();
        LinkLabel diemtongketkytam = new LinkLabel();
        string dtbccanam;
        int demcotontai = 0;
        int demktontai = 0;
        int demcotontaiky1 = 0;
        int demktontaiky1 = 0;

        public void Laynienkhoa(string malop, ref string nienkhoa)
        {
            List<string> nk = new List<string>();
            cls.Loadlist("select Nienkhoa from Lop where Malop = '" + malop + "'", ref nk);
            nienkhoa = nk[0];
        }

        void Laynamhoc()
        {
            string nienkhoa = "", namhoc = "";
            Laynienkhoa(cbMaLTK.Text, ref nienkhoa);
            foreach (string xc in nienkhoa.Split('-'))
            {
                namhoc = xc; break;
            }
            cbNamHTK.Items.Clear();
            for (int i = int.Parse(namhoc); i < int.Parse(namhoc) + 4; i++)
                cbNamHTK.Items.Add(i.ToString() + " - " + (i + 1).ToString());
            cbNamHTK.Text = cbNamHTK.Items[0].ToString();
        }
        public void LoadcomMalop(ComboBox comma, ComboBox comten)
        {
            cls.Data2Combobox(comma, "select Malop from Lop");
            cls.Data2Combobox(comten, "select Tenlop from Lop");
        }

#region Hàm kiểm tra dữ liệu đầu vào
        //Kiểm tra điểm đã có bên bảng điểm hay chưa
        public bool KiemtraMaHS(string mhs, string nh, string hk)
        {
            //Trả về giá trị True khi học sinh đã có điểm
            LinkLabel ktmahocsinh = new LinkLabel();
            LinkLabel ktnamhoc = new LinkLabel();
            LinkLabel kthocky = new LinkLabel();
            cls.loadlinklabel(ktmahocsinh, "select MaHS from Diem where MaHS=N'" + mhs + "'");
            if (ktmahocsinh.Text != "")
            {
                cls.loadlinklabel(ktnamhoc, "select Namhoc from Diem where Namhoc=N'" + nh + "' and MaHS=N'" + mhs + "'");
                if (ktnamhoc.Text != "")
                {
                    cls.loadlinklabel(kthocky, "select Hocky from Diem where Hocky=N'" + hk + "' and Namhoc=N'" + nh + "' and MaHS=N'" + mhs + "'");
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

        //Hàm kiểm tra điểm tổng kết có hay chưa
        //Kiểm tra điểm kỳ 1
        public bool KiemtraMaHStongketky1(string mhs, string nh)
        {
            //Trả về giá trị True khi học sinh đã có điểm
            LinkLabel ktmahocsinh = new LinkLabel();
            LinkLabel ktnamhoc = new LinkLabel();
            LinkLabel ktDiem = new LinkLabel();
            cls.loadlinklabel(ktmahocsinh, "select MaHS from Diemtongket where MaHS=N'" + mhs + "'");
            if (ktmahocsinh.Text != "")
            {
                cls.loadlinklabel(ktnamhoc, "select Namhoc from Diemtongket where Namhoc=N'" + nh + "' and MaHS=N'" + mhs + "'");
                if (ktnamhoc.Text != "")
                {
                    cls.loadlinklabel(ktDiem, "select DiemTongketky1 from Diemtongket where Namhoc=N'" + nh + "' and MaHS=N'" + mhs + "'");
                    if (ktDiem.Text != "")
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
        //Kiểm tra điểm kỳ 2
        public bool KiemtraMaHStongketky2(string mhs, string nh)
        {
            //Trả về giá trị True khi học sinh đã có điểm
            LinkLabel ktmahocsinh = new LinkLabel();
            LinkLabel ktnamhoc = new LinkLabel();
            LinkLabel ktDiem = new LinkLabel();
            cls.loadlinklabel(ktmahocsinh, "select MaHS from Diemtongket where MaHS=N'" + mhs + "'");
            if (ktmahocsinh.Text != "")
            {
                cls.loadlinklabel(ktnamhoc, "select Namhoc from Diemtongket where Namhoc=N'" + nh + "' and MaHS=N'" + mhs + "'");
                if (ktnamhoc.Text != "")
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;

        }

#endregion
        
        private void frmTongketdiem_Load(object sender, EventArgs e)
        {
            LoadcomMalop(cbMaLTK, cbTenLTK);
            cbMaLTK.Focus();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaLTK_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMaLTK.Text != "")
                Laynamhoc();
            cls.Loadlist("select MaHS from Hocsinh where Malop = '" + cbMaLTK.SelectedItem.ToString() + "'", ref Mhs);
            cbTenLTK.Text = cbTenLTK.Items[cbMaLTK.Items.IndexOf(cbMaLTK.Text)].ToString();
        }

        private void cbTenLTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaLTK.Text = cbMaLTK.Items[cbTenLTK.Items.IndexOf(cbTenLTK.Text)].ToString();
        }

        private void cbNamHTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbHocKTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttCapNhat_Click(object sender, EventArgs e)
        {
            List<string> DiemTBHocky = new List<string>();
            if (cbHocKTK.Text == "I")
            {
                for (int i = 0; i < Mhs.Count; i++)
                {
                    int demsodiem = 0;
                    double bientam = 0;
                    double diemtam = 0;
                    if (KiemtraMaHS(Mhs[i], cbNamHTK.Text, cbHocKTK.Text) == true)
                    {
                        cls.Loadlist("select DiemTBhocky from Diem where MaHS = '" + Mhs[i] + "' and Namhoc='" + cbNamHTK.Text + "' and Hocky='" + cbHocKTK.Text + "'", ref DiemTBHocky);
                        for (int j = 0; j < DiemTBHocky.Count; j++)
                        {
                            demsodiem++;
                            bientam = bientam + (double.Parse(DiemTBHocky[j]));
                        }
                        diemtam = Math.Round(bientam / demsodiem, 2);
                        //Update nếu học sinh đã được tổng kết
                        string update = "update Diemtongket set DiemTongketky1=N'" + diemtam.ToString() + "' where(MaHS=N'" + Mhs[i].ToString() + "' and Namhoc=N'" + cbNamHTK.Text + "')";
                        //Insert nếu học sinh chưa tổng kết
                        string insert = "insert into Diemtongket (MaHS,Namhoc,DiemTongketky1) values(N'" + Mhs[i].ToString() + "', N'" + cbNamHTK.Text + "', N'" + diemtam.ToString() + "')";
                        if (KiemtraMaHStongketky1(Mhs[i], cbNamHTK.Text) == true)
                        {
                            cls.thucthiketnoi(update);
                            demcotontaiky1++;
                        }
                        else
                            if (KiemtraMaHStongketky1(Mhs[i], cbNamHTK.Text) == false)
                            {
                                cls.thucthiketnoi(insert);
                                demktontaiky1++;
                            }
                        //MessageBox.Show(diemtam + " " + Mhs[i]);
                    }
                }
                MessageBox.Show(demcotontaiky1.ToString() + " đã được cập nhật lại và " + demktontaiky1.ToString() + " cập nhật mới!");
            }
            else
            {
                if (cbHocKTK.Text == "II")
                {
                    for (int i = 0; i < Mhs.Count; i++)
                    {
                        int demsodiem = 0;
                        double bientam = 0;
                        double diemtam = 0;
                        if (KiemtraMaHS(Mhs[i], cbNamHTK.Text, cbHocKTK.Text) == true)
                        {
                            cls.Loadlist("select DiemTBhocky from Diem where MaHS = '" + Mhs[i] + "' and Namhoc='" + cbNamHTK.Text + "' and Hocky='" + cbHocKTK.Text + "'", ref DiemTBHocky);
                            for (int j = 0; j < DiemTBHocky.Count; j++)
                            {
                                demsodiem++;
                                bientam = bientam + (double.Parse(DiemTBHocky[j]));
                            }
                            diemtam = Math.Round(bientam / demsodiem, 2);
                            //Lấy điểm tổng kết kỳ 1 ra để tính điểm tổng kết cả năm
                            cls.loadlinklabel(diemtongketkytam, "select DiemTongketky1 from Diemtongket where(MaHS=N'" + Mhs[i] + "' and Namhoc=N'" + cbNamHTK.Text + "') ");
                            //Tính điểm tổng kết cả năm
                            dtbccanam = (Math.Round((diemtam * 2 + double.Parse(diemtongketkytam.Text.Trim())) / 3, 2)).ToString();
                            //Update nếu học sinh đã được tổng kết
                            string update = "update Diemtongket set DiemTongketky2=N'" + diemtam.ToString() + "', DiemTongketCanam=N'" + dtbccanam + "' where(MaHS=N'" + Mhs[i] + "' and Namhoc=N'" + cbNamHTK.Text + "')";
                            //Insert nếu học sinh chưa tổng kết
                            //string insert = "insert into Diemtongket (MaHS,Namhoc,DiemTongketky2,DiemTongketCanam) values(MaHS=N'" + Mhs[i] + "', Namhoc=N'" + cbNamHTK.Text + "', DiemTongketky1=N'" + diemtam.ToString() + "', DiemTongketCanam=N'"+dtbccanam+"')";
                            if (KiemtraMaHStongketky2(Mhs[i], cbNamHTK.Text) == true)
                            {
                                cls.thucthiketnoi(update);
                                demcotontai++;
                            }
                            else
                                if (KiemtraMaHStongketky2(Mhs[i], cbNamHTK.Text) == false)
                                    demktontai++;
                            //cls.thucthiketnoi(insert);
                            //MessageBox.Show(diemtam + " " + Mhs[i]);
                        }
                    }
                    MessageBox.Show(demcotontai.ToString()+" đã được cập nhật. " + demktontai.ToString()+" chưa cập nhật vì có điểm TK kỳ I");
                }
            }
            cls.Data2DataGridView(dgrvTongket, "select Diemtongket.MaHS,Namhoc,DiemTongketky1,DiemTongketky2,DiemTongketCanam from Diemtongket,Hocsinh where Diemtongket.MaHS=Hocsinh.MaHS and Malop = '" + cbMaLTK.SelectedItem.ToString() + "'");
        }
    }
}
