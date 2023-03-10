USE [master]
GO
/****** Object:  Database [Trade]    Script Date: 18.10.2022 0:15:31 ******/
CREATE DATABASE [Trade]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Trade', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Trade.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Trade_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Trade_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Trade] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Trade].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Trade] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Trade] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Trade] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Trade] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Trade] SET ARITHABORT OFF 
GO
ALTER DATABASE [Trade] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Trade] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Trade] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Trade] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Trade] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Trade] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Trade] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Trade] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Trade] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Trade] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Trade] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Trade] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Trade] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Trade] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Trade] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Trade] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Trade] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Trade] SET RECOVERY FULL 
GO
ALTER DATABASE [Trade] SET  MULTI_USER 
GO
ALTER DATABASE [Trade] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Trade] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Trade] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Trade] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Trade] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Trade] SET QUERY_STORE = OFF
GO
USE [Trade]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 18.10.2022 0:15:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacture]    Script Date: 18.10.2022 0:15:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacture](
	[ManufactureID] [int] NOT NULL,
	[ManufactureName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Manufacture] PRIMARY KEY CLUSTERED 
(
	[ManufactureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 18.10.2022 0:15:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductArticleNumber] [nvarchar](100) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[ProductDescription] [nvarchar](max) NULL,
	[ProductCategoryID] [int] NOT NULL,
	[ProductPhoto] [nvarchar](100) NULL,
	[ProductManufacturerID] [int] NOT NULL,
	[ProductCost] [decimal](19, 4) NOT NULL,
	[ProductDiscountMax] [int] NULL,
	[ProductDiscountNow] [int] NOT NULL,
	[ProductQuantityInStock] [int] NOT NULL,
	[ProductUnitID] [int] NOT NULL,
	[ProductProviderID] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductArticleNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 18.10.2022 0:15:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ProviderID] [int] NOT NULL,
	[ProviderName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ProviderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 18.10.2022 0:15:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 18.10.2022 0:15:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitID] [int] NOT NULL,
	[UnitName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 18.10.2022 0:15:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserSurname] [nvarchar](100) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[UserPatronymic] [nvarchar](100) NOT NULL,
	[UserLogin] [nvarchar](max) NOT NULL,
	[UserPassword] [nvarchar](max) NOT NULL,
	[UserRole] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Вилки')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Ложки')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Наборы')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Ножи')
