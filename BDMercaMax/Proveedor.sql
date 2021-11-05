CREATE TABLE [dbo].[Proveedor]
(
	[nit] INT NOT NULL PRIMARY KEY, 
    [nombre_proveedor] NVARCHAR(MAX) NOT NULL, 
    [telefono_proveedor] NVARCHAR(MAX) NOT NULL, 
    [email_proveedor] NVARCHAR(MAX) NOT NULL, 
    [direccion_proveedor] NVARCHAR(MAX) NOT NULL, 
    [agente_ventas] NVARCHAR(MAX) NOT NULL
)
