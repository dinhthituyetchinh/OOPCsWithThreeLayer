using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject_DTO_
{
    public abstract class HoaDon
    {
        protected string maKH, tenKH;
        protected int soLuong;
        protected double giaBan;

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double GiaBan { get => giaBan; set => giaBan = value; }

        public HoaDon()
        {

        }
        public HoaDon(string maKH, string tenKH, int soLuong, double giaBan)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SoLuong = soLuong;
            GiaBan = giaBan;
        }
        public HoaDon(HoaDon a)
        {
            MaKH = a.MaKH;
            TenKH = a.TenKH;
            SoLuong = a.SoLuong;
            GiaBan = a.GiaBan;
        }
        public double tongTien()
        {
            return SoLuong * GiaBan;
        }
        public abstract double chietKhau();
        public double thanhTien()
        {
            return tongTien() - chietKhau() + (10 / 100 * tongTien()); ;
        }
        public virtual void xuat()
        {
            Console.WriteLine("Mã khách hàng là: {0}", MaKH);
            Console.WriteLine("Tên khách hàng là: {0}", TenKH);
            Console.WriteLine("Số lượng máy lạnh: {0}", SoLuong);
            Console.WriteLine("Giá bán một chiếc máy lạnh: {0} ", GiaBan);
            Console.WriteLine("Thành tiền: {0}", thanhTien());
        }
    }
}
