CREATE TABLE [dbo].[DetallesPedido] (
    [id]                    INT          IDENTITY (1, 1) NOT NULL,
    [tipo]                  VARCHAR (25) NOT NULL,
    [fecha]                 DATE         NOT NULL,
    [hora]                  TIME (7)     NOT NULL,
    [datos_envio]           TEXT         NULL,
    [precio]                MONEY        NOT NULL,
    [informacion_adicional] TEXT         NULL,
    [repartidor]            INT          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([repartidor]) REFERENCES [dbo].[Empleado] ([numero_seguridad_social])
);