GO
INSERT [dbo].[Manufacture] ([ManufactureID], [ManufactureName]) VALUES (1, N'Alaska')
INSERT [dbo].[Manufacture] ([ManufactureID], [ManufactureName]) VALUES (2, N'Apollo')
INSERT [dbo].[Manufacture] ([ManufactureID], [ManufactureName]) VALUES (3, N'Attribute')
INSERT [dbo].[Manufacture] ([ManufactureID], [ManufactureName]) VALUES (4, N'Doria')
INSERT [dbo].[Manufacture] ([ManufactureID], [ManufactureName]) VALUES (5, N'Mayer & Boch')
INSERT [dbo].[Manufacture] ([ManufactureID], [ManufactureName]) VALUES (6, N'Smart Home')
INSERT [dbo].[Manufacture] ([ManufactureID], [ManufactureName]) VALUES (7, N'Davinci

')
GO
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'B736H6', N'Вилка столовая', N'Вилка столовая 21,2 см «Аляска бэйсик» сталь KunstWerk', 1, N'B736H6.jpg', 1, CAST(220.0000 AS Decimal(19, 4)), NULL, 3, 4, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'B963H5', N'Ложка', N'Ложка 21 мм металлическая (медная) (Упаковка 10 шт)', 2, N'', 6, CAST(800.0000 AS Decimal(19, 4)), NULL, 3, 8, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'C430T4', N'Набор на одну персону', N'Набор на одну персону (4 предмета) серия "Bistro", нерж. сталь, Was, Германия.', 3, N'', 3, CAST(1600.0000 AS Decimal(19, 4)), NULL, 3, 6, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'C635Y6', N'Детский столовый набор', N'Детский столовый набор Fissman «Зебра» ', 3, N'', 2, CAST(1000.0000 AS Decimal(19, 4)), NULL, 4, 25, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'C730R7', N'Ложка детская', N'Ложка детская столовая', 2, N'', 6, CAST(300.0000 AS Decimal(19, 4)), NULL, 3, 17, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'C943G5', N'Набор чайных ложек', N'Attribute Набор чайных ложек Baguette 3 предмета серебристый', 3, N'', 3, CAST(200.0000 AS Decimal(19, 4)), NULL, 4, 12, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'C946Y6', N'Вилка столовая', N'Вилка детская столовая', 1, N'', 2, CAST(300.0000 AS Decimal(19, 4)), NULL, 2, 16, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'D735T5', N'Ложка чайная', N'Ложка чайная ALASKA Eternum', 2, N'D735T5.jpg', 1, CAST(220.0000 AS Decimal(19, 4)), NULL, 2, 13, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'E732R7', N'Набор столовых приборов', N'Набор столовых приборов Smart Home20 Black в подарочной коробке, 4 шт', 3, N'E732R7.jpg', 6, CAST(990.0000 AS Decimal(19, 4)), NULL, 5, 6, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'F392G6', N'Набор столовых приборов', N'Apollo Набор столовых приборов Chicago 4 предмета серебристый', 3, N'', 2, CAST(490.0000 AS Decimal(19, 4)), NULL, 4, 9, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'F573T5', N'Вилки столовые', N'Вилки столовые на блистере / 6 шт.', 1, N'F573T5.jpg', 7, CAST(650.0000 AS Decimal(19, 4)), NULL, 3, 4, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'F745K4', N'Столовые приборы для салата', N'Столовые приборы для салата Orskov Lava, 2шт', 3, N'', 5, CAST(2000.0000 AS Decimal(19, 4)), NULL, 3, 2, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'F839R6', N'Ложка чайная', N'Ложка чайная DORIA Eternum', 2, N'', 4, CAST(400.0000 AS Decimal(19, 4)), NULL, 2, 6, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'G304H6', N'Набор ложек', N'Набор ложек столовых APOLLO "Bohemica" 3 пр.', 2, N'', 2, CAST(500.0000 AS Decimal(19, 4)), NULL, 4, 12, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'G387Y6', N'Ложка столовая', N'Ложка столовая DORIA L=195/60 мм Eternum', 2, N'G387Y6.jpg', 4, CAST(441.0000 AS Decimal(19, 4)), NULL, 4, 23, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'H384H3', N'Набор столовых приборов', N'Набор столовых приборов для торта Palette 7 предметов серебристый', 3, N'H384H3.jpg', 2, CAST(600.0000 AS Decimal(19, 4)), NULL, 2, 9, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'H495H6', N'Набор стейковых ножей', N'Набор стейковых ножей 4 пр. в деревянной коробке', 4, N'', 5, CAST(7000.0000 AS Decimal(19, 4)), NULL, 2, 15, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'K437E6', N'Набор вилок', N'Набор вилок столовых APOLLO "Aurora" 3шт.', 3, N'K437E6.jpg', 2, CAST(530.0000 AS Decimal(19, 4)), NULL, 3, 16, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'L593H5', N'набор ножей', N'Набор ножей Mayer & Boch, 4 шт', 3, N'', 5, CAST(1300.0000 AS Decimal(19, 4)), NULL, 5, 14, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'N493G6', N'Набор для серверовки', N'Набор для сервировки сыра Select', 3, N'', 6, CAST(2550.0000 AS Decimal(19, 4)), NULL, 4, 6, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'R836H6', N'Набор  столовых ножей', N'Attribute Набор столовых ножей Baguette 2 предмета серебристый', 4, N'R836H6.jpg', 3, CAST(250.0000 AS Decimal(19, 4)), NULL, 3, 16, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'S394J5', N'Набор чайных ложек', N'Attribute Набор чайных ложек Chaplet 3 предмета серебристый', 3, N'', 3, CAST(170.0000 AS Decimal(19, 4)), NULL, 3, 4, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'S395B5', N'Нож для стейка', N'Нож для стейка 11,5 см серебристый/черный', 4, N'', 2, CAST(600.0000 AS Decimal(19, 4)), NULL, 4, 15, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'T793T4', N'Набор ложек', N'Набор столовых ложек Baguette 3 предмета серебристый', 2, N'T793T4.jpg', 3, CAST(250.0000 AS Decimal(19, 4)), NULL, 3, 16, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'V026J4', N'набор ножей', N'абор ножей для стейка и пиццы Swiss classic 2 шт. желтый', 3, N'', 2, CAST(700.0000 AS Decimal(19, 4)), NULL, 3, 9, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'V403G6', N'Ложка чайная', N'Ложка чайная DORIA Eternum', 2, N'', 4, CAST(600.0000 AS Decimal(19, 4)), NULL, 5, 24, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'V727Y6', N'Набор десертных ложек', N'Набор десертных ложек на подставке Размер: 7*7*15 см', 2, N'', 5, CAST(3000.0000 AS Decimal(19, 4)), NULL, 4, 8, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'W295Y5', N'Сервировочный набор для торта', N'Набор сервировочный для торта "Розанна"', 3, N'', 3, CAST(1100.0000 AS Decimal(19, 4)), NULL, 2, 16, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'W405G6', N'Набор столовых приборов', N'Набор сервировочных столовых вилок Цветы', 3, N'', 3, CAST(1300.0000 AS Decimal(19, 4)), NULL, 3, 4, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [ProductDescription], [ProductCategoryID], [ProductPhoto], [ProductManufacturerID], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitID], [ProductProviderID]) VALUES (N'А112Т4', N'Набор вилок', N'Набор столовых вилок Davinci, 20 см 6 шт.', 1, N'А112Т4.jpg', 7, CAST(1600.0000 AS Decimal(19, 4)), NULL, 2, 6, 1, 1)
GO
INSERT [dbo].[Provider] ([ProviderID], [ProviderName]) VALUES (1, N'Максидом')
INSERT [dbo].[Provider] ([ProviderID], [ProviderName]) VALUES (2, N'LeroiMerlin')
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Администратор
')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Менеджер
')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (3, N'Клиент
')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[Unit] ([UnitID], [UnitName]) VALUES (1, N'шт.')
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (1, N'Ефремов ', N'Сергей', N'Пантелеймонович', N'loginDEppn2018', N'6}i+FD', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (2, N'Родионова ', N'Тамара', N'Валентиновна', N'loginDElqb2018', N'RNynil', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (3, N'Миронова ', N'Галина', N'Улебовна', N'loginDEydn2018', N'34I}X9', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (4, N'Сидоров ', N'Роман', N'Иринеевич', N'loginDEijg2018', N'4QlKJW', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (5, N'Ситников ', N'Парфений', N'Всеволодович', N'loginDEdpy2018', N'MJ0W|f', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (6, N'Никонов ', N'Роман', N'Геласьевич', N'loginDEwdm2018', N'&PynqU', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (7, N'Щербаков ', N'Владимир', N'Матвеевич', N'loginDEdup2018', N'JM+2{s', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (8, N'Кулаков ', N'Мартын', N'Михаилович', N'loginDEhbm2018', N'9aObu4', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (9, N'Сазонова ', N'Оксана', N'Лаврентьевна', N'loginDExvq2018', N'hX0wJz', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (10, N'Архипов ', N'Варлам', N'Мэлорович', N'loginDErks2018', N'LQNSjo', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (11, N'Устинова ', N'Ираида', N'Мэлоровна', N'loginDErvb2018', N'ceAf&R', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (12, N'Лукин ', N'Георгий', N'Альбертович', N'loginDEulo2018', N'loginDEulo2018', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (13, N'Кононов ', N'Эдуард', N'Валентинович', N'loginDEgfw2018', N'3c2Ic1', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (14, N'Орехова ', N'Клавдия', N'Альбертовна', N'loginDEmxb2018', N'ZPXcRS', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (15, N'Яковлев ', N'Яков', N'Эдуардович', N'loginDEgeq2018', N'&&Eim0', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (16, N'Воронов ', N'Мэлс', N'Семёнович', N'loginDEkhj2018', N'Pbc0t{', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (17, N'Вишнякова ', N'Ия', N'Данииловна', N'loginDEliu2018', N'32FyTl', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (18, N'Третьяков ', N'Фёдор', N'Вадимович', N'loginDEsmf2018', N'{{O2QG', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (19, N'Макаров ', N'Максим', N'Ильяович', N'loginDEutd2018', N'GbcJvC', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (20, N'Шубина ', N'Маргарита', N'Анатольевна', N'loginDEpgh2018', N'YV2lvh', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (21, N'Блинова ', N'Ангелина', N'Владленовна', N'loginDEvop2018', N'pBP8rO', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (22, N'Воробьёв ', N'Владлен', N'Фролович', N'loginDEwjo2018', N'EQaD|d', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (23, N'Сорокина ', N'Прасковья', N'Фёдоровна', N'loginDEbur2018', N'aZKGeI', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (24, N'Давыдов ', N'Яков', N'Антонович', N'loginDEszw2018', N'EGU{YE', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (25, N'Рыбакова ', N'Евдокия', N'Анатольевна', N'loginDExsu2018', N'*2RMsp', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (26, N'Маслов ', N'Геннадий', N'Фролович', N'loginDEztn2018', N'nJBZpU', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (27, N'Цветкова ', N'Элеонора', N'Аристарховна', N'loginDEtmn2018', N'UObB}N', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (28, N'Евдокимов ', N'Ростислав', N'Александрович', N'loginDEhep2018', N'SwRicr', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (29, N'Никонова ', N'Венера', N'Станиславовна', N'loginDEevr2018', N'zO5l}l', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (30, N'Громов ', N'Егор', N'Антонович', N'loginDEnpa2018', N'M*QLjf', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (31, N'Суворова ', N'Валерия', N'Борисовна', N'loginDEgyt2018', N'Pav+GP', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (32, N'Мишина ', N'Елизавета', N'Романовна', N'loginDEbrr2018', N'Z7L|+i', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (33, N'Зимина ', N'Ольга', N'Аркадьевна', N'loginDEyoo2018', N'UG1BjP', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (34, N'Игнатьев ', N'Игнатий', N'Антонинович', N'loginDEaob2018', N'3fy+3I', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (35, N'Пахомова ', N'Зинаида', N'Витальевна', N'loginDEwtz2018', N'&GxSST', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (36, N'Устинов ', N'Владимир', N'Федосеевич', N'loginDEctf2018', N'sjt*3N', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (37, N'Кулаков ', N'Мэлор', N'Вячеславович', N'loginDEipm2018', N'MAZl6|', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (38, N'Сазонов ', N'Авксентий', N'Брониславович', N'loginDEjoi2018', N'o}C4jv', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (39, N'Бурова ', N'Наина', N'Брониславовна', N'loginDEwap2018', N'4hny7k', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (40, N'Фадеев ', N'Демьян', N'Федосеевич', N'loginDEaxm2018', N'BEc3xq', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (41, N'Бобылёва ', N'Дарья', N'Якуновна', N'loginDEsmq2018', N'ATVmM7', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (42, N'Виноградов ', N'Созон', N'Арсеньевич', N'loginDEeur2018', N'n4V{wP', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (43, N'Гордеев ', N'Владлен', N'Ефимович', N'loginDEvke2018', N'WQLXSl', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (44, N'Иванова ', N'Зинаида', N'Валерьевна', N'loginDEvod2018', N'0EW93v', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (45, N'Гусев ', N'Руслан', N'Дамирович', N'loginDEjaw2018', N'h6z&Ky', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (46, N'Маслов ', N'Дмитрий', N'Иванович', N'loginDEpdp2018', N'8NvRfC', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (47, N'Антонова ', N'Ульяна', N'Семёновна', N'loginDEjpp2018', N'oMOQq3', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (48, N'Орехова ', N'Людмила', N'Владимировна', N'loginDEkiy2018', N'BQzsts', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (49, N'Авдеева ', N'Жанна', N'Куприяновна', N'loginDEhmn2018', N'a|Iz|7', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (50, N'Кузнецов ', N'Фрол', N'Варламович', N'loginDEfmn2018', N'cw3|03', 3)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Manufacture] FOREIGN KEY([ProductManufacturerID])
REFERENCES [dbo].[Manufacture] ([ManufactureID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Manufacture]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Provider] FOREIGN KEY([ProductUnitID])
REFERENCES [dbo].[Provider] ([ProviderID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Provider]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Unit] FOREIGN KEY([ProductUnitID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Unit]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([UserRole])
REFERENCES [dbo].[Role] ([RoleID])
GO
USE [master]
GO
ALTER DATABASE [Trade] SET  READ_WRITE 
GO
