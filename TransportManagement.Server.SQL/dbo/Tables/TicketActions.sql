CREATE TABLE [dbo].[TicketActions] (
    [Id]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [UniqueKey]  INT           NOT NULL,
    [UniqueName] NVARCHAR (20) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_TicketActions] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_TicketActions_UniqueKey]
    ON [dbo].[TicketActions]([UniqueKey] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_TicketActions_UniqueName]
    ON [dbo].[TicketActions]([UniqueName] ASC);

