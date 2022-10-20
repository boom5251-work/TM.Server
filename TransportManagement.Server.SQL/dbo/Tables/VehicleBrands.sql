CREATE TABLE [dbo].[VehicleBrands] (
    [Id]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (255) NOT NULL,
    [Capacity]      INT            NOT NULL,
    [MaxSpeed]      FLOAT (53)     NOT NULL,
    [VehicleTypeId] BIGINT         NOT NULL,
    CONSTRAINT [PK_VehicleBrands] PRIMARY KEY CLUSTERED ([Id] ASC)
);

