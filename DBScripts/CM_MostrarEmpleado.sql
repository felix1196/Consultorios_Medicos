IF EXISTS (SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CM_MostrarEmpleado]') AND TYPE IN(N'P', N'PC'))
	DROP PROCEDURE [dbo].[CM_MostrarEmpleado]
GO

CREATE PROCEDURE [dbo].[CM_MostrarEmpleado]
AS
BEGIN
	SELECT
		*
	FROM
		Empleados WITH(NOLOCK)
END