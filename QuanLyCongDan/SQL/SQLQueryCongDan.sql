create table CongDan
(
	HoTen nchar(50),
	GioiTinh nchar(5),
	CCCD char(12),
	NgaySinh Date,
	NoiSinh nchar(20),
	HonNhan nchar(30),
	QuocTich nchar(20),
	DanToc nchar(20),
	TonGiao nchar(30),
	ThuongTru nchar(20),
	QueQuan nchar(20),
	DiaChi nchar(20),
	SDT char(10),
	Email char(30)
)

insert into CongDan values
(N'Phạm Văn T','Nam', '083078008061', '1978-10-05', N'Bến Tre', N'Đã kết hôn', N'Việt Nam', N'Kinh', N'Không', N'Bến Tre', N'Bến Tre', N'Bến Tre', '0814096656', 'phamvant@gmail.com'),
(N'Lê Thị Bảo T', N'Nữ', '080059219345', '1976-04-21', N'Hồ Chí Minh', N'Đã kết hôn', N'Việt Nam', N'Kinh', N'Không', N'Long An', N'Long An' , N'Long An', '0987565114',	'lebaot@gmail.com'),
(N'Phạm Nhật T', N'Nam',	'083208004574',	'2008-01-21', N'Bến Tre', N'Chưa kết hôn',	N'Việt Nam', N'Kinh', N'Không',	N'Bến Tre',	N'Bến Tre',	N'Bến Tre',	'0357412115', 'phamnhatt@gmail.com'),
(N'Nguyễn Hoàng Y',	N'Nữ',	'034303214547',	'2003-03-14', N'Thái Bình', N'Chưa kết hôn', N'Việt Nam', N'Hoa', N'Đạo Phật', N'Thái Bình', N'Thái Bình',	N'Thủ Đức',	'0922474595', 'nguyenhoangy@gmail.com'),
(N'Lê Hoàng L', N'Nam',	'075204126282',	'2004-12-25', N'Đồng Nai', N'Chưa kết hôn',	N'Việt Nam', N'Kinh', N'Tin Lành', N'Hồ Chí Minh', N'Đồng Nai',	N'Hồ Chí Minh',	'0377454487', 'lehoangl@gmail.com'),
(N'Đinh Thị Kim H', N'Nữ',	'083179004521',	'1979-03-07', N'Bến Tre', N'Đã kết hôn', N'Việt Nam', N'Kinh', N'Không', N'Bến Tre', N'Bến Tre', N'Bến Tre', '0814247544', 'dinhthikimh@gmail.com'),
(N'Hoàng Thùy L', N'Nữ',	'091301721456',	'2001-01-01', N'Kiên Giang', N'Chưa kết hôn', N'Việt Nam', N'Kinh', N'Không', N'Kiên Giang', N'Kiên Giang', N'Thủ Đức',	'0354499875', 'hoangthuyl@gmail.com'),
(N'Nguyễn Anh K', N'Nam',	'092174003985',	'1974-04-03', N'Cần Thơ', N'Đã kết hôn', N'Việt Nam', N'Hoa', N'Thiên Chúa Giáo', N'Cần Thơ', N'Cần Thơ',	N'Cần Thơ',	'0985787445', 'nguyenanhk@gmail.com'),
(N'Lê Hữu C', N'Nam',	'096100102545',	'2000-01-31', N'Cà Mau', N'Chưa kết hôn', N'Việt Nam', N'Kinh', N'Thiên Chúa Giáo',	N'Hồ Chí Minh',	N'Cà Mau',	N'Hồ Chí Minh', '0356445874', 'lehuuc@gmail.com'),
(N'Bùi Kim Y', N'Nữ',	'058305451003',	'2005-04-28', N'Ninh Thuận', N'Chưa kết hôn', N'Việt Nam', N'Kinh', N'Đạo Phật', N'Ninh Thuận',	N'Ninh Thuận',	N'Ninh Thuận',	'0367636601', 'buikimy@gmail.com')

select *from CongDan


