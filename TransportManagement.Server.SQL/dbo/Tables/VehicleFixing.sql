CREATE TABLE [dbo].[VehicleFixing] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [DateTime]  DATETIME2 (7) NOT NULL,
    [Latitude]  FLOAT (53)    NOT NULL,
    [Longitude] FLOAT (53)    NOT NULL,
    [Speed]     FLOAT (53)    NOT NULL,
    [VehicleId] BIGINT        NOT NULL,
    [RountId]   BIGINT        NOT NULL,
    CONSTRAINT [PK_VehicleFixing] PRIMARY KEY CLUSTERED ([Id] ASC)
);

