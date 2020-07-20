CREATE PROCEDURE UpdateDiem
    @maSV VARCHAR(100),
    @diemlan1 FLOAT,
    @diemlan2 FLOAT
AS
BEGIN
    UPDATE tbDiemThi
    SET
        diemlan1 =@diemlan1,
        diemlan2 =@diemlan2
    WHERE maSV = @maSV;
    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END
GO