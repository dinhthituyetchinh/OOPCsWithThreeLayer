using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_HoaDon
    {
        DanhSachHoaDon dtDSHD = new DanhSachHoaDon();
        public BLL_HoaDon()
        {

        }
        public void loadHD()
        {
            dtDSHD.docFile("Hoadon.xml");
            dtDSHD.xuat();
            //Console.WriteLine("===========================================");
            //dtDSHD.xuatKVLai();
            Console.WriteLine("===========================================");
            Console.WriteLine("Tổng thành tiền các hoá đơn: " + dtDSHD.tongTTDS());
            //Console.WriteLine("Hoá đơn có tổng thành tiền cao nhất");
            //dtDSHD.xuatHDTongTTMax();
            //dtDSHD.xuat();
            Console.WriteLine("===================================");
            Console.WriteLine("Khách hàng VIP và khách hàng thân thiết có tổng số hoá đơn: " + dtDSHD.demHD());
            Console.WriteLine("Tổng thanh toán tạm ứng của khách Nguyễn Long: " + dtDSHD.tongTamUng("Nguyễn Long"));
            Console.WriteLine("==================================================");
            Console.WriteLine("Sắp xếp tăng dần theo tổng thành tiền, nếu thành tiền bằng thì sắp xếp giảm theo mã số hoá đơn");
            dtDSHD.sapXep();
            dtDSHD.xuat();
        }
    }
}
