using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject_DTO_;
using DataAccessLayer_DAL_;
namespace BusinessLogicLayer_BLL_
{
    public class BLL_HoaDon
    {
            DanhSachHoaDon hd = new DanhSachHoaDon();
        public BLL_HoaDon()
        {

        }
        public void LoadHD()
        {
            hd.docFile("DSHOADON.xml");
            hd.xuatDSHD();
            Console.WriteLine("Tổng thành tiền của cả danh sách hoá đơn: {0}", hd.tongThanhTien());
            Console.WriteLine("Tổng tiền trợ giá mà công ty đã hỗ trợ: {0}", hd.tongTroGia());
            Console.WriteLine("======================================================================");
            Console.WriteLine("Thông tin khách hàng có số lượng mua nhiều nhất");
            hd.khachHangMuaNhieuNhat();
            hd.xuatDSHD();
            Console.WriteLine("======================================================================");
            Console.WriteLine("Xuất thông tin của hóa đơn có thành tiền cao nhất");
            hd.hoaDonTTMax();
            hd.xuatDSHD();
            Console.WriteLine("======================================================================");
            Console.WriteLine("Tổng chiết khấu của công ty là {0} đối với khách hàng công ty", hd.tongChietKhauKHCT());
            Console.WriteLine("Tổng thành tiền của công ty là {0} đối với khách hàng công ty", hd.tongThanhTienKHCT());
            Console.WriteLine("Tổng số tiền chiết khấu của công ty là {0} đối với khách hàng công ty", hd.tongTienCKKHCT());
            Console.WriteLine("======================================================================");
            Console.WriteLine("Sắp xếp danh sách hóa đơn tăng dần theo số lượng, nếu số lượng bằng nhau thì sắp xếp giảm dần theo thành tiền");
            hd.sapXepHoaDon();
            hd.xuatDSHD();
            Console.WriteLine("======================================================================");
            Console.WriteLine("Cho biết trong danh sách công ty có {0} đại lý cấp 1", hd.demDL());
        }
    }
}
