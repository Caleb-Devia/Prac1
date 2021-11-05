CREATE TABLE [dbo].[Facturacion]
(
	[id_factura] INT NOT NULL PRIMARY KEY, 
    [monto_total] DECIMAL NOT NULL, 
    [fecha] DATE NOT NULL, 
    [monto_iva] DECIMAL NOT NULL, 
    [cc_cliente] INT NOT NULL, 
    [cc_personal] INT NOT NULL, 
    [id_venta] INT NOT NULL, 
    CONSTRAINT [FK_Facturacion_ToTable] FOREIGN KEY ([cc_cliente]) REFERENCES [Cliente]([cc_cliente]), 
    CONSTRAINT [FK_Facturacion_ToTable_1] FOREIGN KEY ([cc_personal]) REFERENCES [Personal]([cc_personal]), 
    CONSTRAINT [FK_Facturacion_ToTable_2] FOREIGN KEY ([id_venta]) REFERENCES [Venta]([id_venta])
)
