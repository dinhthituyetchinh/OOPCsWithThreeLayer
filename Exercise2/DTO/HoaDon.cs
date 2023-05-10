using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class HoaDon
    {
        protected string maSo, hoTenKhach, ngayLap;
        protected MatHang mh = new MatHang();
        protected int soLuong;

        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTenKhach { get => hoTenKhach; set => hoTenKhach = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public MatHang Mh { get => mh; set => mh = value; }

        public HoaDon(string maSo, string hoTenKhach, string ngayLap, MatHang mh, int soLuong)
        {
            MaSo = maSo;
            HoTenKhach = hoTenKhach;
            NgayLap = ngayLap;
            Mh = mh;
            SoLuong = soLuong;
        }

        public double thanhTien()
        {
            return SoLuong * Mh.DonGia;
        }
        public abstract double tienKM();
        public double tongThanhTien()
        {
            return thanhTien() - tienKM();
        }
        public void xuat()
        {
            Console.WriteLine("Mã số: " + MaSo);
            Console.WriteLine("Tên kh: " + HoTenKhach);
            Console.WriteLine("Ngày lập: " + NgayLap);
            Mh.xuatMH();
            Console.WriteLine("Số lượng: " + SoLuong);
        }
    }
}
