using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DTO;
namespace DAL
{
    public class DanhSachHoaDon
    {
        List<HoaDon> hdList = new List<HoaDon>();
        List<int> ds = new List<int>();
        public List<HoaDon> HdList { get => hdList; set => hdList = value; }
        public DanhSachHoaDon()
        {

        }
        public void docFile(string fileName)
        {
            XmlDocument read = new XmlDocument();
            read.Load(fileName);
            XmlNodeList nodeList = read.SelectNodes("/DSHD/HoaDon");
            foreach (XmlNode node in nodeList)
            {
                HoaDon hd;
                int loai = int.Parse(node["Loai"].InnerText);
                ds.Add(loai);
                string ms = node["MS"].InnerText;
                string ten = node["Khach"].InnerText;
                string ngay = node["NgayLap"].InnerText;
                XmlNodeList nodeList1 = read.SelectNodes("/DSHD/HoaDon/Hang");
                //Cách 1
                //MatHang mh = new MatHang();  
                //XmlNode nodeMH = node.SelectSingleNode("Hang");
                //string maHang = nodeMH.SelectSingleNode("MH").InnerText;
                //string tenHang = nodeMH.SelectSingleNode("TenHang").InnerText;
                //double dg = double.Parse(nodeMH.SelectSingleNode("Gia").InnerText);
                //mh.MaHang = maHang;
                //mh.TenHang = tenHang;
                //mh.DonGia = dg;
                //Cách 2
                MatHang mh = new MatHang();
                foreach (XmlNode node1 in nodeList1)
                {
                    mh.MaHang = node1["MH"].InnerText;
                    mh.TenHang = node1["TenHang"].InnerText;
                    mh.DonGia = double.Parse(node1["Gia"].InnerText);
                }
                int sl = int.Parse(node["SoLuong"].InnerText);
                if (loai == 1)////Hoá đơn khách VIP
                {
                    hd = new HoaDonKhachVIP(ms, ten, ngay, mh, sl);
                }
                else
                    if (loai == 2)//Hoá đơn khách vãng lai
                {
                    hd = new HoaDonKhachVangLai(ms, ten, ngay, mh, sl);
                }
                else//Hoá đơn khách thân thiết
                {
                    hd = new HoaDonKhachHangThanThiet(ms, ten, ngay, mh, sl);
                }
                hdList.Add(hd);
            }
        }

        public void xuat()
        {
            foreach (HoaDon hd in hdList)
            {
                hd.xuat();
            }
        }
        public void xuatKVLai()
        {
            foreach (HoaDon hd in hdList)
            {
                if (hd is HoaDonKhachVangLai)
                {
                    hd.xuat();
                }
            }
        }
        public double tongTTDS()
        {
            return hdList.Sum(hd => hd.tongThanhTien());
        }
        public void xuatHDTongTTMax()
        {
            double maxTong = hdList.Max(hd => hd.tongThanhTien());
            hdList = hdList.Where(hd => hd.tongThanhTien() == maxTong).ToList();
        }
        public int demHD()
        {
            int dem = 0;

            foreach (int loai in ds)
            {
                if (loai == 1 || loai == 3)
                {
                    dem++;
                }
            }
            return dem;
        }
        public double tongTamUng(string tenKH)
        {
            double tong = 0;
            foreach (HoaDon hd in hdList)
            {
                if (hd is TamUngVaLaiXuat)
                {
                    TamUngVaLaiXuat t = (TamUngVaLaiXuat)hd;
                    if (hd.HoTenKhach == tenKH)
                    {


                        tong += t.thanhToanTamUng();
                    }
                }


            }
            return tong;
        }
        public void sapXep()
        {
            hdList = hdList.OrderBy(hd => hd.tongThanhTien()).ThenByDescending(hd => hd.MaSo).ToList();
        }
    }
}
