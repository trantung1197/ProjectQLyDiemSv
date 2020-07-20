CREATE PROCEDURE SelectOneGv
    @maGV VARCHAR(100)
AS
BEGIN 
    SELECT
        hoTenDemGV,
        tenGV,
        CONVERT(VARCHAR(10), ngaySinh, 103) as ngaySinh,
        gioiTinh,
        dienThoai, 
        email
    FROM tbGiangVien
    WHERE maGV = @maGV;
END

--selectallgiangvien ''
--go
--SelectOneGv 'GV1116'
--go