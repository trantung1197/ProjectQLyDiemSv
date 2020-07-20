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
END;

SelectAllGiangVien ''
go 
UpdateGiangVien 'GV1118',N'Cao Văn', N'An','1972-11-11', 1,'0456456456','caoan@gmail.com'
go
SelectAllGiangVien ''
