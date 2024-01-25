USE Consultorios_Electronet
GO

--	EMPLEADOS
CREATE TABLE Empleados(
ID				INT IDENTITY(1,1)	NOT NULL,
Nombre			VARCHAR(255)		NOT NULL,
Telefono		VARCHAR(10),
Correo			VARCHAR(255),
FechaNacimiento	DATETIME,
Usuario			VARCHAR(10)			NOT NULL,
Contraseña		VARCHAR(10)			NOT NULL,
IdTipoUsuario	INT					NOT NULL,
FechaRegistro	DATETIME
)
GO

-- EMPLEADOS TIPO
CREATE TABLE Empleados_Tipo(
ID				INT IDENTITY(1,1)	NOT NULL,
Descripcion		VARCHAR(255)		NOT NULL
)
GO

CREATE TABLE Modulos(
ID				INT IDENTITY(1,1)	NOT NULL,
NombreModulo	VARCHAR(255)		NOT NULL,
Descripcion		VARCHAR(255),
NombreEnsamble	VARCHAR(255)		NOT NULL
)
GO

--INSERT INTO Empleados
--(
--	Nombre,
--	Telefono,
--	Correo,
--	FechaNacimiento,
--	Usuario,
--	Contraseña,
--	IdTipoUsuario,
--	FechaRegistro

--) 
--VALUES
--(
--	'Administrador',
--	'3511334983',
--	'felixjr11@hotmail.com',
--	GETDATE(),
--	'Admin',
--	'Admin',
--	1,
--	GETDATE()	
--)

--INSERT INTO Empleados_Tipo
--(
--	Descripcion
--) 
--VALUES
--(
--	'Administrador'
--)

--INSERT INTO Modulos
--(
--	NombreModulo,
--	Descripcion,
--	NombreEnsamble
--) 
--VALUES
--(
--	'Empleados',
--	'Modulo empleados',
--	'frmEmpleados'
--)
