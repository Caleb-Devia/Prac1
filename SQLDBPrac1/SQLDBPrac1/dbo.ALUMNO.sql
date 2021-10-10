CREATE TABLE [dbo].[ALUMNO] (
    [Id]     INT           IDENTITY(1,1) NOT NULL,
    [Nombre] NVARCHAR (50) NOT NULL,
    [Ciudad] NVARCHAR (50) NOT NULL,
    [Edad]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

