CREATE TABLE [dbo].[UserCatMessages] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Message]         NVARCHAR (MAX) NULL,
    [DateMessage]     DATETIME       NOT NULL,
    [DialogId]        INT            NOT NULL,
    [AuthorMessageId] INT            NOT NULL,
    CONSTRAINT [PK_dbo.UserCatMessages] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.UserCatMessages_dbo.AllUserCats_AuthorMessageId] FOREIGN KEY ([AuthorMessageId]) REFERENCES [dbo].[AllUserCats] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_AuthorMessageId]
    ON [dbo].[UserCatMessages]([AuthorMessageId] ASC);

