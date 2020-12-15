USE [master]
GO
/****** Object:  Database [SHOPBANTHUOCAPI2020]    Script Date: 12/15/2020 5:49:21 PM ******/
CREATE DATABASE [SHOPBANTHUOCAPI2020]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SHOPBANTHUOCAPI2020', FILENAME = N'D:\SHOPBANTHUOCAPI2020.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SHOPBANTHUOCAPI2020_log', FILENAME = N'D:\SHOPBANTHUOCAPI2020_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SHOPBANTHUOCAPI2020].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET ARITHABORT OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET RECOVERY FULL 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET  MULTI_USER 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SHOPBANTHUOCAPI2020]
GO
/****** Object:  Table [dbo].[CHITIETDONHANG]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETDONHANG](
	[ID_CT] [int] IDENTITY(1,1) NOT NULL,
	[MaDH] [int] NOT NULL,
	[MaSP] [char](15) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_CT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[MaDM] [int] IDENTITY(1,1) NOT NULL,
	[TenDM] [nvarchar](255) NOT NULL,
	[GhiChu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONHANG]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DONHANG](
	[MaDH] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [date] NULL,
	[MaKH] [int] NULL,
	[SDT] [char](20) NULL,
	[HoTen] [nvarchar](255) NULL,
	[Email] [nvarchar](100) NULL,
	[Diachi] [nvarchar](255) NULL,
	[TongTien] [int] NULL,
	[GhiChu] [nvarchar](255) NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[SDT] [nchar](20) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[Email] [nvarchar](100) NULL,
	[MatKhau] [char](100) NOT NULL,
	[Diachi] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLES](
	[IDRole] [int] NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
(
	[IDRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSP] [char](15) NOT NULL,
	[TenSP] [nvarchar](100) NULL,
	[ThanhPhan] [nvarchar](100) NULL,
	[CongDung] [nvarchar](100) NULL,
	[LieuLuong] [nvarchar](255) NULL,
	[GiaBan] [int] NULL,
	[MaDM] [int] NULL,
	[DonVi] [nvarchar](100) NOT NULL,
	[DangThuoc] [nvarchar](100) NOT NULL,
	[HinhAnh] [nchar](255) NULL,
	[MoTa] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOANQUANTRI]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOANQUANTRI](
	[MaQT] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](255) NULL,
	[SDT] [nchar](20) NOT NULL,
	[MatKhau] [nchar](100) NOT NULL,
	[Role] [int] NOT NULL,
 CONSTRAINT [PK__QUANTRI__2725F85A1C938C35] PRIMARY KEY CLUSTERED 
(
	[MaQT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRANGTHAIDONHANG]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAIDONHANG](
	[MaTT] [int] IDENTITY(1,1) NOT NULL,
	[TenTT] [nvarchar](255) NULL,
	[GhiChu] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[VIEWCHITIET]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEWCHITIET] AS
SELECT DH.MaDH, DH.MaKH, CT.MaSP, SP.TenSP, SP.HinhAnh, CT.SoLuong, CT.DonGia, CT.ThanhTien 
FROM dbo.CHITIETDONHANG CT, dbo.DONHANG DH, dbo.SANPHAM SP
WHERE CT.MaDH =DH.MaDH AND CT.MaSP = SP.MaSP

GO
/****** Object:  View [dbo].[VIEWDONHANG]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEWDONHANG]
AS
SELECT DH.MaDH, DH.NgayLap, DH.MaKH, DH.HoTen, DH.SDT, DH.Email, DH.Diachi, DH.TongTien, TT.MaTT, TT.TenTT, TT.GhiChu
FROM     dbo.DONHANG AS DH INNER JOIN
                  dbo.TRANGTHAIDONHANG AS TT ON TT.MaTT = DH.TrangThai

GO
SET IDENTITY_INSERT [dbo].[CHITIETDONHANG] ON 

INSERT [dbo].[CHITIETDONHANG] ([ID_CT], [MaDH], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (1, 1, N'2020122        ', 2, 22000, 44000)
INSERT [dbo].[CHITIETDONHANG] ([ID_CT], [MaDH], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (2, 2, N'2020122        ', 2, 22000, 44000)
INSERT [dbo].[CHITIETDONHANG] ([ID_CT], [MaDH], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (3, 2, N'2020124        ', 1, 22000, 22000)
INSERT [dbo].[CHITIETDONHANG] ([ID_CT], [MaDH], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (4, 2, N'2020125        ', 1, 22000, 22000)
INSERT [dbo].[CHITIETDONHANG] ([ID_CT], [MaDH], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (5, 3, N'2020126        ', 1, 79000, 79000)
INSERT [dbo].[CHITIETDONHANG] ([ID_CT], [MaDH], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (6, 4, N'2020122        ', 1, 22000, 22000)
INSERT [dbo].[CHITIETDONHANG] ([ID_CT], [MaDH], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (7, 4, N'2020123        ', 1, 9000, 9000)
SET IDENTITY_INSERT [dbo].[CHITIETDONHANG] OFF
SET IDENTITY_INSERT [dbo].[DANHMUC] ON 

INSERT [dbo].[DANHMUC] ([MaDM], [TenDM], [GhiChu]) VALUES (1, N'THUỐC ĐÔNG Y', N'')
INSERT [dbo].[DANHMUC] ([MaDM], [TenDM], [GhiChu]) VALUES (2, N'THỰC PHẨM CHỨC NĂNG', N'')
INSERT [dbo].[DANHMUC] ([MaDM], [TenDM], [GhiChu]) VALUES (4, N'SẢN PHẨM KHỬ KHUẨN', N'')
INSERT [dbo].[DANHMUC] ([MaDM], [TenDM], [GhiChu]) VALUES (6, N'Dụng cụ y tế', NULL)
SET IDENTITY_INSERT [dbo].[DANHMUC] OFF
SET IDENTITY_INSERT [dbo].[DONHANG] ON 

INSERT [dbo].[DONHANG] ([MaDH], [NgayLap], [MaKH], [SDT], [HoTen], [Email], [Diachi], [TongTien], [GhiChu], [TrangThai]) VALUES (1, CAST(N'2020-12-05' AS Date), 1, N'0362869837          ', N'Đồng Văn Hùng', N'tata.dongvanhung@gmail.com', N'Kim Tân', 44000, N'Xin chào', 5)
INSERT [dbo].[DONHANG] ([MaDH], [NgayLap], [MaKH], [SDT], [HoTen], [Email], [Diachi], [TongTien], [GhiChu], [TrangThai]) VALUES (2, CAST(N'2020-12-05' AS Date), 1, N'0362869837          ', N'Đồng Văn Hùng', N'tata.dongvanhung@gmail.com', N'123456', 88000, N'Test2', 2)
INSERT [dbo].[DONHANG] ([MaDH], [NgayLap], [MaKH], [SDT], [HoTen], [Email], [Diachi], [TongTien], [GhiChu], [TrangThai]) VALUES (3, CAST(N'2020-12-08' AS Date), 3, N'0974250427          ', N'Lỗ Trung Hiếu', N'lotrunghieu2011@gmail.com', N'Đình Thôn, Mỹ Đình, Nam Từ Liêm, Hà Nội', 79000, NULL, 5)
INSERT [dbo].[DONHANG] ([MaDH], [NgayLap], [MaKH], [SDT], [HoTen], [Email], [Diachi], [TongTien], [GhiChu], [TrangThai]) VALUES (4, CAST(N'2020-12-14' AS Date), 3, N'0974250427          ', N'Lỗ Trung Hiếu', N'lotrunghieu2011@gmail.com', N'Đình Thôn, Mỹ Đình, Nam Từ Liêm, Hà Nội', 31000, NULL, 2)
SET IDENTITY_INSERT [dbo].[DONHANG] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [HoTen], [Email], [MatKhau], [Diachi]) VALUES (1, N'0362869837          ', N'Đồng Văn Hùng', N'tata.dongvanhung@gmail.com', N'$2a$14$iGRBRwMp7whK0fCxHG3WB.XwCwsiQlvXs5IocuzI13HD8Q80a4EYu                                        ', N'Kim Tân, Kim Thành, Hải Dương')
INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [HoTen], [Email], [MatKhau], [Diachi]) VALUES (2, N'0362869839          ', N'Dong Van Hung', N'hungdong@gmail.com', N'$2a$14$Y1B45Zt49Uuv9R.4zbZTzeFCnnch3KAGkydGM1kJydg1Hw.KaM80m                                        ', N'Hà Nội')
INSERT [dbo].[KHACHHANG] ([MaKH], [SDT], [HoTen], [Email], [MatKhau], [Diachi]) VALUES (3, N'0974250427          ', N'Lỗ Trung Hiếu', N'lotrunghieu2011@gmail.com', N'$2a$14$kjg23RhD58vopqy/7qj5q.rp/dNonqZRVF.rLT/b/MDbEIZYouteK                                        ', N'Đình Thôn, Mỹ Đình, Nam Từ Liêm, Hà Nội')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
INSERT [dbo].[ROLES] ([IDRole], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[ROLES] ([IDRole], [RoleName]) VALUES (2, N'Member')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [ThanhPhan], [CongDung], [LieuLuong], [GiaBan], [MaDM], [DonVi], [DangThuoc], [HinhAnh], [MoTa]) VALUES (N'2020121        ', N'Geo Rửa Tay', N'Ethanol, Nước tinh khiết, Benzalkonium Chloride', N'Diệt Khuẩn, Khử trùng', N'Luôn sử dụng', 40000, 4, N'Chai 200ml', N'geo lỏng', N'geo-rua-tay.jpg                                                                                                                                                                                                                                                ', NULL)
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [ThanhPhan], [CongDung], [LieuLuong], [GiaBan], [MaDM], [DonVi], [DangThuoc], [HinhAnh], [MoTa]) VALUES (N'2020122        ', N'Nước muối Vĩnh Phúc', N'NaCl, Nước tinh khiết, Benzalkonium Chloride', N'Diệt Khuẩ, Khử trùng', N'Luôn sử dụng', 22000, 4, N'Chai 200ml', N'geo', N'nuoc-muoi.jpg                                                                                                                                                                                                                                                  ', N'Phòng ngừa Đại dịch COVID 19, Bộ Y Tế khuyến cáo người dân rửa tay thường xuyên')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [ThanhPhan], [CongDung], [LieuLuong], [GiaBan], [MaDM], [DonVi], [DangThuoc], [HinhAnh], [MoTa]) VALUES (N'2020123        ', N'Cồn 90 độ', N'Ethanol, Nước tinh khiết', N'Diệt Khuẩ, Khử trùng', N'Khuyến cáo', 9000, 4, N'Chai 200ml', N'Chai dung dịch', N'con-90.jpg                                                                                                                                                                                                                                                     ', N'Dung dịch Cồn 90 độ hay còn được gọi là cồn y tế có tác dụng diệt vi khuẩn, siêu vi khuẩn và các loại nấm. Trong y tế, các loại cồn sát trùng này thường được dùng để: sát trùng dụng cụ y tế, sát trùng phần mô trước khi tiêm, phẫu thuật…')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [ThanhPhan], [CongDung], [LieuLuong], [GiaBan], [MaDM], [DonVi], [DangThuoc], [HinhAnh], [MoTa]) VALUES (N'2020124        ', N'Oxi Già', N'oxy già đậm đặc 6,03g, Acid benzoic, Ethanol 96%.', N'Diệt Khuẩ, Khử trùng', N'Luôn sử dụng', 22000, 4, N'Chai 200ml', N'Chai dung dịch', N'oxi-gia.jpg                                                                                                                                                                                                                                                    ', N'Dung dịch Oxy Già 3% còn có tên là Hydrogen Peroxide. Oxy già là dung dịch trong suốt có tác dụng khử trùng, sát khuẩn rất thông dụng trong y tế. ')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [ThanhPhan], [CongDung], [LieuLuong], [GiaBan], [MaDM], [DonVi], [DangThuoc], [HinhAnh], [MoTa]) VALUES (N'2020125        ', N'Nước muối 5', N'NaCl, Nước tinh khiết, Benzalkonium Chloride', N'Diệt Khuẩ, Khử trùng', N'Tùy chọn', 22000, 1, N'Chai 750ml', N'dung dịch lỏng', N'khu-khuan-be-mat.jpg                                                                                                                                                                                                                                           ', N'ALFASEPT SURFACE-RTU là dung dịch sát khuẩn được sử dụng để khử khuẩn nhanh các bề mặt, lau làm sạch các dụng cụ đồ dùng thường ngày.

An toàn, dễ sử dụng, phòng tránh nguy cơ lây nhiễm.

Phổ diệt khuẩn rộng bao gồm các loại vi khuẩn, nấm')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [ThanhPhan], [CongDung], [LieuLuong], [GiaBan], [MaDM], [DonVi], [DangThuoc], [HinhAnh], [MoTa]) VALUES (N'2020126        ', N'ALFASEPT SURFACE-RTU', N'Didecyl dimethyl ammonium chloride, Poly, Ethanol', N'Khử khuẩn nhanh các bề mặt', N'', 99000, 4, N'Chai 750ml', N'Chai dung dịch', N'khu-khuan-be-mat.jpg                                                                                                                                                                                                                                           ', N'ALFASEPT SURFACE-RTU là dung dịch sát khuẩn được sử dụng để khử khuẩn nhanh các bề mặt, lau làm sạch các dụng cụ đồ dùng thường ngày.

An toàn, dễ sử dụng, phòng tránh nguy cơ lây nhiễm.

Phổ diệt khuẩn rộng bao gồm các loại vi khuẩn, nấm.')
SET IDENTITY_INSERT [dbo].[TAIKHOANQUANTRI] ON 

INSERT [dbo].[TAIKHOANQUANTRI] ([MaQT], [HoTen], [SDT], [MatKhau], [Role]) VALUES (1, N'lotrunghieu', N'0983975031          ', N'123                                                                                                 ', 1)
INSERT [dbo].[TAIKHOANQUANTRI] ([MaQT], [HoTen], [SDT], [MatKhau], [Role]) VALUES (2, N'dongvanhung', N'0977825412          ', N'1234                                                                                                ', 2)
INSERT [dbo].[TAIKHOANQUANTRI] ([MaQT], [HoTen], [SDT], [MatKhau], [Role]) VALUES (4, N'trung hieu', N'0983975034          ', N'123                                                                                                 ', 1)
SET IDENTITY_INSERT [dbo].[TAIKHOANQUANTRI] OFF
SET IDENTITY_INSERT [dbo].[TRANGTHAIDONHANG] ON 

INSERT [dbo].[TRANGTHAIDONHANG] ([MaTT], [TenTT], [GhiChu]) VALUES (1, N'Chưa xác nhận', N'Chưa xác nhận')
INSERT [dbo].[TRANGTHAIDONHANG] ([MaTT], [TenTT], [GhiChu]) VALUES (2, N'Đã xác nhận', NULL)
INSERT [dbo].[TRANGTHAIDONHANG] ([MaTT], [TenTT], [GhiChu]) VALUES (3, N'Đang đóng gói', NULL)
INSERT [dbo].[TRANGTHAIDONHANG] ([MaTT], [TenTT], [GhiChu]) VALUES (4, N'Đang vận chuyển', NULL)
INSERT [dbo].[TRANGTHAIDONHANG] ([MaTT], [TenTT], [GhiChu]) VALUES (5, N'Hoàn thành', NULL)
INSERT [dbo].[TRANGTHAIDONHANG] ([MaTT], [TenTT], [GhiChu]) VALUES (6, N'Đã hủy', NULL)
SET IDENTITY_INSERT [dbo].[TRANGTHAIDONHANG] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__QUANTRI__CA1930A5B69A7E59]    Script Date: 12/15/2020 5:49:21 PM ******/
ALTER TABLE [dbo].[TAIKHOANQUANTRI] ADD  CONSTRAINT [UQ__QUANTRI__CA1930A5B69A7E59] UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETDONHANG]  WITH CHECK ADD FOREIGN KEY([MaDH])
REFERENCES [dbo].[DONHANG] ([MaDH])
GO
ALTER TABLE [dbo].[CHITIETDONHANG]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SANPHAM] ([MaSP])
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD FOREIGN KEY([TrangThai])
REFERENCES [dbo].[TRANGTHAIDONHANG] ([MaTT])
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD FOREIGN KEY([MaDM])
REFERENCES [dbo].[DANHMUC] ([MaDM])
GO
ALTER TABLE [dbo].[TAIKHOANQUANTRI]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOANQUANTRI_ROLES] FOREIGN KEY([Role])
REFERENCES [dbo].[ROLES] ([IDRole])
GO
ALTER TABLE [dbo].[TAIKHOANQUANTRI] CHECK CONSTRAINT [FK_TAIKHOANQUANTRI_ROLES]
GO
/****** Object:  StoredProcedure [dbo].[updateTKQT]    Script Date: 12/15/2020 5:49:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateTKQT]
	@maQT int,
	@role int
as
begin
	delete USEinROLES where MaQT=@maQT
	insert into USEinROLES 
	values (@maQT,@role)
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DH"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TT"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 316
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 11
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1572
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEWDONHANG'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VIEWDONHANG'
GO
USE [master]
GO
ALTER DATABASE [SHOPBANTHUOCAPI2020] SET  READ_WRITE 
GO
