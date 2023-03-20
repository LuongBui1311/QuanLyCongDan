﻿create table Tamvang
(
	Ncdi nvarchar(50),
	Ncden	nvarchar(50),
	Hoten	nvarchar(255),
	Ngaysinh	date,
	Cmnd	nvarchar(20),
	Nccmnd	nvarchar(100),
	Ngccmnd	date,
	Diachitht	nvarchar(50),
	Diachitt	nvarchar(50),
	Ngaydi	date,
	Ngayve	date,
	Lydo nvarchar(100)
);

insert into Tamvang(Ncdi, Ncden, Hoten, Ngaysinh, Cmnd, Nccmnd, Ngccmnd, Diachitht, Diachitt, Ngaydi, Ngayve, Lydo)
values (N'Bến Tre',	N'Hồ Chí Minh',	N'Đinh Thị Kim H',	'1979-03-07',	'083179004521',	N'Bến Tre',	'2021-04-03',	N'Bến Tre',	N'Hồ Chí Minh',	'2023-01-01',	'2025-01-01',	N'Làm công ty'),
	(N'Cà Mau',	N'Hồ Chí Minh',	N'Lê Hữu C',	'2000-01-31',	'096100102545',	N'Cà Mau',	'2020-03-26',	N'Cà Mau',	N'Hồ Chí Minh',	'2022-02-04',	'2024-02-04',	N'Học cao học'),
	(N'Đồng Nai',	N'Hồ Chí Minh',	N'Lê Hoàng L',	'2004-12-25',	'075204126282',	N'Đồng Nai',	'2021-05-08',	N'Đồng Nai',	N'Hồ Chí Minh',	'2023-02-25',	'2027-02-25',	N'Học đại học'),
	(N'Cần Thơ',	N'Hồ Chí Minh',	N'Nguyễn Anh K',	'1974-04-03',	'092174003985',	N'Cần Thơ',	'2020-07-21',	N'Cần Thơ',	N'Hồ Chí Minh',	'2023-02-10',	'2024-02-10',	N'Điều trị bệnh')
	select *from Tamvang