CREATE DATABASE QuanLyDiemSinhVien_1
GO

USE QuanLyDiemSinhVien_1
GO

CREATE TABLE tbAccount
(
    UserName VARCHAR(100) PRIMARY KEY,
    Password VARCHAR(100) NOT NULL DEFAULT 0,
)
GO

CREATE TABLE tbMonHoc
(
    maMonHoc VARCHAR(100) PRIMARY KEY,
    tenMonHoc NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tên',
    soTinChi INT NOT NULL DEFAULT 1,
)
GO

CREATE TABLE tbGiangVien
(
    maGV VARCHAR(100) PRIMARY KEY,
    hoTenDemGV NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập tên',
    tenGV NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập tên',
    gioiTinh INT,
    ngaySinh DATE DEFAULT GETDATE(),
    dienThoai VARCHAR(15),
    email VARCHAR(100),
    Password VARCHAR(50) NOT NULL DEFAULT '1'
)
GO

CREATE TABLE tbSinhVien
(
    maSV VARCHAR(100) PRIMARY KEY,
    hoTenDemSV NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập họ',
    tenSV NVARCHAR(100) NOT NULL DEFAULT N'Chưa nhập tên',
    ngaySinh DATE,
    gioiTinh INT,
    queQuan NVARCHAR(100),
    dienThoai VARCHAR(15),
    email VARCHAR(100),
    Password VARCHAR(50) NOT NULL DEFAULT '1'
) 
GO

CREATE TABLE tbLopHoc
(
    maLopHoc INT IDENTITY(1,1) PRIMARY KEY,
    maMonHoc VARCHAR(100) NOT NULL,
    maGV VARCHAR(100) NOT NULL,

    FOREIGN KEY (maMonHoc) REFERENCES dbo.tbMonHoc(maMonHoc),
    FOREIGN KEY (maGV) REFERENCES dbo.tbGiangVien(maGV)
)
GO

CREATE TABLE tbDiemThi
(
    maSV VARCHAR(100) NOT NULL,
    maLopHoc INT NOT NULL,
    diemlan1 FLOAT DEFAULT 0,
    diemlan2 FLOAT DEFAULT 0,

    CONSTRAINT PK_DiemThi PRIMARY KEY (maSV,maLopHoc),
    FOREIGN KEY (maLopHoc) REFERENCES dbo.tbLopHoc(maLopHoc),
    FOREIGN KEY (maSV) REFERENCES dbo.tbSinhVien(maSV),
)
GO

----------------------------------------------------------------
----------------------------------------------------------------
-- Tạo seq tự động tăng

CREATE SEQUENCE giangVienSeq
    START WITH 1111 --bắt đầu từ 1111
    INCREMENT BY 1; --mỗi lần tăng 1
GO
    -- SELECT NEXT VALUE FOR giangVienSeq

CREATE SEQUENCE sinhVienSeq
    START WITH 1111 --bắt đầu từ 0001
    INCREMENT BY 1; --mỗi lần tăng 1
GO
    -- SELECT NEXT VALUE FOR sinhVienSeq


----------------------------------------------------------------
----------------------------------------------------------------
-- Demo Data

INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Trần Ngọc', N'Tùng', 1, '1978-01-01','0123456789','trantung@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Phạm Xuân', N'Phúc', 0, '1977-02-02','0987654321','phamxuan@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Vũ Văn', N'Lâm', 1, '1976-03-03','0167896789','vanlam@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Nguyễn Văn', N'Quyết', 1, '1975-04-04','0123412349','vanquyet@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Phạm Ngọc', N'Diệp', 0, '1974-05-05','0189898989','ngocdiem@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Vũ Xuân', N'Hoàng', 1, '1973-06-06','0123456234','xuanhoang@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Cao Văn', N'Ân', 1, '1972-07-07','0456456456','caoan@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Quang Nhật', N'Bảo', 1, '1971-08-08','0123443210','quangnhat@gmail.com');
GO


INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('csdl_0', N'Thiết kế cơ sở dữ liệu', 4);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('math_1', N'Toán cao cấp 1', 2);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('math_2', N'Toán cao cấp 2', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('physic_1', N'Vật lý 1', 2);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('physic_2', N'Vật lý 2', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('oop_0', N'Lập trình hướng đối tượng', 4);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('web_0', N'Lập trình web', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('java_core', N'Ngôn ngữ lập trình Java', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('reactjs', N'Thiết kế web với React JS', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('reactnative', N'Lập trình mobile với React Native', 4);
GO

INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Trần Ngọc', N'Tùng', '2000-01-01', 1, N'Hà Nam', '0123654789','tung2011@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Nguyễn Ngọc', N'Ngạn', '2000-02-02', 0, N'Hải Phòng', '0789789789','ngoc555@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Xuân Hải', N'Hậu', '2000-03-03', 1, N'Thanh Hóa', '0123654789','51ssshai@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Văn Sơn', N'Lâm', '2000-04-04', 1, N'Đà Nẵng', '0512364122','sonvan56@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Võ Giang', N'Nguyệt', '2000-05-05', 0, N'Bình Định', '0512364122','giang79@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Cao Ly', N'Ánh', '2000-06-06', 0, N'Huế', '0512364122','ly186@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Lý Tuấn', N'Hưng', '2000-07-07', 1, N'Tiền Giang', '0147854789','tuan111@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Thế Phan', N'Trí', '2000-08-08', 1, N'Đồng Tháp', '0123654365','phan1514@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Phạm', N'Tuân', '2000-09-09', 1, N'Bình Dương', '0478654789','tuan98@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Vũ Hiền', N'Thái', '2000-10-10', 0, N'Vũng Tàu', '0123654369','hien151@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Võ', N'Lâm', '2000-11-11', 1, N'Đồng Nai', '0123654012','lam1122@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Phạm Nhật', N'Quang', '2000-12-12', 1, N'Cao Bằng', '0123612712','nhat1212@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Xuân Trường', N'Anh', '2000-01-01', 1, N'Quảng Ninh', '0121265471','truong20@gmail.com');
GO

INSERT INTO tbLopHoc(maMonHoc, maGV)
VALUES ('physic_1', 'GV1112')
INSERT INTO tbLopHoc(maMonHoc, maGV)
VALUES ('physic_2', 'GV1113')
GO

INSERT INTO tbAccount(UserName, Password)
VALUES('admin', 'admin')
GO

INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1111',1)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1112',1)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1113',1)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1114',1)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1115',1)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1116',1)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1117',2)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1118',2)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1119',2)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1120',2)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1121',2)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1122',2)
INSERT INTO tbDiemThi(maSV,maLopHoc)
VALUES('SV1111',2)
GO

----------------------------------------------------------------
----------------------------------------------------------------
-----------------------CREATE PROCEDURE-------------------------
----------------------------------------------------------------
----------------------------------------------------------------

CREATE PROCEDURE AddGiangVien --Procedure thêm mới giảng viên
    @hoTenDemGV NVARCHAR(100),
    @tenGV NVARCHAR(100),
    @ngaySinh DATE,
    @gioiTinh INT,
    @dienThoai VARCHAR(15),
    @email VARCHAR(100)
AS
BEGIN
   INSERT INTO tbGiangVien
   (
        maGV,
        hoTenDemGV,
        tenGV,
        ngaySinh,
        gioiTinh,
        dienThoai,
        email
   )
   VALUES
   (
      'GV'+CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)),
      @hoTenDemGV,
      @tenGV,
      @ngaySinh,
      @gioiTinh,
      @dienThoai,
      @email
   );

   IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
   ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE AddMonHoc
    @tenMonHoc NVARCHAR(100),
    @maMonHoc varchar(100),
    @soTinChi int
AS
BEGIN
    INSERT INTO tbMonHoc
    (tenMonHoc, maMonHoc, soTinChi)
    VALUES
    (@tenMonHoc, @maMonHoc, @soTinChi);

    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE AddSinhVien --Procedure thêm mới sinh viên
    @hoTenDemSV NVARCHAR(100),
    @tenSV NVARCHAR(100),
    @ngaySinh DATE,
    @gioiTinh INT,
    @queQuan NVARCHAR(100),
    @dienThoai VARCHAR(15),
    @email VARCHAR(100)
AS
BEGIN
   INSERT INTO tbSinhVien
   (
      maSV,
      hoTenDemSV,
      tenSV,
      ngaySinh,
      gioiTinh,
      queQuan,
      dienThoai,
      email
   )
   VALUES
   (
      'SV'+CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)),
      @hoTenDemSV,
      @tenSV,
      @ngaySinh,
      @gioiTinh,
      @queQuan,
      @dienThoai,
      @email
   );

   IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
   ELSE BEGIN RETURN 0 END;
END 
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE AddLopHoc
    @maMonHoc VARCHAR(30),
    @maGV VARCHAR(30)
AS
BEGIN
    INSERT INTO tbLopHoc(maMonHoc, maGV)
    VALUES (@maMonHoc, @maGV)
    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE DangkyMon
    @maSV VARCHAR(100),
    @maLopHoc INT
AS
BEGIN

    DECLARE @v_daDangKy int,
            @v_maMonHoc VARCHAR(30);

	SELECT @v_daDangKy = count(*)
    FROM tbDiemThi d
    inner join tbLopHoc l on d.maLopHoc = l.maLopHoc
    WHERE l.maMonHoc = @v_maMonHoc AND d.maSV = @maSV

    IF @v_daDangKy > 0 return -1;

    INSERT INTO tbDiemThi(maSV, maLopHoc)
    VALUES(@maSV, @maLopHoc);

    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE SelectAllGiangVien
    @tuKhoa NVARCHAR(50)
