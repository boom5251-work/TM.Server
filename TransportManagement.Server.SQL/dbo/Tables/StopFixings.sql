CREATE TABLE [dbo].[StopFixings] (
    [Id]               BIGINT        IDENTITY (1, 1) NOT NULL,
    [DateTime]         DATETIME2 (7) NOT NULL,
    [PassengersNumber] INT           NOT NULL,
    [StopId]           BIGINT        NOT NULL,
    [RouteId]          BIGINT        NOT NULL,
    [VehicleId]        BIGINT        NOT NULL,
    CONSTRAINT [PK_StopFixings] PRIMARY KEY CLUSTERED ([Id] ASC)
);

