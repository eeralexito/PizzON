CREATE TABLE [dbo].[Direccion] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [calle]     VARCHAR (100) NOT NULL,
    [numero]    VARCHAR (10)  NOT NULL,
    [portal]    VARCHAR (10)  NULL,
    [piso]      INT           NULL,
    [puerta]    VARCHAR (5)   NULL,
    [localidad] VARCHAR (50)  NOT NULL,
    [cliente]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([cliente]) REFERENCES [dbo].[Cliente] ([id])
);

