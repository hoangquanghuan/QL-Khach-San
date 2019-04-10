USE [master]
GO
/****** Object:  Database [QuanLyKhachSan9]    Script Date: 10/04/2019 11:13:15 ******/
CREATE DATABASE [QuanLyKhachSan9]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyKhachSan9', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyKhachSan9.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyKhachSan9_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyKhachSan9_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyKhachSan9] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyKhachSan9].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyKhachSan9] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyKhachSan9] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhachSan9] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyKhachSan9] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyKhachSan9] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyKhachSan9] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan9] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyKhachSan9] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyKhachSan9] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyKhachSan9] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyKhachSan9] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyKhachSan9] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyKhachSan9]
GO
/****** Object:  Table [dbo].[CT_PHIEUDATPHONG]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUDATPHONG](
	[MAPHIEUDAT] [nchar](10) NOT NULL,
	[MAPHONG] [nchar](10) NOT NULL,
 CONSTRAINT [PK_CT_PHIEUDATPHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUDAT] ASC,
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PHIEUTHUEPHONG]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUTHUEPHONG](
	[MAPHIEUTHUE] [nchar](10) NOT NULL,
	[MAPHONG] [nchar](10) NOT NULL,
	[MA_DV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_CT_PHIEUTHUE[HONG] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUTHUE] ASC,
	[MAPHONG] ASC,
	[MA_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MA_DV] [nchar](10) NOT NULL,
	[TEN_DV] [nvarchar](50) NULL,
	[GIA] [int] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MA_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MA_HD] [nchar](10) NOT NULL,
	[MA_NV] [nchar](10) NULL,
	[MA_KH] [nchar](10) NULL,
	[MAPHIEUTHUE] [nchar](10) NULL,
	[NGAY_THANH_TOAN] [date] NULL,
	[HINHTHUC] [nvarchar](50) NULL,
	[TONGTIEN] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MA_HD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MA_KH] [nchar](10) NOT NULL,
	[HT_KH] [nvarchar](50) NULL,
	[NS] [date] NULL,
	[GT] [nchar](10) NULL,
	[CMND] [nchar](15) NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MA_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MA_LP] [nchar](10) NOT NULL,
	[TEN_LP] [nvarchar](50) NULL,
	[GIA] [int] NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MA_LP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MA_NV] [nchar](10) NOT NULL,
	[HT_NV] [nvarchar](50) NULL,
	[GT] [nchar](10) NULL,
	[NS] [date] NULL,
	[DC] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MA_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUDATPHONG]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDATPHONG](
	[MAPHIEUDAT] [nchar](10) NOT NULL,
	[MA_KH] [nchar](10) NULL,
	[NGAYDAT] [date] NULL,
	[NGAYNHANPHONG] [date] NULL,
	[SONGUOI] [int] NULL,
 CONSTRAINT [PK_PHIEUDATPHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUDAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTHUEPHONG]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUEPHONG](
	[MAPHIEUTHUE] [nchar](10) NOT NULL,
	[SONGUOI] [int] NULL,
	[NGAYDEN] [date] NULL,
	[NGAYDI] [date] NULL,
	[MAPHIEUDAT] [nchar](10) NULL,
 CONSTRAINT [PK_CT_PHIEUTHUEPHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUTHUE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MAPHONG] [nchar](10) NOT NULL,
	[TENPHONG] [nvarchar](50) NULL,
	[MA_LP] [nchar](10) NULL,
	[MA_TT] [nchar](10) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TRANGTHAI]    Script Date: 10/04/2019 11:13:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANGTHAI](
	[MA_TT] [nchar](10) NOT NULL,
	[TEN_TT] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRANGTHANG] PRIMARY KEY CLUSTERED 
(
	[MA_TT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[LOAIPHONG] ([MA_LP], [TEN_LP], [GIA]) VALUES (N'1         ', N'bình thường', 200)
INSERT [dbo].[LOAIPHONG] ([MA_LP], [TEN_LP], [GIA]) VALUES (N'2         ', N'vip', 500)
INSERT [dbo].[PHONG] ([MAPHONG], [TENPHONG], [MA_LP], [MA_TT]) VALUES (N'p001      ', N'p001', N'1         ', N'1         ')
INSERT [dbo].[PHONG] ([MAPHONG], [TENPHONG], [MA_LP], [MA_TT]) VALUES (N'p002      ', N'p002', N'2         ', N'3         ')
INSERT [dbo].[PHONG] ([MAPHONG], [TENPHONG], [MA_LP], [MA_TT]) VALUES (N'p003      ', N'p003', N'2         ', N'2         ')
INSERT [dbo].[PHONG] ([MAPHONG], [TENPHONG], [MA_LP], [MA_TT]) VALUES (N'p004      ', N'p004', N'1         ', N'3         ')
INSERT [dbo].[TRANGTHAI] ([MA_TT], [TEN_TT]) VALUES (N'1         ', N'đã sử dụng')
INSERT [dbo].[TRANGTHAI] ([MA_TT], [TEN_TT]) VALUES (N'2         ', N'đang dọn')
INSERT [dbo].[TRANGTHAI] ([MA_TT], [TEN_TT]) VALUES (N'3         ', N'sẵn sàng')
ALTER TABLE [dbo].[CT_PHIEUDATPHONG]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATPHONG_PHIEUDATPHONG] FOREIGN KEY([MAPHIEUDAT])
REFERENCES [dbo].[PHIEUDATPHONG] ([MAPHIEUDAT])
GO
ALTER TABLE [dbo].[CT_PHIEUDATPHONG] CHECK CONSTRAINT [FK_CT_PHIEUDATPHONG_PHIEUDATPHONG]
GO
ALTER TABLE [dbo].[CT_PHIEUDATPHONG]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATPHONG_PHONG] FOREIGN KEY([MAPHONG])
REFERENCES [dbo].[PHONG] ([MAPHONG])
GO
ALTER TABLE [dbo].[CT_PHIEUDATPHONG] CHECK CONSTRAINT [FK_CT_PHIEUDATPHONG_PHONG]
GO
ALTER TABLE [dbo].[CT_PHIEUTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTHUEPHONG_DICHVU] FOREIGN KEY([MA_DV])
REFERENCES [dbo].[DICHVU] ([MA_DV])
GO
ALTER TABLE [dbo].[CT_PHIEUTHUEPHONG] CHECK CONSTRAINT [FK_CT_PHIEUTHUEPHONG_DICHVU]
GO
ALTER TABLE [dbo].[CT_PHIEUTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTHUEPHONG_PHIEUTHUEPHONG] FOREIGN KEY([MAPHIEUTHUE])
REFERENCES [dbo].[PHIEUTHUEPHONG] ([MAPHIEUTHUE])
GO
ALTER TABLE [dbo].[CT_PHIEUTHUEPHONG] CHECK CONSTRAINT [FK_CT_PHIEUTHUEPHONG_PHIEUTHUEPHONG]
GO
ALTER TABLE [dbo].[CT_PHIEUTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUTHUEPHONG_PHONG] FOREIGN KEY([MAPHONG])
REFERENCES [dbo].[PHONG] ([MAPHONG])
GO
ALTER TABLE [dbo].[CT_PHIEUTHUEPHONG] CHECK CONSTRAINT [FK_CT_PHIEUTHUEPHONG_PHONG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MA_KH])
REFERENCES [dbo].[KHACHHANG] ([MA_KH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MA_NV])
REFERENCES [dbo].[NHANVIEN] ([MA_NV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_PHIEUTHUEPHONG] FOREIGN KEY([MAPHIEUTHUE])
REFERENCES [dbo].[PHIEUTHUEPHONG] ([MAPHIEUTHUE])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_PHIEUTHUEPHONG]
GO
ALTER TABLE [dbo].[PHIEUDATPHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUDATPHONG_KHACHHANG] FOREIGN KEY([MA_KH])
REFERENCES [dbo].[KHACHHANG] ([MA_KH])
GO
ALTER TABLE [dbo].[PHIEUDATPHONG] CHECK CONSTRAINT [FK_PHIEUDATPHONG_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUEPHONG_PHIEUDATPHONG] FOREIGN KEY([MAPHIEUDAT])
REFERENCES [dbo].[PHIEUDATPHONG] ([MAPHIEUDAT])
GO
ALTER TABLE [dbo].[PHIEUTHUEPHONG] CHECK CONSTRAINT [FK_PHIEUTHUEPHONG_PHIEUDATPHONG]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAIPHONG] FOREIGN KEY([MA_LP])
REFERENCES [dbo].[LOAIPHONG] ([MA_LP])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAIPHONG]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_TRANGTHAI] FOREIGN KEY([MA_TT])
REFERENCES [dbo].[TRANGTHAI] ([MA_TT])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_TRANGTHAI]
GO
USE [master]
GO
ALTER DATABASE [QuanLyKhachSan9] SET  READ_WRITE 
GO
