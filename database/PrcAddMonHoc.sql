
CREATE PROCEDURE AddMonHoc
    @tenMonHoc NVARCHAR(100),
    @maMonHoc varchar(100),
    @soTinChi int
AS
BEGIN
    INSERT INTO tbMonHoc
    (tenMonHoc, maMonHoc, soTinChi)
    VALUES
    (@tenMonHoc, @maMonHoc, @soTinChi);

    IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
    ELSE BEGIN RETURN 0 END;
END

AddMonHoc N'Ngôn ngữ lập trình Dart', 'lang_dart', 3 
go
select * from tbMonHoc