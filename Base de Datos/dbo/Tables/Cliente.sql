CREATE TABLE [dbo].[Cliente] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [nombre]    VARCHAR (25) NULL,
    [apellidos] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

