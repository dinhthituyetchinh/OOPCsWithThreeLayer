using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonKhachVIP : HoaDon, TamUngVaLaiXuat
    {
        public HoaDonKhachVIP(string maSo, string hoTenKhach, string ngayLap, MatHang mh, int soLuong) : base(maSo, hoTenKhach, ngayLap, mh, soLuong)
        {

        }
        public override double tienKM()
        {
            if (SoLuong > 50)
            {
                return 0.05 * Mh.DonGia;
            }
            else if (SoLuong <= 50 && thanhTien() >= 600000)
            {
                return 0.04 * thanhTien();
            }
            else if (SoLuong > 10)
            {
                return 0.01 * thanhTien();
            }
            else return 0;
        }
        public double thanhToanTamUng()
        {
            return 0.4 * tongThanhTien();
        }
        public double laiXuatTraCham()
        {
            return 0.02 * (tongThanhTien() - thanhToanTamUng());
        }

    }
}
