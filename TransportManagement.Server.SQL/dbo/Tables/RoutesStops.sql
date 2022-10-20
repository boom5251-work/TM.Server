CREATE TABLE [dbo].[RoutesStops] (
    [Id]      BIGINT IDENTITY (1, 1) NOT NULL,
    [RouteId] BIGINT NOT NULL,
    [StopId]  BIGINT NOT NULL,
    CONSTRAINT [PK_RoutesStops] PRIMARY KEY CLUSTERED ([Id] ASC)
);

