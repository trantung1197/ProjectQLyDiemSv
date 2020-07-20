EXEC SelectAllSinhVien N'';

SELECT * FROM tbSinhVien

DROP PROCEDURE SelectAllSinhVien 

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