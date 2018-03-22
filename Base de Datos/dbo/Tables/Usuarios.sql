CREATE TABLE [dbo].[Usuarios] (
    [usuario]    VARCHAR (50) NOT NULL,
    [contrasena] VARCHAR (50) NOT NULL,
    [privilegio] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([usuario] ASC)
);

