SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[Artist_ID] [int] NOT NULL,
	[First_Name] [varchar](15) NOT NULL,
	[Last_Name] [varchar](20) NOT NULL,
	[Year_Born] [int] NOT NULL,
	[Year_Died] [int] NULL,
	[Years_Active] [int] NULL,
	[Occupation] [varchar](30) NULL,
	[Net_Worth] [decimal](10,2) NULL,
	[Home_Town] [varchar](50) NULL,
	[Genre] [varchar](20) NOT NULL,
	[Awards] [varchar](100) NULL,
	[Instruments] [varchar](50) NULL,
	[Label] [varchar](50) NULL,
	[Photo] [varchar](20) NULL,

 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[Artist_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO