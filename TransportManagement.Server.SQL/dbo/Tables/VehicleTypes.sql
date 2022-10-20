CREATE TABLE [dbo].[VehicleTypes] (
    [Id]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [UniqueKey]  INT           NOT NULL,
    [UniqueName] NVARCHAR (20) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_VehicleTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_VehicleTypes_UniqueKey]
    ON [dbo].[VehicleTypes]([UniqueKey] ASC);

