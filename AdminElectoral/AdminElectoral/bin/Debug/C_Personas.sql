CREATE PROCEDURE SelectAllCustomers @DIRECCION varchar(500)
AS
DECLARE @XML XML
DECLARE @handle INT  
DECLARE @PrepareXmlStatus INT

SET @XML = ( SELECT *
			  FROM OPENROWSET(BULK @DIRECCION, SINGLE_BLOB) AS data)

EXEC @PrepareXmlStatus= sp_xml_preparedocument @handle OUTPUT, @XML  



INSERT Persona (Cedula, IdProvincia,IdCanton,IdDistrito,Sexo,FechaCaducidad,CodigoJunta,Nombre,Apellido1,Apellido2) 
SELECT Cedula, Provincia, Canton, Distrito, Sexo, FechaCad
,Junta,Nombre,Apellido1,Apellido2
FROM OPENXML (@handle, 'Personas/Persona') WITH 
( Cedula bigint '@Cedula',Provincia smallint,Canton smallint, Distrito smallint, Sexo bit, FechaCad date,
Junta int ,Nombre varchar(50) '@Nombre',Apellido1 varchar(50),Apellido2 varchar(50))
