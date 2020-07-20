CREATE PROCEDURE updateLopHoc
    @maLopHoc int,
    @maMonHoc VARCHAR(30),
    @maGV VARCHAR(30)
AS
BEGIN
    UPDATE tbLopHoc
    set maMonHoc = @maMonHoc,
        maGV = @maGV
    WHERE maLopHoc = @maLopHoc
    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END