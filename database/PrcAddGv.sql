


CREATE PROCEDURE AddGiangVien --Procedure thêm mới giảng viên
    @hoTenDemGV NVARCHAR(100),
    @tenGV NVARCHAR(100),
    @ngaySinh DATE,
    @gioiTinh INT,
    @dienThoai VARCHAR(15),
    @email VARCHAR(100)
AS
BEGIN
   INSERT INTO tbGiangVien
   (
        maGV,
        hoTenDemGV,
        tenGV,
        ngaySinh,
        gioiTinh,
        dienThoai,
        email
   )
   VALUES
   (
      'GV'+CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)),
      @hoTenDemGV,
      @tenGV,
      @ngaySinh,
      @gioiTinh,
      @dienThoai,
      @email
   );

   IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
   ELSE BEGIN RETURN 0 END;
END    

select * from tbGiangVien order by tenGV
go

AddGiangVien N'Phan Văn', N'Trị', '1978-01-01', 1, '0262621151', 'phantri@gmail.com'
go

select * from tbGiangVien order by tenGV