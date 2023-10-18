
-- =============================================
-- Author:		<Author,,Natalia>
-- Create date: <Create Date,,12/10/2023>
-- Description:	<Description,, Registrar Personas>
-- =============================================
CREATE PROCEDURE SP_Registrar_Personas

	@id varchar (10),
	@p_nombre varchar(40),
	@s_nombre varchar(40),
	@p_apellido varchar(40),
	@s_apellido varchar(40),
	@contacto varchar(10),
	@direccion varchar(100),
	@sexo char,
	@correo varchar(80)

	as begin
		insert into tbl_personas
		(PKId, P_Nombre,S_Nombre, P_Apellido,S_Apellido,Contacto,Direccion,FKId_tbl_sexo,Correo)
		values
		(@id,@p_nombre,@s_nombre,@p_apellido,@s_apellido,@contacto,@direccion,@sexo,@correo)
end
