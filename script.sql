USE [master]
GO
/****** Object:  Database [StockUygula]    Script Date: 25.06.2020 16:53:22 ******/
CREATE DATABASE [StockUygula]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockUygula', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StockUygula.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StockUygula_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\StockUygula_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StockUygula] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockUygula].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockUygula] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockUygula] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockUygula] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockUygula] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockUygula] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockUygula] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockUygula] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockUygula] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockUygula] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockUygula] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockUygula] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockUygula] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockUygula] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockUygula] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockUygula] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockUygula] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockUygula] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockUygula] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockUygula] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockUygula] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockUygula] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockUygula] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockUygula] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockUygula] SET  MULTI_USER 
GO
ALTER DATABASE [StockUygula] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockUygula] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockUygula] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockUygula] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StockUygula] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StockUygula] SET QUERY_STORE = OFF
GO
USE [StockUygula]
GO
/****** Object:  Table [dbo].[StokHareket]    Script Date: 25.06.2020 16:53:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokHareket](
	[Id] [int] NOT NULL,
	[Girdi] [int] NULL,
	[Cıktı] [int] NULL,
 CONSTRAINT [PK_StokHareket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[StokHareketEkrani]    Script Date: 25.06.2020 16:53:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StokHareketEkrani]
AS
SELECT Id,Girdi,Cıktı,(sum(Girdi)-sum(Cıktı)) AS Sonuc from StokHareket group by Id,Girdi,Cıktı
GO
/****** Object:  Table [dbo].[StokKartı]    Script Date: 25.06.2020 16:53:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokKartı](
	[StokKod] [int] IDENTITY(1,1) NOT NULL,
	[StokKart] [varchar](30) NULL,
 CONSTRAINT [PK_StokKartı] PRIMARY KEY CLUSTERED 
(
	[StokKod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (1, 22, 11)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (2, 22, 11)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (3, 3, 2)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (4, 16, 16)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (5, 5, 4)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (6, 54, 53)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (7, 45, 1)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (8, 55, 12)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (9, 33, 11)
INSERT [dbo].[StokHareket] ([Id], [Girdi], [Cıktı]) VALUES (10, 21, 11)
GO
SET IDENTITY_INSERT [dbo].[StokKartı] ON 

INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (1, N'45')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (2, N'45')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (3, N'Su')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (4, N'Çerez')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (5, N'Sakız')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (6, N'Cips')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (7, N'Muz')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (8, N'ekleme')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (9, N'Mal')
INSERT [dbo].[StokKartı] ([StokKod], [StokKart]) VALUES (10, N'aqs')
SET IDENTITY_INSERT [dbo].[StokKartı] OFF
GO
ALTER TABLE [dbo].[StokHareket]  WITH CHECK ADD  CONSTRAINT [FK_StokHareket_StokKartı1] FOREIGN KEY([Id])
REFERENCES [dbo].[StokKartı] ([StokKod])
GO
ALTER TABLE [dbo].[StokHareket] CHECK CONSTRAINT [FK_StokHareket_StokKartı1]
GO
USE [master]
GO
ALTER DATABASE [StockUygula] SET  READ_WRITE 
GO
