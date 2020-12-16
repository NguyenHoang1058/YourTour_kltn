using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.db
{
    public class DataInitializer
    {
        public static void Initialize(YourTourContext context)
        {
            context.Database.EnsureCreated();

            //
            //  init data table Nguoidung
            //

            var nguoidung = new Nguoidung[]
            {
                new Nguoidung{Hoten="Hoàng Sĩ Nguyên", Gioitinh="Nam", Email="nv@gmail.com", Sdt="0123456789" },
                new Nguoidung{Hoten="Lê Tuấn Kiệt", Gioitinh="Nam", Email="admin@gmail.com", Sdt="0123456789" }
            };
            foreach (Nguoidung nd in nguoidung)
            {
                context.Nguoidungs.Add(nd);
            }
            context.SaveChanges();

            //
            //  init data table Taikhoan
            //

            var taikhoan = new Taikhoan[]
            {
                new Taikhoan{Email="admin@gmail.com", Matkhau="123", Vaitro="admin"},
                new Taikhoan{Email="nv@gmail.com", Matkhau="123", Vaitro="nv"}
            };
            foreach (Taikhoan tk in taikhoan)
            {
                context.Taikhoans.Add(tk);
            }
            context.SaveChanges();

            //
            //  init data table Khachhang 
            //

            var khachhang = new Khachhang[]
            {
                new Khachhang{Hoten="Hoàng Sĩ Nguyên", Cmnd = 251139125, Diachi="12 Nguyễn Văn Bảo", Email="test@gmail.com", Sdt="0123456789"},
                new Khachhang{Hoten="Lê Tuấn Kiệt", Cmnd = 251133132, Diachi="13 Nguyễn Văn Bảo", Email="test@gmail.com", Sdt="0987465133"},
                new Khachhang{Hoten="Hoàng Bá Bửu", Cmnd = 251139125, Diachi="14 Nguyễn Văn Bảo", Email="test@gmail.com", Sdt="0123456789"},
                new Khachhang{Hoten="Lê Tuấn Anh", Cmnd = 251133132, Diachi="15 Nguyễn Văn Bảo", Email="test@gmail.com", Sdt="0987465133"}
            };
            foreach (Khachhang kh in khachhang)
            {
                context.Khachhangs.Add(kh);
            }
            context.SaveChanges();

            //
            //  init data table Mien
            //

            var mien = new Mien[]
            {
                new Mien{Tenmien="Miền Bắc"},
                new Mien{Tenmien="Miền Trung"},
                new Mien{Tenmien="Miền Nam"}
            };
            foreach (Mien m in mien)
            {
                context.Miens.Add(m);
            }
            context.SaveChanges();


            //
            //  init data table Diadiemdulich
            //  data mô tả địa điểm du lịch chưa đúng cần sửa
            //

            var diadiemdulich = new Diadiemdulich[]
            {
                new Diadiemdulich{Tendiadiem="Tây An Cổ Tự",MienID = 3,
                    Mota="ngôi chùa có kiến trúc kết hợp phong cách nghệ thuật Ấn Độ và kiến trúc cổ dân tộc đầu tiên tại Việt Nam."},
                new Diadiemdulich{Tendiadiem="Miếu Bà Chúa Xứ", MienID=3,
                    Mota="một di tích lịch sử, kiến trúc và tâm linh quan trọng của tỉnh An Giang. Ðược lập vào năm 1820, kiến trúc theo kiểu chữ quốc."},
                new Diadiemdulich{Tendiadiem="Thác Dải Yếm", MienID=1,
                    Mota="có chiều cao khoảng trên dưới 100m, với một màn nước trắng xóa, vừa hùng vĩ vừa thơ mộng, nhìn từ xa thác như một “dải yếm” hững hợ nối giữa trời và đất."},
                new Diadiemdulich{Tendiadiem="Đầm Ô Loan", MienID=2,
                    Mota="ngắm vẻ đẹp thanh bình với không gian thoáng đãng, khí hậu trong lành, mát mẻ và thưởng thức những món hải sản đậm đà hương vị miền Trung, du khách mới có thể cảm nhận hết được vẻ đẹp của vùng đất Phú Yên thơ mộng. then leng…"}

            };
            foreach (Diadiemdulich dddl in diadiemdulich)
            {
                context.Diadiemduliches.Add(dddl);
            }
            context.SaveChanges();

            //
            //  init data table Tour
            //  data trong Lichtrinh cần được update lại tương tự như vậy cho data trong Hinhanh
            //

            var tour = new Tour[]
            {
                new Tour{Code="T001", Tentour="Tour Tây An Cổ Tự - Miếu Bà Chúa Xứ", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Miếu Bà Chúa Xứ", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-15"), Thoigiandi=5,
                    Hinhanh="mieu_ba_chua_xu.jpg", Gianguoilon=1100000, Giatreem=1000000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Một tour du lịch tuyệt vời đi qua các điểm đến nổi tiếng", 
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn A", Songuoi=9, Trangthai = "còn chỗ", Tournoibat=1, Thuocmien = 3, },
                new Tour{Code="T002", Tentour="Tour Đầm Ô Loan", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Đầm Ô Loan", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-15"), Thoigiandi=5,
                    Hinhanh="phu-yen-dam-o-loan.jpg", Gianguoilon=1250000, Giatreem=1000000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Một tour du lịch tuyệt vời đi qua các điểm đến nổi tiếng", 
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn B", Songuoi=9, Trangthai = "còn chỗ", Tournoibat=1, Thuocmien= 2},
                new Tour{Code="T003", Tentour="Tour Thác Dải Yếm", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Thác Dải Yếm Mộc Châu", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-15"), Thoigiandi=5,
                    Hinhanh="thac-dai-yem.jpg", Gianguoilon=1400000, Giatreem=1000000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Một tour du lịch tuyệt vời đi qua các điểm đến nổi tiếng", 
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn A", Songuoi=9, Trangthai = "còn chỗ", Thuocmien = 1},
                new Tour{Code="T004", Tentour="Miếu Bà Chúa Xứ", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Đầm Ô Loan", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-15"), Thoigiandi=5,
                    Hinhanh="phu-yen-dam-o-loan.jpg", Gianguoilon=1150000, Giatreem=1000000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Một tour du lịch tuyệt vời đi qua các điểm đến nổi tiếng", 
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn B", Songuoi=9, Trangthai = "còn chỗ", Thuocmien = 3}

            };
            foreach (Tour tr in tour)
            {
                context.Tours.Add(tr);
            }
            context.SaveChanges();

            //
            //  init data table Hoadon
            //

            var hoadon = new Hoadon[]
            {
                new Hoadon{KhachHangID=1, Ngaylaphd=DateTime.Parse("2020-12-09"), Tongtien=1200000, Tinhtrang = 1},
                new Hoadon{KhachHangID=2, Ngaylaphd=DateTime.Parse("2020-12-09"), Tongtien=1100000, Tinhtrang = 0},
                new Hoadon{KhachHangID=3, Ngaylaphd=DateTime.Parse("2020-12-09"), Tongtien=1250000, Tinhtrang = 1},
                new Hoadon{KhachHangID=4, Ngaylaphd=DateTime.Parse("2020-12-09"), Tongtien=1250000, Tinhtrang = 1}
            };
            foreach (Hoadon hd in hoadon)
            {
                context.Hoadons.Add(hd);
            }
            context.SaveChanges();

            //
            //  init data table CTHoadon
            //

            var cthd = new CTHoadon[]
            {
                new CTHoadon{Hotenkhachhang="Hoàng Sĩ Nguyên", Sdt="0369052254", Email="onegtheprober1058@gmail.com", Hoadoncode = "ABCND134",
                    Songuoidi=1, Ptthanhtoan="tiền mặt", HoadonID=1, TourID=1},
                new CTHoadon{Hotenkhachhang="Lê Tuấn Kiệt", Sdt="0369052253", Email="kietle@gmail.com",Hoadoncode = "ABCND135",
                    Songuoidi=2, Ptthanhtoan="thanh toán online", HoadonID=2, TourID=2},
                new CTHoadon{Hotenkhachhang="Hoàng Bá Bửu", Sdt="0369052254", Email="onegtheprober1058@gmail.com", Hoadoncode = "ABCND136",
                    Songuoidi=3, Ptthanhtoan="tiền mặt", HoadonID=3, TourID=3},
                new CTHoadon{Hotenkhachhang="Lê Tuấn Anh", Sdt="0369052253", Email="kietle@gmail.com",Hoadoncode = "ABCND137",
                    Songuoidi=4, Ptthanhtoan="chuyển khoản", HoadonID=4, TourID=4}
            };
            foreach (CTHoadon cthoadon in cthd)
            {
                context.CTHoadons.Add(cthoadon);
            }
            context.SaveChanges();
        }
    }
}
