CREATE PROCEDURE DsLopCuaGV
    @maGV VARCHAR(100)
AS
BEGIN
    SELECT 
        tb.maLopHoc,
        tb.maMonHoc,
        tb.tenMonHoc,
        tb.soTinChi,
        COUNT(d.maSV) as stt
    FROM
    (   
        SELECT
            l.maLopHoc,
            l.maMonHoc,
            m.tenMonHoc,
            m.soTinChi
        FROM tbLopHoc l
        inner join tbMonHoc m on l.maMonHoc = m.maMonHoc
        WHERE l.maGV = @maGV
    ) AS tb inner join tbDiemThi d on d.maLopHoc = tb.maLopHoc
    GROUP BY tb.maLopHoc, tb.maMonHoc,tb.tenMonHoc,tb.soTinChi
END
GO


-- SELECT 
--     tb.maLopHoc,
--     tb.maMonHoc,
--     tb.tenMonHoc,
--     tb.soTinChi,
--     COUNT(d.maSV) as stt
-- FROM
-- (   
--     SELECT
--         l.maLopHoc,
--         l.maMonHoc,
--         m.tenMonHoc,
--         m.soTinChi
--     FROM tbLopHoc l
--     inner join tbMonHoc m on l.maMonHoc = m.maMonHoc
--     WHERE l.maGV = 'gv1112'
-- )   AS tb inner join tbDiemThi d on d.maLopHoc = tb.maLopHoc
-- GROUP BY tb.maLopHoc, tb.maMonHoc,tb.tenMonHoc,tb.soTinChi