CREATE TABLE [dbo].[Password] (
    [IdPass]   INT           IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (50) NULL,
    [Site]     NVARCHAR (50) NULL,
    [Login]    NVARCHAR (50) NULL,
    [Password] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([IdPass] ASC)
);

