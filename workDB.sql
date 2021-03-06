USE [master]
GO
/****** Object:  Database [workDB]    Script Date: 2021/6/30 下午 09:46:32 ******/
CREATE DATABASE [workDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'workDB', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\workDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'workDB_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\workDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [workDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [workDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [workDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [workDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [workDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [workDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [workDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [workDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [workDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [workDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [workDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [workDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [workDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [workDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [workDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [workDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [workDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [workDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [workDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [workDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [workDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [workDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [workDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [workDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [workDB] SET RECOVERY FULL 
GO
ALTER DATABASE [workDB] SET  MULTI_USER 
GO
ALTER DATABASE [workDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [workDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [workDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [workDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [workDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [workDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'workDB', N'ON'
GO
ALTER DATABASE [workDB] SET QUERY_STORE = OFF
GO
USE [workDB]
GO
/****** Object:  Table [dbo].[member]    Script Date: 2021/6/30 下午 09:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[class] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[tel] [nchar](10) NULL,
	[值日生狀態] [bit] NULL,
 CONSTRAINT [PK_memberlogin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 2021/6/30 下午 09:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[eatName] [nvarchar](20) NULL,
	[item] [nvarchar](20) NULL,
	[price] [int] NULL,
	[people] [nvarchar](20) NULL,
 CONSTRAINT [PK_orders_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[restaurant]    Script Date: 2021/6/30 下午 09:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[restaurant](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[eatName] [nvarchar](20) NULL,
	[item] [nvarchar](20) NULL,
	[price] [nvarchar](20) NULL,
 CONSTRAINT [PK_restaurant] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[member] ON 

INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (1, N'全端班', N'王小明', N'0912345678', 0)
INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (2, N'全端班', N'李小龍', N'0934654875', 0)
INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (3, N'JAVA班', N'陳小美', N'0924587512', 0)
INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (4, N'JAVA班', N'皮諾可', N'0915467821', 0)
INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (5, N'調查兵團', N'李大膽', N'0999999999', 0)
INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (6, N'火槍班', N'李大衛', N'0915147513', 0)
INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (7, N'器材班', N'李曉明', N'0915481524', 0)
INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (9, N'火槍班', N'里為', N'0912345678', 0)
INSERT [dbo].[member] ([id], [class], [name], [tel], [值日生狀態]) VALUES (1007, N'全端班', N'黑傑克', N'0912345678', 1)
SET IDENTITY_INSERT [dbo].[member] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([id], [eatName], [item], [price], [people]) VALUES (1063, N'好吃便當店', N'排骨飯', 100, N'陳小美')
INSERT [dbo].[orders] ([id], [eatName], [item], [price], [people]) VALUES (1064, N'好吃便當店', N'燒肉飯', 60, N'陳小美')
INSERT [dbo].[orders] ([id], [eatName], [item], [price], [people]) VALUES (1065, N'好喝飲料店', N'奶茶', 50, N'陳小美')
INSERT [dbo].[orders] ([id], [eatName], [item], [price], [people]) VALUES (1067, N'好喝飲料店', N'多多綠', 89, N'陳小美')
INSERT [dbo].[orders] ([id], [eatName], [item], [price], [people]) VALUES (1068, N'好吃便當店', N'超好吃大排骨', 80, N'陳小美')
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[restaurant] ON 

INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (1, N'雙雙漢堡', N'米糕熱狗 ', N'40')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (2, N'好吃便當店', N'排骨飯', N'100')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (3, N'好吃便當店', N'燒肉飯', N'60')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (4, N'好喝飲料店', N'奶茶', N'50')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (5, N'好喝飲料店', N'綠茶', N'30')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (7, N'好喝飲料店', N'多多綠', N'89')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (8, N'好吃便當店', N'超好吃大排骨', N'80')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (9, N'好吃便當店', N'竹筍炒肉絲', N'60')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (10, N'可口咖啡店', N'果汁', N'70')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (11, N'可口咖啡店', N'薄荷茶', N'20')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (12, N'雙雙漢堡', N'紐奧良烤腿堡', N'79')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (13, N'小惡魔鹹酥雞', N'鹹酥雞 ', N'60')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (14, N'小天使麵包店', N'麵包1號', N'50')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (15, N'螃蟹餐廳', N'螃蟹', N'150')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (17, N'雙雙漢堡', N'勁辣雞腿堡', N'80')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (18, N'小上海鹹酥雞', N'雞米花', N'50')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (20, N'好吃便當店', N'雞腿飯', N'80')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (21, N'吃吃早餐店', N'火腿  ', N'20')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (22, N'123早餐店', N'火腿', N'20')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (24, N'789早餐店', N'小黃瓜', N'30')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (25, N'小惡魔鹹酥雞', N'紅茶', N'20')
INSERT [dbo].[restaurant] ([id], [eatName], [item], [price]) VALUES (1020, N'123早餐店', N'三明治 ', N'100')
SET IDENTITY_INSERT [dbo].[restaurant] OFF
GO
USE [master]
GO
ALTER DATABASE [workDB] SET  READ_WRITE 
GO
