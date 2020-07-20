CREATE PROCEDURE DangkyMon
    @maSV VARCHAR(100),
    @maLopHoc INT
AS
BEGIN

    DECLARE @v_daDangKy int,
            @v_maMonHoc VARCHAR(30);

	SELECT @v_daDangKy = count(*)
    FROM tbDiemThi d
    inner join tbLopHoc l on d.maLopHoc = l.maLopHoc
    WHERE l.maMonHoc = @v_maMonHoc AND d.maSV = @maSV

    IF @v_daDangKy > 0 return -1;

    INSERT INTO tbDiemThi(maSV, maLopHoc)
    VALUES(@maSV, @maLopHoc);

    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END

