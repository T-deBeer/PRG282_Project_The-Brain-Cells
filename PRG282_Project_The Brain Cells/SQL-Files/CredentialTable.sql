CREATE TABLE [dbo].[CredentialTable] (
    [AdminID]  INT IDENTITY(1,1) NOT NULL,
    [Username] VARCHAR (20)  NULL,
    [Password] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([AdminID] ASC)
);

