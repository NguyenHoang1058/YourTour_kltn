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

            //var khachhang = new Khachhang[]
            //{
            //    new Khachhang{Hoten="Hoàng Sĩ Nguyên", Cmnd = 251139125, Diachi="12 Nguyễn Văn Bảo", Email="hoangsinguyen@gmail.com", Sdt="0123456789"},
            //    new Khachhang{Hoten="Lê Tuấn Kiệt", Cmnd = 251133122, Diachi="13 Lê Lợi", Email="letuankiet@gmail.com", Sdt="0987465133"},
            //    new Khachhang{Hoten="Hoàng Bá Bửu", Cmnd = 251139115, Diachi="14 Nguyễn Trung Trực", Email="hoangbabuu@gmail.com", Sdt="0323456556"},
            //    new Khachhang{Hoten="Lê Tuấn Anh", Cmnd = 251133112, Diachi="15 Hoàng Văn Thụ", Email="letuananh@gmail.com", Sdt="0987465123"},
            //    new Khachhang{Hoten="Đoàn Lê Huy", Cmnd = 251139126, Diachi="16 Trần Lê", Email="doanlehuy@gmail.com", Sdt="0423456700"},
            //    new Khachhang{Hoten="Nguyễn Hữu Tình", Cmnd = 251133162, Diachi="17 Phan Đình Phùng", Email="nguyenhuutinh@gmail.com", Sdt="0987465100"},
            //    new Khachhang{Hoten="Hoàng Văn Dương", Cmnd = 251139185, Diachi="18 Lê Duẩn", Email="hoangvanduong@gmail.com", Sdt="0523456723"},
            //    new Khachhang{Hoten="Lê Tuấn Vũ", Cmnd = 251133190, Diachi="19 Lê Văn Tám", Email="letuanvu@gmail.com", Sdt="0987435133"}
            //};
            //foreach (Khachhang kh in khachhang)
            //{
            //    context.Khachhangs.Add(kh);
            //}
            //context.SaveChanges();

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
                    Mota="ngắm vẻ đẹp thanh bình với không gian thoáng đãng, khí hậu trong lành, mát mẻ và thưởng thức những món hải sản đậm đà hương vị miền Trung, du khách mới có thể cảm nhận hết được vẻ đẹp của vùng đất Phú Yên thơ mộng. then leng…"},
                new Diadiemdulich{Tendiadiem="Đồi Thiên Phúc Đức",MienID = 3,
                    Mota="Đồi thiên phúc Đức có lẽ không còn là địa điểm du lịch xa lạ với nhiều bạn trẻ. Nằm  cách trung tâm thành phố hoa khoảng 3 km, ngọn đồi cao du khách lên đây cắm trại qua đêm, chụp hình vào buổi sớm mai cũng rất đẹp."},
                new Diadiemdulich{Tendiadiem="Nhà ga Đà Lạt", MienID = 3,
                    Mota="Nhà Ga Đà Lạt hay còn gọi là nhà Ga xe lửa có công trình đường sắt từ thời Pháp. Nên nó luôn mang trong mình một nét đẹp cổ tích pha lẫn sự hiện đại mà con người tạo thành."},
                new Diadiemdulich{Tendiadiem="Tháp bà Ponagar", MienID=2,
                    Mota="Tháp Bà Ponagar đây là điểm du lịch miền Trung cổ kính không thể bỏ qua, tọa lạc trên núi Tháp Bà nằm ngay giữa trung tâm thành phố Nha Trang. Được xây dựng từ năm 813 đến 817 thì hoàn thành."},
                new Diadiemdulich{Tendiadiem="Thành địa Mỹ Sơn", MienID =2,
                    Mota="Được phát hiện từ những năm 1885, thành địa Mỹ Sơn là một trong những di sản của Việt Nam được UNESCO công nhận là Di sản Văn hóa Thế Giới vào năm 1999."},
                new Diadiemdulich{Tendiadiem="Ghềnh đá đĩa", MienID = 2,
                    Mota="Ghềnh đá đĩa là một trong những địa điểm du lịch đáng chú ý khi tới Phú Yên. Tạo hóa đã ban cho nơi này một khung cảnh thiên nhiên kì thú. Nhìn từ xa ghềnh đá không khác gì một chồng đĩa được  xếp ngay ngăn bên bờ biển, như có bàn tay của con người tạo lên."},
                new Diadiemdulich{Tendiadiem="Rừng thông Yên Minh", MienID = 1,
                    Mota="Rừng thông Yên Minh được mệnh danh là Đà Lạt thứ 2 ở phía Bắc với những cây thông xanh rì, cao ngút hướng thẳng lên trời."},
                new Diadiemdulich{Tendiadiem="Phố cổ Đồng Văn", MienID = 1,
                    Mota="Phố cổ Đồng Văn là một thung lũng đẹp cổ kính, trầm mặc được bao bọc bởi núi đồi và cây xanh. Đó là những ngôi nhà 2 tầng trình tường, một lối kiến trúc phổ biến của Hà Giang xưa."}
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
                new Tour{Code="TMN201220A", Tentour="Tour Tây An Cổ Tự - Miếu Bà Chúa Xứ", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Miếu Bà Chúa Xứ", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-13"), Thoigiandi=3,
                    Hinhanh="mieu_ba_chua_xu.jpg", Gianguoilon=1100000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", 
                    Mota="Châu Đốc, một địa danh gắn liền với sự linh thiêng với thế phong thủy tiền tam giang, hậu thất sơn và huyền bí cùng nhiều tín ngưỡng tôn giáo tồn tại từ lâu đời. " +
                    "Nhắc tới mảnh đất này, người ta không thể không nhớ tới Miếu Bà Chúa Xứ Núi Sam là điểm du lịch tâm linh nổi tiếng không chỉ ở miền Tây Nam Bộ, mà ngay cả người Việt ở nước " +
                    "ngoài vẫn biết đến.",  Loaitour="Trong nước", TenHDV="Nguyễn Văn A", 
                    Songuoi=9, Trangthai = "còn chỗ", Tournoibat=1, Thuocmien = 1},
                new Tour{Code="TMT291220B", Tentour="Tour Đầm Ô Loan", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Đầm Ô Loan", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-15"), Thoigiandi=5,
                    Hinhanh="phu-yen-dam-o-loan.jpg", Gianguoilon=1250000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Ô Loan có diện tích 1570km, nổi danh là một đầm nước lợ nằm sát cửa biển với vẻ đẹp bình dị, mộc mạc và yên bình. " +
                    "Toạ lạc sát chân đèo Quán Cau; từ trên đèo nhìn xuống, đầm có hình dáng như một con chim phượng hoàng đang dang đôi cánh phủ rợp cả vùng.", 
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn B", Songuoi=9, Trangthai = "còn chỗ", Tournoibat=1, Thuocmien= 2},
                new Tour{Code="TMB181220R", Tentour="Tour Thác Dải Yếm", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Thác Dải Yếm Mộc Châu", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-14"), Thoigiandi=4,
                    Hinhanh="thac-dai-yem.jpg", Gianguoilon=1400000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Vào những ngày hè oi bức, còn gì tuyệt vời hơn là đứng dưới chân thác hít thở không khí trong lành, hơi nước dịu mát phả vào mặt," +
                    " hay có thể hòa mình vào dòng nước mát lạnh sản khoái.", 
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn A", Songuoi=9, Trangthai = "còn chỗ", Thuocmien = 1},
                new Tour{Code="TNM181220B", Tentour="Miếu Bà Chúa Xứ", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="Đầm Ô Loan", Ngaydi=DateTime.Parse("2020-11-10"), Ngayve=DateTime.Parse("2020-11-15"), Thoigiandi=5,
                    Hinhanh="phu-yen-dam-o-loan.jpg", Gianguoilon=1150000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Châu Đốc, một địa danh gắn liền với sự linh thiêng với thế phong thủy tiền tam giang, hậu thất sơn và huyền bí cùng nhiều tín ngưỡng tôn giáo tồn tại từ lâu đời.", 
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn B", Songuoi=9, Trangthai = "còn chỗ", Thuocmien = 3},
                new Tour{Code="TMT201220DF", Tentour="Ghềnh đá đĩa", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Phú Yên", Ngaydi= DateTime.Parse("2020-12-22"), Ngayve=DateTime.Parse("2020-12-25"), Thoigiandi=4,
                        Hinhanh="ghenh-da-dia.jpg", Gianguoilon=1250000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Ghềnh đá đĩa là một trong những địa điểm du lịch đáng chú ý khi tới Phú Yên. Tạo hóa đã ban cho nơi này một khung cảnh thiên nhiên kì thú. Nhìn từ xa ghềnh đá không khác gì một chồng đĩa được  xếp ngay ngăn bên bờ biển, như có bàn tay của con người tạo lên.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2},
                new Tour{Code="TMN201220DL", Tentour="Đồi thiên phúc", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Đà Lạt", Ngaydi= DateTime.Parse("2020-12-23"), Ngayve=DateTime.Parse("2020-12-25"), Thoigiandi=3,
                        Hinhanh="doi-thien-phuc-duc.jpg", Gianguoilon=900000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Đồi thiên phúc Đức có lẽ không còn là địa điểm du lịch xa lạ với nhiều bạn trẻ. Nằm  cách trung tâm thành phố hoa khoảng 3 km, ngọn đồi cao du khách lên đây cắm trại qua đêm, chụp hình vào buổi sớm mai cũng rất đẹp.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=3},
                new Tour{Code="TMT231220NT", Tentour="Thánh địa Mỹ Sơn", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Mỹ Sơn", Ngaydi= DateTime.Parse("2020-12-24"), Ngayve=DateTime.Parse("2020-12-26"), Thoigiandi=3,
                        Hinhanh="my-son.jpg", Gianguoilon=1200000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Được phát hiện từ những năm 1885, thánh địa Mỹ Sơn là một trong những di sản của Việt Nam được UNESCO công nhận là Di sản Văn hóa Thế Giới vào năm 1999.",
                        Loaitour="Trong nước", TenHDV="Nguyễn Trọng Sơn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2},
                new Tour{Code="TMB201220HG", Tentour="Phố cổ Đồng Văn", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Hà Giang", Ngaydi= DateTime.Parse("2020-12-22"), Ngayve=DateTime.Parse("2020-12-25"), Thoigiandi=4,
                        Hinhanh="pho-co-dong-van.jpg", Gianguoilon=1500000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Phố cổ Đồng Văn là một thung lũng đẹp cổ kính, trầm mặc được bao bọc bởi núi đồi và cây xanh. Đó là những ngôi nhà 2 tầng trình tường, một lối kiến trúc phổ biến của Hà Giang xưa.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=1, Tournoibat=1},
                new Tour{Code="TMB191220YM", Tentour="Rừng thông Yên Minh", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Hà Giang", Ngaydi= DateTime.Parse("2020-12-22"), Ngayve=DateTime.Parse("2020-12-26"), Thoigiandi=4,
                        Hinhanh="rung-thong-yen-minh.jpg", Gianguoilon=1750000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Rừng thông Yên Minh được mệnh danh là Đà Lạt thứ 2 ở phía Bắc với những cây thông xanh rì, cao ngút hướng thẳng lên trời.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=1},
                new Tour{Code="TMN201220GA", Tentour="Ga Đà Lạt", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Đà Lạt", Ngaydi= DateTime.Parse("2020-12-20"), Ngayve=DateTime.Parse("2020-12-23"), Thoigiandi=3,
                        Hinhanh="ga-da-lat.jpg", Gianguoilon=1250000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Nhà Ga Đà Lạt hay còn gọi là nhà Ga xe lửa có công trình đường sắt từ thời Pháp. Nên nó luôn mang trong mình một nét đẹp cổ tích pha lẫn sự hiện đại mà con người tạo thành.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=3},
            };
            foreach (Tour tr in tour)
            {
                context.Tours.Add(tr);
            }
            context.SaveChanges();

            //
            //  init data table Hoadon
            //

            //var hoadon = new Hoadon[]
            //{
            //    new Hoadon{KhachHangID=1, Ngaylaphd=DateTime.Parse("2020-12-09"), Tongtien=1250000, Tinhtrang = 1, Ptthanhtoan="Tiền mặt"},
            //    new Hoadon{KhachHangID=2, Ngaylaphd=DateTime.Parse("2020-12-19"), Tongtien=1250000, Tinhtrang = 0, Ptthanhtoan="Thanh toán Online"},
            //    new Hoadon{KhachHangID=3, Ngaylaphd=DateTime.Parse("2020-12-20"), Tongtien=1400000, Tinhtrang = 1, Ptthanhtoan="Chuyển khoản"}
            //};
            //foreach (Hoadon hd in hoadon)
            //{
            //    context.Hoadons.Add(hd);
            //}
            //context.SaveChanges();

            //
            //  init data table CTHoadonNam
            //

            //var cthd = new CTHoadonNam[]
            //{
            //    new CTHoadonNam{Hotenkhachhang="Hoàng Sĩ Nguyên", Sdt="0369052254", Email="hoangsinguyen@gmail.com", Hoadoncode = "12345678",
            //        Songuoidi=1, Dahuy = 0, HoadonID=1, TourID=10}
            //};
            //foreach (CTHoadonNam cthoadon in cthd)
            //{
            //    context.CTHoadonNams.Add(cthoadon);
            //}
            //context.SaveChanges();

            //
            // init data table CTHoadonTrung
            //

            //var cthdt = new CTHoadonTrung[]
            //{
            //    new CTHoadonTrung{Hotenkhachhang="Lê Tuấn Kiệt", Sdt="0987465133", Email="letuankiet@gmail.com", Hoadoncode = "12897546",
            //        Songuoidi=1, Dahuy =0, HoadonID=2, TourID=2}
            //};
            //foreach (CTHoadonTrung cTHoadonTrung in cthdt)
            //{
            //    context.CTHoadonTrungs.Add(cTHoadonTrung);
            //}
            //context.SaveChanges();

            //
            // init data table CTHoadonBac
            //

            //var cthdb = new CTHoadonBac[]
            //{
            //    new CTHoadonBac{Hotenkhachhang="Hoàng Bá Bửu", Sdt="0323456556", Email="hoangbabuu8@gmail.com", Hoadoncode = "56487231",
            //        Songuoidi=1, Dahuy =0, HoadonID=3, TourID=3}
            //};
            //foreach (CTHoadonBac cTHoadonBac in cthdb)
            //{
            //    context.CTHoadonBacs.Add(cTHoadonBac);
            //}
            //context.SaveChanges();
        }
    }
}
