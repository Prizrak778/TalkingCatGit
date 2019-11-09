CREATE TABLE [dbo].[CatAlbumAllUserCat] (
    [CatAlbum_Id] INT NOT NULL,
    [CatUser_Id]  INT NOT NULL,
    CONSTRAINT [PK_dbo.CatAlbumAllUserCat] PRIMARY KEY CLUSTERED ([CatAlbum_Id] ASC, [CatUser_Id] ASC),
    CONSTRAINT [FK_dbo.CatAlbumAllUserCat_dbo.CatAlbums_CatAlbum_Id] FOREIGN KEY ([CatAlbum_Id]) REFERENCES [dbo].[CatAlbums] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.CatAlbumAllUserCat_dbo.AllUserCats_CatUser_Id] FOREIGN KEY ([CatUser_Id]) REFERENCES [dbo].[AllUserCats] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CatAlbum_Id]
    ON [dbo].[CatAlbumAllUserCat]([CatAlbum_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CatUser_Id]
    ON [dbo].[CatAlbumAllUserCat]([CatUser_Id] ASC);

