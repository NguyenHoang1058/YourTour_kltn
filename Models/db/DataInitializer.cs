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
                new Diadiemdulich{Tendiadiem="Thành phố Hồ Chí Minh",MienID = 1,
                    Mota="là thành phố lớn nhất tại Việt Nam về dân số và quy mô đô thị hóa. Đây còn là trung tâm kinh tế, chính trị, văn hóa và giáo dục tại Việt Nam."},
                new Diadiemdulich{Tendiadiem="Cần Thơ", MienID=1,
                    Mota="là một thành phố trực thuộc trung ương của Việt Nam, là thành phố hiện đại và phát triển nhất ở Đồng bằng sông Cửu Long, Cần Thơ hiện là đô thị loại I, là trung tâm kinh tế, văn hóa, xã hội, y tế và giáo dục của vùng Đồng bằng sông Cửu Long."},
                new Diadiemdulich{Tendiadiem="Bà Rịa - Vũng Tàu", MienID=1,
                    Mota=" thành phố du lịch biển và là trung tâm của hoạt động khai thác dầu mỏ phía Nam, đã từng là trung tâm hành chính của tỉnh. Từ ngày 2 tháng 5 năm 2012, tỉnh lỵ chuyển đến thành phố Bà Rịa. Đây cũng là tỉnh đầu tiên của Đông Nam Bộ có 2 thành phố trực thuộc tỉnh."},
                new Diadiemdulich{Tendiadiem="Bình Dương", MienID=1,
                    Mota="là vùng đất chiến trường năm xưa với những địa danh đã đi vào lịch sử như Phú Lợi, Bàu Bàng, Bến Súc, Lai Khê, Nhà Đỏ và đặc biệt là chiến khu Đ với trung tâm là huyện Tân Uyên (nay là huyện Bắc Tân Uyên và thị xã Tân Uyên), vùng Tam giác sắt trong đó có ba làng An. Ngoài ra còn có khu du lịch Đại Nam là khu du lịch lớn nhất Đông Nam Á."},
                new Diadiemdulich{Tendiadiem="Tây Ninh",MienID = 1,
                    Mota="Kiến trúc Chàm, nền văn minh Chàm và dân tộc Khmer được đánh giá cao như là một xã hội văn minh sớm xuất hiện ở miền Nam Việt Nam. Tây Ninh hiện còn 2 trong 3 tháp cổ ở vùng đất nam bộ của nền văn hóa Óc Eo (Vương quốc Phù Nam tồn tại từ thế kỷ I đến thế kỷ VIII) hầu như còn nguyên vẹn là Tháp Chót mạt ở xã Tân Phong huyện Tân Biên và Tháp Bình Thạnh huyện Trảng Bàng Theo thống kê của ban Dân tộc tỉnh Tây Ninh hiện Tây Ninh có 21 dân tộc cùng chung sống,dân tộc Tà Mun (hình như là hậu duệ của Vương quốc Phù Nam) ở Tây Ninh đang làm thủ tục để công nhận là dân tộc thứ 55 của Việt Nam."},
                new Diadiemdulich{Tendiadiem="Cà Mau", MienID = 1,
                    Mota="Các di tích lich sử cấp quốc gia như Đình Tân Hưng, Hồng Anh Thư Quán, Biệt khu Hải Yến Bình Hưng (của Nguyễn Lạc Hóa), Khu di tích lịch sử Hòn Đá Bạc, Hòn Khoai...Các di tích cấp tỉnh, Nhà Dây thép, Đền thờ Bác Hồ xã Trí Phải, Đền thờ Bác Hồ xã Viên An, Đền thờ Bác Hồ thị trấn Cái Nước."},
                new Diadiemdulich{Tendiadiem="An Giang", MienID=1,
                    Mota="An Giang là một trong 10 vùng du lịch trọng điểm quốc gia có một số thắng cảnh tiêu biểu như: Châu Đốc, Thất Sơn, Phú Tân, Rừng Tràm Trà Sư, Hồ Thoại Sơn,..."},
                new Diadiemdulich{Tendiadiem="Bến Tre", MienID =1,
                    Mota="Bến Tre có điều kiện thuận tiện để phát triển du lịch sinh thái, bởi ở đó còn giữ được nét nguyên sơ của miệt vườn, giữ được môi trường sinh thái trong lành trong màu xanh của những vườn dừa, vườn cây trái rộng lớn."},
                new Diadiemdulich{Tendiadiem="Lâm Đồng", MienID = 2,
                    Mota="Lâm Đồng có nhiều thắng cảnh nổi tiếng như các thác nước tại huyện Đức Trọng và những thắng cảnh thiên nhiên tại Đà Lạt như Hồ Than Thở, Hồ Xuân Hương."},
                new Diadiemdulich{Tendiadiem="Đắk Lắk", MienID = 2,
                    Mota="Du lịch Đắk Lắk đang có lợi thế với nhiều địa danh cho phép khai thác theo hướng kết hợp cảnh quan, sinh thái, môi trường và truyền thống văn hoá của nhiều dân tộc trong tỉnh như hồ Lắk, Thác Gia Long, cụm du lịch Buôn Đôn, Thác Krông Kmar, Diệu Thanh, Tiên Nữ… bên cạnh các vườn quốc gia, khu bảo tồn thiên nhiên Chư Yang Sin, Easo..."},
                new Diadiemdulich{Tendiadiem="Gia Lai", MienID = 2,
                    Mota="Tiềm năng du lịch của Gia Lai rất phong phú, đa dạng với núi rùng cao có nhiều cảnh quan tự nhiên và nhân tạo. Rừng nguyên sinh nơi đây có hệ thống động thực vật phong phú, nhiều ghềnh thác, suối, hồ như Biển Hồ là một thắng cảnh nổi tiếng, ngoài ra có chùa Minh Thành (Gia Lai). Nhiều đồi núi như cổng trời Mang Yang, đỉnh Hàm Rồng, thác Hang Dơi và thác K50 (Huyện Kbang). Các cảnh quan nhân tạo có các rừng cao su, đồi chè, cà phê bạt ngàn. Kết hợp với tuyến đường rừng, có các tuyến dã ngoại bằng thuyền trên sông, cưỡi voi xuyên rừng,..."},
                new Diadiemdulich{Tendiadiem="Đà Nẵng", MienID = 2,
                    Mota="Đà Nẵng là một thành phố có nhiều tiềm năng để phát triển du lịch, là trung tâm du lịch lớn hàng đầu của Việt Nam. Phía bắc thành phố được bao bọc bởi núi cao với đèo Hải Vân được mệnh danh là Thiên hạ đệ nhất hùng quan."},
                new Diadiemdulich{Tendiadiem="Bình Thuận", MienID = 2,
                    Mota="Là một tỉnh ven biển, khí hậu quanh năm nắng ấm, nhiều bãi biển sạch đẹp, cảnh quan tự nhiên và thơ mộng, giao thông thuận lợi, Bình Thuận đang là một trong những trung tâm du lịch lớn của Việt Nam."},
                new Diadiemdulich{Tendiadiem="Khánh Hòa", MienID = 2,
                    Mota="Khánh Hòa là một trong những trung tâm du lịch lớn của Việt Nam. Nhờ có bờ biển dài hơn 200 km và gần 200 hòn đảo lớn nhỏ cùng nhiều vịnh biển đẹp như Vân Phong, Nha Trang (một trong 12 vịnh đẹp nhất thế giới), Cam Ranh... với khí hậu ôn hòa, nhiệt độ trung bình 26 °C, có hơn 300 ngày nắng trong năm, và nhiều di tích lịch sử văn hóa và danh lam thắng cảnh, nên dịch vụ - du lịch là ngành phát triển nhất ở Khánh Hòa."},
                new Diadiemdulich{Tendiadiem="Thừa Thiên Huế", MienID = 2,
                    Mota="Thừa Thiên Huế là trung tâm văn hoá lớn và đặc sắc của Việt Nam. Thừa Thiên Huế có 5 danh hiệu UNESCO (1 di sản văn hoá thế giới, 1 di sản văn hóa phi vật thể, 3 di sản tư liệu thế giới)."},
                new Diadiemdulich{Tendiadiem="Nghệ An", MienID = 2,
                    Mota="Có bãi tắm Cửa Lò là khu nghỉ mát; Khu du lịch biển diễn Thành, huyện Diễn Châu - một bãi biển hoang sơ và lãng mạn; khu di tích Hồ Chí Minh, khu di tích đền Cuông. Năm 2008, Khu du lịch Bãi Lữ được đưa vào khai thác."},
                new Diadiemdulich{Tendiadiem="Hà Nội", MienID = 3,
                    Mota="So với các tỉnh, thành phố khác của Việt Nam, Hà Nội là một thành phố có tiềm năng để phát triển du lịch. Trong nội ô, cùng với các công trình kiến trúc, Hà Nội còn sở hữu một hệ thống bảo tàng đa dạng bậc nhất Việt Nam. Thành phố cũng có nhiều lợi thế trong việc giới thiệu văn hóa Việt Nam với du khách nước ngoài thông qua các nhà hát sân khấu dân gian, các làng nghề truyền thống,..."},
                new Diadiemdulich{Tendiadiem="Hải Phòng", MienID = 3,
                    Mota="Là một thành phố lớn và gần biển đảo, Hải Phòng là một mắt xích quan trọng trong tam giác kinh tế và du lịch Hải Phòng - Hà Nội - Quảng Ninh. Hải Phòng sở hữu nhiều điểm tham quan, khu du lịch chất lượng cao, đạt tầm quốc tế như khu nghỉ dưỡng (resort) 4 sao và sòng bạc (casino), sân golf Đồ Sơn, khu nghỉ dưỡng - sinh thái và bể bơi lọc nước biển tạo sóng lớn nhất châu Á tại Hòn Dáu,..."},
                new Diadiemdulich{Tendiadiem="Quảng Ninh", MienID = 3,
                    Mota="Quảng Ninh là một trong những trung tâm du lịch hàng đầu Việt Nam, giàu tiềm năng du lịch, sở hữu nhiều danh lam thắng cảnh nổi tiếng như: Vịnh Hạ Long, Vịnh Bái Tử Long, Đảo Cô Tô,..."},
                new Diadiemdulich{Tendiadiem="Lào Cai", MienID = 3,
                    Mota="Với 25 dân tộc cùng sinh sống, Lào Cai trở thành mảnh đất phong phú về bản sắc văn hóa, về truyền thống lịch sử, di sản văn hóa. Là tỉnh miền núi cao, đang phát triển nên Lào Cai còn giữ được cảnh quan môi trường đa dạng và trong sạch. Đây sẽ là điều quan trọng tạo nên một điểm du lịch lý tưởng đối với du khách trong và ngoài nước."},
                new Diadiemdulich{Tendiadiem="Điện Biên", MienID = 3,
                    Mota="Điện Biên là tỉnh giàu tiềm năng du lịch, đặc biệt là về lĩnh vực văn hóa – lịch sử. Nổi bật nhất là hệ thống di tích lịch sử gắn liền với chiến dịch Điện Biên Phủ gồm: Sở chỉ huy chiến dịch Điện Biên Phủ (Mường Phăng); các cứ điểm Him Lam, Bản Kéo, Độc Lập; các đồi A1, C1, E1 và khu trung tâm tập đoàn cứ điểm của Pháp (hầm Đờ-cát Tơ-ri).[4] Một điểm đến thu hút khách du lịch khác là thành Bản Phủ – đền thờ Hoàng Công Chất."},
                new Diadiemdulich{Tendiadiem="Thái Nguyên", MienID = 3,
                    Mota="Thái Nguyên từng là nơi tổ chức Năm Du lịch Quốc gia 2007. Với lợi thế là trung tâm vùng, hạ tầng cơ sở phát triển, với hơn 800 điểm đến là các di tích lịch sử, di tích danh thắng, di tích khảo cổ học, di tích kiến trúc nghệ thuật, di tích tín ngưỡng đã được kiểm kê, bảo vệ theo quy định của Luật Di sản văn hoá và 80 lễ hội được tổ chức vào dịp đầu xuân…"},
                new Diadiemdulich{Tendiadiem="Bắc Kạn", MienID = 3,
                    Mota="Bắc Kạn là tỉnh giàu tiềm năng du lịch bởi sự phong phú của tài nguyên, khoáng sản và nền văn hoá đậm đà bản sắc dân tộc miền núi đông bắc Việt Nam. Các địa điểm du lịch nổi tiếng: Hồ Ba Bể, Khu di tích lịch sử Nà Tu, Thác Roọm, Chùa Thạch Long, Di tích hầm bí mật Dốc Tiệm và Hội trường chữ U,..."},
                new Diadiemdulich{Tendiadiem="Ninh Bình", MienID = 3,
                    Mota="Quy hoạch du lịch Việt Nam đến năm 2030 xác định Ninh Bình là một trung tâm du lịch (Ninh Bình và phụ cận) với khu du lịch quốc gia là quần thể di sản thế giới Tràng An và 2 trọng điểm du lịch vườn quốc gia Cúc Phương và khu bảo tồn thiên nhiên Vân Long. Ninh Bình cũng là nơi được đăng cai năm năm Du lịch quốc gia 2020 với chủ đề Hoa Lư - cố đô ngàn năm."}
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
                    Diemden="An Giang", Ngaydi=DateTime.Parse("2021-01-15"), Thoigiandi=3,
                    Hinhanh="mieu_ba_chua_xu.jpg", Gianguoilon=1100000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                    Mota="Châu Đốc, một địa danh gắn liền với sự linh thiêng với thế phong thủy tiền tam giang, hậu thất sơn và huyền bí cùng nhiều tín ngưỡng tôn giáo tồn tại từ lâu đời. " +
                    "Nhắc tới mảnh đất này, người ta không thể không nhớ tới Miếu Bà Chúa Xứ Núi Sam là điểm du lịch tâm linh nổi tiếng không chỉ ở miền Tây Nam Bộ, mà ngay cả người Việt ở nước " +
                    "ngoài vẫn biết đến.",  Loaitour="Trong nước", TenHDV="Nguyễn Văn A",
                    Songuoi=9, Trangthai = "còn chỗ", Tournoibat=1, Thuocmien = 1},
                new Tour{Code="TMT291220B", Tentour="Tour Đầm Ô Loan", Diadiemkhoihanh="Đà Nẵng",
                    Diemden="Phú Yên", Ngaydi=DateTime.Parse("2021-02-14"), Thoigiandi=5,
                    Hinhanh="phu-yen-dam-o-loan.jpg", Gianguoilon=1250000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Ô Loan có diện tích 1570km, nổi danh là một đầm nước lợ nằm sát cửa biển với vẻ đẹp bình dị, mộc mạc và yên bình. " +
                    "Toạ lạc sát chân đèo Quán Cau; từ trên đèo nhìn xuống, đầm có hình dáng như một con chim phượng hoàng đang dang đôi cánh phủ rợp cả vùng.",
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn B", Songuoi=9, Trangthai = "còn chỗ", Tournoibat=1, Thuocmien = 2},
                new Tour{Code="TMB181220R", Tentour="Tour Thác Dải Yếm", Diadiemkhoihanh="Hải Phòng",
                    Diemden="Sơn La", Ngaydi=DateTime.Parse("2021-03-20"), Thoigiandi=4,
                    Hinhanh="thac-dai-yem.jpg", Gianguoilon=1400000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Vào những ngày hè oi bức, còn gì tuyệt vời hơn là đứng dưới chân thác hít thở không khí trong lành, hơi nước dịu mát phả vào mặt," +
                    " hay có thể hòa mình vào dòng nước mát lạnh sản khoái.",
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn A", Songuoi=9, Trangthai = "còn chỗ", Thuocmien = 3},
                new Tour{Code="TNM181220B", Tentour="Miếu Bà Chúa Xứ", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="An Giang", Ngaydi=DateTime.Parse("2021-02-10"), Thoigiandi=5,
                    Hinhanh="phu-yen-dam-o-loan.jpg", Gianguoilon=1150000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Châu Đốc, một địa danh gắn liền với sự linh thiêng với thế phong thủy tiền tam giang, hậu thất sơn và huyền bí cùng nhiều tín ngưỡng tôn giáo tồn tại từ lâu đời.",
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn B", Songuoi=9, Trangthai = "còn chỗ", Thuocmien = 1},
                new Tour{Code="TMT201220DF", Tentour="Ghềnh đá đĩa", Diadiemkhoihanh = "Đà Nẵng",
                        Diemden="Phú Yên", Ngaydi= DateTime.Parse("2020-12-22"), Thoigiandi=4,
                        Hinhanh="ghenh-da-dia.jpg", Gianguoilon=1250000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Ghềnh đá đĩa là một trong những địa điểm du lịch đáng chú ý khi tới Phú Yên. Tạo hóa đã ban cho nơi này một khung cảnh thiên nhiên kì thú. Nhìn từ xa ghềnh đá không khác gì một chồng đĩa được  xếp ngay ngăn bên bờ biển, như có bàn tay của con người tạo lên.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2},
                new Tour{Code="TMN201220DL", Tentour="Đồi thiên phúc", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Lâm Đồng", Ngaydi= DateTime.Parse("2020-12-30"), Thoigiandi=3,
                        Hinhanh="doi-thien-phuc-duc.jpg", Gianguoilon=9000000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Đồi thiên phúc Đức có lẽ không còn là địa điểm du lịch xa lạ với nhiều bạn trẻ. Nằm  cách trung tâm thành phố hoa khoảng 3 km, ngọn đồi cao du khách lên đây cắm trại qua đêm, chụp hình vào buổi sớm mai cũng rất đẹp.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2},
                new Tour{Code="TMT231220NT", Tentour="Thánh địa Mỹ Sơn", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Quảng Nam", Ngaydi= DateTime.Parse("2021-02-24"), Thoigiandi=4,
                        Hinhanh="my-son.jpg", Gianguoilon=12000000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Được phát hiện từ những năm 1885, thánh địa Mỹ Sơn là một trong những di sản của Việt Nam được UNESCO công nhận là Di sản Văn hóa Thế Giới vào năm 1999.",
                        Loaitour="Trong nước", TenHDV="Nguyễn Trọng Sơn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2},
                new Tour{Code="TMB201220HG", Tentour="Phố cổ Đồng Văn", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Hà Giang", Ngaydi= DateTime.Parse("2021-02-22"), Thoigiandi=3,
                        Hinhanh="pho-co-dong-van.jpg", Gianguoilon=4500000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Phố cổ Đồng Văn là một thung lũng đẹp cổ kính, trầm mặc được bao bọc bởi núi đồi và cây xanh. Đó là những ngôi nhà 2 tầng trình tường, một lối kiến trúc phổ biến của Hà Giang xưa.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=3, Tournoibat=1},
                new Tour{Code="TMB191220YM", Tentour="Rừng thông Yên Minh", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Hà Giang", Ngaydi= DateTime.Parse("2021-01-22"), Thoigiandi=5,
                        Hinhanh="rung-thong-yen-minh.jpg", Gianguoilon=11750000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Rừng thông Yên Minh được mệnh danh là Đà Lạt thứ 2 ở phía Bắc với những cây thông xanh rì, cao ngút hướng thẳng lên trời.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=3},
                new Tour{Code="TMN201220GA", Tentour="Ga Đà Lạt", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Lâm Đồng", Ngaydi= DateTime.Parse("2021-01-20"), Thoigiandi=3,
                        Hinhanh="ga-da-lat.jpg", Gianguoilon=4250000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                        Mota="Nhà Ga Đà Lạt hay còn gọi là nhà Ga xe lửa có công trình đường sắt từ thời Pháp. Nên nó luôn mang trong mình một nét đẹp cổ tích pha lẫn sự hiện đại mà con người tạo thành.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2},
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
