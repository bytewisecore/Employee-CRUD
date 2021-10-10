USE [University]
GO

/****** Object:  Table [dbo].[employees]    Script Date: 10/10/2021 10:31:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employees](
	[id] [int] NOT NULL,
	[firstname] [nchar](10) NOT NULL,
	[lastname] [nchar](10) NOT NULL,
	[gender] [nchar](10) NOT NULL,
	[age] [nchar](10) NOT NULL,
	[cellphone] [nchar](10) NOT NULL,
	[nationality] [nchar](10) NOT NULL,
	[dateofbirth] [nchar](10) NOT NULL
) ON [PRIMARY]
GO


