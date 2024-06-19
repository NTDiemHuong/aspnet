USE [NTDHCNTT2Lesson07Db]
GO
/****** Object:  Table [dbo].[NTDHKhoa]    Script Date: 17/06/2024 2:40:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NTDHKhoa](
	[NTDHMaKH] [nchar](10) NOT NULL,
	[NTDHtenKH] [nvarchar](50) NULL,
	[NTDHTrangThai] [bit] NULL,
 CONSTRAINT [PK_NTDHKhoa] PRIMARY KEY CLUSTERED 
(
	[NTDHMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NTDHSinhVien]    Script Date: 17/06/2024 2:40:36 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NTDHSinhVien](
	[NTDHMaSV] [nvarchar](50) NOT NULL,
	[NTDHHoSV] [nvarchar](50) NULL,
	[NTDHTenSV] [nvarchar](50) NULL,
	[NTDHNgaySinh] [date] NULL,
	[NTDHPhai] [bit] NULL,
	[NTDHPhone] [nchar](10) NULL,
	[NTDHEmail] [nvarchar](50) NULL,
	[NTDHMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_NTDHSinhVien] PRIMARY KEY CLUSTERED 
(
	[NTDHMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NTDHKhoa] (NTDH, [NTDHtenKH], [NTDHTrangThai]) VALUES (N'CNTT3     ', N'CNTT2', 1)
GO
INSERT [dbo].[NTDHSinhVien] ([NTDHMaSV], [NTDHHoSV], [NTDHTenSV], [NTDHNgaySinh], [NTDHPhai], [NTDHPhone], [NTDHEmail], [NTDHMaKH]) VALUES (N'2210900027', N'Nguyễn Thị Diễm Hương', N'Hương', CAST(N'2004-10-18' AS Date), 1, N'0383520274', N'huongntd1810@gmail.com', N'CNTT2     ')
GO
