CREATE PROCEDURE SelectAllGiangVien
    @tuKhoa NVARCHAR(50)
AS
BEGIN
    SELECT
        maGV,
        hoTenDemGV,
        tenGV,
        CASE WHEN gioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS gioiTinh,
        convert(varchar(10),ngaysinh,103) as ngaysinh,
        dienThoai,
        email
    FROM tbGiangVien
    WHERE
    lower(hoTenDemGV) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(tenGV) like '%'+lower(trim(@tuKhoa))+'%'
    or dienThoai like '%'+lower(trim(@tuKhoa))+'%'
    or cast(maGV as VARCHAR(30)) like '%'+lower(trim(@tuKhoa))+'%'
    or lower(email) like '%'+lower(trim(@tuKhoa))+'%' 
    order by tenGV;
END

select * from tbGiangVien
go
SelectAllGiangVien N''