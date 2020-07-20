

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

SELECT * FROM tbMonHoc
go
SelectAllMonHoc N'lập'