IF EXISTS (SELECT TOP 1 1 FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CM_RegistrarEmpleado]') AND TYPE IN(N'P', N'PC'))
	DROP PROCEDURE [dbo].[CM_RegistrarEmpleado]
GO

CREATE PROCEDURE [dbo].[CM_RegistrarEmpleado]
@nombre					VARCHAR(255),
@telefono				VARCHAR(10),
@correo					VARCHAR(255),
@fechaNacimiento		DATETIME,
@usuario				VARCHAR(10),
@contrase�a				VARCHAR(10),
@tipoUsuario			VARCHAR(255),
@Mensaje				VARCHAR(MAX) OUTPUT
AS
BEGIN
	
	DECLARE @idTipoUsuario INT

	IF EXISTS(SELECT TOP 1 1 FROM Empleados WITH(NOLOCK) WHERE Usuario = @usuario AND Contrase�a = @contrase�a)
	BEGIN
		SET @Mensaje = 'Error, no se puede ingresar el siguiente empleado el usuario y/o contrase�a ya existen.'
	END
	ELSE
	BEGIN
		SELECT
			@idTipoUsuario = ID
		FROM
			Empleados_Tipo WITH(NOLOCK)
		WHERE
			Descripcion = @tipoUsuario

		INSERT INTO Empleados
		(
			Nombre,
			Telefono,
			Correo,
			FechaNacimiento,
			Usuario,
			Contrase�a,
			IdTipoUsuario,
			FechaRegistro
			
		)
		VALUES
		(
			@nombre,
			@telefono,
			@correo,
			@fechaNacimiento,
			@usuario,
			@contrase�a,
			@idTipoUsuario,
			GETDATE()
		)

		SET @Mensaje = 'Empleado registrado exitosamente.'
	END
END