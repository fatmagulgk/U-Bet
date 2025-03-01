USE [master]
GO
/****** Object:  Database [Ucbetdb]    Script Date: 16.01.2023 07:39:57 ******/
CREATE DATABASE [Ucbetdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ucbetdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ucbetdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ucbetdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Ucbetdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ucbetdb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ucbetdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ucbetdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ucbetdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ucbetdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ucbetdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ucbetdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ucbetdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ucbetdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ucbetdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ucbetdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ucbetdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ucbetdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ucbetdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ucbetdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ucbetdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ucbetdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ucbetdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ucbetdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ucbetdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ucbetdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ucbetdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ucbetdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ucbetdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ucbetdb] SET RECOVERY FULL 
GO
ALTER DATABASE [Ucbetdb] SET  MULTI_USER 
GO
ALTER DATABASE [Ucbetdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ucbetdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ucbetdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ucbetdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ucbetdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ucbetdb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Ucbetdb', N'ON'
GO
ALTER DATABASE [Ucbetdb] SET QUERY_STORE = OFF
GO
USE [Ucbetdb]
GO
/****** Object:  Table [dbo].[Bilet]    Script Date: 16.01.2023 07:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bilet](
	[biletID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciId] [int] NOT NULL,
	[ucusIdd] [int] NOT NULL,
	[kampanyaId] [int] NOT NULL,
	[biletDurum] [bit] NOT NULL,
 CONSTRAINT [PK_Bilet] PRIMARY KEY CLUSTERED 
(
	[biletID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kampanyalar]    Script Date: 16.01.2023 07:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kampanyalar](
	[kampanyaID] [int] IDENTITY(1,1) NOT NULL,
	[kampanyaAd] [nvarchar](50) NOT NULL,
	[kampanyaAciklama] [nvarchar](100) NOT NULL,
	[kampanyaGorsel] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Kampanyalar] PRIMARY KEY CLUSTERED 
(
	[kampanyaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Koltuk]    Script Date: 16.01.2023 07:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Koltuk](
	[koltukID] [int] IDENTITY(1,1) NOT NULL,
	[koltukNo] [nvarchar](50) NOT NULL,
	[koltukDurumu] [bit] NOT NULL,
 CONSTRAINT [PK_Koltuk] PRIMARY KEY CLUSTERED 
(
	[koltukID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 16.01.2023 07:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[yetkiId] [int] NOT NULL,
	[TCno] [nvarchar](11) NULL,
	[pasaportNo] [nvarchar](7) NULL,
	[ad] [nvarchar](50) NOT NULL,
	[soyad] [nvarchar](50) NOT NULL,
	[uyruk] [nvarchar](50) NOT NULL,
	[doğumt] [date] NOT NULL,
	[cinsiyet] [nvarchar](50) NULL,
	[telefonNo] [nvarchar](50) NOT NULL,
	[Eposta] [nvarchar](50) NOT NULL,
	[kullaniciSifre] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ucuslar]    Script Date: 16.01.2023 07:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ucuslar](
	[ucusID] [int] IDENTITY(1,1) NOT NULL,
	[kalkisYeri] [nvarchar](50) NOT NULL,
	[varisYeri] [nvarchar](50) NOT NULL,
	[ucusTarih] [date] NOT NULL,
	[ucusSaat] [time](7) NOT NULL,
	[bagaj] [nvarchar](50) NOT NULL,
	[fiyat] [money] NOT NULL,
	[koltukId] [int] NOT NULL,
 CONSTRAINT [PK_Ucuslar] PRIMARY KEY CLUSTERED 
(
	[ucusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetki]    Script Date: 16.01.2023 07:39:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetki](
	[yetkiID] [int] IDENTITY(1,1) NOT NULL,
	[yetkiAd] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Yetki] PRIMARY KEY CLUSTERED 
(
	[yetkiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Koltuk] ON 

INSERT [dbo].[Koltuk] ([koltukID], [koltukNo], [koltukDurumu]) VALUES (1, N'A1', 1)
INSERT [dbo].[Koltuk] ([koltukID], [koltukNo], [koltukDurumu]) VALUES (2, N'A2', 1)
INSERT [dbo].[Koltuk] ([koltukID], [koltukNo], [koltukDurumu]) VALUES (3, N'A3', 1)
INSERT [dbo].[Koltuk] ([koltukID], [koltukNo], [koltukDurumu]) VALUES (5, N'A4', 0)
INSERT [dbo].[Koltuk] ([koltukID], [koltukNo], [koltukDurumu]) VALUES (6, N'A5', 0)
INSERT [dbo].[Koltuk] ([koltukID], [koltukNo], [koltukDurumu]) VALUES (7, N'A6', 0)
INSERT [dbo].[Koltuk] ([koltukID], [koltukNo], [koltukDurumu]) VALUES (8, N'A7', 1)
INSERT [dbo].[Koltuk] ([koltukID], [koltukNo], [koltukDurumu]) VALUES (9, N'A8', 0)
SET IDENTITY_INSERT [dbo].[Koltuk] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetki] ON 

INSERT [dbo].[Yetki] ([yetkiID], [yetkiAd]) VALUES (1, N'Admin')
INSERT [dbo].[Yetki] ([yetkiID], [yetkiAd]) VALUES (2, N'Müşteri')
SET IDENTITY_INSERT [dbo].[Yetki] OFF
GO
ALTER TABLE [dbo].[Bilet]  WITH CHECK ADD  CONSTRAINT [FK_Bilet_Kampanyalar] FOREIGN KEY([kampanyaId])
REFERENCES [dbo].[Kampanyalar] ([kampanyaID])
GO
ALTER TABLE [dbo].[Bilet] CHECK CONSTRAINT [FK_Bilet_Kampanyalar]
GO
ALTER TABLE [dbo].[Bilet]  WITH CHECK ADD  CONSTRAINT [FK_Bilet_Kullanici] FOREIGN KEY([kullaniciId])
REFERENCES [dbo].[Kullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[Bilet] CHECK CONSTRAINT [FK_Bilet_Kullanici]
GO
ALTER TABLE [dbo].[Bilet]  WITH CHECK ADD  CONSTRAINT [FK_Bilet_Ucuslar] FOREIGN KEY([ucusIdd])
REFERENCES [dbo].[Ucuslar] ([ucusID])
GO
ALTER TABLE [dbo].[Bilet] CHECK CONSTRAINT [FK_Bilet_Ucuslar]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Yetki1] FOREIGN KEY([yetkiId])
REFERENCES [dbo].[Yetki] ([yetkiID])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Yetki1]
GO
ALTER TABLE [dbo].[Ucuslar]  WITH CHECK ADD  CONSTRAINT [FK_Ucuslar_Koltuk] FOREIGN KEY([koltukId])
REFERENCES [dbo].[Koltuk] ([koltukID])
GO
ALTER TABLE [dbo].[Ucuslar] CHECK CONSTRAINT [FK_Ucuslar_Koltuk]
GO
USE [master]
GO
ALTER DATABASE [Ucbetdb] SET  READ_WRITE 
GO
