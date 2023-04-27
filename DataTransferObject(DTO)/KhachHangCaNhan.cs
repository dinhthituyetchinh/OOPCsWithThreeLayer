using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject_DTO_
{
    public class KhachHangCaNhan:HoaDon, HoTroGia
    {
        private double khoangCach;

        public double KhoangCach { get => khoangCach; set => khoangCach = value; }

        public KhachHangCaNhan()
        {

        }
        public KhachHangCaNhan(string ma, string hoTen, int sl, double gia, double khoangCach) : base(ma, hoTen, sl, gia)
        {
            this.MaKH = ma;
            this.TenKH = hoTen;
            this.SoLuong = sl;
            this.GiaBan = gia;
            this.KhoangCach = khoangCach;
        }
        public KhachHangCaNhan(KhachHangCaNhan a)
        {
            MaKH = a.MaKH;
            TenKH = a.TenKH;
            SoLuong = a.SoLuong;
            GiaBan = a.GiaBan;
            khoangCach = a.khoangCach;
        }

        public override double chietKhau()
        {
            if (SoLuong < 7)
                return 0;
            else
                if (KhoangCach < 10)
                return (5 / 100 * GiaBan) + 10000;
            else
                return 5 / 100 * GiaBan;
        }
        public double hoTroGia()
        {
            if (SoLuong > 2)
                return (double)2 / 100 * GiaBan + 100000;
            else return (double)2 / 100 * GiaBan;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Khoảng cách: {0}", KhoangCach);
            Console.WriteLine("Chiết khấu: {0}", chietKhau());
            Console.WriteLine("Trợ giá: {0}", hoTroGia());
        }
    }
}

