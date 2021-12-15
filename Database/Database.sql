USE [master]
GO
/****** Object:  Database [ExpenseDb]    Script Date: 12/15/2021 6:30:26 AM ******/
CREATE DATABASE [ExpenseDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExpenseDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ExpenseDb.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ExpenseDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ExpenseDb_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ExpenseDb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExpenseDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExpenseDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExpenseDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExpenseDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExpenseDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExpenseDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExpenseDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ExpenseDb] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ExpenseDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExpenseDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExpenseDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExpenseDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExpenseDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExpenseDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExpenseDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExpenseDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExpenseDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ExpenseDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExpenseDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExpenseDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExpenseDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExpenseDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExpenseDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ExpenseDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExpenseDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ExpenseDb] SET  MULTI_USER 
GO
ALTER DATABASE [ExpenseDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExpenseDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExpenseDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExpenseDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ExpenseDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/15/2021 6:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/15/2021 6:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 12/15/2021 6:30:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseId] [int] IDENTITY(1,1) NOT NULL,
	[ExpanceAmmount] [float] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ExpenseDate] [date] NOT NULL CONSTRAINT [DF__Expenses__Expens__21B6055D]  DEFAULT ('0001-01-01T00:00:00.0000000'),
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[ExpenseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211213200338_InitialCreate', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211213201550_AddDate', N'5.0.0')
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Water Bill')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Electric Bill')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Uber')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (5, N'Grocery')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (6, N'Gas ')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Expenses] ON 

INSERT [dbo].[Expenses] ([ExpenseId], [ExpanceAmmount], [CategoryId], [ExpenseDate]) VALUES (14, 100, 2, CAST(N'2021-12-01' AS Date))
INSERT [dbo].[Expenses] ([ExpenseId], [ExpanceAmmount], [CategoryId], [ExpenseDate]) VALUES (15, 1200, 4, CAST(N'2021-12-13' AS Date))
INSERT [dbo].[Expenses] ([ExpenseId], [ExpanceAmmount], [CategoryId], [ExpenseDate]) VALUES (16, 1200, 6, CAST(N'2021-12-08' AS Date))
INSERT [dbo].[Expenses] ([ExpenseId], [ExpanceAmmount], [CategoryId], [ExpenseDate]) VALUES (19, 1000, 5, CAST(N'2021-12-08' AS Date))
INSERT [dbo].[Expenses] ([ExpenseId], [ExpanceAmmount], [CategoryId], [ExpenseDate]) VALUES (21, 1500, 3, CAST(N'2021-12-09' AS Date))
SET IDENTITY_INSERT [dbo].[Expenses] OFF
USE [master]
GO
ALTER DATABASE [ExpenseDb] SET  READ_WRITE 
GO
