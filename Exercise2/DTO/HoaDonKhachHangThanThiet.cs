using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonKhachHangThanThiet : HoaDon, TamUngVaLaiXuat
    {
        public HoaDonKhachHangThanThiet(string maSo, string hoTenKhach, string ngayLap, MatHang mh, int soLuong) : base(maSo, hoTenKhach, ngayLap, mh, soLuong)
        {

        }
        public override double tienKM()
        {
            if (SoLuong > 60)
            {
                return 0.04 * Mh.DonGia;
            }
            else if (SoLuong <= 50 && thanhTien() >= 800000)
            {
                return 0.03 * thanhTien();
            }
            else
                return 0;
        }
        public double thanhToanTamUng()
        {
            return 0.6 * tongThanhTien();
        }
        public double laiXuatTraCham()
        {
            return 0.03 * (tongThanhTien() - thanhToanTamUng());
        }
    }
}
