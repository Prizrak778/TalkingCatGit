CREATE TABLE [dbo].[CatImgCatAlbums] (
    [CatImg_Id]   INT NOT NULL,
    [CatAlbum_Id] INT NOT NULL,
    CONSTRAINT [PK_dbo.CatImgCatAlbums] PRIMARY KEY CLUSTERED ([CatImg_Id] ASC, [CatAlbum_Id] ASC),
    CONSTRAINT [FK_dbo.CatImgCatAlbums_dbo.CatAlbums_CatImg_Id] FOREIGN KEY ([CatImg_Id]) REFERENCES [dbo].[CatAlbums] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.CatImgCatAlbums_dbo.CatImgs_CatAlbum_Id] FOREIGN KEY ([CatAlbum_Id]) REFERENCES [dbo].[CatImgs] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CatImg_Id]
    ON [dbo].[CatImgCatAlbums]([CatImg_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CatAlbum_Id]
    ON [dbo].[CatImgCatAlbums]([CatAlbum_Id] ASC);

