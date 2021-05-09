using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace softQld
{
    class doituong
    {
    }
    #region Lớp Tài khoản
    class Taikhoan
    {
        private string tentk;
        private string matkhau;
        private string quyen;
        private string magv;
        public string Tentk
        {
            get
            {
                return tentk;
            }
            set
            {
                tentk = value;
            }
        }
        public string Matkhau
        {
            get
            {
                return matkhau;
            }
            set
            {
                matkhau = value;
            }
        }
        public string Quyen
        {
            get
            {
                return quyen;
            }
            set
            {
                quyen = value;
            }
        }
        public string Magv
        {
            get
            {
                return magv;
            }
            set
            {
                magv = value;
            }
        }
        public Taikhoan()
        {
        }
        public Taikhoan(string tentk, string matkhau, string quyen, string magv)
        {
            this.tentk = tentk;
            this.matkhau = matkhau;
            this.quyen = quyen;
            this.magv = magv;
        }

    }
    #endregion
}
