CREATE PROCEDURE [dbo].[VerPuntos]
	@user int
AS
	SELECT puntos_acumulados FROM Cliente WHERE cc_cliente=@user
RETURN 0
