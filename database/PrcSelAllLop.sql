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

--SelectAllLopHoc N'Ph'