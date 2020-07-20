CREATE PROCEDURE UpdateMonHoc
    @maMonHoc VARCHAR(100),
    @tenMonHoc NVARCHAR(100),
    @soTinChi int
AS
BEGIN
    UPDATE tbMonHoc
    SET 
        tenMonHoc = @tenMonHoc,
        soTinChi = @soTinChi
    WHERE maMonHoc = @maMonHoc;

    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END

select * from tbMonHoc order by tenMonHoc
go
UpdateMonHoc 'csdl_0', N'Cơ sở dữ liệu', 3
go
select * from tbMonHoc order by tenMonHoc
