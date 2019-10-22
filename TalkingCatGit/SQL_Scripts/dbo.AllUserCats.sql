CREATE TABLE [dbo].[AllUserCats] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (MAX) NULL,
    [SurName]        NVARCHAR (MAX) NULL,
    [SecondName]     NVARCHAR (MAX) NULL,
    [Birthday]       DATETIME       NULL,
    [CurrentCity]    NVARCHAR (MAX) NULL,
    [CurrentCountry] NVARCHAR (MAX) NULL,
    [Language]       NVARCHAR (MAX) NULL,
    [UrlLink]        NVARCHAR (MAX) NULL,
    [Status]         NVARCHAR (MAX) NULL,
    [AboutMe]        NVARCHAR (MAX) NULL,
    [LastActivity]   DATETIME       NULL,
    [ImgId]          INT            NULL,
    CONSTRAINT [PK_dbo.AllUserCats] PRIMARY KEY CLUSTERED ([Id] ASC)
);

