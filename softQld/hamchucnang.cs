using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace softQld
{
    class hamchucnang
    {
    }
    #region Lớp nghiệp vụ tài Khoản
    class TaikhoanNv
    {
        DatabaseConnection cls = new DatabaseConnection();
        //Ketnoi data;
        //Congcu tool = new Congcu();
        //public TaikhoanNv(string sever, string database)
        //{
        //    data = new Ketnoi(sever, database);
        //}
        //public void Nhap(Taikhoan tk)
        //{
        //    data.ExecuteNonQuery("Insert Into [Taikhoan] Values (N'" + tk.Tentk + "',N'" + tk.Matkhau + "','" + tk.Quyen + "','" + tk.Magv + "')");
        //}
        //public void Sua(Taikhoan tk)
        //{
        //    data.ExecuteNonQuery("update [Taikhoan] set [quyen] = N'" + tk.Quyen + "'  where [taiKhoan] = '" + tk.Tentk + "'");
        //}
        //public void Doimatkhau(string taikhoan, string matkhau)
        //{
        //    data.ExecuteNonQuery("update [Taikhoan] set [matkhau] = N'" + matkhau + "'  where [taiKhoan] = '" + taikhoan + "'");
        //}
        //public void Xoa(string tentk)
        //{
        //    DialogResult xoa = MessageBox.Show("Bạn có muốn xóa không?", "Question ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (xoa == DialogResult.Yes)
        //    {
        //        data.ExecuteNonQuery("delete from [nhatki] where [taikhoan ] = '" + tentk + "'");
        //        data.ExecuteNonQuery("delete from [Taikhoan] where [taiKhoan] = '" + tentk + "'");
        //    }
        //}

        public bool Kiemtrataikhoan(string tentk)
        {
            //Tra ve gia tri true neu tai khoan da ton tai
            bool kt = false;
            List<string> dstk = new List<string>();
            cls.Loadlist("select taikhoan from Taikhoan", ref dstk);
            foreach (string xc in dstk)
                if (tentk == xc)
                {
                    kt = true;
                    break;
                }
            return kt;
        }


        public bool Kiemtramagv(string magv)
        {
            //Tra ve gia tri true neu magv nay ton tai
            bool kt = false;
            List<string> dsmagv = new List<string>();
            cls.Loadlist("select magv from Giaovien", ref dsmagv);
            foreach (string xc in dsmagv)
                if (magv == xc)
                {
                    kt = true;
                    break;
                }
            return kt;
        }

        public bool Kiemtradangnhap(string tentk, string mk, ref string quyen)
        {
            //Tra ve gia tri true neu dang nhap dung
            bool kt = false;
            List<string> dsmk = new List<string>();
            cls.Loadlist("select matkhau from Taikhoan where taikhoan = '" + tentk + "'", ref dsmk);
            if (mk == dsmk[0])
                kt = true;
            //Lay quyen cua tai khoan
            if (kt == true)
            {
                List<string> dsquyen = new List<string>();
                cls.Loadlist("select quyen from Taikhoan where taikhoan = '" + tentk + "'", ref dsquyen);
                quyen = dsquyen[0];
            }
            return kt;
        }
    }
    #endregion
}
