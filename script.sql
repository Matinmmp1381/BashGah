USE [master]
GO
/****** Object:  Database [DB_Gym]    Script Date: 3/18/2021 11:32:26 AM ******/
CREATE DATABASE [DB_Gym]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Gym', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_Gym.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_Gym_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\DB_Gym_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_Gym] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Gym].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Gym] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Gym] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Gym] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Gym] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Gym] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Gym] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Gym] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Gym] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Gym] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Gym] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Gym] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Gym] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Gym] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Gym] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Gym] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Gym] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Gym] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Gym] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Gym] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Gym] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Gym] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Gym] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Gym] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_Gym] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Gym] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Gym] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Gym] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Gym] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB_Gym] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DB_Gym]
GO
/****** Object:  Table [dbo].[Tbl_AdminAccess]    Script Date: 3/18/2021 11:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_AdminAccess](
	[AdminAccess_ID] [int] IDENTITY(1,1) NOT NULL,
	[AdminAccess_UserName] [nvarchar](50) NOT NULL,
	[AdminAccess_PassWord] [nvarchar](50) NOT NULL,
	[AdminAccess_AddMember] [bit] NOT NULL,
	[AdminAccess_ManageMember] [bit] NOT NULL,
	[AdminAccess_CaseHistory] [bit] NOT NULL,
	[AdminAccess_AddGoods] [bit] NOT NULL,
	[AdminAccess_ManageGoods] [bit] NOT NULL,
	[AdminAccess_SaleGoods] [bit] NOT NULL,
	[AdminAccess_ManageWardRobe] [bit] NOT NULL,
	[AdminAccess_ManageAdmin] [bit] NOT NULL,
	[AdminAccess_BackUp] [bit] NOT NULL,
	[AdminAccess_Restore] [bit] NOT NULL,
 CONSTRAINT [PK_Tbl_AdminAccess] PRIMARY KEY CLUSTERED 
(
	[AdminAccess_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Athlete]    Script Date: 3/18/2021 11:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Athlete](
	[Athlete_ID] [int] IDENTITY(1,1) NOT NULL,
	[Athlete_FullName] [nvarchar](50) NOT NULL,
	[Athlete_BirthDay] [nvarchar](50) NOT NULL,
	[Athlete_JoinDate] [nvarchar](50) NOT NULL,
	[Athlete_ValidityDate] [nvarchar](50) NOT NULL,
	[Athlete_WardropNum] [nvarchar](50) NULL,
	[Athlete_Address] [nvarchar](250) NULL,
	[Athlete_PhoneNumber] [nvarchar](50) NULL,
	[Athlete_Image] [nvarchar](100) NOT NULL,
	[Athlete_Barcod] [nvarchar](100) NULL,
 CONSTRAINT [PK_Tbl_Athlete_1] PRIMARY KEY CLUSTERED 
(
	[Athlete_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Factor]    Script Date: 3/18/2021 11:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Factor](
	[Factor_ID] [int] IDENTITY(1,1) NOT NULL,
	[Factor_Date] [nvarchar](50) NOT NULL,
	[Facotr_Price] [int] NOT NULL,
	[Factor_Type] [nvarchar](50) NOT NULL,
	[Athlete_ID] [int] NOT NULL,
 CONSTRAINT [PK_Tbl_Factor] PRIMARY KEY CLUSTERED 
(
	[Factor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Store]    Script Date: 3/18/2021 11:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Store](
	[Store_FoodID] [int] IDENTITY(1,1) NOT NULL,
	[Store_FoodName] [nvarchar](100) NOT NULL,
	[Store_FoodPrice] [nvarchar](50) NOT NULL,
	[Store_FoodInventory] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Tbl_Foods] PRIMARY KEY CLUSTERED 
(
	[Store_FoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tbl_Wardrops]    Script Date: 3/18/2021 11:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Wardrops](
	[Wardrop_ID] [int] IDENTITY(1,1) NOT NULL,
	[Wardrop_Number] [nvarchar](50) NOT NULL,
	[Wardrop_State] [nvarchar](50) NOT NULL,
	[Wardrop_AthleteName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tbl_Wardrop] PRIMARY KEY CLUSTERED 
(
	[Wardrop_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[Vw_Factor]    Script Date: 3/18/2021 11:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vw_Factor]
AS
SELECT dbo.Tbl_Factor.Factor_ID, dbo.Tbl_Factor.Factor_Date, dbo.Tbl_Factor.Facotr_Price, dbo.Tbl_Factor.Athlete_ID, dbo.Tbl_Factor.Factor_Type, dbo.Tbl_Athlete.Athlete_FullName
FROM     dbo.Tbl_Factor INNER JOIN
                  dbo.Tbl_Athlete ON dbo.Tbl_Factor.Athlete_ID = dbo.Tbl_Athlete.Athlete_ID

GO
SET IDENTITY_INSERT [dbo].[Tbl_AdminAccess] ON 

INSERT [dbo].[Tbl_AdminAccess] ([AdminAccess_ID], [AdminAccess_UserName], [AdminAccess_PassWord], [AdminAccess_AddMember], [AdminAccess_ManageMember], [AdminAccess_CaseHistory], [AdminAccess_AddGoods], [AdminAccess_ManageGoods], [AdminAccess_SaleGoods], [AdminAccess_ManageWardRobe], [AdminAccess_ManageAdmin], [AdminAccess_BackUp], [AdminAccess_Restore]) VALUES (1, N'Matin', N'mm', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[Tbl_AdminAccess] ([AdminAccess_ID], [AdminAccess_UserName], [AdminAccess_PassWord], [AdminAccess_AddMember], [AdminAccess_ManageMember], [AdminAccess_CaseHistory], [AdminAccess_AddGoods], [AdminAccess_ManageGoods], [AdminAccess_SaleGoods], [AdminAccess_ManageWardRobe], [AdminAccess_ManageAdmin], [AdminAccess_BackUp], [AdminAccess_Restore]) VALUES (2, N'Matin1', N'mm', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Tbl_AdminAccess] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Athlete] ON 

INSERT [dbo].[Tbl_Athlete] ([Athlete_ID], [Athlete_FullName], [Athlete_BirthDay], [Athlete_JoinDate], [Athlete_ValidityDate], [Athlete_WardropNum], [Athlete_Address], [Athlete_PhoneNumber], [Athlete_Image], [Athlete_Barcod]) VALUES (3011, N'matin', N'1111/11/11', N'1111/11/11', N'1111/11/11', NULL, N'vfgbve', N'8765', N'9734f020-85de-454c-b020-14aabe07f9a3.png', N'_Barcode_9734f020-85de-454c-b020-14aabe07f9a3.png')
INSERT [dbo].[Tbl_Athlete] ([Athlete_ID], [Athlete_FullName], [Athlete_BirthDay], [Athlete_JoinDate], [Athlete_ValidityDate], [Athlete_WardropNum], [Athlete_Address], [Athlete_PhoneNumber], [Athlete_Image], [Athlete_Barcod]) VALUES (3012, N'mmad', N'1111/11/11', N'1111/11/11', N'1111/11/11', NULL, N'222222222222', N'2', N'a24c3673-63f8-436a-88a2-0c05a9674f25.png', N'_Barcode_a24c3673-63f8-436a-88a2-0c05a9674f25.png')
SET IDENTITY_INSERT [dbo].[Tbl_Athlete] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Factor] ON 

INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (4, N'1111/11/11', 80000, N'شهریه', 3011)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (5, N'1111/11/11', 6000, N'شهریه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (6, N'1111/11/11', 70000, N'شهریه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (7, N'1111/11/11', 90000, N'شهریه', 3011)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (1002, N'1399/12/27', 2500, N'خرید از فروشگاه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (1003, N'1399/12/27', 1000, N'خرید از فروشگاه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (1004, N'1399/12/27', 500, N'خرید از فروشگاه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (1005, N'1399/12/27', 500, N'خرید از فروشگاه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (1006, N'1399/12/27', 200, N'خرید از فروشگاه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (1007, N'1399/12/27', 200, N'خرید از فروشگاه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (1008, N'1399/12/27', 200, N'خرید از فروشگاه', 3012)
INSERT [dbo].[Tbl_Factor] ([Factor_ID], [Factor_Date], [Facotr_Price], [Factor_Type], [Athlete_ID]) VALUES (1009, N'1399/12/27', 100, N'خرید از فروشگاه', 3012)
SET IDENTITY_INSERT [dbo].[Tbl_Factor] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Store] ON 

INSERT [dbo].[Tbl_Store] ([Store_FoodID], [Store_FoodName], [Store_FoodPrice], [Store_FoodInventory]) VALUES (3, N'نوشابه', N'100', N'48')
SET IDENTITY_INSERT [dbo].[Tbl_Store] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Wardrops] ON 

INSERT [dbo].[Tbl_Wardrops] ([Wardrop_ID], [Wardrop_Number], [Wardrop_State], [Wardrop_AthleteName]) VALUES (1, N'101', N'پر', N'mmad')
SET IDENTITY_INSERT [dbo].[Tbl_Wardrops] OFF
ALTER TABLE [dbo].[Tbl_Factor]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Factor_Tbl_Athlete] FOREIGN KEY([Athlete_ID])
REFERENCES [dbo].[Tbl_Athlete] ([Athlete_ID])
GO
ALTER TABLE [dbo].[Tbl_Factor] CHECK CONSTRAINT [FK_Tbl_Factor_Tbl_Athlete]
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
         Begin Table = "Tbl_Factor"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 266
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Tbl_Athlete"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 289
               Right = 534
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1800
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Factor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vw_Factor'
GO
USE [master]
GO
ALTER DATABASE [DB_Gym] SET  READ_WRITE 
GO
