--====================================
 -- Author: <Author,,Jose David>
-- Create date: <Create Date,,12/10/2023>
-- Description:	<Description,, Registrar Usuario> 
--====================================
USE dbs_prestamos_deportivos
GO

CREATE TRIGGER TRG_Registrar_Usuario 
	ON tbl_personas
	AFTER INSERT
AS
BEGIN
	DECLARE @id varchar(10)
	DECLARE @p_nombre varchar(40)
	DECLARE @p_apellido varchar(40)
	DECLARE @user varchar(100)

	SELECT @id = (SELECT PKId from inserted)
	SELECT @p_nombre = (SELECT P_Nombre from inserted)
	SELECT @p_apellido = (SELECT P_Apellido from inserted)
	SELECT @user = @id + '.' + @p_nombre + @p_apellido

	INSERT INTO tbl_usuarios
	(PKUsuario, Contraseña, FKId_tbl_personas,Fecha, FKId_tbl_estado,FKId_tbl_rol)
	VALUES
	(@user,@id, @id,GETDATE(),1,4)
END
GO


