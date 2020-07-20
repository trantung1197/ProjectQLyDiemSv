
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
-- select * from tbDiemThi Where maLopHoc = 1
-- select * from tbLopHoc Where maLopHoc = 1