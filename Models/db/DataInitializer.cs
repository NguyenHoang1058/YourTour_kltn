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
                new Diadiemdulich{Tendiadiem="Khánh Hòa", MienID = 2,
                    Mota="Khánh Hòa là một trong những trung tâm du lịch lớn của Việt Nam. Nhờ có bờ biển dài hơn 200 km và gần 200 hòn đảo lớn nhỏ cùng nhiều vịnh biển đẹp như Vân Phong, Nha Trang (một trong 12 vịnh đẹp nhất thế giới), Cam Ranh... với khí hậu ôn hòa, nhiệt độ trung bình 26 °C, có hơn 300 ngày nắng trong năm, và nhiều di tích lịch sử văn hóa và danh lam thắng cảnh, nên dịch vụ - du lịch là ngành phát triển nhất ở Khánh Hòa."},
                new Diadiemdulich{Tendiadiem="Thừa Thiên Huế", MienID = 2,
                    Mota="Thừa Thiên Huế là trung tâm văn hoá lớn và đặc sắc của Việt Nam. Thừa Thiên Huế có 5 danh hiệu UNESCO (1 di sản văn hoá thế giới, 1 di sản văn hóa phi vật thể, 3 di sản tư liệu thế giới)."},
                new Diadiemdulich{Tendiadiem="Nghệ An", MienID = 2,
                    Mota="Có bãi tắm Cửa Lò là khu nghỉ mát; Khu du lịch biển diễn Thành, huyện Diễn Châu - một bãi biển hoang sơ và lãng mạn; khu di tích Hồ Chí Minh, khu di tích đền Cuông. Năm 2008, Khu du lịch Bãi Lữ được đưa vào khai thác."},
                new Diadiemdulich{Tendiadiem="Vũng Tàu", MienID = 2, Hinhanh="2-vung-tau.jpg",
                    Mota="Du lịch Đắk Lắk đang có lợi thế với nhiều địa danh cho phép khai thác theo hướng kết hợp cảnh quan, sinh thái, môi trường và truyền thống văn hoá của nhiều dân tộc trong tỉnh như hồ Lắk, Thác Gia Long, cụm du lịch Buôn Đôn, Thác Krông Kmar, Diệu Thanh, Tiên Nữ… bên cạnh các vườn quốc gia, khu bảo tồn thiên nhiên Chư Yang Sin, Easo..."},
                new Diadiemdulich{Tendiadiem="Phú Quốc", MienID = 2,Hinhanh="1-phu-quoc.jpg",
                    Mota="Tiềm năng du lịch của Gia Lai rất phong phú, đa dạng với núi rùng cao có nhiều cảnh quan tự nhiên và nhân tạo. Rừng nguyên sinh nơi đây có hệ thống động thực vật phong phú, nhiều ghềnh thác, suối, hồ như Biển Hồ là một thắng cảnh nổi tiếng, ngoài ra có chùa Minh Thành (Gia Lai). Nhiều đồi núi như cổng trời Mang Yang, đỉnh Hàm Rồng, thác Hang Dơi và thác K50 (Huyện Kbang). Các cảnh quan nhân tạo có các rừng cao su, đồi chè, cà phê bạt ngàn. Kết hợp với tuyến đường rừng, có các tuyến dã ngoại bằng thuyền trên sông, cưỡi voi xuyên rừng,..."},
                new Diadiemdulich{Tendiadiem="Phan Thiết", MienID = 2, Hinhanh="3-phan-thiet.jpg",
                    Mota="Đà Nẵng là một thành phố có nhiều tiềm năng để phát triển du lịch, là trung tâm du lịch lớn hàng đầu của Việt Nam. Phía bắc thành phố được bao bọc bởi núi cao với đèo Hải Vân được mệnh danh là Thiên hạ đệ nhất hùng quan."},
                new Diadiemdulich{Tendiadiem="Đà Lạt", MienID = 2,Hinhanh="4-da-lat.jpg",
                    Mota="Lâm Đồng có nhiều thắng cảnh nổi tiếng như các thác nước tại huyện Đức Trọng và những thắng cảnh thiên nhiên tại Đà Lạt như Hồ Than Thở, Hồ Xuân Hương."},
                new Diadiemdulich{Tendiadiem="Đà Nẵng", MienID = 2, Hinhanh ="7-da-nang.jpg",
                    Mota="Là một tỉnh ven biển, khí hậu quanh năm nắng ấm, nhiều bãi biển sạch đẹp, cảnh quan tự nhiên và thơ mộng, giao thông thuận lợi, Bình Thuận đang là một trong những trung tâm du lịch lớn của Việt Nam."},
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

                //tour miền nam
                new Tour{Code="TMN201220A", Tentour="Tour Tây An Cổ Tự - Miếu Bà Chúa Xứ", Diadiemkhoihanh="TP Hồ Chí Minh",
                    Diemden="An Giang", Ngaydi=DateTime.Parse("2021-01-15"), Thoigiandi=3,
                    Hinhanh="mieu_ba_chua_xu.jpg", Gianguoilon=1100000, Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf",
                    Mota="Châu Đốc, một địa danh gắn liền với sự linh thiêng với thế phong thủy tiền tam giang, hậu thất sơn và huyền bí cùng nhiều tín ngưỡng tôn giáo tồn tại từ lâu đời. " +
                    "Nhắc tới mảnh đất này, người ta không thể không nhớ tới Miếu Bà Chúa Xứ Núi Sam là điểm du lịch tâm linh nổi tiếng không chỉ ở miền Tây Nam Bộ, mà ngay cả người Việt ở nước " +
                    "ngoài vẫn biết đến.",  Loaitour="Trong nước", TenHDV="Nguyễn Văn A",
                    Songuoi=9, Trangthai = "còn chỗ", Thuocmien = 1},
                new Tour{Code="TMT291220B", Tentour="Tour Đầm Ô Loan", Diadiemkhoihanh="Đà Nẵng",
                    Diemden="Phú Yên", Ngaydi=DateTime.Parse("2021-02-14"), Thoigiandi=5,
                    Hinhanh="phu-yen-dam-o-loan.jpg", Gianguoilon=1250000,
                    Lichtrinh="/docs/lichtrinh/template_ctrinhtour_bluesky.pdf", Mota="Ô Loan có diện tích 1570km, nổi danh là một đầm nước lợ nằm sát cửa biển với vẻ đẹp bình dị, mộc mạc và yên bình. " +
                    "Toạ lạc sát chân đèo Quán Cau; từ trên đèo nhìn xuống, đầm có hình dáng như một con chim phượng hoàng đang dang đôi cánh phủ rợp cả vùng.",
                    Loaitour="Trong nước", TenHDV="Nguyễn Văn B", Songuoi=9, Trangthai = "còn chỗ", Thuocmien = 2},
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

                //tour miền Trung
                new Tour{Code="TMT060120DF", Tentour="Huế - La Vang - 2 Động Phong Nha & Thiên Đường - Bà Nà - Cầu Vàng - Hội An - Đà Nẵng", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Đà Nẵng", Ngaydi= DateTime.Parse("2020-01-06"), Thoigiandi=5,
                        Hinhanh="danang.PNG", Gianguoilon=6390000, Lichtrinh="danang-hue.pdf",
                        Mota="Đại Nội Huế rộng lớn nơi hoàng cung xưa của các vua chúa Triều Nguyễn. Động Phong Nha được xem như chốn thần tiên bởi hệ thống núi đá vôi và sông ngầm dài nhất thế giới." +
                        " Động Thiên Đường kỳ ảo như hoàng cung dưới lòng đất.Bà Nà Hills với không gian như làng Pháp thu nhỏ đa sắc màu và Cầu Vàng mới siêu hot. Phố cổ Hội An với lung linh sắc màu của đèn lồng và những trò chơi dân gian đặc sắc.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2},

                new Tour{Code="TMT201220DF", Tentour="Đà Nẵng - Bà Nà - Cầu Vàng - Hội An - KDL Thần Tài - Huế", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Đà Nẵng", Ngaydi= DateTime.Parse("2020-01-07"), Thoigiandi=4,
                        Hinhanh="cau-vang.PNG", Gianguoilon=5390000, Lichtrinh="danang.pdf",
                        Mota="Đà Nẵng một trong những trung tâm du lịch hàng đầu miền trung là địa điểm du lịch mà bạn không thể bỏ qua. Với những bãi biển dài, xanh trong, không khí trong lành và những món ăn ngon lành. " +
                        "Với những địa điểm du lịch Đà Nẵng đẹp đến quên lối về ngay và lên đường khám phá thành phố đáng sống nhất Việt Nam.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2, Tournoibat=1},

                new Tour{Code="TMN201220DL", Tentour="Đà Lạt - Puppy Farm - Phân Viện Sinh Học - Đồi Chè Cầu Đất - Đường Hầm Đất Sét", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Đà Lạt", Ngaydi= DateTime.Parse("2020-12-31"), Thoigiandi=3,
                        Hinhanh="puppy-farm.jpg", Gianguoilon=3250000, Lichtrinh="lichtrinh-dalat-puppyfarm.pdf",
                        Mota="Đà Lạt mộng mơ khiến bao người ngơ ngẩn bởi nơi đây ăm ắp nắng vàng, bầu trời xanh ngắt, khí trời se lạnh thả hồn cho bao chuyện tình lãng mạn, nơi chốn hẹn hò của những trái tim khát khao. " +
                        "Không chỉ dừng nơi ấy, Quý khách sẽ không khỏi ngỡ ngàng khi được tận mắt thấy được sự mênh mông của núi đồi, sự hùng vĩ của thác nước, sự êm ả của mặt hồ, sự đắm thắm của những bông hoa đang hé nụ,…" +
                        " những tuyệt tác mà thiên nhiên ưu ái dành cho xứ sở sương mù.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Tournoibat=1, Thuocmien=2},

                new Tour{Code="TMT231220NT", Tentour="Phú Yên - Quy Nhơn", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Phú Yên", Ngaydi= DateTime.Parse("2021-01-08"), Thoigiandi=3,
                        Hinhanh="ghenh-da-dia.jpg", Gianguoilon=5300000, Lichtrinh="phuyen-quynhon.pdf",
                        Mota="Du lịch Bình Định với khung cảnh thiên nhiên tuyệt đẹp, nhiều đặc sản hấp dẫn sẽ là điểm dừng chân thú vị cho du khách muốn tránh xa những nơi ồn ào, đông đúc. " +
                        "Bình Định không chỉ có nhiều bãi biển và danh lam thắng cảnh đẹp mà còn được mệnh danh là vùng đất võ với môn võ cổ truyền Bình Định lưu danh sử sách, những điểm tham quan mang đậm tính lịch sử hào hùng của dân tộc.",
                        Loaitour="Trong nước", TenHDV="Nguyễn Trọng Sơn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=2},

                //tour miền bắc
                new Tour{Code="TMB201220HG", Tentour="Hà Nội - Đông Bắc: Hà Giang - Lũng Cú - Đồng Văn - Mã Pí Lèng - Mèo Vạc - Cao Bằng - Thác Bản Giốc - Hồ Ba Bể", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Hà Nội", Ngaydi= DateTime.Parse("2021-01-05"), Thoigiandi=6,
                        Hinhanh="pho-co-dong-van.jpg", Gianguoilon=8790000, Lichtrinh="hanoi-dongbac.pdf",
                        Mota="Phố cổ Đồng Văn là một thung lũng đẹp cổ kính, trầm mặc được bao bọc bởi núi đồi và cây xanh. Đó là những ngôi nhà 2 tầng trình tường, một lối kiến trúc phổ biến của Hà Giang xưa.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=3, Tournoibat=1},
                new Tour{Code="TMB191220YM", Tentour="HÀ NỘI - TÂY BẮC: NGHĨA LỘ - TÚ LỆ - MÙ CANG CHẢI - YÊN BÁI - SAPA - ĐIỆN BIÊN - SƠN LA - MỘC CHÂU - MÙNG 2 TẾT", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Tây Bắc", Ngaydi= DateTime.Parse("2021-02-13"), Thoigiandi=6,
                        Hinhanh="taybac.PNG", Gianguoilon=13990000, Lichtrinh="hanoi-taybac.pdf",
                        Mota="Mù Cang Chải là một huyện vùng cao của tỉnh Yên Bái, nằm Cách Hà Nội gần 300 km về hướng Tây Bắc, Mù Cang Chải, Yên Bái là điểm đến ưa thích của người yêu thiên nhiên và thích thưởng ngoạn không khí vùng cao. " +
                        "Hàng năm cứ vào khoảng tháng 9, hàng ngìn người đến đây để được chiêm ngưỡng những thửa ruộng bậc thang đẹp nhất cả nước.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=3},
                new Tour{Code="TMN201220GA", Tentour="Hà Nội - Đông Tây Bắc: Nậm Ty - Nậm Hồng - Bắc Hà - Mù Cang Chải - Tú Lệ - Phú Thọ", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Đông Tây Bắc", Ngaydi= DateTime.Parse("2021-02-12"), Thoigiandi=6,
                        Hinhanh="dongtaybac.PNG", Gianguoilon=4250000, Lichtrinh="hanoi-dongtaybac.pdf",
                        Mota="Hành trình khám phá vùng núi Tây Bắc với cảnh sắc thiên nhiên hoang sơ tuyệt đẹp hay Đông Bắc với những danh thắng đẹp nổi tiếng, thơ mộng đến ngỡ ngàng sẽ là một sự lựa chọn khó có thể bỏ qua cho du khách trong chuyến du lịch nghỉ dưỡng của mình.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=3, Tournoibat=1},
                new Tour{Code="TMN201220DTB", Tentour="Hà Nội - Đông Tây Bắc: Nậm Ty - Nậm Hồng - Bắc Hà - Mù Cang Chải - Tú Lệ - Phú Thọ", Diadiemkhoihanh = "Tp Hồ Chí Minh",
                        Diemden="Đông Tây Bắc", Ngaydi= DateTime.Parse("2021-02-24"), Thoigiandi=6,
                        Hinhanh="dongtaybac.PNG", Gianguoilon=6250000, Lichtrinh="hanoi-dongtaybac.pdf",
                        Mota="Hành trình khám phá vùng núi Tây Bắc với cảnh sắc thiên nhiên hoang sơ tuyệt đẹp hay Đông Bắc với những danh thắng đẹp nổi tiếng, thơ mộng đến ngỡ ngàng sẽ là một sự lựa chọn khó có thể bỏ qua cho du khách trong chuyến du lịch nghỉ dưỡng của mình.",
                        Loaitour="Trong nước", TenHDV="Lê Tấn", Songuoi=9, Trangthai="còn chỗ", Thuocmien=3, Tournoibat=1},
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

            //
            // init data table KinhNghiemDuLich
            //

            var kndl = new KinhNghiemDuLich[]
            {
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Đà Lạt", HinhAnh="gd_151113_kinh-nghiem-du-lich-da-lat.jpg",
                Noidung="Cách thành phố Hồ Chí Minh 300km, Đà Lạt là thành phố lý tưởng để bạn trốn cái nóng mùa hè hay tận hưởng cảm giác mùa đông se lạnh. " +
                "Đà Lạt nổi tiếng với những thắng cảnh như Hồ Xuân Hương, Thung Lũng Vàng, Đồi Mộng Mơ, Thung Lũng Tình Yêu, Langbiang… tất cả đã tạo nên một Đà Lạt lung linh, huyền diệu. " +
                "Đà Lạt có nhiều dân tộc anh em như Hoa, Cơ Ho, Tày, Nùng, Chăm nhưng trong đó chiếm đại da số vẫn là người kinh."},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Đà Nẵng", HinhAnh="gd_151113_kinh-nghiem-du-lich-da-nang.jpg",
                Noidung="Đà Nẵng là thành phố thuộc vùng duyên hải Nam Trung Bộ, thành phố vừa hiện đại, sạch đẹp vừa yên bình này nổi tiếng với những tên gọi như thành phố đáng sống nhất Việt Nam, " +
                "thành phố của những chiếc cầu hay thành phố của những bãi biển. Với chiều dài hơn 60km, biển Đà Nẵng được tạp chí Forbes của Mỹ bình chọn là 1 trong 6 bãi biển quyến rũ nhất hành tinh, " +
                "đến đây du khách còn được tham quan những thắng cảnh ấn tượng như bán đảo Sơn Trà, khu du lịch Bà Nà Hills, danh thắng Ngũ Hành Sơn,..."},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Hạ Long", HinhAnh="gd_151114_kinh-nghiem-du-lich-ha-long.jpg",
                Noidung="Hạ Long là điểm đến du lịch bạn nên đến một lần trong đời, bởi ngoài thưởng ngoạn phong cảnh thiên nhiên tuyệt đẹp của Vịnh Hạ Long cùng với hệ thống các hang động, bạn còn trải nghiệm những hoạt động như ngủ đêm trên du thuyền, " +
                "chèo kayak, tham quan những điểm đến linh thiêng như Yên Tử, Chùa Ba Vàng và không thể cưỡng lại với những món ăn làm mê hoặc lòng người như chả mực, hàu nướng, sá sùng…"},
               
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Huế", HinhAnh="gd_151114_kinh-nghiem-du-lich-hue.jpg",
                Noidung="Thành phố Huế nằm trên dải đất miền Trung được biết đến với Quần thể Di tích Cố đô Huế - Di sản Văn hóa Thế giới và Nhã nhạc Cung đình Huế - Kiệt tác phi vật thể và truyền miệng của nhân loại. " +
                "Ngoài ra, Huế còn nổi tiếng với những lăng tẩm, món ăn ngon và làng nghề truyền thống lâu đầu."},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Ninh Bình", HinhAnh="gd_151114_kinh-nghiem-du-lich-ninh-binh.jpg",
                Noidung="Ninh Bình là một trong ba điểm đến hấp dẫn nhất ở miền Bắc (sau Hạ Long và Sa Pa), bởi nơi đây có nhiều thắng cảnh hùng vĩ và tráng lệ, đó là các danh thắng đất ngập nước Tràng An, Tam Cốc, " +
                "Vân Long hay những công trình kiến trúc đẹp và đồ sộ như Chùa Bái Đính, nhà thờ Phát Diệm, Cố Đô Hoa Lư và vườn quốc gia Cúc Phương dành cho những ai thích thiên nhiên và khám phá. " +
                "Vùng đất Ninh Bình còn nổi tiếng với nhiều danh nhân đất Việt tiêu biểu như anh hùng dân tộc Đinh Bộ Lĩnh, Lê Hoàn, Lê…"},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Quảng Bình", HinhAnh="gd_151202_kinh-nghiem-du-lich-quang-binh.jpg",
                Noidung="Quảng Bình, mảnh đất thuộc dải đất miền Bắc Trung Bộ Việt Nam, nơi đây được xem là thủ đô của hang động bởi hệ thống hang động dày đặt, hệ thống thạch nhũ kỳ ảo, tuyệt đẹp như động Phong Nha, " +
                "động Thiên Đường hay những hang động dành cho những du khách ưu mạo hiểm, khám phá như hang Sơn Đoòng, hang Va, động Tiên Sơn… Ngoài ra, Quảng Bình còn nổi tiếng với biển Nhật Lệ êm đềm, bãi Đá Nhảy kỳ thú hay Vũng Chùa bình yên."},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Nha Trang", HinhAnh="gd_151214_kinh-nghiem-du-lich-nha-trang.jpg",
                Noidung="Vốn nổi tiếng là thành phố biển du lịch của Việt Nam, Nha Trang có rất nhiều những danh lam thắng cảnh hút hồn các du khách bởi vẻ đẹp tuyệt vời. Khu giải trí Vinpearl Land với nhiều trò chơi thú vị và hấp dẫn, đảo Hòn Mun với những rặng san hô đẹp lộng lẫy, " +
                "còn Hòn Tằm thu hút du khách với bãi tắm tuyệt đẹp hay dịch vụ tắm bùn khoáng tại I-Resort, khu du lịch Trăm Trứng sẽ giúp du khách thư giãn sau ngày dài. " +
                "Đến Nha Trang không quên thưởng thức đặc sản nổi tiếng phố biển như bún sứa, nem…"},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Quảng Nam", HinhAnh="gd_151214_kinh-nghiem-du-lich-quang-nam.jpg",
                Noidung="Hội An là một đô thị cổ của Việt Nam, là trung tâm giao thương chính của miền trung cuối thế kỷ 16 đến thế kỷ 17. Đến với Hội An bạn sẽ được ngắm nhìn những ngôi nhà cổ hàng trăm năm tuổi, những bãi biển đẹp tại Cửa Đại và Cù Lao Chàm. " +
                "Quảng Nam là vùng đất còn lưu giữ nhiều dấu tích của nền văn hóa Chăm-pa, là nơi giao thoa của những sắc thái văn hóa giữa hai miền và giao lưu văn hóa với bên ngoài, điều này góp phần làm cho Quảng Nam giàu truyền thống văn hóa, độc đáo về bản sắc."},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Phan Thiết", HinhAnh="gd_151114_kinh-nghiem-du-lich-phan-thiet.jpg",
                Noidung="Phan Thiết là thành phố trực thuộc tỉnh Bình Thuận, nơi đây có Mũi Né nổi tiếng là thủ đô resort trong cả nước, được biết đến vào năm 1995 khi xảy ra hiện tượng nhật thực toàn phần. " +
                "Phan Thiết cách TP.HCM 200km nên thuận lợi cho việc tham quan, nghĩ dưỡng vào cuối tuần."},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Vũng Tàu", HinhAnh="gd_151214_kinh-nghiem-du-lich-vung-tau.jpg",
                Noidung="Vũng Tàu là thành phố thuộc tỉnh Bà Rịa - Vũng Tàu, ở vùng Đông Nam Bộ Việt Nam. Cách TPHCM 100km, Vũng Tàu thích hợp cho những chuyến nghỉ ngơi, thư giãn vào cuối tuần hay các dịp lễ. " +
                "Đến đây, ngoài tắm biển, tham quan bạn sẽ bị thu hút bởi những món ăn ngon và một thành phố năng động, mến khách. Cách Vũng Tàu 200km là Côn Đảo với những bãi tắm hoang sơ, tuyệt đẹp, " +
                "Côn Đảo thích hợp cho những ai thích tìm hiểu văn hóa, lịch sử và tìm một cảm giác bình yên trong lòng."},
                new KinhNghiemDuLich{Tieude="Kinh nghiệm du lịch Hà Nội",
                    HinhAnh="gd_151114_kinh-nghiem-du-lich-ha-noi.jpg",
                    Noidung="Thành phố Hà Nội là Thủ đô ngàn năm văn hiến với những di tích cổ xưa, cuộc sống yên bình. Nếu đã một lần du lịch Hà Nội, chắc chắn bạn không thể nào quên không khí đặc trưng nơi đây, với Hồ Gươm, Hồ Tây, " +
                    "những quán cafe trầm mặc, những con đường nhỏ và những gánh hàng rong.",
                    Tieude1="Phương tiện đi lại",
                    Noidung1="Từ TP.HCM, Đà Nẵng hay Cần Thơ thì phương tiện thuận tiện và tiết kiệm thời gian nhất bạn nên chọn là máy bay, " +
                    "bởi hiện nay các hãng hàng không Vietjet, Jestar hay Vietnam Airlines luôn có nhiều chương trình khuyến mãi hấp dẫn, " +
                    "bạn nên đăng ký địa chỉ mail để các hãng hàng không gởi thông tin khuyến mãi nhé. " +
                    "Ngoài ra, bạn có thể chọn xe lửa tàu Thống Nhất Bắc Nam tuy nhiên lưu ý bạn chỉ nên chọn khi có nhiều thời gian tham quan." +
                    "Từ sân bay Nội Bài về trung tâm khoảng 30km, bạn có thể đi taxi nếu đi đông hay chọn xe bus trung chuyển của hai hãng hàng không nội địa là Jetstar và VietJet Air với giá mềm hơn. " +
                    "Trong trung tâm Hà Nội để tham quan bạn nên thuê xe máy để di chuyển, ngoài ra còn 2 phương tiện cũng khá độc đáo để thăm thủ đô là xích lô và xe điện.",
                    Tieude2="Nên đi Hà Nội mùa nào?",
                    Noidung2="Thời gian thích hợp nhất để du lịch Hà Nội là vào tháng 9 đến tháng 11 hoặc từ tháng 3 đến tháng 4, đó là lúc chuyển mùa thời tiết ấm áp và dễ chịu, không quá nắng gắt hay hanh khô. " +
                    "Tuyệt vời nhất là vào mùa thu, Hà Nội như khoác một chiếc áo mới, dịu dàng và lãng mạng nhất trong năm.",
                    Tieude3="Những điểm nào nên tham quan khi đến Hà Nội",
                    Noidung3="Hà Nội có rất nhiều điểm tham quan di tích lịch sử - văn hóa để bạn tham quan tìm hiểu, ngay khu vực trung tâm thủ đô bạn hãy ghé tham quan Hồ Hoàn Kiếm, ngắm tháp Rùa, đền Ngọc Sơn, cầu Thê Húc. " +
                    "Chiêm ngưỡng và chụp hình tại Nhà thờ lớn Hà Nội, Nhà hát lớn Hà Nội, khu phố Cổ. Xa hơn một chút tầm 3km bạn hãy viếng Lăng Bác (lưu ý Lăng không mở thứ 2, 6 hàng tuần) thăm quan Bảo tàng Hồ Chí Minh, " +
                    "nhà sàn Bác Hồ, chùa Một Cột, quảng trường Ba Đình; tiếp tục tham quan Văn Miếu - Quốc Tử Giám - nơi thờ Khổng Tử và các bậc hiền triết của Nho Giáo, Hoàng Thành Thăng Long.Ngày hôm sau tại Hà Nội bạn hãy ghé khu vực Hồ Tây, " +
                    "tham quan Đền Quán Thánh, chùa Trấn Quốc. Thích tìm hiểu về văn hóa các dân tộc thì bạn ghé tham quan Bảo tàng dân tộc học Việt Nam, nếu còn thời gian tại Hà Nội bạn hãy ghé các khu vực lân cận như làng gốm Bát Tràng (cách trung tâm 20km), " +
                    "làng cổ Đường Lâm (cách trung tâm 45km) nơi còn lưu giữ những nét cổ xưa của một làng quê miền Bắc.",
                    Tieude4="Hà Nội có lễ hội gì đặc sắc?",
                    Noidung4="Lễ hội Chùa Hương là lễ hội đặc sắc nhất ở Hà Nội, được diễn ra từ mùng 6 tháng Giêng đến hết tháng 3 âm lịch, tuy nhiên trong giai đoạn lễ hội thường rất đông nên bạn có thể đi dịp trước tết dương lịch và nguyên đán. " +
                    "Ngoài ra, Hà Nội còn có các lễ hội như Hội gò Đống Đa mùng 5 Tết tại gò Đống Đa, lễ hội đền Gióng Sóc Sơn ngày 6/1 âm lịch, lễ hội Cổ Loa diễn ra từ ngày 6 đến 16 tháng giêng âm lịch (chính hội ngày 6).",
                    Tieude5="Khách sạn và ẩm thực địa phương",
                    Noidung5="Hà nội có rất nhiều khách sạn để bạn lựa chọn, để tham khảo các khách sạn hợp với túi tiền và vị trí gần trung tâm phố cổ bạn nên tham khảo trước trên các web tư vấn khách sạn như Agoda hay Tripadvisor rất hữu ích. " +
                    "Ngoài ra, mình tư vấn cho bạn một số khách sạn như Asian Star, Chaerry 2, Crysral 2 sao hay khách sạn 3 sao như Boss, ATS, Church Boutique.Ẩm thực Hà Nội luôn hấp dẫn với những món ăn đậm chất riêng." +
                    " Một số món ăn không thể bỏ qua khi du lịch Hà Nội: phở gánh Hàng Trống, chả cá Lã Vọng, bún chả, bún thang, bánh cốm, bánh cuốn, bún đậu mắm tôm.",
                    Tieude6="Những điều lưu ý",
                    Noidung6="Miền Bắc có bốn mùa rõ rệt trong năm, chính vì vậy thời tiết là điều bạn cần quan tâm khi đi du lịch Hà Nội. Mùa hè trời thường rất nắng nóng, mùa đông thì rất lạnh, mùa xuân thì hay mưa phùn, ẩm ướt. " +
                    "Hãy có một tấm bản đồ để xác định quãng đường đi, tránh việc bị người khác (xe ôm, taxi) đưa đi lòng vòng rồi tính tiền. Hãy hỏi về giá cả trước khi sử dụng bất cứ dịch vụ nào. Cách tốt nhất là bạn nên nhờ lễ tân tại khách sạn mình ở tư vấn, " +
                    "giúp đỡ khi cần thông tin. Để thưởng thức hết vẻ đẹp thiên nhiên, kiến trúc kỳ vĩ ở các chùa lớn thì không nên đi các chùa vào mùa lễ hội."},
            };
            foreach (KinhNghiemDuLich item in kndl)
            {
                context.KinhNghiemDuLiches.Add(item);
            }
            context.SaveChanges();

            //
            // init data table Tin Tức
            //

            var tt = new TinTuc[]
            {
                new TinTuc {Tieude="Xuân trọn niềm vui cùng tour du lịch Đà Lạt 3 ngày 2 đêm",
                    NgayDang=DateTime.Parse("2020-12-25"), Hinhanh="du-lich-da-lat.jpg", Noidung="“Cả nước du xuân – Khởi hành Tết mới”, tháng 1 này chúng ta hãy cùng nhau làm một chuyến du lịch Đà Lạt thôi nào. " +
                    "Và nếu bạn ngại việc chen lấn tại các địa điểm check-in sống ảo ở Đà Lạt đang làm mưa làm gió trên các trang mạng xã hội những ngày qua, thì có thể tham khảo ngay những điểm đến này."},
                new TinTuc {Tieude="Tour chùa Hương và những điểm hành hương nổi tiếng ở miền Bắc",
                    NgayDang=DateTime.Parse("2020-12-24"), Hinhanh="du-lich-phu-quoc.jpg", Noidung="Phú Quốc là thành phố đảo đầu tiên của Việt Nam. " +
                    "Du lịch Phú Quốc từ lâu đã được du khách biết đến là thiên đường nghỉ dưỡng ở phía Nam Việt Nam rất hút khách khi sở hữu nhiều bãi biển đẹp như Bãi Sao, Bãi Trường với một Sunset Sanato ma mị; " +
                    "những hòn đảo yên bình, hoang sơ và các khu vui chơi đẳng cấp Quốc tế."},
                new TinTuc {Tieude="Về miền Tây đón Tết Tây miệt vườn, ngại gì không thử",
                    NgayDang=DateTime.Parse("2020-12-26"), Hinhanh="du-xuan-don-tet-mien-tay.jpg", Noidung="Miền Tây được biết đến là vùng đất dành riêng cho những du khách muốn “du lịch vườn”, Tết này về miền Tây bạn không những được tận hưởng một kỷ nghỉ đặc biệt với những trải nghiệm độc đáo, " +
                    "mà còn được chiêm ngưỡng những vườn hoa rực rỡ đẹp nhất trong năm."},
                new TinTuc {Tieude="48 giờ khám phá những địa điểm du lịch Ninh Thuận nổi tiếng",
                    NgayDang=DateTime.Parse("2020-12-25"), Hinhanh="48-gio-du-lich-ninh-thuan-vinh-vinh-hy.jpg", Noidung="Vịnh Vĩnh Hy, Ninh Chữ là những cái tên vô cùng nổi bật của du lịch Ninh Thuận, " +
                    "thu hút du khách bằng vẻ đẹp hoang sơ của những bãi biển dài cát trắng mịn màng, làn nước trong xanh như ngọc bích,…"},
                new TinTuc {Tieude="Top 8 địa điểm du lịch Hà Nội, Ninh Bình nổi tiếng bốn phương",
                    NgayDang=DateTime.Parse("2020-12-27"), Hinhanh="du-lich-ha-noi-ninh-binh.jpg", Noidung="Nếu Hà Nội được biết đến là vùng đất Thủ đô ngàn năm văn hiến đậm đà bản sắc dân tộc, " +
                    "thì Ninh Bình lại nổi tiếng là nơi có cảnh sắc non nước hữu tình và là một trong những địa điểm du xuân du lịch hành hương hút khách nhất ở miền Bắc. " +
                    "Du lịch Hà Nội, du lịch Ninh Bình bạn nhất định đừng bỏ 8 địa danh nổi tiếng này."},
                new TinTuc {Tieude="Du xuân, du lịch Tết Tây ở Nha Trang có gì thú vị?",
                    NgayDang=DateTime.Parse("2020-12-27"), Hinhanh="vinwonders-nha-trang.jpg", Noidung="Địa điểm du lịch Nha Trang không những nổi tiếng với những bãi biển tuyệt đẹp mà còn gây ấn tượng bởi các công trình kiến trúc độc đáo đẹp đến mê hồn. " +
                    "Trong 3 ngày nghỉ Tết Tây năm nay, bạn hãy đưa gia đình, những người thân yêu của mình đến đây du xuân nhé."},
                new TinTuc {Tieude="Bật mí những địa điểm du lịch ngày đầu năm mới thú vị",
                    NgayDang=DateTime.Parse("2020-12-25"), Hinhanh="dia-diem-du-xuan-ly-tuong.jpg", Noidung="Những ngày đầu năm mới, nếu bạn không có nhiều thời gian để đi du lịch ở phương xa, " +
                "thì hãy tham khảo ngay một vài địa điểm du xuân gần nhưng vô cùng thú vị trong bài viết này."},
                new TinTuc {Tieude="Tour chùa Hương và những điểm hành hương nổi tiếng ở miền Bắc",
                    NgayDang=DateTime.Parse("2020-12-26"), 
                    Hinhanh="tour-chua-huong.jpg", 
                    Noidung="Chùa Hương được biết đến là địa điểm hành hương bậc nhất tại Việt Nam. " +
                    "Do đó, nếu có dịp đi xuyên Việt để hành hương, bạn đừng quên tham gia tour chùa Hương đến với các ngôi chùa lịnh thiêng trong quần thể thắng cảnh này, " +
                    "cũng như những điểm hành hương nổi tiếng khác ở miền Bắc như chùa Đồng Yên Tử, chùa Bái Đính,…",
                    Tieude1="Chùa Thiên Trù",
                    Hinhanh1="camnhi-203528053526-chua-thien-tru.jpg",
                    Noidung1="Đây là ngôi chùa được xem là điểm đến chính của nhiều du khách đi tour chùa Hương." +
                    " Chùa được xây dựng từ thời vua Vua Lê Thánh Tông, uy nghi, tráng lệ như một lâu đài giữa núi rừng Hương Sơn. " +
                    "Kiểu kiến trúc của ngôi chùa có tên là “Ngũ môn tam cấp” - tức năm cửa ba bậc. Hai bên sân là hai dãy nhà tranh làm cho du khách nghỉ ngơi trong ngày hội. " +
                    "Trước bảo thềm thứ nhất có đặt một đỉnh đồng cao đến 3m lúc nào cũng khói nhang nghi ngút.",
                    Tieude2="Động Tiên Sơn",
                    Hinhanh2="camnhi-203728053740-dong-tien-son.jpg",
                    Noidung2="Một địa điểm hành hương khác trong tour chùa Hương mà bạn không nên bỏ lỡ là Động Tiên Sơn. " +
                    "Động được mở mang cùng thời với Chùa Thiên Trù, nhưng do bến cố của thiên nhiên động đã bị đất đá lấp đi. " +
                    "Mãi đến năm 1904 mới được mở lại và đồng thời mở thêm một cửa động thứ hai ở bên phải. " +
                    "Động Tiên Sơn tuy nhỏ nhưng có địa thế đẹp và nhiều nhũ đá với hình thù độc đáo như: bàn tay phật, ngà voi trắng,… khi gõ vào phát ra những âm thanh như tiếng nhạc. " +
                    "Đặc biệt là 5 pho tượng gia đình bà Chúa Ba được tạc từ 3 phiến đá bạch thạch đào được ở trong động.",
                    Tieude3="Chùa Trấn Quốc",
                    Hinhanh3="camnhi-203828053849-chua-tran-quoc.jpg",
                    Noidung3="Chùa Trấn Quốc nằm cách quần thể chùa Hương không xa, vì thế khi tham gia tour chùa Hương bạn hãy ghé qua địa điểm du lịch Hà Nội nổi tiếng này nhé. " +
                    "Chùa Trấn Quốc được xem là ngôi chùa lâu đời nhất ở Thăng Long - Hà Nội với lịch sử gần 1.500 năm. " +
                    "Từng là trung tâm Phật giáo thời Lý, Trần, đến nay chùa vẫn nổi tiếng là chốn Phật pháp linh thiêng, thu hút nhiều tín đồ Phật tử và du khách đến chiêm bái mỗi năm. " +
                    "Ngôi chùa này từng lọt vào danh sách xếp hạng 16 ngôi chùa đẹp nhất thế giới của tờ báo Daily Mail (Anh) năm 2016 nữa đó.",
                    Tieude4="Quần thể kiến trúc tâm linh trên đỉnh Fansipan",
                    Hinhanh4="camnhi-203928053917-kim-son-bao-thang-tu-fansipan.jpg",
                    Noidung4="Với các tín đồ Phật tử thì địa điểm trải nghiệm hành hương đầu năm ở miền Bắc không chỉ có tour chùa Hương là nơi quen thuộc mà còn có đỉnh thiêng Fansipan với quần thể kiến trúc tâm linh tại Sun World Fansipan Legend. " +
                    "Điểm đến thu hút nhất trong quần thể tâm linh này phải kể đến Kim Sơn Bảo Thắng Tự. Ngôi chùa này là nơi trưng bày 18 vị La Hán bằng gỗ mít cao 2m và Bảo tháp 11 tầng ốp đá xanh nguyên khối theo thiết kế từ ngôi tháp chùa Phổ Minh ở Nam Định. " +
                    "Hơn nữa, ở Sun World Fansipan Legend còn có nhiều kiến trúc độc đáo khác như Bích Vân Thiền Tự, Bảo An Thiền Tự với tượng đồng Quan Thế Âm Bồ Tát và Đai tượng Phật A Di Đà khoan thai sừng sững, uy nghi giữa đất trời.",
                    Tieude5="Chùa Bái Đính",
                    Hinhanh5="camnhi-205328055351-chua-bai-dinh.jpg",
                    Noidung5="Chùa Bái Đính là điểm lễ chùa đầu năm ở khu vực miền Bắc được nhiều du khách lựa chọn. " +
                    "Bái Đính là một quần thể chùa lớn với nhiều kỉ lục châu Á và Việt Nam được xác lập như chùa có tượng Phật bằng đồng dát vàng lớn nhất châu Á, chùa có hành lang La Hán dài nhất châu Á, chùa có tượng Di lặc bằng đồng lớn nhất Đông Nam Á,... " +
                    "Sẽ thật thiếu sót nếu bạn đi tour chùa Hương mà không ghé qua địa điểm hành hương lân cận này đấy. Chùa Bái Đính thường khai hội vào mùng 6 Tết và kéo dài đến hết tháng 3 Âm lịch."},
                new TinTuc {Tieude="Mách bạn những điểm du xuân đầu năm chơi vui quên lối về",
                    NgayDang=DateTime.Parse("2020-12-26"), Hinhanh="nhung-diem-du-xuan-dau-nam.jpg", Noidung="Tết đến, xuân về là dịp để cả gia đình đoàn tụ, sum vầy bên nhau. " +
                "Ngày nay, càng ngày càng có nhiều sự lựa chọn để tận hưởng Tết, thay vì chỉ quây quần bên bàn tiệc cùng bạn bè, dành trọn thời gian để đi chúc Tết, nhiều người đã chọn đi du lịch. " +
                "Dưới đây là những điểm du xuân đầu năm được nhiều người lựa chọn."},
            };
            foreach (TinTuc item in tt)
            {
                context.TinTucs.Add(item);
            }
            context.SaveChanges();

            //
            //init data table KhachSan
            //
            var ks = new KhachSan[]
            {
                new KhachSan{Tenks="Khách Sạn Lan Anh Đà Lạt", Diachi=" 27/6 Hai Bà Trưng, Phường 6, Đà Lạt, Lâm Đồng", Hinhanh="thb_hotel_dalat_lan_anh.jpg", Sdt="1900 1839",
                Gia=550000, Giaphuthu=250000, Giatreem=80000, DiaDiemID=9,Mota="Tọa lạc tại thành phố Đà Lạt, cách Quảng trường Lâm Viên 2,1 km, Lan Anh Hotel có nhà hàng, chỗ đỗ xe riêng miễn phí, trung tâm thể dục và quán bar. Khách sạn 3 sao này còn có phòng khách chung và máy ATM. Chỗ nghỉ cũng cung cấp dịch vụ lễ tân 24 giờ, dịch vụ đưa đón sân bay, dịch vụ phòng và WiFi miễn phí. Tất cả phòng nghỉ tại khách sạn đều được trang bị truyền hình cáp màn hình phẳng, tủ lạnh, ấm đun nước, vòi sen, máy sấy tóc và tủ để quần áo. Mỗi phòng còn có phòng tắm riêng với đồ vệ sinh cá nhân miễn phí. Lan Anh Hotel nằm cách Hồ Xuân Hương 2,3 km và Công viên Yersin 2,4 km. Sân bay gần nhất là sân bay Liên Khương, nằm trong bán kính 30 km từ chỗ nghỉ.",
                Loaiphong="Deluxe Giường Đôi/2 Giường Đơn", Thongtinphong="Tiện nghi trong phòng: - Diện tích phòng: 25m2 - Két an toàn - Nhà vệ sinh - Truyền hình cáp - Dịch vụ báo thức - Giờ nhận phòng:- Nhận phòng: 14h00 - Trả phòng: 12h00 - Tiện ích của Khách Sạn - Bãi đỗ xe miễn phí - Phòng hội thảo - Phòng họp - Thang máy - Truyền hình cáp/vệ tinh - Wifi miễn phí - Phòng gia đình - Đưa đón sân bay tính phí - Cho thuê xe máy - Xe đưa đón tham quan tính phí - Cho thuê xe đạp - Phòng xông hơi khô - Phòng gym - Phục vụ đồ ăn tại phòng - Giặt khô - Cửa hàng dụng cụ thể thao"},
                new KhachSan{Tenks="Khách Sạn Dalat Palace Convention", Diachi = "2 Trần Phú, Phường 3, Đà Lạt, Lâm Đồng", Hinhanh="thb_hotel_dalat_palace.jpeg", Sdt="1900 1839",
                Gia=3750000, Giaphuthu=600000, Giatreem=120000, DiaDiemID=9, Mota="Khách sạn Dalat Palace Covention tọa lạc trên con đường Trần Phú, ngay trung tâm thành phố Đà Lạt. Khách sạn cách sân bay Liên Khương khoảng 31 km, cách chợ Đà Lạt tầm 1,3 km. Trước đây khách sạn này tên là Langbian Palace do người Pháp xây dựng năm 1916 hoàn thành năm 1922. Về sau nó mang tên Dalat Sofitel Palace rồi đổi thành Dalat Palace Hotel như hiện nay. Khách sạn Dalat Palace là một công trình kiến trúc kiểu Pháp. Khuôn viên của khách sạn rộng đến hơn 40.000 m2, chung quanh là vườn hoa, thảm cỏ, rừng thông. Khách sạn gồm 43 phòng và suite rộng rãi với hướng nhìn ra Hồ Xuân Hương hoặc nhà thờ. Nơi đây thường thu hút nhiều đối tượng khách du lịch như gia đình, cặp đôi hay khách công tác."
                , Loaiphong="Royal Superior", Thongtinphong="Ban công/ sân thượng " +
                "Quầy bar nhỏ (mini bar)" +
                "TV màn hình phẳng" +
                "Vòi hoa sen" +
                "Bồn tắm Máy sấy tóc Két sắt trong phòng Dép đi trong phòng Buồng tắm đứng Cà phê/ trà Giờ nhận phòng: Nhận phòng: 14h00 Trả phòng: 12h00.Tiện ích của Khách Sạn Bãi đỗ xe miễn phí Phòng hội thảo Phòng họp Thang máy Truyền hình cáp/ vệ tinh Wifi miễn phí Giặt là Hỗ trợ đặt tour Nhà hàng Lễ tân 24 / 24 Đưa đón sân bay tính phí Taxi / Cho thuê xe hơi Phục vụ đồ ăn tại phòng Dọn phòng hàng ngày Két an toàn Đặt vé xe / máy bay Giữ hành lý miễn phí Khu vực hút thuốc Tổ chức sự kiện"},
                new KhachSan{Tenks="Đà Lạt Wonder Resort", Diachi="19 Hoa Hồng, Hồ Tuyền Lâm, Đà Lạt, Lâm Đồng", Hinhanh="thb_hotel_dalat_wonder_resort.jpg", Sdt="1900 1839",
                Gia=1200000, Giatreem=180000, DiaDiemID=9, Mota="Dalat Wonder Resort là lựa chọn sáng giá dành cho những ai đang tìm kiếm một trải nghiệm xa hoa đầy thú vị trong kỳ nghỉ của mình. Lưu trú tại đây cũng là cách để quý khách chiều chuộng bản thân với những dịch vụ xuất sắc nhất và khiến kỳ nghỉ của mình trở nên thật đáng nhớ. Điểm nhấn của khách sạn: Dalat Wonder Resort là lựa chọn sáng giá dành cho những ai đang tìm kiếm một trải nghiệm xa hoa đầy thú vị trong kỳ nghỉ của mình. Lưu trú tại đây cũng là cách để quý khách chiều chuộng bản thân với những dịch vụ xuất sắc nhất và khiến kỳ nghỉ của mình trở nên thật đáng nhớ. Có bãi đậu xe, Wifi miễn phí."
                ,Loaiphong="Deluxe Garden View/ Bungalow - Phòng 02 Giường Đơn (tặng kèm 1 bữa tối)", Thongtinphong="Tiện nghi trong phòng: Diện tích phòng 30m2 Internet miễn phí Wifi Bữa sáng miễn phí -Lò sưởi -Ấm nấu bằng điện -Điều hòa nhiệt độ -Giá quần áo -Dịch vụ đánh thức / đồng hồ báo thức -Vòi sen -Đồ dùng nhà tắm miễn phí. *Giờ nhận phòng: - Nhận phòng: sau 14h00 - Trả phòng: trước 12h00 *Số lượng khách tối đa trong 1 phòng: 02 khách người lớn. *Lưu ý cho trẻ em: Từ 0 - 05 tuổi: miễn phí (ăn ngủ chung với ba mẹ) Từ 06 tuổi trở lên tính bằng giá người lớn."},
                new KhachSan{Tenks="River Prince Đà Lạt", Diachi="135-145 Phan Đình Phùng, Phường 2, Đà Lạt, Lâm Đồng", Hinhanh="thb_hotel_dalat_river_prince.jpg", Sdt="1900 1839",
                Gia=580000, Giatreem=120000,DiaDiemID=9, Mota="Khách sạn River Prince Đà Lạt là một khách sạn được xây dựng theo lối kiến trúc Châu Âu, hiện đại, nằm trên con đường trung tâm của thánh phố Đà Lạt –  đường Phan Đình Phùng. Khách sạn bao gồm 102 phòng với tiện nghi trang trọng, hiện đại. Tất cả phòng đều có cửa sổ với không gian rộng rãi, thoáng mát.",
                Loaiphong="Loại superior 1 giường đôi hoặc 2 giường đơn", Thongtinphong="*Tiện nghi trong phòng: - Diện tích phòng 39m2 - Wifi miễn phí -Bữa sáng miễn phí - Máy điều hòa - Phòng tắm vòi sen & bồn tắm - Nước đóng chai miễn phí - Giá treo quần áo, tủ quần áo - Dịch vụ đánh thức / đồng hồ báo thức - Dép đi trong nhà, máy sấy tóc, lò vi sóng - Két sắt trong phòng - Mini Bar *Giờ nhận phòng: - Nhận phòng: 14h00 - Trả phòng: 12h00"},
            };
            foreach (KhachSan item in ks)
            {
                context.KhachSans.Add(item);
            }
            context.SaveChanges();
        }
    }
}