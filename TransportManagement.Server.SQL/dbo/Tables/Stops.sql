CREATE TABLE [dbo].[Stops] (
    [Id]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (255) NOT NULL,
    [Latitude]  FLOAT (53)     NOT NULL,
    [Longitude] FLOAT (53)     NOT NULL,
    CONSTRAINT [PK_Stops] PRIMARY KEY CLUSTERED ([Id] ASC)
);

