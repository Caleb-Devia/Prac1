CREATE TABLE [dbo].[Cliente]
(
	[cc_cliente] INT NOT NULL PRIMARY KEY, 
    [nombre_apellido_cliente] NVARCHAR(MAX) NOT NULL, 
    [telefono_cliente] NVARCHAR(MAX) NOT NULL, 
    [email_cliente] NVARCHAR(MAX) NOT NULL, 
    [direccion_cliente] NVARCHAR(MAX) NOT NULL, 
    [fecha_nacimiento_cliente] DATE NOT NULL, 
    [puntos_acumulados] INT NOT NULL
)
