CREATE PROCEDURE AddLopHoc
    @maMonHoc VARCHAR(30),
    @maGV VARCHAR(30)
AS
BEGIN
    INSERT INTO tbLopHoc(maMonHoc, maGV)
    VALUES (@maMonHoc, @maGV)
    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END

--select * from tbGiangVien
--go
--select * from tbMonHoc
--go

--AddLopHoc 'csdl_0','GV1111'

--SelectAllLopHoc ''