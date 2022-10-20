CREATE TABLE [dbo].[TicketValidations] (
    [Id]             BIGINT     IDENTITY (1, 1) NOT NULL,
    [Cost]           FLOAT (53) NOT NULL,
    [TicketId]       BIGINT     NOT NULL,
    [TicketActionId] BIGINT     NOT NULL,
    [StopFixingId]   BIGINT     NOT NULL,
    CONSTRAINT [PK_TicketValidations] PRIMARY KEY CLUSTERED ([Id] ASC)
);

