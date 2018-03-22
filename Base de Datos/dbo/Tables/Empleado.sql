CREATE TABLE [dbo].[Empleado] (
    [numero_seguridad_social] INT          NOT NULL,
    [nombre]                  VARCHAR (30) NOT NULL,
    [apellidos]               VARCHAR (30) NOT NULL,
    [telefono]                INT          NULL,
    [direccion]               TEXT         NULL,
    [tipo_empleado]           VARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([numero_seguridad_social] ASC)
);

