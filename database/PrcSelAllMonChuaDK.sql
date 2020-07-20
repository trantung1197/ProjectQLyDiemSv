CREATE PROCEDURE DsLopChuaDKy
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