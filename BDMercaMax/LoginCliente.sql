CREATE PROCEDURE [dbo].[LoginCliente]
	@user int 
AS
	SELECT cc_cliente,nombre_apellido_cliente FROM Cliente WHERE cc_cliente = @user
RETURN 0
