CREATE PROCEDURE AddSinhVien --Procedure thêm mới sinh viên
    @hoTenDemSV NVARCHAR(100),
    @tenSV NVARCHAR(100),
    @ngaySinh DATE,
    @gioiTinh INT,
    @queQuan NVARCHAR(100),
    @dienThoai VARCHAR(15),
    @email VARCHAR(100)
AS
BEGIN
   INSERT INTO tbSinhVien
   (
      maSV,
      hoTenDemSV,
      tenSV,
      ngaySinh,
      gioiTinh,
      queQuan,
      dienThoai,
      email
   )
   VALUES
   (
      'SV'+CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)),
      @hoTenDemSV,
      @tenSV,
      @ngaySinh,
      @gioiTinh,
      @queQuan,
      @dienThoai,
      @email
   );

   IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
   ELSE BEGIN RETURN 0 END;
END    

-- EXEC AddSinhVien N'Đinh Thị', N'Thoa', '2000-12-03', 0, N'Yên Bái', '0232132443', 'thoa23232@gmail.com'

-- SELECT * FROM tbSinhVien

