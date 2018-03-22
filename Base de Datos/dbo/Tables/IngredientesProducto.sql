CREATE TABLE [dbo].[IngredientesProducto] (
    [producto]    INT NOT NULL,
    [ingrediente] INT NOT NULL,
    [cantidad]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([producto] ASC, [ingrediente] ASC)
);

