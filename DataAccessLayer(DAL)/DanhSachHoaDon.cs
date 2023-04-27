using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DataTransferObject_DTO_;
namespace DataAccessLayer_DAL_
{
    public class DanhSachHoaDon
    {
        List<HoaDon> dskh = new List<HoaDon>();

        public List<HoaDon> Dskh { get => dskh; set => dskh = value; }

        public DanhSachHoaDon()
        {

        }

        public void docFile(string fileName)
        {
            XmlDocument read = new XmlDocument();
            read.Load(fileName);
            XmlNodeList nodeList = read.SelectNodes("/DS/HD");
            foreach (XmlNode node in nodeList)
            {
                HoaDon hd;
                string Loai = node["Loai"].InnerText;
                string MaKH = node["MaKH"].InnerText;
                string TenKH = node["TenKH"].InnerText;
                int SoLuong = int.Parse(node["SL"].InnerText);
                double GiaBan = double.Parse(node["GB"].InnerText);
                if (Loai == "KHCN")
                {
                    double KhoangCach = double.Parse(node["KC"].InnerText);
                    hd = new KhachHangCaNhan(MaKH, TenKH, SoLuong, GiaBan, KhoangCach);
                }
                else

                    if (Loai == "KHCT")
                {
                    int sLNV = int.Parse(node["SLNV"].InnerText);
                    hd = new KhachHangCongTy(MaKH, TenKH, SoLuong, GiaBan, sLNV);
                }
                else
                {
                    int namHT = int.Parse(node["NamHT"].InnerText);
                    hd = new DaiLyCap1(MaKH, TenKH, SoLuong, GiaBan, namHT);
                }

                dskh.Add(hd);
            }
        }

        public void xuatDSHD()
        {
            foreach (HoaDon hd in dskh)
            {
                hd.xuat();
            }
        }
        //Tính tổng thành tiền của tất cả các hóa đơn.
        public double tongThanhTien()
        {
            return dskh.Sum(hd => hd.thanhTien());
        }
        // Tính tổng tiền trợ giá mà công ty đã hỗ trợ.
        public double tongTroGia()
        {
            double tong = 0;
            foreach (HoaDon hd in dskh)
            {
                if (hd is HoTroGia)
                {
                    HoTroGia t = (HoTroGia)hd;
                    tong += t.hoTroGia();
                }
            }
            return tong;
        }
        //Xuất thông tin khách hàng có số lượng mua nhiều nhất.
        public void khachHangMuaNhieuNhat()
        {
            int maxSL = dskh.Max(hd => hd.SoLuong);
            dskh = dskh.Where(hd => hd.SoLuong == maxSL).ToList();
        }
        //Xuất thông tin của hóa đơn có thành tiền cao nhất.
        public void hoaDonTTMax()
        {
            double maxTT = dskh.Max(hd => hd.thanhTien());
            dskh = dskh.Where(hd => hd.thanhTien() == maxTT).ToList();
        }
        //Tổng số tiền chiết khấu của công ty là bao nhiêu đối với khách hàng công ty.
        public double tongChietKhauKHCT()
        {
            double tong = 0;
            foreach (HoaDon hd in dskh)
            {
                if (hd is KhachHangCongTy)
                {
                    KhachHangCongTy t = (KhachHangCongTy)hd;
                    tong += t.chietKhau();
                }
            }
            return tong;
        }
        public double tongThanhTienKHCT()
        {
            double tong = 0;
            foreach (HoaDon hd in dskh)
            {
                if (hd is KhachHangCongTy)
                {
                    KhachHangCongTy t = (KhachHangCongTy)hd;
                    tong += t.thanhTien();
                }
            }
            return tong;
        }
        public double tongTienCKKHCT()
        {
            return tongThanhTienKHCT() * tongChietKhauKHCT();
        }
        //Sắp xếp danh sách hóa đơn tăng dần theo số lượng, nếu số lượng bằng nhau thì
        //sắp xếp giảm dần theo thành tiền.
        public void sapXepHoaDon()
        {
            dskh = dskh.OrderBy(hd => hd.SoLuong).OrderByDescending(hd => hd.thanhTien()).ToList();
        }
        //Cho biết trong danh sách công ty có bao nhiêu đại lý cấp 1.
        public int demDL()
        {
            int dem = 0;
            foreach (HoaDon hd in dskh)
            {
                if (hd is DaiLyCap1)
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}

