create table DangNhap
(
	Quyen char(5),
	TenDangNhap char(20),
	MatKhau char(20)
)

insert into DangNhap values
('ADMIN', 'admin12345',	'123456'),
('USER', '092174003985', '4031979'),
('USER', '075204126282', '2512004')

insert into DangNhap values('USER', 'user12345', '123456')

select *from DangNhap
select *from CongDan
select *from Cnkh
select *from Tamtru
select *from Tamvang
select *from Thue