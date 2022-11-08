CREATE TABLE [dbo].[ModuleTable]
(
	[Module_Code] VARCHAR(10) NOT NULL,
	[Module_Name]  VARCHAR(30) NOT NULL ,
	[Module_Description] VARCHAR(1000) NOT NULL,
	[Module_Link] VARCHAR(1000) NULL,
	CONSTRAINT "PK_ModuleCode" PRIMARY KEY CLUSTERED
	(
		"Module_Code"
	)
)
