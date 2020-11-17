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
                new Nguoidung{Hoten="Hoang Si Nguyen", Gioitinh="Nam", Email="abc@gmail.com", Sdt="0123456789" }
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
                new Taikhoan{Email="abc@gmail.com", Matkhau="123", Vaitro="nv"}
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
                new Khachhang{Hoten="Nguyễn Văn A", Gioitinh="Nam", Email="test@gmail.com", Sdt="0123456789"},
                new Khachhang{Hoten="Nguyễn Văn B", Gioitinh="Nam", Email="test@gmail.com", Sdt="0987465133"}
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
                new Mien{Tenmien="Miền Tây"}
            };
            foreach (Mien m in mien)
            {
                context.Miens.Add(m);
            }
            context.SaveChanges();

            //
            //  init data table Tinh
            //

            var tinh = new Tinh[]
            {
                new Tinh{Tentinh="Sơn La", MienID=1},
                new Tinh{Tentinh="Yên Bái", MienID=1},
                new Tinh{Tentinh="Phú Yên", MienID=2},
                new Tinh{Tentinh="Bình Định", MienID=2},
                new Tinh{Tentinh="An Giang", MienID=3},
                new Tinh{Tentinh="Cần Thơ", MienID=3}
            };
            foreach (Tinh t in tinh)
            {
                context.Tinhs.Add(t);
            }
            context.SaveChanges();

            //
            //  init data table Diadiemdulich
            //  data mô tả địa điểm du lịch chưa đúng cần sửa
            //

            var diadiemdulich = new Diadiemdulich[]
            {
                new Diadiemdulich{Tendiadiem="Tây An Cổ Tự", TinhID=5, Mota="ngôi chùa có kiến trúc kết hợp phong cách nghệ thuật Ấn Độ và kiến trúc cổ dân tộc đầu tiên tại Việt Nam."},
                new Diadiemdulich{Tendiadiem="Miếu Bà Chúa Xứ", TinhID=5, Mota="một di tích lịch sử, kiến trúc và tâm linh quan trọng của tỉnh An Giang. Ðược lập vào năm 1820, kiến trúc theo kiểu chữ quốc."},
                new Diadiemdulich{Tendiadiem="Thác Dải Yếm", TinhID=1, Mota="có chiều cao khoảng trên dưới 100m, với một màn nước trắng xóa, vừa hùng vĩ vừa thơ mộng, nhìn từ xa thác như một “dải yếm” hững hợ nối giữa trời và đất."},
                new Diadiemdulich{Tendiadiem="Đầm Ô Loan", TinhID=3, Mota="ngắm vẻ đẹp thanh bình với không gian thoáng đãng, khí hậu trong lành, mát mẻ và thưởng thức những món hải sản đậm đà hương vị miền Trung, du khách mới có thể cảm nhận hết được vẻ đẹp của vùng đất Phú Yên thơ mộng. then leng…"}

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
                    Hinhanh="chua co", Gianguoilon=1200000, Giatreem=1000000,
                    Lichtrinh="Xuất phát từ tp Hồ Chí Minh đi qua Tây An Cổ Tự sau đó đến Miếu Bà Chúa Xứ", Mota="Một tour du lịch tuyệt vời đi qua các điểm đến nổi tiếng", Trongnuoc=1},
                new Tour{Code="T002", Tentour="Tour Đầm Ô Loan", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Đầm Ô Loan", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-15"), Thoigiandi=5,
                    Hinhanh="chua co", Gianguoilon=1200000, Giatreem=1000000,
                    Lichtrinh="Xuất phát từ tp Hồ Chí Minh đi đến đầm Ô Loan", Mota="Một tour du lịch tuyệt vời đi qua các điểm đến nổi tiếng", Trongnuoc=1}

            };
            foreach (Tour tr in tour)
            {
                context.Tours.Add(tr);
            }
            context.SaveChanges();

            //
            // init data table Diadiemtour
            //

            var diadiemtour = new Diadiemtour[]
            {
                new Diadiemtour{TourID=1,DiadiemdulichID=1},
                new Diadiemtour{TourID=1,DiadiemdulichID=2},
                new Diadiemtour{TourID=2,DiadiemdulichID=4}
            };
            foreach (Diadiemtour ddt in diadiemtour)
            {
                context.Diadiemtours.Add(ddt);
            }
            context.SaveChanges();

            //
            //  init data table Hoadon
            //

            var hoadon = new Hoadon[]
            {
                new Hoadon{KhachHangID=1, Ngaylaphd=DateTime.Parse("2020-12-09"), Tongtien=1250000, Tinhtrang=0},
                new Hoadon{KhachHangID=1, Ngaylaphd=DateTime.Parse("2020-12-09"), Tongtien=1250000, Tinhtrang=1},
                new Hoadon{KhachHangID=2, Ngaylaphd=DateTime.Parse("2020-12-09"), Tongtien=1250000, Tinhtrang=0}
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
                new CTHoadon{Hotenkhachhang="Hoàng Sĩ Nguyên", Sdt="0369052254", Email="onegtheprober1058@gmail.com",
                    Songuoidi=1, Ptthanhtoan="tien mat", HoadonID=2, TourID=1},
                new CTHoadon{Hotenkhachhang="Lê Tuấn Kiệt", Sdt="0369052253", Email="kietle@gmail.com",
                    Songuoidi=1, Ptthanhtoan="online", HoadonID=1, TourID=2}
            };
            foreach (CTHoadon cthoadon in cthd)
            {
                context.CTHoadons.Add(cthoadon);
            }
            context.SaveChanges();
        }
    }
}
