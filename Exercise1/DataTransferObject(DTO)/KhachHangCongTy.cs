using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject_DTO_
{
    public class KhachHangCongTy:HoaDon, HoTroGia
    {
        private int soLuongNV;

        public int SoLuongNV { get => soLuongNV; set => soLuongNV = value; }

        public KhachHangCongTy()
        {

        }
        public KhachHangCongTy(string ma, string hoTen, int sl, double gia, int slgNV) : base(ma, hoTen, sl, gia)
        {
            this.MaKH = ma;
            this.TenKH = hoTen;
            this.SoLuong = sl;
            this.GiaBan = gia;
            this.SoLuongNV = slgNV;
        }
        public KhachHangCongTy(KhachHangCongTy a)
        {
            MaKH = a.MaKH;
            TenKH = a.TenKH;
            SoLuong = a.SoLuong;
            GiaBan = a.GiaBan;
            SoLuongNV = a.SoLuongNV;
        }
        public override double chietKhau()
        {
            if (SoLuongNV > 100)
                return (double)3 / 100;
            else if (SoLuongNV > 500)
                return (double)5 / 100;
            return 0;
        }
        public double hoTroGia()
        {
            return SoLuong * 120000;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Số lượng nhân viên: {0}", SoLuongNV);
            Console.WriteLine("Chiết khấu: {0}", chietKhau());
            Console.WriteLine("Trợ giá: {0}", hoTroGia());
        }
    }
}
