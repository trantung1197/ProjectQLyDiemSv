CREATE PROCEDURE SelectOneSv
    @maSV VARCHAR(100)
AS
BEGIN 
    SELECT
        hoTenDemSV,
        tenSV,
        CONVERT(VARCHAR(10), ngaySinh, 103) as ngaySinh,
        gioiTinh,
        queQuan, 
        dienThoai, 
        email
    FROM tbSinhVien
    WHERE maSV = @maSV;
END

-- SELECT * FROM tbSinhVien

-- EXEC SelectOneSv 'SV1112'