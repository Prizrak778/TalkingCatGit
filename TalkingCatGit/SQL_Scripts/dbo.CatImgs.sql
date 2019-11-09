CREATE TABLE [dbo].[CatImgs] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [UserId]       INT            NOT NULL,
    [DateDownload] DATETIME       NOT NULL,
    [PathImg]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.CatImgs] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.CatImgs_dbo.AllUserCats_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AllUserCats] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserId]
    ON [dbo].[CatImgs]([UserId] ASC);

