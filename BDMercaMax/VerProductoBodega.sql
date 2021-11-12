CREATE PROCEDURE [dbo].[VerProductoBodega]
	@codProd int
	
AS
	 SELECT cantidad_bodega, seccion_bodega  FROM LugarStock WHERE barcode_producto=@codProd
RETURN 0
