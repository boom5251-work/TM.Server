CREATE TABLE [dbo].[Vehicles] (
    [Id]      BIGINT       IDENTITY (1, 1) NOT NULL,
    [Number]  NVARCHAR (9) NOT NULL,
    [BrandId] BIGINT       NOT NULL,
    CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Vehicles_Number]
    ON [dbo].[Vehicles]([Number] ASC);

