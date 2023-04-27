using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject_DTO_
{
    public class DaiLyCap1:HoaDon
    {
        private int soNamHopTac;

        public int SoNamHopTac { get => soNamHopTac; set => soNamHopTac = value; }
        public DaiLyCap1()
        {

        }
        public DaiLyCap1(string ma, string hoTen, int sl, double gia, int namHT) : base(ma, hoTen, sl, gia)
        {
            this.MaKH = ma;
            this.TenKH = hoTen;
            this.SoLuong = sl;
            this.GiaBan = gia;
            this.SoNamHopTac = namHT;
        }
        public DaiLyCap1(DaiLyCap1 a)
        {
            MaKH = a.MaKH;
            TenKH = a.TenKH;
            SoLuong = a.SoLuong;
            GiaBan = a.GiaBan;
            SoNamHopTac = a.SoNamHopTac;
        }
        public override double chietKhau()
        {
            double ck = 0.3;
            if (SoNamHopTac > 3)
            {
                ck += 0.1;
                if (ck >= 0.35)
                {
                    ck = 0.35;
                }
            }
            return ck;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Số năm hợp tác: {0}", SoNamHopTac);
            Console.WriteLine("Chiết khấu: {0}", chietKhau());
        }
    }
}
