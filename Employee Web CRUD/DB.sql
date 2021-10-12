USE [University]
GO

/****** Object:  Table [dbo].[webemployees]    Script Date: 10/10/2021 10:27:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[webemployees](
	[id] [varchar](50) NOT NULL,
	[firstname] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[age] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[cellphone] [varchar](50) NOT NULL,
	[position] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


