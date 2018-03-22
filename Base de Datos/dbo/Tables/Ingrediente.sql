CREATE TABLE [dbo].[Ingrediente] (
    [codigo] VARCHAR (20) NOT NULL,
    [nombre] VARCHAR (50) NOT NULL,
    [precio] MONEY        NOT NULL,
    PRIMARY KEY CLUSTERED ([codigo] ASC)
);

