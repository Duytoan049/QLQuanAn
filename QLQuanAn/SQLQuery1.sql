-- Tao co so du lieu qlquanan
CREATE DATABASE qlquanan;
-- Su dung co so du lieu qlquanan
USE qlquanan;

-- Tao bang nhanvien
CREATE TABLE nhanvien (
    id_nvien INT IDENTITY(1,1) PRIMARY KEY,
    hoten NVARCHAR(50),
	sdt VARCHAR(10) NOT NULL CHECK (sdt LIKE '0%' AND LEN(sdt) = 10 AND sdt NOT LIKE '%[^0-9]%'),
    matkhau VARCHAR(255),
);

-- Them du lieu vao bang nhanvien
INSERT INTO nhanvien (hoten, matkhau, sdt) VALUES
('Nguyen Van A', 'matkhau123', '0987654321'),
('Nguyen Van B',  'matkhau123', '0912345678'),
('Nguyen Van C',  'matkhau123', '0312357898'),
('Nguyen Van D',  'matkhau123', '0356789123');


-- Tao bang khachhang
CREATE TABLE khachhang (
    id_khachhang INT IDENTITY(1,1) PRIMARY KEY,
    hoten NVARCHAR(50),
    sdt VARCHAR(10) NOT NULL CHECK (sdt LIKE '0%' AND LEN(sdt) = 10 AND sdt NOT LIKE '%[^0-9]%'),
    diachi NVARCHAR(255)
);

-- Tao bang loaimon
CREATE TABLE loaimon (
    id_loaimon INT IDENTITY(1,1) PRIMARY KEY,
    tenloaimon NVARCHAR(50)
);

-- Tao bang monan
CREATE TABLE monan (
    id_monan INT IDENTITY(1,1) PRIMARY KEY,
    tenmonan NVARCHAR(50),
    id_loaimon INT,
    gia DECIMAL(10, 2),
    mota TEXT,
    FOREIGN KEY (id_loaimon) REFERENCES loaimon(id_loaimon)
);

-- Tao bang hoadon
CREATE TABLE hoadon (
    id_hoadon INT IDENTITY(1,1) PRIMARY KEY,
    id_khachhang INT,
    id_nvien INT,
    ngaylap DATETIME,
    tongtien DECIMAL(10, 2),
    FOREIGN KEY (id_khachhang) REFERENCES khachhang(id_khachhang),
    FOREIGN KEY (id_nvien) REFERENCES nhanvien(id_nvien)
);

-- Tao bang chitiethoadon
CREATE TABLE chitiethoadon (
    id_chitiethd INT IDENTITY(1,1) PRIMARY KEY,
    id_hoadon INT,
    id_monan INT,
    soluong INT,
    dongia DECIMAL(10, 2),
    thanhtien DECIMAL(10, 2),
    FOREIGN KEY (id_hoadon) REFERENCES hoadon(id_hoadon),
    FOREIGN KEY (id_monan) REFERENCES monan(id_monan)
);

CREATE TABLE category (
	catID int primary key identity,
	catName varchar(50),

);

CREATE TABLE tables (
	tID int primary key identity,
	tName varchar(50),

);
-- Them du lieu mau vao cac bang
-- Them loai mon
INSERT INTO loaimon (tenloaimon) VALUES ('Mon khai vi'), ('Mon chinh'), ('Do uong');

-- Them mon an
INSERT INTO monan (tenmonan, id_loaimon, gia, mota) VALUES
('Goi cuon', 1, 30000, 'Goi cuon tom thit'),
('Com ga xoi mo', 2, 50000, 'Com ga xoi mo gion tan'),
('Coca-Cola', 3, 15000, 'Nuoc ngot co gas');

-- Them khach hang
INSERT INTO khachhang (hoten, sdt, diachi) VALUES
('Tran Van E', '0901234567', '123 Duong A'),
('Le Thi F', '0987654321', '456 Duong B');

-- Them hoa don
INSERT INTO hoadon (id_khachhang, id_nvien, ngaylap, tongtien) VALUES
(1,1,'2024-10-25', '100000'),
(2,1,'2024-10-25', '150000');

-- Them chi tiet hoa don
INSERT INTO chitiethoadon(id_hoadon, id_monan, soluong, dongia, thanhtien) VALUES
(1,1,2,30000,60000),
(1,2,1,50000,50000),
(2,2,2,50000,100000),
(2,3,1,15000,15000);

-- Xem du lieu trong bang monan
SELECT * FROM nhanvien;
SELECT * FROM category;

SELECT COUNT(*) FROM nhanvien 
WHERE sdt = '0356789123' AND matkhau ='matkhau123'
