CREATE TABLE [dbo].[TicketTypes] (
    [Id]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [UniqueKey]  INT           NOT NULL,
    [UniqueName] NVARCHAR (20) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_TicketTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_TicketTypes_UniqueKey]
    ON [dbo].[TicketTypes]([UniqueKey] ASC);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_TicketTypes_UniqueName]
    ON [dbo].[TicketTypes]([UniqueName] ASC);

