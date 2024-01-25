IF EXISTS (SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CM_RegistrarEmpleado]') AND TYPE IN(N'P', N'PC'))
	DROP PROCEDURE [dbo].[CM_RegistrarEmpleado]
GO

CREATE PROCEDURE [dbo].[CM_RegistrarEmpleado]
@nombre					VARCHAR(255),
@telefono				VARCHAR(10),
@correo					VARCHAR(255),
@fechaNacimiento		DATETIME,
@usuario				VARCHAR(10),
@contraseña				VARCHAR(10)


AS
BEGIN
	SELECT
		*
	FROM
		Empleados WITH(NOLOCK)
END