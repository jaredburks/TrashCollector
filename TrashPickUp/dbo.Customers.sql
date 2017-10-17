CREATE TABLE [dbo].[Customers] (
    [ID]     INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (MAX) NULL,
    [Street] NVARCHAR (MAX) NULL,
    [City]   NVARCHAR (MAX) NULL,
    [Zip]    NVARCHAR (MAX) NULL,
    [Date]   DATETIME       NULL,
    CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED ([ID] ASC)
);

