create table Cnkh
(
	Hotenvo nvarchar(255),
	Ngaysinhvo date,
	Dantocvo nvarchar(50),
	Quoctichvo nvarchar(100),
	Noicutruvo nvarchar(100),
	Giaytotuythanvo nvarchar(100),
	Hotenchong nvarchar(255),
	Ngaysinhchong date,
	Dantocchong nvarchar(50),
	Quoctichchong nvarchar(100),
	Noicutruchong nvarchar(100),
	Giaytotuythanchong nvarchar(100),
	Noidk nvarchar(100),
	Ngaydk date
);

insert into Cnkh(Hotenvo, Ngaysinhvo, Dantocvo, Quoctichvo, Noicutruvo, Giaytotuythanvo, Hotenchong, Ngaysinhchong, Dantocchong, Quoctichchong, Noicutruchong, Giaytotuythanchong, Noidk, Ngaydk)
values (N'Đinh Thị Kim H',	'1979-03-07',	N'Kinh',	N'Việt Nam',	N'Bến Tre',	'CCCD',	N'Phạm Văn T',	'1978-10-05',	N'Kinh',	N'Việt Nam',	N'Bến Tre',	N'CCCD',	N'UBND tỉnh Bến Tre',	N'2002-10-10'),
	(N'Lê Thị Bảo T',	'1976-04-21',	N'Kinh',	N'Việt Nam',	N'Hồ Chí Minh',	'CCCD',	N'Nguyễn Anh K',	'1974-04-03',	N'Hoa',	N'Việt Nam',	N'Cần Thơ',	N'CCCD',	N'UBND Tp. Hồ Chí Minh',	N'2005-01-02')