AS
BEGIN
    SELECT
        maGV,
        CONCAT(hoTenDemGV, ' ', tenGV) as hoTen,
        CASE WHEN gioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS gioiTinh,
        convert(varchar(10),ngaysinh,103) as ngaysinh,
        dienThoai,
        email
    FROM tbGiangVien
    WHERE
    lower(hoTenDemGV) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(tenGV) like '%'+lower(trim(@tuKhoa))+'%'
    or dienThoai like '%'+lower(trim(@tuKhoa))+'%'
    or cast(maGV as VARCHAR(30)) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(email) like '%'+lower(trim(@tuKhoa))+'%' 
    order by tenGV;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE SelectAllGiangVien_detail
    @tuKhoa NVARCHAR(50)
AS
BEGIN
    SELECT
        maGV,
        hoTenDemGV,tenGV,
        CASE WHEN gioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS gioiTinh,
        convert(varchar(10),ngaysinh,103) as ngaysinh,
        dienThoai,
        email
    FROM tbGiangVien
    WHERE
    lower(hoTenDemGV) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(tenGV) like '%'+lower(trim(@tuKhoa))+'%'
    or dienThoai like '%'+lower(trim(@tuKhoa))+'%'
    or cast(maGV as VARCHAR(30)) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(email) like '%'+lower(trim(@tuKhoa))+'%' 
    order by tenGV;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE SelectAllMonHoc
    @tuKhoa NVARCHAR(30)
AS
BEGIN
    SELECT
        maMonHoc,
        tenMonHoc,
        soTinChi
    FROM tbMonHoc
    WHERE
    lower(maMonHoc) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(tenMonHoc) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(soTinChi) like '%'+lower(trim(@tuKhoa))+'%'
    order by tenMonHoc;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE DsLopCuaGV
    @maGV VARCHAR(100)
AS
BEGIN
    SELECT 
        tb.maLopHoc,
        tb.maMonHoc,
        tb.tenMonHoc,
        tb.soTinChi,
        COUNT(d.maSV) as stt
    FROM
    (   
        SELECT
            l.maLopHoc,
            l.maMonHoc,
            m.tenMonHoc,
            m.soTinChi
        FROM tbLopHoc l
        inner join tbMonHoc m on l.maMonHoc = m.maMonHoc
        WHERE l.maGV = @maGV
    ) AS tb inner join tbDiemThi d on d.maLopHoc = tb.maLopHoc
    GROUP BY tb.maLopHoc, tb.maMonHoc,tb.tenMonHoc,tb.soTinChi
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE SelectAllSinhVien
    @tuKhoa NVARCHAR(50)
AS
BEGIN
    SELECT
        maSV,
        hoTenDemSV,
        tenSV,
        CASE WHEN gioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS gioiTinh,
        convert(varchar(10),ngaysinh,103) as ngaysinh,
		   queQuan,
        dienThoai,
        email
    FROM tbSinhvien
    WHERE
    lower(hoTenDemSV) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(tenSV) like '%'+lower(trim(@tuKhoa))+'%'
    or dienThoai like '%'+lower(trim(@tuKhoa))+'%'
    or cast(maSV as VARCHAR(30)) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(email) like '%'+lower(trim(@tuKhoa))+'%' 
    order by tenSV;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE SelectAllLopHoc
    @tuKhoa NVARCHAR(50)
AS
BEGIN
    SELECT
        l.maLopHoc,
        concat(g.hoTenDemGV,' ',g.tenGV) as giangVien,
        m.tenMonHoc,
        m.soTinChi
    FROM tbLopHoc l
    inner join tbGiangVien g on l.maGV = g.maGV
    inner join tbMonHoc m on l.maMonHoc = m.maMonHoc
    WHERE lower(m.tenMonHoc) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(g.tenGV) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(g.hoTenDemGV) like '%'+lower(trim(@tuKhoa))+'%'
    or l.maLopHoc like '%'+lower(trim(@tuKhoa))+'%'
    order by l.maLopHoc;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE SelectOneLopHoc
    @maLopHoc int
AS
BEGIN
    SELECT
        maGV,
        maMonHoc
    FROM tbLopHoc
    WHERE maLopHoc = @maLopHoc;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE SelectAllMonDaDk
    @maSV VARCHAR(100)
AS
BEGIN
    SELECT
        l.maLopHoc,
        m.tenMonHoc,
        CONCAT(g.hoTenDemGV, ' ', g.tenGV) as giangVien,
        m.soTinChi
    FROM tbDiemThi d
    inner join tbLopHoc l on d.maLopHoc = l.maLopHoc
    inner join tbMonHoc m on l.maMonHoc = m.maMonHoc
    inner join tbGiangVien g on l.maGV = g.maGV
    WHERE d.maSV = @maSV
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE XemDiem
    @maSV VARCHAR(100)
