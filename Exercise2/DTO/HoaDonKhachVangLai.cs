using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonKhachVangLai : HoaDon
    {
        public HoaDonKhachVangLai(string maSo, string hoTenKhach, string ngayLap, MatHang mh, int soLuong) : base(maSo, hoTenKhach, ngayLap, mh, soLuong)
        {

        }
        public override double tienKM()
        {
            if (thanhTien() > 1000000)
            {
                return 0.03 * thanhTien();
            }
            else return 0;
        }
    }
}
