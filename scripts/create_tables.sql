USE [PoliceStation]
GO

/****** Object:  Table [dbo].[CasesTable]    Script Date: 06/01/2024 12:09:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CasesTable]') AND type in (N'U'))
DROP TABLE [dbo].[CasesTable]
GO

/****** Object:  Table [dbo].[CasesTable]    Script Date: 06/01/2024 12:09:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CasesTable](
	[No] [bigint] NOT NULL,
	[Type of Case] [nchar](100) NOT NULL,
	[Status] [nchar](100) NOT NULL,
	[Description] [ntext] NOT NULL,
	[Date of Modification] [date] NOT NULL,
 CONSTRAINT [PK_CasesTable] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [PoliceStation]
GO

/****** Object:  Table [dbo].[EmployeesTable]    Script Date: 06/01/2024 12:10:35 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmployeesTable]') AND type in (N'U'))
DROP TABLE [dbo].[EmployeesTable]
GO

/****** Object:  Table [dbo].[EmployeesTable]    Script Date: 06/01/2024 12:10:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeesTable](
	[ID] [bigint] NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[Department] [nchar](100) NOT NULL,
	[Date of Birth] [date] NOT NULL,
	[Hourly Rate] [money] NOT NULL,
	[Write Access] [bit],
	[Password] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_EmployeesTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [PoliceStation]
GO

/****** Object:  Table [dbo].[InventoryTable]    Script Date: 06/01/2024 12:11:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InventoryTable]') AND type in (N'U'))
DROP TABLE [dbo].[InventoryTable]
GO

/****** Object:  Table [dbo].[InventoryTable]    Script Date: 06/01/2024 12:11:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InventoryTable](
	[S No] [bigint] NOT NULL,
	[Police Inventory] [nchar](100) NOT NULL,
	[Inventory Type] [nchar](100) NOT NULL,
	[Quantity] [bigint] NOT NULL,
 CONSTRAINT [PK_InventoryTable] PRIMARY KEY CLUSTERED 
(
	[S No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [PoliceStation]
GO

/****** Object:  Table [dbo].[ShiftsTable]    Script Date: 06/01/2024 12:11:55 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ShiftsTable]') AND type in (N'U'))
DROP TABLE [dbo].[ShiftsTable]
GO

/****** Object:  Table [dbo].[ShiftsTable]    Script Date: 06/01/2024 12:11:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ShiftsTable](
	[ID] [bigint] NOT NULL,
	[Shift] [nchar](100) NOT NULL,
	[Date] [date] NOT NULL,
	CONSTRAINT [PK_ShiftsTable] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC,
		[Date] ASC
	) WITH (
		PAD_INDEX = OFF,
		STATISTICS_NORECOMPUTE = OFF,
		IGNORE_DUP_KEY = OFF,
		ALLOW_ROW_LOCKS = ON,
		ALLOW_PAGE_LOCKS = ON,
		OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
	) ON [PRIMARY]
) ON [PRIMARY]
GO
