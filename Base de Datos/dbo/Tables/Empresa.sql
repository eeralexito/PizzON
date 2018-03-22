CREATE TABLE [dbo].[Empresa] (
    [CIF]                  VARCHAR (15) NOT NULL,
    [nombre]               VARCHAR (50) NOT NULL,
    [direccion]            TEXT         NULL,
    [horario]              VARCHAR (50) NULL,
    [telefono_reparto]     INT          NULL,
    [telefono_restaurante] INT          NULL,
    PRIMARY KEY CLUSTERED ([CIF] ASC)
);

