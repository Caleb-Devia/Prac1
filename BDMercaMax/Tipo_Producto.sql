CREATE TABLE [dbo].[Tipo_Producto]
(
	[id_tipo] INT NOT NULL PRIMARY KEY, 
    [categoria] NVARCHAR(MAX) NOT NULL, 
    [perecedero] BIT NOT NULL, 
    [iva] INT NOT NULL, 
    [puntos] INT NOT NULL 
)
