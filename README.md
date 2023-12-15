This project is a website for a restaurant.
In order to run this  project,  .NET 7 is needed, as well as V.S. at least 2022 version. 
To create a DB you need to use CODE FIRST and make sure you have SQL installed.
About our project:
The project was written in .NET 7, client side: JS.
The project was written according to REST API  architecture principles.
When a user registers in the system we verified the strength of the password  by using the Zxcvbn package.
We divided our project according to the layers model. The layers communicate with the help of DI to enable encapsulation and for the code to be easier to operate.
We used async await for the project to be scalability.
We created the project in the DATA FIRST way using EF so that we used the data as objects.
In order to monitor the operations on the database we used the PROFILER professional tool.
Our project is documented and organized by the SWAGGWR.
We used DTO entities because we have to return to the client not the same things 
We used AutoMapper library- to exchange objects to DTO object and the opposite.
We created CONFIGURATION file for separated code parameters, like connection string
Our project send information data to file, in case of error it send email to the manager by using the LOGGER opensource library.
 To catch errors from all the layer we wrote middleware.  
We wrote another middleware to keep important data about the entries user.   
Enjoy using our project.

לw
we tryed to push the DBscript to git but we have some broblem so we will try push it on sunday in the seminar

USE [master]
GO
/****** Object:  Database [StoreDataBase2]    Script Date: 12/12/2023 11:46:32 ******/
CREATE DATABASE [StoreDataBase2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StoreDataBase2', FILENAME = N'D:\SqlData\MSSQL15.PUPILS\MSSQL\DATA\StoreDataBase2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'StoreDataBase2_log', FILENAME = N'D:\SqlData\MSSQL15.PUPILS\MSSQL\DATA\StoreDataBase2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StoreDataBase2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StoreDataBase2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StoreDataBase2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StoreDataBase2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StoreDataBase2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StoreDataBase2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StoreDataBase2] SET ARITHABORT OFF 
GO
ALTER DATABASE [StoreDataBase2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StoreDataBase2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StoreDataBase2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StoreDataBase2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StoreDataBase2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StoreDataBase2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StoreDataBase2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StoreDataBase2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StoreDataBase2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StoreDataBase2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StoreDataBase2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StoreDataBase2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StoreDataBase2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StoreDataBase2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StoreDataBase2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StoreDataBase2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StoreDataBase2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StoreDataBase2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StoreDataBase2] SET  MULTI_USER 
GO
ALTER DATABASE [StoreDataBase2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StoreDataBase2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StoreDataBase2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StoreDataBase2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [StoreDataBase2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StoreDataBase2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StoreDataBase2', N'ON'
GO
ALTER DATABASE [StoreDataBase2] SET QUERY_STORE = OFF
GO
USE [StoreDataBase2]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/12/2023 11:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem_tbl]    Script Date: 12/12/2023 11:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem_tbl](
	[orderItemId] [int] IDENTITY(1,1) NOT NULL,
	[productId] [int] NULL,
	[orderId] [int] NULL,
	[quentity] [int] NOT NULL,
 CONSTRAINT [PK_OrderItem_tbl] PRIMARY KEY CLUSTERED 
(
	[orderItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders_tbl]    Script Date: 12/12/2023 11:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders_tbl](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[orderDate] [nchar](50) NOT NULL,
	[orderSum] [int] NOT NULL,
	[userId] [int] NULL,
 CONSTRAINT [PK_Orders_tbl] PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/12/2023 11:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Price] [int] NULL,
	[Name] [nchar](20) NULL,
	[Description] [nchar](30) NULL,
	[Image] [nchar](10) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RATING]    Script Date: 12/12/2023 11:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RATING](
	[RATING_ID] [int] IDENTITY(1,1) NOT NULL,
	[HOST] [nvarchar](50) NULL,
	[METHOD] [nchar](10) NULL,
	[PATH] [nvarchar](50) NULL,
	[REFERER] [nvarchar](100) NULL,
	[USER_AGENT] [nvarchar](max) NULL,
	[Record_Date] [datetime] NULL,
 CONSTRAINT [PK_RATING] PRIMARY KEY CLUSTERED 
(
	[RATING_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_tbl]    Script Date: 12/12/2023 11:46:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_tbl](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[password] [nchar](50) NULL,
	[firstName] [nchar](50) NULL,
	[lastName] [nchar](50) NULL,
	[email] [nchar](50) NULL,
 CONSTRAINT [PK_Users_tbl] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 
GO
INSERT [dbo].[Category] ([CategoryId], [name]) VALUES (3, N'מנה עיקרית')
GO
INSERT [dbo].[Category] ([CategoryId], [name]) VALUES (4, N'תוספות    ')
GO
INSERT [dbo].[Category] ([CategoryId], [name]) VALUES (5, N'מנת פתיחה ')
GO
INSERT [dbo].[Category] ([CategoryId], [name]) VALUES (6, N'עוגות     ')
GO
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderItem_tbl] ON 
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (1, 14, 7, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (2, 13, 7, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (3, 9, 11, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (4, 9, 12, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (5, 10, 12, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (6, 9, 13, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (7, 10, 13, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (8, 9, 14, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (9, 10, 14, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (10, 9, 15, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (11, 10, 15, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (12, 14, 16, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (13, 13, 16, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (14, 14, 17, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (15, 10, 17, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (16, 9, 17, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (17, 14, 18, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (18, 13, 18, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (19, 10, 18, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (20, 14, 19, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (21, 13, 20, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (22, 10, 21, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (23, 9, 21, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (24, 14, 22, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (25, 14, 23, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (26, 13, 24, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (27, 10, 25, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (28, 9, 25, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (29, 14, 26, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (30, 9, 27, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (31, 9, 28, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (32, 14, 29, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (33, 14, 30, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (34, 13, 30, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (35, 14, 31, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (36, 13, 31, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (37, 14, 32, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (38, 14, 33, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (39, 13, 33, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (40, 13, 34, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (41, 10, 34, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (42, 10, 35, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (43, 9, 35, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (44, 14, 36, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (45, 13, 36, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (46, 10, 36, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (47, 10, 37, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (48, 13, 37, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (49, 13, 38, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (50, 10, 38, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (51, 10, 39, 1)
GO
INSERT [dbo].[OrderItem_tbl] ([orderItemId], [productId], [orderId], [quentity]) VALUES (52, 9, 39, 1)
GO
SET IDENTITY_INSERT [dbo].[OrderItem_tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders_tbl] ON 
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (1, N'sttfufduring                                      ', 10, 1)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (2, N'1/2/2024                                          ', 40, 1)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (3, N'1/2/2024                                          ', 40, 1)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (4, N'1/2/2024                                          ', 105, 1)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (5, N'1/2/2024                                          ', 100, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (6, N'1/2/2024                                          ', 145, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (7, N'1/2/2024                                          ', 105, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (8, N'1/2/2024                                          ', 60, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (9, N'2023-11-23T12:08:56.442Z                          ', 45, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (10, N'6778                                              ', 233, NULL)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (11, N'7777777                                           ', 69, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (12, N'2023-11-29T13:31:28.315Z                          ', 55, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (13, N'2023-11-29T13:33:43.547Z                          ', 55, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (14, N'2023-11-29T13:49:47.262Z                          ', 55, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (15, N'2023-11-29T13:50:47.286Z                          ', 55, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (16, N'2023-11-29T14:04:09.392Z                          ', 105, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (17, N'2023-11-29T14:05:12.936Z                          ', 115, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (18, N'2023-11-29T14:10:45.032Z                          ', 145, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (19, N'2023-11-29T14:11:36.545Z                          ', 60, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (20, N'2023-11-29T14:26:21.034Z                          ', 45, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (21, N'2023-11-29T16:43:57.284Z                          ', 55, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (22, N'2023-11-29T18:01:06.438Z                          ', 60, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (23, N'2023-11-29T18:03:15.632Z                          ', 60, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (24, N'2023-11-29T18:04:43.776Z                          ', 45, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (25, N'2023-11-29T18:07:39.952Z                          ', 0, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (26, N'2023-11-29T18:10:38.977Z                          ', 0, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (27, N'2023-11-29T18:12:54.049Z                          ', 15, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (28, N'string                                            ', 0, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (29, N'2023-11-29T18:31:24.276Z                          ', 60, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (30, N'2023-12-04T10:42:41.861Z                          ', 105, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (31, N'2023-12-04T10:42:46.189Z                          ', 105, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (32, N'2023-12-04T10:43:48.089Z                          ', 60, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (33, N'2023-12-04T10:45:13.078Z                          ', 105, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (34, N'2023-12-04T10:46:46.687Z                          ', 0, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (35, N'2023-12-04T10:56:11.267Z                          ', 10, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (36, N'2023-12-04T11:06:57.054Z                          ', 145, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (37, N'2023-12-04T12:22:29.304Z                          ', 85, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (38, N'2023-12-04T12:22:38.903Z                          ', 85, 3)
GO
INSERT [dbo].[Orders_tbl] ([orderId], [orderDate], [orderSum], [userId]) VALUES (39, N'2023-12-04T14:50:19.517Z                          ', 55, 18)
GO
SET IDENTITY_INSERT [dbo].[Orders_tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [Price], [Name], [Description], [Image]) VALUES (9, 4, 15, N'אפונה               ', N'תוספת אפונה ברוטב עגבניות     ', N'אפונה.JPG ')
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [Price], [Name], [Description], [Image]) VALUES (10, 5, 40, N'רביולי כבד          ', N'רביולי במילוי כבד עם בצל ברוטב', N'רביולי.JPG')
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [Price], [Name], [Description], [Image]) VALUES (13, 3, 45, N'עוף ברוטב           ', N'עוף ברוטב על מצע פסטה         ', N'עוף.JPG   ')
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [Price], [Name], [Description], [Image]) VALUES (14, 3, 60, N'בשר                 ', N'בשר מבושל טעים במיוחד         ', N'בשר.JPG   ')
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [Price], [Name], [Description], [Image]) VALUES (15, 6, 10, N'עוגת שמרים          ', N'עוגת שמרים חמה וטריה          ', N'עוגתש.JPG ')
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [Price], [Name], [Description], [Image]) VALUES (16, 6, 10, N'עוגת חמוציות        ', N'עוגת וניל במילוי חמוציות      ', N'עוגתח.JPG ')
GO
INSERT [dbo].[Product] ([ProductId], [CategoryId], [Price], [Name], [Description], [Image]) VALUES (17, 5, 30, N'סלמון מעושן         ', N'סלמון מעושן על לימון          ', N'סלמון.JPG ')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[RATING] ON 
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (1, N'localhost:44348', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.HttpSys.Internal.RequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T19:35:30.837' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (2, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T19:45:22.410' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (3, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T19:47:26.893' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (4, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:15:10.830' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (5, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:15:38.683' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (6, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:15:53.283' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (7, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:15:59.497' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (8, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:16:29.040' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (9, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:17:43.623' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (10, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:17:48.363' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (11, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:18:11.030' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (12, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:18:15.897' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (13, N'localhost:44348', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.HttpSys.Internal.RequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:27:02.890' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (14, N'localhost:44348', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.HttpSys.Internal.RequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36', CAST(N'2023-12-03T21:27:17.997' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (15, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T12:26:49.463' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (16, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T12:27:15.190' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (17, N'localhost:7167', N'GET       ', N'/home.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:28:15.737' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (18, N'localhost:7167', N'GET       ', N'/user.js', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:28:17.517' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (19, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T12:28:21.107' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (20, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:28:35.297' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (21, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:29:00.587' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (22, N'localhost:7167', N'GET       ', N'/home.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:30:55.843' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (23, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:31:20.987' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (24, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/swagger/index.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:32:22.717' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (25, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:33:11.867' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (26, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:33:41.437' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (27, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T12:34:49.873' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (28, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:35:28.370' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (29, N'localhost:7167', N'GET       ', N'/home.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:36:55.897' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (30, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:37:06.200' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (31, N'localhost:7167', N'GET       ', N'/home.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:37:30.810' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (32, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:37:38.080' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (33, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:37:42.243' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (34, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:37:42.317' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (35, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:37:42.317' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (36, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T12:38:21.700' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (37, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:23:48.927' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (38, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:23:49.970' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (39, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:23:53.633' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (40, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:24:02.783' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (41, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:24:17.697' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (42, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:24:17.697' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (43, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:25:34.080' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (44, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:27:24.300' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (45, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:27:25.687' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (46, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:27:29.017' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (47, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:29:00.330' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (48, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:29:08.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (49, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:30:59.627' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (50, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:31:25.747' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (51, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:40:55.197' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (52, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:41:10.727' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (53, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:41:44.487' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (54, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:41:55.053' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (55, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:42:24.217' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (56, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:43:33.717' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (57, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:43:43.677' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (58, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'https://localhost:7167/Product.css', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:43:51.727' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (59, N'localhost:7167', N'GET       ', N'/api/Products', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:43:53.437' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (60, N'localhost:7167', N'GET       ', N'/api/Categories', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T13:43:53.437' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (61, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:50:19.250' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (62, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:50:34.997' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (63, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:50:37.050' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (64, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:50:38.607' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (65, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:50:38.880' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (66, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:50:48.830' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (67, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:54:27.977' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (68, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:54:28.933' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (69, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:54:33.603' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (70, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:54:33.657' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (71, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:54:33.657' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (72, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%942.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:54:33.783' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (73, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:56:44.747' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (74, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:56:44.013' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (75, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:56:46.210' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (76, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:56:46.270' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (77, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:56:46.270' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (78, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:59:06.493' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (79, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:59:05.677' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (80, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:59:07.857' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (81, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:59:07.913' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (82, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:59:07.913' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (83, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T13:59:08.047' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (84, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:04:50.413' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (85, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:04:49.507' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (86, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:04:51.320' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (87, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:04:51.387' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (88, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:04:51.387' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (89, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:04:51.527' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (90, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:06:25.290' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (91, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:16:35.460' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (92, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:16:46.197' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (93, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:16:46.290' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (94, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:16:46.290' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (95, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:16:46.673' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (96, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:17:19.973' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (97, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:19:44.827' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (98, N'localhost:7167', N'GET       ', N'/product.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:06.050' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (99, N'localhost:7167', N'GET       ', N'/products', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:10.773' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (100, N'localhost:7167', N'GET       ', N'/products', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:12.833' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (101, N'localhost:7167', N'GET       ', N'/products', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:14.217' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (102, N'localhost:7167', N'GET       ', N'/products', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:14.447' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (103, N'localhost:7167', N'GET       ', N'/products', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:16.713' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (104, N'localhost:7167', N'GET       ', N'/products.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:26.283' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (105, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'https://localhost:7167/Product.css', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:26.343' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (106, N'localhost:7167', N'GET       ', N'/api/Categories', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:26.393' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (107, N'localhost:7167', N'GET       ', N'/api/Products', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:26.393' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (108, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:26.663' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (109, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:26.663' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (110, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:26.663' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (111, N'localhost:7167', N'GET       ', N'/ShoppingBag.html', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:31.570' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (112, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:32.857' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (113, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:32.857' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (114, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:32.857' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (115, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'https://localhost:7167/ShoppingBag.css', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:35.660' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (116, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:20:40.010' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (117, N'localhost:7167', N'GET       ', N'/ShoppingBag.html', N'https://localhost:7167/products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:56.367' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (118, N'localhost:7167', N'GET       ', N'/shoppingBag.js', N'https://localhost:7167/ShoppingBag.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:56.390' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (119, N'localhost:7167', N'GET       ', N'/ShoppingBag.css', N'https://localhost:7167/ShoppingBag.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:56.390' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (120, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'https://localhost:7167/ShoppingBag.css', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:56.457' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (121, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%A3.JPG', N'https://localhost:7167/ShoppingBag.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:56.453' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (122, N'localhost:7167', N'GET       ', N'/Image/icn-remove.png', N'https://localhost:7167/ShoppingBag.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:56.453' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (123, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/ShoppingBag.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:56.470' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (124, N'localhost:7167', N'GET       ', N'/home.html', N'https://localhost:7167/ShoppingBag.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:59.177' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (125, N'localhost:7167', N'GET       ', N'/user.js', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:20:59.190' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (126, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:20:59.440' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (127, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:20:59.537' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (128, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:20:59.537' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (129, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:20:59.933' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (130, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:02.053' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (131, N'localhost:7167', N'GET       ', N'/Products.html', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.810' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (132, N'localhost:7167', N'GET       ', N'/Image/searchIcon.svg', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.827' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (133, N'localhost:7167', N'GET       ', N'/Product.css', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.827' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (134, N'localhost:7167', N'GET       ', N'/Products.js', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.827' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (135, N'localhost:7167', N'GET       ', N'/Image/BagActive.png', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.827' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (136, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'https://localhost:7167/Product.css', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (137, N'localhost:7167', N'GET       ', N'/api/Categories', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.903' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (138, N'localhost:7167', N'GET       ', N'/api/Products', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.903' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (139, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.923' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (140, N'localhost:7167', N'GET       ', N'/Image/%D7%90%D7%A4%D7%95%D7%A0%D7%94.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.923' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (141, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.923' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (142, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.930' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (143, N'localhost:7167', N'GET       ', N'/Image/%D7%A8%D7%91%D7%99%D7%95%D7%9C%D7%99.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.930' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (144, N'localhost:7167', N'GET       ', N'/Image/%D7%91%D7%A9%D7%A8.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:07.937' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (145, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:21:09.740' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (146, N'localhost:7167', N'GET       ', N'/shoppingBag.js', N'https://localhost:7167/ShoppingBag.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:10.653' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (147, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'https://localhost:7167/ShoppingBag.css', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:10.727' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (148, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:21:22.467' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (149, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:35.530' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (150, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:35.603' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (151, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:35.603' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (152, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:35.687' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (153, N'localhost:7167', N'GET       ', N'/Products.html', N'https://localhost:7167/ShoppingBag.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:41.440' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (154, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'https://localhost:7167/Product.css', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:41.480' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (155, N'localhost:7167', N'GET       ', N'/api/Categories', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:41.587' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (156, N'localhost:7167', N'GET       ', N'/api/Products', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:41.587' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (157, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:41.607' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (158, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:41.607' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (159, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:21:41.607' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (160, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:01.497' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (161, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:01.497' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (162, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:01.537' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (163, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:03.967' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (164, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:03.967' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (165, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:04.003' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (166, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:09.577' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (167, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:09.643' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (168, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:09.643' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (169, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:09.683' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (170, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:09.720' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (171, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:16.610' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (172, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:24.307' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (173, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:24.467' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (174, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:24.467' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (175, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:24.507' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (176, N'localhost:7167', N'POST      ', N'/api/Orders', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:29.307' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (177, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:32.067' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (178, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:32.067' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (179, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:32.100' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (180, N'localhost:7167', N'POST      ', N'/api/Orders', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:38.907' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (181, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:41.490' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (182, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:41.543' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (183, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:41.543' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (184, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:41.580' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (185, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:47.193' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (186, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:51.490' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (187, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:51.490' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (188, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:51.507' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (189, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:59.163' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (190, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:59.163' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (191, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:22:59.200' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (192, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:10.447' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (193, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:10.447' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (194, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:10.483' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (195, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:12.397' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (196, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:19.603' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (197, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:19.657' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (198, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:19.657' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (199, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:19.700' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (200, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:22.423' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (201, N'localhost:7167', N'GET       ', N'/Product.css', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:23.070' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (202, N'localhost:7167', N'GET       ', N'/Product.css', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:23.100' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (203, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:23:36.190' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (204, N'localhost:7167', N'GET       ', N'/Product.css', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:23.907' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (205, N'localhost:7167', N'GET       ', N'/Product.css', N'https://localhost:7167/Products.html?fromShoppingBag=1', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:23.937' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (206, N'localhost:7167', N'GET       ', N'/home.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:43.820' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (207, N'localhost:7167', N'GET       ', N'/home.css', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:45.517' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (208, N'localhost:7167', N'GET       ', N'/user.js', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:45.517' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (209, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:45.630' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (210, N'localhost:7167', N'POST      ', N'/api/Users/login', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.390' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (211, N'localhost:7167', N'GET       ', N'/Products.html', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.677' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (212, N'localhost:7167', N'GET       ', N'/Product.css', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.690' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (213, N'localhost:7167', N'GET       ', N'/Products.js', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.690' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (214, N'localhost:7167', N'GET       ', N'/Image/searchIcon.svg', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.690' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (215, N'localhost:7167', N'GET       ', N'/Image/BagActive.png', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.690' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (216, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'https://localhost:7167/Product.css', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.713' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (217, N'localhost:7167', N'GET       ', N'/api/Products', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.753' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (218, N'localhost:7167', N'GET       ', N'/api/Categories', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.753' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (219, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (220, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%A3.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (221, N'localhost:7167', N'GET       ', N'/Image/%D7%90%D7%A4%D7%95%D7%A0%D7%94.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (222, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (223, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (224, N'localhost:7167', N'GET       ', N'/Image/%D7%91%D7%A9%D7%A8.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (225, N'localhost:7167', N'GET       ', N'/Image/%D7%A8%D7%91%D7%99%D7%95%D7%9C%D7%99.JPG', N'https://localhost:7167/Products.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:24:48.850' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (226, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:25:39.567' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (227, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:25:38.437' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (228, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:25:38.317' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (229, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:25:38.343' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (230, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:25:40.423' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (231, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:25:40.453' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (232, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:25:40.453' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (233, N'localhost:7167', N'GET       ', N'/home.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:26:08.020' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (234, N'localhost:7167', N'GET       ', N'/home.css', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:26:09.667' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (235, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:26:09.783' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (236, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:26:20.540' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (237, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:26:28.627' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (238, N'localhost:7167', N'GET       ', N'/home.css', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:26:51.613' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (239, N'localhost:7167', N'GET       ', N'/home.css', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:27:18.797' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (240, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:29:24.933' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (241, N'localhost:7167', N'GET       ', N'/home.html', N'', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:29:32.717' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (242, N'localhost:7167', N'GET       ', N'/home.css', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:29:34.343' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (243, N'localhost:7167', N'GET       ', N'/favicon.ico', N'https://localhost:7167/home.html', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:29:34.433' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (244, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:29:35.117' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (245, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:29:35.193' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (246, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:29:35.193' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (247, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36', CAST(N'2023-12-04T14:29:35.397' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (248, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:57:00.657' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (249, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:57:01.533' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (250, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:57:02.597' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (251, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:57:02.653' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (252, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:57:02.653' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (253, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:57:02.817' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (254, N'localhost:7167', N'POST      ', N'/api/Orders', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T14:57:24.730' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (255, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T15:02:40.113' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (256, N'localhost:7167', N'POST      ', N'/api/Users/check', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T15:03:09.033' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (257, N'localhost:7167', N'POST      ', N'/api/Users', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 Edg/114.0.1823.82', CAST(N'2023-12-04T15:03:09.033' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (258, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:03:41.233' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (259, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:03:44.257' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (260, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:03:44.767' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (261, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:03:44.830' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (262, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:03:44.830' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (263, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:03:44.983' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (264, N'localhost:7167', N'POST      ', N'/api/Users', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:04:07.523' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (265, N'localhost:7167', N'POST      ', N'/api/Users/check', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:04:07.523' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (266, N'localhost:7167', N'POST      ', N'/api/Users', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:04:21.617' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (267, N'localhost:7167', N'POST      ', N'/api/Users/check', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:04:21.617' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (268, N'localhost:7167', N'POST      ', N'/api/Users/check', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:04:32.843' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (269, N'localhost:7167', N'POST      ', N'/api/Users', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:04:32.843' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (270, N'localhost:7167', N'POST      ', N'/api/Users', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:04:36.723' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (271, N'localhost:7167', N'POST      ', N'/api/Users/check', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 Edg/119.0.0.0', CAST(N'2023-12-04T15:04:36.723' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (272, N'localhost:7167', N'GET       ', N'/home.html', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:47:27.327' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (273, N'localhost:7167', N'GET       ', N'/home.css', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:47:29.110' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (274, N'localhost:7167', N'GET       ', N'/favicon.ico', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:47:29.223' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (275, N'localhost:7167', N'POST      ', N'/api/Users/check', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:17.197' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (276, N'localhost:7167', N'POST      ', N'/api/Users', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:17.197' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (277, N'localhost:7167', N'POST      ', N'/api/Users', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:36.683' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (278, N'localhost:7167', N'POST      ', N'/api/Users/check', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:36.683' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (279, N'localhost:7167', N'POST      ', N'/api/Users', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:43.200' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (280, N'localhost:7167', N'POST      ', N'/api/Users/check', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:43.200' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (281, N'localhost:7167', N'POST      ', N'/api/Users/login', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:59.600' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (282, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:59.793' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (283, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:59.840' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (284, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:59.840' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (285, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:59.947' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (286, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:59.947' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (287, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:48:59.947' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (288, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:15.097' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (289, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:25.223' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (290, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:25.240' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (291, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:25.240' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (292, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:25.240' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (293, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:31.040' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (294, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:44.880' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (295, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:44.900' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (296, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:51.713' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (297, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:51.767' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (298, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:51.767' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (299, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:51.783' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (300, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:51.783' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (301, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:51.783' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (302, N'localhost:7167', N'GET       ', N'/shoppingbag.html', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:55.857' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (303, N'localhost:7167', N'GET       ', N'/ShoppingBag.css', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:55.873' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (304, N'localhost:7167', N'GET       ', N'/shoppingBag.js', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:55.873' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (305, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:58.307' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (306, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:58.307' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (307, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:49:58.307' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (308, N'localhost:7167', N'GET       ', N'/ShoppingBag.html', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:11.123' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (309, N'localhost:7167', N'GET       ', N'/Image/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:11.187' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (310, N'localhost:7167', N'GET       ', N'/Images/icn-remove.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:11.187' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (311, N'localhost:7167', N'POST      ', N'/api/Orders', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:19.520' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (312, N'localhost:7167', N'GET       ', N'/Payment.html', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:23.713' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (313, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:25.713' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (314, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:25.750' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (315, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:25.750' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (316, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:25.787' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (317, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:25.783' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (318, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:25.783' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (319, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:29.507' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (320, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:29.560' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (321, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:29.560' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (322, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:29.587' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (323, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:29.587' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (324, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:29.587' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (325, N'localhost:7167', N'GET       ', N'/Images/BagActive.png', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:30.420' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (326, N'localhost:7167', N'GET       ', N'/api/Categories', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:30.477' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (327, N'localhost:7167', N'GET       ', N'/api/Products', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:30.477' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (328, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:30.497' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (329, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:30.497' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (330, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:30.497' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (331, N'localhost:7167', N'GET       ', N'/update.html', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:34.490' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (332, N'localhost:7167', N'GET       ', N'/update.css', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:34.503' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (333, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%A9.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:42.477' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (334, N'localhost:7167', N'GET       ', N'/Image/%D7%A2%D7%95%D7%92%D7%AA%D7%97.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:42.477' AS DateTime))
GO
INSERT [dbo].[RATING] ([RATING_ID], [HOST], [METHOD], [PATH], [REFERER], [USER_AGENT], [Record_Date]) VALUES (335, N'localhost:7167', N'GET       ', N'/Image/%D7%A1%D7%9C%D7%9E%D7%95%D7%9F.JPG', N'Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpRequestHeaders', N'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36', CAST(N'2023-12-04T16:50:42.477' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[RATING] OFF
GO
SET IDENTITY_INSERT [dbo].[Users_tbl] ON 
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (1, N'string                                            ', N'string                                            ', N'string                                            ', N'strigfjgfhkdvvvvvvvvvvvvng                        ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (2, N'strhgjing                                         ', N'stgjhcring                                        ', N'stgcjring                                         ', N'strigvcjng                                        ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (3, N'tamar65411@gmail.com                              ', N'Tamar                                             ', N'Shapira                                           ', N'tamar65411@gmail.com                              ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (4, N'b0534190904@gmail.com                             ', N'brachi                                            ', N'tolidano                                          ', N'b0534190904@gmail.com                             ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (5, N'sad#$Erfcd%%^fcxa                                 ', N'stringaaaa                                        ', N'stringaaa                                         ', N'stringaaaa                                        ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (6, N'B0534190904@GMAIL.COM                             ', N'z                                                 ', N'z                                                 ', N'z                                                 ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (7, N'kkkkkkk$5gfa@@                                    ', N'string                                            ', N'string                                            ', N'string                                            ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (8, N'string@gm.com                                     ', N'string                                            ', N'string                                            ', N'string                                            ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (9, N'tamar65411@gmail.com                              ', N'tamar                                             ', N'tamar                                             ', N'tamar65411@gmail.com                              ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (10, N'tamar65411@gmail.com                              ', N'tamar                                             ', N'tamar                                             ', N'tamar65411@gmail.com                              ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (11, N'Brachi                                            ', N'Brachi                                            ', N'Brachi                                            ', N'Brachi@gmail.com                                  ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (12, N'aaaaaaaaaASADdea@#                                ', N'stringnnn                                         ', N'stringnnn                                         ', N'stringnnn                                         ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (13, N'b@gmail.com                                       ', N'brachi                                            ', N'tolidano                                          ', N'b@gmail.com                                       ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (14, N'aasd@gm.co                                        ', N'a                                                 ', N'a                                                 ', N'a                                                 ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (15, N'aasd@gm.co                                        ', N'a                                                 ', N'a                                                 ', N'a                                                 ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (16, N'gg@gmail.com                                      ', N'gg                                                ', N'gg                                                ', N'gg                                                ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (17, N'tuyih#$^y                                         ', N'ssssss                                            ', N'ssssss                                            ', N'sdffhgh                                           ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (18, N's0583245665@gmail.com                             ', N'shulamit                                          ', N'krupnick                                          ', N's0583245665@gmail.com                             ')
GO
INSERT [dbo].[Users_tbl] ([userId], [password], [firstName], [lastName], [email]) VALUES (19, N's0583245665@gmail.com                             ', N'shulamit                                          ', N'krupnick                                          ', N's0583245665@gmail.com                             ')
GO
SET IDENTITY_INSERT [dbo].[Users_tbl] OFF
GO
ALTER TABLE [dbo].[OrderItem_tbl] ADD  CONSTRAINT [DF_OrderItem_tbl_quentity]  DEFAULT ((1)) FOR [quentity]
GO
ALTER TABLE [dbo].[OrderItem_tbl]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_tbl_Orders_tbl] FOREIGN KEY([orderId])
REFERENCES [dbo].[Orders_tbl] ([orderId])
GO
ALTER TABLE [dbo].[OrderItem_tbl] CHECK CONSTRAINT [FK_OrderItem_tbl_Orders_tbl]
GO
ALTER TABLE [dbo].[OrderItem_tbl]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_tbl_Product] FOREIGN KEY([productId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[OrderItem_tbl] CHECK CONSTRAINT [FK_OrderItem_tbl_Product]
GO
ALTER TABLE [dbo].[Orders_tbl]  WITH CHECK ADD  CONSTRAINT [FK_Orders_tbl_Users_tbl] FOREIGN KEY([userId])
REFERENCES [dbo].[Users_tbl] ([userId])
GO
ALTER TABLE [dbo].[Orders_tbl] CHECK CONSTRAINT [FK_Orders_tbl_Users_tbl]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [StoreDataBase2] SET  READ_WRITE 
GO

לא
