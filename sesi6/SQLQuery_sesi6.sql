a. create database staff;

b. create table data_staff (
	nik int primary key, 
	nama varchar (50) null, 
	alamat varchar (200) null, 
	handphone varchar (15) null
	);

c. insert into data_staff (nik, nama, alamat, handphone)
	values ('10001','Ayu','Jakarta','085679278134');


d. insert into data_staff (nik, nama, alamat, handphone)
	values ('10002','Kiki','Bogor','085679278132');
   insert into data_staff (nik, nama, alamat, handphone)
	values ('10003','Budi','Malang','085679278131');

e. alter table data_staff add joindate date;
	insert into data_staff (nik, nama, alamat, handphone, joindate)
	values ('10004','Koko','Bandung','085679278134','2021-07-09');

f. select top (2) [nik],[nama],[alamat],[handphone],[joindate] from [dbo].[data_staff];

g. select top (3) [nik],[nama],[alamat],[handphone],[joindate] from [dbo].[data_staff];

h. create table staffoutsource(
	nik int primary key,
	nama varchar(50)null,
	alamat varchar(150)null, 
	handphone varchar(15)null, 
	joindate date null
	);

i. insert into staffoutsource(nik, nama, alamat, handphone,joindate) 
   values ('10005','Keke','Semarang','085679278136','2021-01-05'),
	      ('10006','Budi','Bandung','085679278137','2020-07-01'), 
          ('10007','Ani','Medan','085679278138','2021-03-05'),
          ('10008','Komo','Bekasi','085679278139','2020-01-05'), 
          ('10009','Ratu','Tasikmalaya','085679278110','2020-04-09'),
		  ('10010','Bambang','Solo','085679278100','2020-02-04'),
		  ('10011','Gani','Garut','085679278109','2021-05-01'),
		  ('10012','Gigi','Jakarta','0085679278104','2021-04-02'),
		  ('10013','Zayn','Bekasi','085679278114','2021-05-04'),
		  ('10014','Abdul','Bandung','085679278154','2020-01-04');

j. select * from data_staff inner join staffoutsource on data_staff.joindate = staffoutsource.joindate;

k. select * from data_staff right join staffoutsource on data_staff.joindate=staffoutsource.joindate;

l. select * from data_staff left join staffoutsource on data_staff.joindate=staffoutsource.joindate;

m. select * from data_staff union select * from staffoutsource;