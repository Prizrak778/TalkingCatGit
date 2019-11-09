CREATE TABLE [dbo].[CatAlbums] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [NameAlbum] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.CatAlbums] PRIMARY KEY CLUSTERED ([Id] ASC)
);

