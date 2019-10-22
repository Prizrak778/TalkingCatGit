CREATE TABLE [dbo].[CatDialogues] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [User1Id]       INT NULL,
    [User2Id]       INT NULL,
    [LastMessageId] INT NULL,
    [AllUserCat_Id] INT NULL,
    CONSTRAINT [PK_dbo.CatDialogues] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.CatDialogues_dbo.AllUserCats_AllUserCat_Id] FOREIGN KEY ([AllUserCat_Id]) REFERENCES [dbo].[AllUserCats] ([Id]),
    CONSTRAINT [FK_dbo.CatDialogues_dbo.AllUserCats_User1Id] FOREIGN KEY ([User1Id]) REFERENCES [dbo].[AllUserCats] ([Id]),
    CONSTRAINT [FK_dbo.CatDialogues_dbo.AllUserCats_User2Id] FOREIGN KEY ([User2Id]) REFERENCES [dbo].[AllUserCats] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_User1Id]
    ON [dbo].[CatDialogues]([User1Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_User2Id]
    ON [dbo].[CatDialogues]([User2Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_AllUserCat_Id]
    ON [dbo].[CatDialogues]([AllUserCat_Id] ASC);

