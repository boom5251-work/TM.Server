﻿CREATE TABLE [dbo].[Tickets] (
    [Id]     BIGINT IDENTITY (1, 1) NOT NULL,
    [TypeId] BIGINT NOT NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED ([Id] ASC)
);

