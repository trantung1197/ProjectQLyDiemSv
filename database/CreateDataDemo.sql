
CREATE SEQUENCE giangVienSeq
    START WITH 1111 --bắt đầu từ 1111
    INCREMENT BY 1; --mỗi lần tăng 1
GO
    -- SELECT NEXT VALUE FOR giangVienSeq

--seq tự động tăng
CREATE SEQUENCE sinhVienSeq
    START WITH 1111 --bắt đầu từ 0001
    INCREMENT BY 1; --mỗi lần tăng 1
GO
    -- SELECT NEXT VALUE FOR sinhVienSeq


INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Trần Ngọc', N'Tùng', 1, '1978-01-01','0123456789','trantung@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Phạm Xuân', N'Phúc', 0, '1977-02-02','0987654321','phamxuan@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Vũ Văn', N'Lâm', 1, '1976-03-03','0167896789','vanlam@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Nguyễn Văn', N'Quyết', 1, '1975-04-04','0123412349','vanquyet@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Phạm Ngọc', N'Diệp', 0, '1974-05-05','0189898989','ngocdiem@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Vũ Xuân', N'Hoàng', 1, '1973-06-06','0123456234','xuanhoang@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Cao Văn', N'Ân', 1, '1972-07-07','0456456456','caoan@gmail.com');
INSERT INTO tbGiangVien (maGV, hoTenDemGV, tenGV, gioiTinh, ngaySinh, dienThoai, email)
VALUES ('GV' + CAST(NEXT VALUE FOR giangVienSeq AS VARCHAR(30)), N'Quang Nhật', N'Bảo', 1, '1971-08-08','0123443210','quangnhat@gmail.com');
GO



INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('csdl_0', N'Thiết kế cơ sở dữ liệu', 4);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('math_1', N'Toán cao cấp 1', 2);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('math_2', N'Toán cao cấp 2', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('physic_1', N'Vật lý 1', 2);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('physic_2', N'Vật lý 2', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('oop_0', N'Lập trình hướng đối tượng', 4);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('web_0', N'Lập trình web', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('java_core', N'Ngôn ngữ lập trình Java', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('reactjs', N'Thiết kế web với React JS', 3);
INSERT INTO tbMonHoc(maMonHoc, tenMonHoc,soTinChi)
VALUES ('reactnative', N'Lập trình mobile với React Native', 4);
GO

INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Trần Ngọc', N'Tùng', '2000-01-01', 1, N'Hà Nam', '0123654789','tung2011@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Nguyễn Ngọc', N'Ngạn', '2000-02-02', 0, N'Hải Phòng', '0789789789','ngoc555@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Xuân Hải', N'Hậu', '2000-03-03', 1, N'Thanh Hóa', '0123654789','51ssshai@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Văn Sơn', N'Lâm', '2000-04-04', 1, N'Đà Nẵng', '0512364122','sonvan56@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Võ Giang', N'Nguyệt', '2000-05-05', 0, N'Bình Định', '0512364122','giang79@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Cao Ly', N'Ánh', '2000-06-06', 0, N'Huế', '0512364122','ly186@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Lý Tuấn', N'Hưng', '2000-07-07', 1, N'Tiền Giang', '0147854789','tuan111@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Thế Phan', N'Trí', '2000-08-08', 1, N'Đồng Tháp', '0123654365','phan1514@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Phạm', N'Tuân', '2000-09-09', 1, N'Bình Dương', '0478654789','tuan98@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Vũ Hiền', N'Thái', '2000-10-10', 0, N'Vũng Tàu', '0123654369','hien151@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Võ', N'Lâm', '2000-11-11', 1, N'Đồng Nai', '0123654012','lam1122@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Phạm Nhật', N'Quang', '2000-12-12', 1, N'Cao Bằng', '0123612712','nhat1212@gmail.com');
INSERT INTO tbSinhVien(maSV, hoTenDemSV, tenSV, ngaySinh, gioiTinh, queQuan, dienThoai, email)
VALUES ('SV' + CAST(NEXT VALUE FOR sinhVienSeq AS VARCHAR(30)), N'Xuân Trường', N'Anh', '2000-01-01', 1, N'Quảng Ninh', '0121265471','truong20@gmail.com');
GO

-- SELECT *
-- FROM tbMonHoc
-- go

-- SELECT * FROM tbSinhVien
-- go

-- SELECT * FROM tbGiangVien
-- GO