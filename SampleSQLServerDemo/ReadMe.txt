Listed below are the things have been added to this ASP.Core MVC Sample
using SQLServer localDB with ADO.Net CRUD database calls
To run this demo you need to 
* create a database called ArtistCollection on your localDB instance
* create a table called Names - See script below

1. Added the new Microsoft.Data.SqlClient (2.0.0. preview) package from Nuget Manager
   Select Tools..Nuget Package Manager..search for Microsoft.Data.SqlClient and check all pre-releases
2. Added the SQLServer localDB connection string to the appsettings.json file
3. Added the Microsoft.Extensions.Configuration namespace in the NameDB.cs (CRUD component)
   to read the appsettings.json file
4. Added the System.IO in the NameDB.cs
5. Example reference link used: https://www.completecsharptutorial.com/mvc-articles/insert-update-delete-in-asp-net-mvc-5-without-entity-framework.php

Additional links for accessing SQL Server using Microsoft.Data.SqlClient (.NetCore 3+) versus System.Data.SqlClient (.Net Framework)
https://devblogs.microsoft.com/dotnet/introducing-the-new-microsoftdatasqlclient/

SQL script to create the Names table in the ArtistCollection database

/****** Object:  Table [dbo].[Names]    Script Date: 4/27/2020 8:05:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Names](
	[ID] [int] NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](30) NULL,
 CONSTRAINT [PK_Names] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
