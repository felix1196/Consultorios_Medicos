IF EXISTS (SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CM_MostrarEmpleadosTipo]') AND TYPE IN(N'P', N'PC'))
	DROP PROCEDURE [dbo].[CM_MostrarEmpleadosTipo]
GO

CREATE PROCEDURE [dbo].[CM_MostrarEmpleadosTipo]
AS
BEGIN
	SELECT
		*
	FROM
		Empleados_Tipo WITH(NOLOCK)
END