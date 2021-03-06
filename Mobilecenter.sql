USE [master]
GO
/****** Object:  Database [MobileCenterApi]    Script Date: 9/18/2020 7:11:11 AM ******/
CREATE DATABASE [MobileCenterApi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MobileCenterApi_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MobileCenterApi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MobileCenterApi_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MobileCenterApi.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MobileCenterApi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MobileCenterApi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MobileCenterApi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MobileCenterApi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MobileCenterApi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MobileCenterApi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MobileCenterApi] SET ARITHABORT OFF 
GO
ALTER DATABASE [MobileCenterApi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MobileCenterApi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MobileCenterApi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MobileCenterApi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MobileCenterApi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MobileCenterApi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MobileCenterApi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MobileCenterApi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MobileCenterApi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MobileCenterApi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MobileCenterApi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MobileCenterApi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MobileCenterApi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MobileCenterApi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MobileCenterApi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MobileCenterApi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MobileCenterApi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MobileCenterApi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MobileCenterApi] SET  MULTI_USER 
GO
ALTER DATABASE [MobileCenterApi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MobileCenterApi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MobileCenterApi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MobileCenterApi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MobileCenterApi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MobileCenterApi] SET QUERY_STORE = OFF
GO
USE [MobileCenterApi]
GO
/****** Object:  Table [dbo].[TableComplaint]    Script Date: 9/18/2020 7:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableComplaint](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Issue] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_TableComplaint] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableContact]    Script Date: 9/18/2020 7:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableContact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Mssg] [varchar](50) NULL,
 CONSTRAINT [PK_TableContact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableEmployee]    Script Date: 9/18/2020 7:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableEmployee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Dsignation] [varchar](50) NULL,
 CONSTRAINT [PK_TableEmployee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableLogin]    Script Date: 9/18/2020 7:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableLogin](
	[id] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_TableLogin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableMobile]    Script Date: 9/18/2020 7:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableMobile](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NULL,
	[ProductModel] [varchar](50) NULL,
	[Features] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[Qty] [varchar](50) NULL,
 CONSTRAINT [PK_TableMobile] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TableComplaint] ON 

INSERT [dbo].[TableComplaint] ([id], [Name], [Issue], [Status]) VALUES (1, N'iphone', N'speaker not working ', N'pending')
SET IDENTITY_INSERT [dbo].[TableComplaint] OFF
INSERT [dbo].[TableLogin] ([id], [Name], [Password]) VALUES (1, N'Test@Test.com', N'Test')
SET IDENTITY_INSERT [dbo].[TableMobile] ON 

INSERT [dbo].[TableMobile] ([id], [CompanyName], [ProductModel], [Features], [Price], [Qty]) VALUES (1, N'iphone', N'6s', N'64gb', N'$500', N'3')
SET IDENTITY_INSERT [dbo].[TableMobile] OFF
USE [master]
GO
ALTER DATABASE [MobileCenterApi] SET  READ_WRITE 
GO
