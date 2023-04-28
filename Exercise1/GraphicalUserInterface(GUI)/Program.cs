using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject_DTO_;
using BusinessLogicLayer_BLL_;
namespace GraphicalUserInterface_GUI_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            QUẢN LÝ BÁN HÀNG
            //Công ty ABC chuyên phân phối máy lạnh cho các khách hàng trong thành phố. Với mỗi lần bán
            //hàng công ty sẽ lưu trữ các thông tin: Mã khách hàng, tên khách hàng, số lượng, giá bán và thành
            //tiền.Biết rằng: 
            //Thành tiền = Số lượng* Đơn giá - Chiết khấu +Thuế VAT
            //Trong đó:
            //- Thuế VAT là 10 % của tổng tiền. Tổng tiền = Số lượng* Đơn giá.
            //- Chiết khấu được tính tùy vào loại khách hàng của công ty: 
            //+ Khách hàng cá nhân: Về mặt giá cả nếu số lượng < 7 thì chiết khấu bằng 0 ngược lại khách
            //hàng sẽ được chiết khấu 5 % đơn giá trên từng sản phẩm.Tuy nhiên nếu khoảng cách từ công
            //ty nhỏ hơn 10 km thì công ty sẽ chiết khấu cho khách hàng thêm 10000 trên mỗi sản phẩm.
            //+ Đại lý cấp 1: Do là đối tác quan trọng của công ty, được công ty đặc biệt quan tâm nên đại lý
            //cấp 1 luôn được chiết khấu 30 % giá bán trên từng sản phẩm.Hơn nữa nếu thời gian hợp tác
            //của đại lý với công ty lớn hơn 3 năm thì cứ mỗi năm hợp tác sẽ được chiết khấu thêm 1 %
            //nhưng tối đa chỉ được chiết khấu là 35 %.
            //+ Khách hàng là công ty: Khách hàng công ty sẽ được công ty ABC ưu đãi nhằm mục đích
            //quảng bá sản phẩm đến nhân viên.Nếu công ty có số lượng nhân viên lớn hơn 100 thì sẽ
            //được chiết khấu 3 %.Nếu số lượng nhân viên lớn hơn 500 thì chiết khấu là 5 %.
            //Gần đây cho chiến lược hỗ trợ giá đối với các mặt hàng điện dân dụng đối với người dân
            //trong thành phố nên hãng sản xuất có thêm chính sách trợ giá cho khách hàng cá nhân và khách
            //hàng công ty như sau:
            //- Khách hàng cá nhân
            //+Trợ giá đối với mỗi sản phẩm là 2 % giá bán.Nếu số lượng lớn hơn 2 sản phẩm thì
            //được hỗ trợ thêm 100000
            //- Khách hàng công ty
            //+Với mỗi sản phẩm khách hàng công ty được giảm giá 120000
            //Yêu cầu: 
            //1.Xác định các lớp(thuộc tính, phương thức khởi tạo và các phương thức cần thiết), vẽ sơ đồ
            //phân cấp cấu trúc các lớp trong bài toán.
            //2.Lập danh sách tất cả các hóa đơn.
            //3.Tạo file DSHOADON.xml có tối thiểu 5 hóa đơn và đọc hóa đơn lên danh sách hóa đơn đã
            //tạo.
            //4.Tính tổng thành tiền của tất cả các hóa đơn.
            //5.Tính tổng tiền trợ giá mà công ty đã hỗ trợ.
            //6.Xuất thông tin khách hàng có số lượng mua nhiều nhất.
            //7.Xuất thông tin của hóa đơn có thành tiền cao nhất.
            //8.Tổng số tiền chiết khấu của công ty là bao nhiêu đối với khách hàng công ty.
            //9.Sắp xếp danh sách hóa đơn tăng dần theo số lượng, nếu số lượng bằng nhau thì sắp xếp giảm
            //dần theo thành tiền.
            //10.Cho biết trong danh sách công ty có bao nhiêu đại lý cấp 1.
            Console.OutputEncoding = Encoding.UTF8;
            BLL_HoaDon dt = new BLL_HoaDon();
            dt.LoadHD();
            Console.ReadLine();
        }
    }
}
