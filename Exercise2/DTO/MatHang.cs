using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatHang
    {
        protected string maHang, tenHang;
        protected double donGia;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public MatHang()
        {

        }
        public MatHang(string maHang, string tenHang, double donGia)
        {
            MaHang = maHang;
            TenHang = tenHang;
            DonGia = donGia;
        }
        public void xuatMH()
        {
            Console.WriteLine("Mã hàng: " + MaHang);
            Console.WriteLine("Tên hàng: " + TenHang);
            Console.WriteLine("Đơn giá: " + DonGia);
        }
    }
}
