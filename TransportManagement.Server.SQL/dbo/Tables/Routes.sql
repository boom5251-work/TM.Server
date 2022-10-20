CREATE TABLE [dbo].[Routes] (
    [Id]            BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)  NOT NULL,
    [DisplayName]   NVARCHAR (10)  NOT NULL,
    [Description]   NVARCHAR (255) NULL,
    [VehicleTypeId] BIGINT         NOT NULL,
    CONSTRAINT [PK_Routes] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Routes_Name]
    ON [dbo].[Routes]([Name] ASC);

