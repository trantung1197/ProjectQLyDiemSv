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
END;

Select * from tbSinhVien order by tenSV
go
UpdateSinhVien 'SV1122',N'Võ Thái',N'Lâm','2000-11-11',1,N'Đồng Nai','0123654012','lam1122@gmail.com'
go
Select * from tbSinhVien order by tenSV