AS
BEGIN
    SELECT 
        m.tenMonHoc,
        CONCAT(g.hoTenDemGV, ' ', g.tenGV) as giangVien,
        m.soTinChi,
        d.diemlan1,
        d.diemlan2,
        (d.diemlan1 + d.diemlan2)/2 as diemTB
    FROM tbDiemThi d
    inner join tbLopHoc l on d.maLopHoc = l.maLopHoc
    inner join tbGiangVien g on l.maGV = g.maGV
    inner join tbMonHoc m on l.maMonHoc = m.maMonHoc
    WHERE d.maSV = @maSV;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE SelectAllLopChuaDKy
    @maSV VARCHAR(100)
AS
BEGIN
    SELECT
        l.maLopHoc,
        l.maMonHoc,
        m.tenMonHoc,
        m.soTinChi,
        CONCAT(g.hoTenDemGV, ' ', g.tenGV) as giangVien 
    FROM tbLopHoc l
    inner join tbGiangVien g on l.maGV = g.maGV
    inner join tbMonHoc m on l.maMonHoc = m.maMonHoc
    WHERE l.maLopHoc not in (select maLopHoc FROM tbDiemThi WHERE maSV = @maSV);
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE DsSVChamDiem
    @maLopHoc int
AS
BEGIN
    SELECT
        s.maSV,
        s.hoTenDemSV,
        s.tenSV,
        d.diemlan1,
        d.diemlan2
    FROM tbDiemThi d
    inner join tbSinhVien s on d.maSV = s.maSV
    WHERE d.maLopHoc = @maLopHoc
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE UpdateGiangVien
    @maGV VARCHAR(100),
	@hoTenDemGV NVARCHAR(100),
	@tenGV NVARCHAR(100),
    @ngaySinh DATE,
    @gioiTinh INT,
    @dienThoai VARCHAR(15),
    @email NVARCHAR(100)
AS
BEGIN
    UPDATE tbGiangVien
    SET
        hoTenDemGV = @hoTenDemGV,
        tenGV = @tenGV,
        ngaySinh = @ngaySinh,
        gioiTinh = @gioiTinh,
        dienThoai = @dienThoai,
        email = @email
    WHERE maGV = @maGV;
    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE UpdateMonHoc
    @maMonHoc VARCHAR(100),
    @tenMonHoc NVARCHAR(100),
    @soTinChi int
AS
BEGIN
    UPDATE tbMonHoc
    SET 
        tenMonHoc = @tenMonHoc,
        soTinChi = @soTinChi
    WHERE maMonHoc = @maMonHoc;

    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE UpdateSinhVien
    @maSV VARCHAR(100),
	@hoTenDemSV NVARCHAR(100),
    @tenSV NVARCHAR(100),
    @ngaySinh DATE,
    @gioiTinh INT,
    @queQuan NVARCHAR(100),
    @dienThoai VARCHAR(15),
    @email NVARCHAR(100)
AS
BEGIN
    UPDATE tbSinhVien
    SET
        hoTenDemSV = @hoTenDemSV,
        tenSV = @tenSV,
        ngaySinh = @ngaySinh,
        gioiTinh = @gioiTinh,
        queQuan = @queQuan,
        dienThoai = @dienThoai,
        email = @email
    WHERE maSV = @maSV;
    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE updateLopHoc
    @maLopHoc int,
    @maMonHoc VARCHAR(30),
    @maGV VARCHAR(30)
AS
BEGIN
    UPDATE tbLopHoc
    set maMonHoc = @maMonHoc,
        maGV = @maGV
    WHERE maLopHoc = @maLopHoc
    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE UpdateDiem
    @maSV VARCHAR(100),
	@maLopHoc INT,
    @diemlan1 FLOAT,
    @diemlan2 FLOAT
AS
BEGIN
    UPDATE tbDiemThi
    SET
        diemlan1 =@diemlan1,
        diemlan2 =@diemlan2
    WHERE maSV = @maSV
	and maLopHoc = @maLopHoc;
    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO
----------------------------------------------------------------
----------------------------------------------------------------
CREATE PROCEDURE PrcLogin
    @loaiTk VARCHAR(30),
    @UserName VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    IF @loaiTk = 'admin'
        SELECT * FROM tbAccount WHERE UserName = @UserName AND Password = @Password;
    ELSE IF @loaiTk = 'sv' 
        SELECT * FROM tbSinhVien WHERE maSV = @UserName AND Password = @Password;
    ELSE
        SELECT * FROM tbGiangVien WHERE maGV = @UserName AND Password = @Password;
END
GO
