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

--SelectAllMonDaDk 'sv1112'