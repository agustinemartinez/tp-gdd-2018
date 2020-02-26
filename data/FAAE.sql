/** CONEXION BASE DE DATOS **/
USE GD1C2018
GO

/** ASEGURAMOS LOS NOMBRES DE TABLAS **/
IF OBJECT_ID('FAAE.Historial_Reserva','U') IS NOT NULL
    DROP TABLE FAAE.Historial_Reserva;
IF OBJECT_ID('FAAE.Rol_Usuario','U') IS NOT NULL
    DROP TABLE FAAE.Rol_Usuario;
IF OBJECT_ID('FAAE.Estadia','U') IS NOT NULL
    DROP TABLE FAAE.Estadia;
IF OBJECT_ID('FAAE.Item_Factura','U') IS NOT NULL
    DROP TABLE FAAE.Item_Factura;
IF OBJECT_ID('FAAE.Funcionalidad','U') IS NOT NULL
    DROP TABLE FAAE.Funcionalidad;
IF OBJECT_ID('FAAE.Consumible','U') IS NOT NULL
    DROP TABLE FAAE.Consumible;
IF OBJECT_ID('FAAE.Factura','U') IS NOT NULL
    DROP TABLE FAAE.Factura;
IF OBJECT_ID('FAAE.Historial_Inhabilitado','U') IS NOT NULL
    DROP TABLE FAAE.Historial_Inhabilitado;
IF OBJECT_ID('FAAE.Hotel_Usuario','U') IS NOT NULL
    DROP TABLE FAAE.Hotel_Usuario;
IF OBJECT_ID('FAAE.Usuario','U') IS NOT NULL
    DROP TABLE FAAE.Usuario;
IF OBJECT_ID('FAAE.Reserva_Habitacion','U') IS NOT NULL
    DROP TABLE FAAE.Reserva_Habitacion;
IF OBJECT_ID('FAAE.Reserva','U') IS NOT NULL
    DROP TABLE FAAE.Reserva;
IF OBJECT_ID('FAAE.Rol','U') IS NOT NULL
    DROP TABLE FAAE.Rol;
IF OBJECT_ID('FAAE.Habitacion','U') IS NOT NULL
    DROP TABLE FAAE.Habitacion;
IF OBJECT_ID('FAAE.Tipo','U') IS NOT NULL
    DROP TABLE FAAE.Tipo;
IF OBJECT_ID('FAAE.Regimen_Hotel ','U') IS NOT NULL
    DROP TABLE FAAE.Regimen_Hotel;
IF OBJECT_ID('FAAE.Regimen','U') IS NOT NULL
    DROP TABLE FAAE.Regimen;
IF OBJECT_ID('FAAE.Motivo','U') IS NOT NULL
    DROP TABLE FAAE.Motivo;
IF OBJECT_ID('FAAE.Hotel','U') IS NOT NULL
    DROP TABLE FAAE.Hotel;
IF OBJECT_ID('FAAE.Cliente','U') IS NOT NULL
    DROP TABLE FAAE.Cliente;

/** ASEGURAMOS LOS NOMBRES DE TRIGGERS FUNCIONES Y VISTAS **/

IF (OBJECT_ID ('FAAE.t_actualizar_Historial_Reserva') IS NOT NULL)
	DROP TRIGGER FAAE.t_actualizar_Estado_Reserva_Dependiendo_de_Historial

IF (OBJECT_ID ('FAAE.t_actualizar_Estado_Reserva_Dependiendo_de_Factura') IS NOT NULL)
	DROP TRIGGER FAAE.t_actualizar_Estado_Reserva_Dependiendo_de_Factura

 IF OBJECT_ID('FAAE.t_mail_y_pasaporte_unico') IS NOT NULL
    DROP TRIGGER FAAE.t_mail_unico;

IF (OBJECT_ID ('FAAE.obtenerHotelCodigo') IS NOT NULL)
	DROP FUNCTION FAAE.obtenerHotelCodigo

IF OBJECT_ID('FAAE.t_agregar_Hotel') IS NOT NULL
	DROP TRIGGER FAAE.t_agregar_Hotel;

IF OBJECT_ID('FAAE.cantPersonas') IS NOT NULL
	DROP FUNCTION FAAE.cantPersonas;

IF OBJECT_ID('FAAE.RolXUsuario') IS NOT NULL
    DROP VIEW FAAE.RolXUsuario;

IF OBJECT_ID('FAAE.login_fallido') IS NOT NULL
    DROP PROCEDURE FAAE.login_fallido;

IF OBJECT_ID('FAAE.limpiar_login_fallidos') IS NOT NULL
    DROP PROCEDURE FAAE.limpiar_login_fallidos;

IF OBJECT_ID('FAAE.guardar_hotel') IS NOT NULL
    DROP PROCEDURE FAAE.guardar_hotel;

IF OBJECT_ID('FAAE.eliminar_hotel') IS NOT NULL
    DROP PROCEDURE FAAE.eliminar_hotel;

IF OBJECT_ID('FAAE.inhabilitar_usuario') IS NOT NULL
    DROP PROCEDURE FAAE.inhabilitar_usuario;

IF OBJECT_ID('FAAE.inhabilitar_rol') IS NOT NULL
    DROP PROCEDURE FAAE.inhabilitar_rol;

IF OBJECT_ID('FAAE.guardar_rol') IS NOT NULL
    DROP PROCEDURE FAAE.guardar_rol;

IF OBJECT_ID('FAAE.asignar_funcionalidad_rol') IS NOT NULL
    DROP PROCEDURE FAAE.asignar_funcionalidad_rol;

IF OBJECT_ID('FAAE.eliminar_funcionalidades_rol') IS NOT NULL
    DROP PROCEDURE FAAE.eliminar_funcionalidades_rol;

IF OBJECT_ID('FAAE.guardar_habitacion') IS NOT NULL
    DROP PROCEDURE FAAE.guardar_habitacion;

IF OBJECT_ID('FAAE.modificar_habitacion') IS NOT NULL
    DROP PROCEDURE FAAE.modificar_habitacion;

IF OBJECT_ID('FAAE.baja_habitacion') IS NOT NULL
    DROP PROCEDURE FAAE.baja_habitacion;

IF OBJECT_ID('FAAE.inhabilitar_habitacion') IS NOT NULL
    DROP PROCEDURE FAAE.inhabilitar_habitacion;

IF OBJECT_ID('FAAE.guardar_usuario') IS NOT NULL
    DROP PROCEDURE FAAE.guardar_usuario;

IF OBJECT_ID('FAAE.asignar_rol_usuario') IS NOT NULL
    DROP PROCEDURE FAAE.asignar_rol_usuario;

IF OBJECT_ID('FAAE.eliminar_roles_usuario') IS NOT NULL
    DROP PROCEDURE FAAE.eliminar_roles_usuario;

IF OBJECT_ID('FAAE.modificar_cliente') IS NOT NULL
    DROP PROCEDURE FAAE.modificar_cliente;

IF OBJECT_ID('FAAE.NuevaFactura') IS NOT NULL
    DROP FUNCTION FAAE.NuevaFactura;

IF OBJECT_ID('FAAE.ConsumiblesReserva') IS NOT NULL
    DROP FUNCTION FAAE.ConsumiblesReserva;

IF OBJECT_ID('FAAE.calcularTotalEstadia') IS NOT NULL
    DROP FUNCTION FAAE.calcularTotalEstadia;

IF OBJECT_ID('FAAE.guardar_factura') IS NOT NULL
    DROP PROCEDURE FAAE.guardar_factura;

IF OBJECT_ID('FAAE.guardar_items_factura') IS NOT NULL
    DROP PROCEDURE FAAE.guardar_items_factura;

IF OBJECT_ID('FAAE.HotelesConMasReservasCanceladas') IS NOT NULL
    DROP FUNCTION FAAE.HotelesConMasReservasCanceladas;

IF OBJECT_ID('FAAE.HotelesConMasConsumiblesFacturados') IS NOT NULL
    DROP FUNCTION FAAE.HotelesConMasConsumiblesFacturados;

IF OBJECT_ID('FAAE.DiasFueraDeServicio') IS NOT NULL
    DROP FUNCTION FAAE.DiasFueraDeServicio;

IF OBJECT_ID('FAAE.HotelesConMasDiasFueraDeServicio') IS NOT NULL
    DROP FUNCTION FAAE.HotelesConMasDiasFueraDeServicio;

IF OBJECT_ID('FAAE.HabitacionesConMasDiasYVecesOcupada') IS NOT NULL
    DROP FUNCTION FAAE.HabitacionesConMasDiasYVecesOcupada;

IF OBJECT_ID('FAAE.ClientesConMasPuntos') IS NOT NULL
    DROP FUNCTION FAAE.ClientesConMasPuntos;

IF OBJECT_ID('FAAE.Codigo_Hoteles_Usuario') IS NOT NULL
    DROP FUNCTION FAAE.Codigo_Hoteles_Usuario;

IF OBJECT_ID('FAAE.asignar_hotel_usuario') IS NOT NULL
    DROP PROC FAAE.asignar_hotel_usuario;

IF OBJECT_ID('FAAE.eliminar_hoteles_usuario') IS NOT NULL
    DROP PROC FAAE.eliminar_hoteles_usuario;

IF OBJECT_ID('FAAE.asignar_regimen_hotel') IS NOT NULL
    DROP PROC FAAE.asignar_regimen_hotel;

IF OBJECT_ID('FAAE.eliminar_regimenes_hotel') IS NOT NULL
    DROP PROC FAAE.eliminar_regimenes_hotel;

IF OBJECT_ID('FAAE.inhabilitar_hotel') IS NOT NULL
    DROP PROC FAAE.inhabilitar_hotel;

IF OBJECT_ID('FAAE.guardar_reserva') IS NOT NULL
    DROP PROC FAAE.guardar_reserva;

IF OBJECT_ID('FAAE.obtenerPrimeraHabitacionDisponible') IS NOT NULL
    DROP FUNCTION FAAE.obtenerPrimeraHabitacionDisponible;

IF OBJECT_ID('FAAE.guardar_reservaPorHabitacion') IS NOT NULL
    DROP PROC FAAE.guardar_reservaPorHabitacion;

IF OBJECT_ID('FAAE.guardar_checkIn') IS NOT NULL
    DROP PROC FAAE.guardar_checkIn;

IF OBJECT_ID('FAAE.guardar_cliente') IS NOT NULL
    DROP PROC FAAE.guardar_cliente;

IF OBJECT_ID('FAAE.encriptar_contrasena_update') IS NOT NULL
    DROP TRIGGER FAAE.encriptar_contrasena_update;

IF OBJECT_ID('FAAE.modificar_reserva') IS NOT NULL
    DROP PROC FAAE.modificar_reserva;

IF OBJECT_ID('FAAE.borrar_habitacionesDeReservaAntigua') IS NOT NULL
    DROP PROC FAAE.borrar_habitacionesDeReservaAntigua;
Go


GO


IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'FAAE')
    DROP SCHEMA FAAE
GO

/** CREACION DE SCHEMA **/
CREATE SCHEMA FAAE AUTHORIZATION gdHotel2018
GO


/** CREACION DE TABLAS **/
CREATE TABLE FAAE.Historial_Reserva (
    hire_codigo numeric(10,0) IDENTITY(1,1) PRIMARY KEY,
    hire_rese_codigo numeric(10) not null,
	hire_descripcion nvarchar(50) default 'Reserva cancelada por No-Show',
	hire_usua_doc_tipo nvarchar(10) default 'pasaporte',
	hire_usua_doc_nro numeric(10),
	hire_usua_mail nvarchar(50)
)
CREATE TABLE FAAE.Cliente (
    clie_doc_tipo nvarchar(10) default 'pasaporte',
	clie_doc_nro numeric(10),
	clie_nombre nvarchar(25) not null,
	clie_apellido nvarchar(25) not null,
	clie_mail nvarchar(50) not null,
	clie_telefono nvarchar(16) default 00000000,
	clie_dire_calle nvarchar(50) not null,
	clie_dire_nro numeric(10),
	clie_dire_localidad nvarchar(16) default 'caba',
	clie_dire_pais nvarchar(16) default 'argentina',
	clie_nacionalidad nvarchar(16) not null,
	clie_habilitado bit default 1,
	clie_fecha_nacimiento smalldatetime not null,
	clie_piso numeric(5),
	clie_depto nvarchar(5)
	PRIMARY KEY (clie_doc_tipo, clie_doc_nro, clie_mail), -- el mail se agrego porque se repiten los numeros de pasaporte en la migracion, esto podria mejorarse eliminando las inconsistencias de la tabla a migrar
)
CREATE TABLE FAAE.Rol_Usuario (
    rous_clie_doc_tipo nvarchar(10) default 'pasaporte',
	rous_clie_doc_nro numeric(10),
	rous_clie_mail nvarchar(50),
	rous_rol_nombre nvarchar(16)
	PRIMARY KEY (rous_clie_doc_tipo, rous_clie_doc_nro, rous_clie_mail, rous_rol_nombre)
)
CREATE TABLE FAAE.Estadia (
    esta_rese_codigo numeric(10),
	esta_habi_nro numeric(10),
	esta_hote_codigo numeric(10),
	esta_clie_doc_tipo nvarchar(10) default 'pasaporte',
	esta_clie_doc_nro numeric(10),
	esta_clie_mail nvarchar(50),
	esta_fecha_salida smalldatetime,
	esta_usuaIn_doc_tipo nvarchar(10) default 'pasaporte',
	esta_usuaIn_doc_nro numeric(10),
	esta_usuaIn_mail nvarchar(50),
	esta_usuaOut_doc_tipo nvarchar(10) default 'pasaporte',
	esta_usuaOut_doc_nro numeric(10),
	esta_usuaOut_mail nvarchar(50),
	PRIMARY KEY (esta_rese_codigo, esta_habi_nro, esta_hote_codigo,esta_clie_doc_tipo,esta_clie_doc_nro, esta_clie_mail)
)
CREATE TABLE FAAE.Reserva_Habitacion (
    reha_rese_codigo numeric(10),
	reha_habi_nro numeric(10),
	reha_hote_codigo numeric(10),
	reha_precio numeric(10),
	PRIMARY KEY (reha_rese_codigo,reha_habi_nro, reha_hote_codigo)
)
CREATE TABLE FAAE.Reserva (
    rese_codigo numeric(10) IDENTITY(1,1) PRIMARY KEY,
	rese_fecha_realizacion smalldatetime,
	rese_fecha_desde smalldatetime,
	rese_fecha_hasta smalldatetime,
	rese_hote_codigo numeric(10),
	rese_regi_codigo nvarchar(30),
	rese_clie_doc_tipo nvarchar(10) default 'pasaporte',
	rese_clie_doc_nro numeric(10),
	rese_clie_mail nvarchar(50),
	rese_estado char(50) default 'Reserva Correcta'
)
CREATE TABLE FAAE.Rol (
    rol_nombre nvarchar(16) PRIMARY KEY,
	rol_habilitado bit default 1
)
CREATE TABLE FAAE.Item_Factura (
    item_fact_tipo nvarchar(10) default 'A',
	item_fact_nro numeric(10),
	item_cons_codigo numeric(10),
	item_cantidad numeric(10),
	item_precio decimal(5,2),
	PRIMARY KEY (item_fact_tipo,item_fact_nro,item_cons_codigo)
)
CREATE TABLE FAAE.Habitacion (
    habi_nro numeric(10),
	habi_hote_codigo numeric(10),
	habi_piso numeric(2) not null,
	habi_vista_exterior char(1) not null,
	habi_tipo_codigo numeric(10) not null,
	habi_habilitada bit default 1,
	habi_descripcion nvarchar(30)
	PRIMARY KEY (habi_nro,habi_hote_codigo)
)
CREATE TABLE FAAE.Tipo (
    tipo_codigo numeric(10) PRIMARY KEY,
	tipo_descripcion nvarchar(30),
	tipo_cant_personas numeric(1),
	tipo_porcentual decimal(4,2)
)
CREATE TABLE FAAE.Funcionalidad (
    func_rol_nombre nvarchar(16),
	func_funcion nvarchar(16),
	PRIMARY KEY (func_rol_nombre,func_funcion)
)
CREATE TABLE FAAE.Consumible (
    cons_codigo numeric(10) PRIMARY KEY,
	cons_descipcion nvarchar(25),
	cons_precio decimal(5,2)
)
CREATE TABLE FAAE.Factura (
    fact_tipo nvarchar(10) default 'A',
	fact_nro numeric(10),
	fact_fecha smalldatetime,
	fact_total decimal(10,2),
	fact_forma_pago nvarchar(10) default 'efectivo',
	fact_rese_codigo numeric(10),
	fact_habi_nro numeric(10),
	fact_hote_codigo numeric(10),
	PRIMARY KEY (fact_tipo,fact_nro),
	CHECK(fact_forma_pago IN('efectivo', 'credito', 'debito'))
)
CREATE TABLE FAAE.Hotel (
    hote_codigo numeric(10) IDENTITY(1,1) PRIMARY KEY,
	hote_nombre nvarchar(16) default 'Hotel Pepito',
	hote_mail nvarchar(25) default 'hotelPrincipal@hotel.com',
	hote_telefono nvarchar(16) default '00000000',
	hote_dire_calle nvarchar(50) not null,
	hote_dire_nro numeric(5) not null,
	hote_cant_estrellas numeric(1) not null,
	hote_ciudad nvarchar(16) not null,
	hote_pais nvarchar(16) default 'argentina',
	hote_fecha_creacion smalldatetime,
	hote_recarga_estrellas decimal(4,2) not null
)
CREATE TABLE FAAE.Regimen_Hotel (
    reho_hote_codigo numeric(10),
	reho_regi_codigo nvarchar(30),
	PRIMARY KEY (reho_hote_codigo,reho_regi_codigo)
)
CREATE TABLE FAAE.Regimen (
	regi_nombre nvarchar(30) PRIMARY KEY,
	regi_precio_base decimal(5,2),
	regi_activo bit default 1
)

CREATE TABLE FAAE.Historial_Inhabilitado (
    hiin_codigo INT IDENTITY PRIMARY KEY,
	hiin_hote_codigo numeric(10),
	hiin_moti_codigo nvarchar(10),
	hiin_fecha_inicio smalldatetime,
	hiin_fecha_fin smalldatetime
)
CREATE TABLE FAAE.Hotel_Usuario (
    hous_usua_doc_tipo nvarchar(10),
	hous_usua_doc_nro numeric(10),
	hous_usua_mail nvarchar(50),
	hous_hote_codigo numeric(10),
	PRIMARY KEY (hous_usua_doc_tipo,hous_usua_doc_nro,hous_usua_mail,hous_hote_codigo)
)
CREATE TABLE FAAE.Usuario (
    usua_doc_tipo nvarchar(10) default 'pasaporte',
	usua_doc_nro numeric(10),
	usua_username nvarchar(10) not null,
	usua_password nvarchar(255) not null,
	usua_nombre nvarchar(16) not null,
	usua_apellido nvarchar(16) not null,
	usua_mail nvarchar(50) not null,
	usua_telefono numeric(10) not null,
	usua_dire_calle nvarchar(25) not null,
	usua_dire_nro numeric(5) not null,
	usua_fecha_nacimiento smalldatetime not null,
	usua_cant_log_in_fallidos numeric(1) default 0,
	usua_hote_codigo_ultimo_log_in numeric(10),
	usua_habilitado bit default 1,
	PRIMARY KEY (usua_doc_tipo,usua_doc_nro, usua_mail)
)

ALTER TABLE FAAE.Historial_Reserva ADD CONSTRAINT Historial_Reserva_Reserva FOREIGN KEY (hire_rese_codigo) REFERENCES FAAE.Reserva(rese_codigo)
ALTER TABLE FAAE.Historial_Reserva ADD CONSTRAINT Historial_Reserva_Usuario FOREIGN KEY (hire_usua_doc_tipo , hire_usua_doc_nro, hire_usua_mail) REFERENCES FAAE.Usuario(usua_doc_tipo, usua_doc_nro, usua_mail)
ALTER TABLE FAAE.Historial_Reserva ADD CONSTRAINT Historial_Reserva_Cliente FOREIGN KEY (hire_usua_doc_tipo , hire_usua_doc_nro, hire_usua_mail) REFERENCES FAAE.Cliente(clie_doc_tipo, clie_doc_nro, clie_mail)

ALTER TABLE FAAE.Rol_Usuario ADD CONSTRAINT Rol_Usuario_Usuario FOREIGN KEY (rous_clie_doc_tipo, rous_clie_doc_nro, rous_clie_mail) REFERENCES FAAE.Usuario(usua_doc_tipo, usua_doc_nro, usua_mail)
ALTER TABLE FAAE.Rol_Usuario ADD CONSTRAINT Rol_Usuario_Rol FOREIGN KEY (rous_rol_nombre) REFERENCES FAAE.Rol(rol_nombre)

ALTER TABLE FAAE.Estadia ADD CONSTRAINT Estadia_Reserva_Habitacion FOREIGN KEY (esta_rese_codigo, esta_habi_nro, esta_hote_codigo) REFERENCES FAAE.Reserva_Habitacion(reha_rese_codigo, reha_habi_nro, reha_hote_codigo)
ALTER TABLE FAAE.Estadia ADD CONSTRAINT Estadia_Cliente FOREIGN KEY (esta_clie_doc_tipo, esta_clie_doc_nro, esta_clie_mail) REFERENCES FAAE.Cliente(clie_doc_tipo, clie_doc_nro, clie_mail)
ALTER TABLE FAAE.Estadia ADD CONSTRAINT Estadia_UsuarioIn FOREIGN KEY (esta_usuaIn_doc_tipo, esta_usuaIn_doc_nro, esta_usuaIn_mail) REFERENCES FAAE.Usuario(usua_doc_tipo, usua_doc_nro, usua_mail)
ALTER TABLE FAAE.Estadia ADD CONSTRAINT Estadia_UsuarioOut FOREIGN KEY (esta_usuaOut_doc_tipo, esta_usuaOut_doc_nro, esta_usuaOut_mail) REFERENCES FAAE.Usuario(usua_doc_tipo, usua_doc_nro, usua_mail)	          
	      
ALTER TABLE FAAE.Reserva_Habitacion ADD CONSTRAINT Reserva_Habitacion_Reserva FOREIGN KEY (reha_rese_codigo) REFERENCES FAAE.Reserva(rese_codigo)
ALTER TABLE FAAE.Reserva_Habitacion ADD CONSTRAINT Reserva_Habitacion_Habitacion FOREIGN KEY (reha_habi_nro, reha_hote_codigo) REFERENCES FAAE.Habitacion(habi_nro, habi_hote_codigo)

ALTER TABLE FAAE.Reserva ADD CONSTRAINT Reserva_Regimen_Hotel FOREIGN KEY (rese_hote_codigo, rese_regi_codigo) REFERENCES FAAE.Regimen_Hotel(reho_hote_codigo, reho_regi_codigo)
ALTER TABLE FAAE.Reserva ADD CONSTRAINT Reserva_Cliente FOREIGN KEY (rese_clie_doc_tipo, rese_clie_doc_nro, rese_clie_mail) REFERENCES FAAE.Cliente(clie_doc_tipo, clie_doc_nro, clie_mail)

ALTER TABLE FAAE.Item_Factura ADD CONSTRAINT Item_Factura_Factura FOREIGN KEY (item_fact_tipo, item_fact_nro) REFERENCES FAAE.Factura(fact_tipo, fact_nro)
ALTER TABLE FAAE.Item_Factura ADD CONSTRAINT Item_Factura_Consumible FOREIGN KEY (item_cons_codigo) REFERENCES FAAE.Consumible(cons_codigo)

ALTER TABLE FAAE.Habitacion ADD CONSTRAINT Habitacion_Hotel FOREIGN KEY (habi_hote_codigo) REFERENCES FAAE.Hotel(hote_codigo)
ALTER TABLE FAAE.Habitacion ADD CONSTRAINT Habitacion_Tipo FOREIGN KEY (habi_tipo_codigo) REFERENCES FAAE.Tipo(tipo_codigo)

ALTER TABLE FAAE.Funcionalidad ADD CONSTRAINT Funcionalidad_Rol FOREIGN KEY (func_rol_nombre) REFERENCES FAAE.Rol(rol_nombre)

ALTER TABLE FAAE.Factura ADD CONSTRAINT Factura_Reserva_Habitacion FOREIGN KEY (fact_rese_codigo, fact_habi_nro, fact_hote_codigo) REFERENCES FAAE.Reserva_Habitacion(reha_rese_codigo, reha_habi_nro, reha_hote_codigo)

ALTER TABLE FAAE.Regimen_Hotel ADD CONSTRAINT Regimen_Hotel_Hotel FOREIGN KEY (reho_hote_codigo) REFERENCES FAAE.Hotel(hote_codigo)
ALTER TABLE FAAE.Regimen_Hotel ADD CONSTRAINT Regimen_Hotel_Regimen FOREIGN KEY (reho_regi_codigo) REFERENCES FAAE.Regimen(regi_nombre)

ALTER TABLE FAAE.Historial_Inhabilitado ADD CONSTRAINT Historial_Inhabilitado_Hotel FOREIGN KEY (hiin_hote_codigo) REFERENCES FAAE.Hotel(hote_codigo)

ALTER TABLE FAAE.Hotel_Usuario ADD CONSTRAINT Hotel_Usuario_Usuario FOREIGN KEY (hous_usua_doc_tipo, hous_usua_doc_nro, hous_usua_mail) REFERENCES FAAE.Usuario(usua_doc_tipo, usua_doc_nro, usua_mail)
ALTER TABLE FAAE.Hotel_Usuario ADD CONSTRAINT Hotel_Usuario_Hotel FOREIGN KEY (hous_hote_codigo) REFERENCES FAAE.Hotel(hote_codigo)
ALTER TABLE FAAE.Usuario ADD CONSTRAINT Usuario_Hotel FOREIGN KEY (usua_hote_codigo_ultimo_log_in) REFERENCES FAAE.Hotel(hote_codigo)
GO

/* CREACION DE OBJETOS QUE APOYAN LA MIGRACION */
-- mantener consistencia historial estado reserva, faltaria que se guarde la persona logeada
create TRIGGER FAAE.t_actualizar_Historial_Reserva
   ON FAAE.Reserva
   after update
AS
BEGIN
	insert FAAE.Historial_Reserva(hire_rese_codigo, hire_descripcion) 
	select distinct rese_codigo, rese_estado
	from inserted
END
GO

-- HABRIA QUE ASEGURARSE QUE FACTURA EL TOTAL DE LA RESERVA PERO EL ENUNCIADO ACTUAL NO CONTEMPLA LA EFECTIVIZACION PARCIAL, LO PROPONE A FUTURO
create TRIGGER FAAE.t_actualizar_Estado_Reserva_Dependiendo_de_Factura 
   ON FAAE.Factura
   after INSERT
AS
BEGIN
	update Reserva set rese_estado = 'Reserva con ingreso (efectivizada)' where rese_codigo in (select fact_rese_codigo 
																								from inserted)
END
GO

-- Inhabilitar Clientes con Mail ya Usado
create TRIGGER FAAE.t_mail_y_pasaporte_unico
   ON FAAE.Cliente
   after INSERT, update
AS 
BEGIN
	update Cliente set clie_habilitado = 0 where clie_doc_nro in (select a.clie_doc_nro
																  from Cliente a, Cliente b
																  where (a.clie_mail = b.clie_mail and
																		 a.clie_doc_nro <> b.clie_doc_nro))
	if exists (select c.clie_doc_nro
			   from Cliente c, inserted d
			   where c.clie_doc_nro = d.clie_doc_nro and c.clie_habilitado = 0)
	begin
		print('Se inhabilito usuarios por mail reutilizado')
	end
	update Cliente set clie_habilitado = 0 where clie_doc_nro in (select a.clie_doc_nro
																  from Cliente a, Cliente b
																  where	(a.clie_mail <> b.clie_mail and
																		 a.clie_doc_nro = b.clie_doc_nro))
	if exists (select c.clie_doc_nro
			   from Cliente c, inserted d
			   where c.clie_doc_nro = d.clie_doc_nro and c.clie_habilitado = 0)
	begin
		print('Se inhabilito usuarios por pasaporte reutilizado')
	end
END
GO

CREATE FUNCTION FAAE.obtenerHotelCodigo (@Hotel_ciudad nvarchar(16), @Hotel_calle nvarchar(50), @Hotel_nro_calle numeric(5))
RETURNS numeric(10)
AS
BEGIN
	return (select hote_codigo 
			from FAAE.Hotel
			where (hote_ciudad = @Hotel_ciudad and
				   hote_dire_calle = @Hotel_calle and
	    		   hote_dire_nro = @Hotel_nro_calle))
END
go

CREATE FUNCTION FAAE.cantPersonas (@Habitacion_Tipo_Descripcion nvarchar(16))
RETURNS numeric(1)
AS
BEGIN
	DECLARE @Cant_Personas numeric(1)
	SET @Cant_Personas = CASE
							WHEN @Habitacion_Tipo_Descripcion = 'Base Simple' THEN 1
							WHEN @Habitacion_Tipo_Descripcion = 'Base Doble' THEN 2
							WHEN @Habitacion_Tipo_Descripcion = 'Base Triple' THEN 3
							WHEN @Habitacion_Tipo_Descripcion = 'Base Cuadruple' THEN 4
							WHEN @Habitacion_Tipo_Descripcion = 'King' THEN 5
							ELSE 2
						END
	RETURN @Cant_Personas
END
GO

CREATE TRIGGER FAAE.encriptar_contrasena_update
ON FAAE.Usuario
AFTER UPDATE, INSERT
AS
BEGIN
	IF ((SELECT usua_password FROM inserted) != (SELECT usua_password FROM deleted)) OR NOT EXISTS (SELECT 1 FROM deleted) 
	BEGIN
		DECLARE @usua_doc_tipo nvarchar(10), @usua_doc_nro numeric(10), @usua_mail nvarchar(50)
		SELECT @usua_doc_tipo = usua_doc_tipo, @usua_doc_nro = usua_doc_nro, @usua_mail = usua_mail FROM inserted

		UPDATE FAAE.Usuario
			SET usua_password = HASHBYTES('SHA2_256', CONVERT(VARCHAR(255), usua_password))
			WHERE usua_doc_tipo = @usua_doc_tipo AND usua_doc_nro = @usua_doc_nro AND usua_mail = @usua_mail
	END
END
GO

/** Migración **/
	insert FAAE.Usuario(usua_doc_nro,usua_username,usua_password,usua_nombre,usua_apellido,usua_mail,usua_telefono,usua_dire_calle, usua_dire_nro, usua_fecha_nacimiento) 
		values	(0000000000,'admin','w23e','admin','admin','admin@admin.com',00000000,'admin',0000,getdate())

	insert FAAE.Rol (rol_nombre) values ('admin'), ('cliente'), ('recepcion')

	insert FAAE.Rol_Usuario (rous_clie_doc_nro,rous_clie_mail, rous_rol_nombre) values	(0000000000,'admin@admin.com' , 'admin'), (0000000000,'admin@admin.com','recepcion')

	insert FAAE.Funcionalidad (func_rol_nombre,func_funcion) 
		values ('admin', 'ABM rol'),('admin','ABM usuario'),('recepcion','ABM cliente'),('admin','ABM hotel'),('admin','ABM habitacion'),('recepcion','ABM reserva'),('cliente','ABM reserva')

	insert FAAE.Hotel(hote_dire_calle,hote_dire_nro,hote_cant_estrellas,hote_recarga_estrellas,hote_ciudad, hote_fecha_creacion) 
		select distinct Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella, Hotel_Ciudad,getdate()
		from gd_esquema.Maestra
	
	-- Se asignan todos los hoteles al usuario admin
	insert into FAAE.Hotel_Usuario (hous_hote_codigo, hous_usua_doc_tipo, hous_usua_doc_nro, hous_usua_mail)
		select hote_codigo, usua_doc_tipo, usua_doc_nro, usua_mail
			from FAAE.Usuario, FAAE.Hotel
			where usua_username = 'admin'

	insert FAAE.Tipo(tipo_codigo,tipo_descripcion,tipo_cant_personas,tipo_porcentual) 
		select distinct Habitacion_Tipo_Codigo,Habitacion_Tipo_Descripcion, FAAE.cantPersonas(Habitacion_Tipo_Descripcion) cant_personas,Habitacion_Tipo_Porcentual
		from gd_esquema.Maestra

	insert FAAE.Habitacion(habi_nro,habi_piso, habi_vista_exterior, habi_tipo_codigo, habi_hote_codigo) 
		select distinct Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, Habitacion_Tipo_Codigo, FAAE.obtenerHotelCodigo(Hotel_Ciudad,Hotel_Calle,Hotel_Nro_Calle)
		from gd_esquema.Maestra

	insert FAAE.Regimen(regi_nombre,regi_precio_base) 
		select distinct Regimen_Descripcion,Regimen_Precio
		from gd_esquema.Maestra

	insert FAAE.Regimen_Hotel(reho_hote_codigo,reho_regi_codigo)
		select distinct FAAE.obtenerHotelCodigo(Hotel_Ciudad,Hotel_Calle,Hotel_Nro_Calle), Regimen_Descripcion
		from gd_esquema.Maestra

	insert FAAE.Consumible(cons_codigo, cons_descipcion, cons_precio) 
		select distinct Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
		from gd_esquema.Maestra
		where Consumible_Codigo is not null

	insert FAAE.Cliente(clie_nombre, clie_apellido, clie_doc_nro, clie_mail, clie_dire_calle, clie_dire_nro, clie_nacionalidad, clie_piso, clie_depto, clie_fecha_nacimiento) 
		select distinct Cliente_Nombre,Cliente_Apellido,Cliente_Pasaporte_Nro,Cliente_Mail,Cliente_Dom_Calle, Cliente_Nro_Calle,Cliente_Nacionalidad,Cliente_Piso,Cliente_Depto, CAST(Cliente_Fecha_Nac AS smalldatetime)
		from gd_esquema.Maestra

	SET IDENTITY_INSERT FAAE.Reserva ON
	insert FAAE.Reserva(rese_codigo,rese_fecha_desde,rese_fecha_hasta,rese_hote_codigo,rese_regi_codigo,rese_clie_doc_nro, rese_fecha_realizacion, rese_clie_mail) 
		select distinct Reserva_Codigo,CAST(Reserva_Fecha_Inicio AS smalldatetime), cast(dateadd(day,Reserva_Cant_Noches,CAST(Reserva_Fecha_Inicio AS smalldatetime))AS smalldatetime), FAAE.obtenerHotelCodigo(Hotel_Ciudad,Hotel_Calle,Hotel_Nro_Calle), Regimen_Descripcion, Cliente_Pasaporte_Nro, getdate(), Cliente_Mail
		from gd_esquema.Maestra

	update FAAE.Reserva set rese_estado = 'Reserva cancelada por No-Show' where rese_codigo in (select distinct Reserva_Codigo
																								from gd_esquema.Maestra
																								group by Reserva_Codigo
																								having count(Reserva_Codigo) = 1)

	insert FAAE.Reserva_Habitacion(reha_rese_codigo, reha_habi_nro, reha_hote_codigo, reha_precio) -- monto y cantidad parecen invertidos en tabla maestra
		select distinct Reserva_Codigo, Habitacion_Numero, FAAE.obtenerHotelCodigo(Hotel_Ciudad,Hotel_Calle,Hotel_Nro_Calle), Item_Factura_Cantidad
		from gd_esquema.Maestra
		where (Consumible_Codigo is null and
			   Item_Factura_Cantidad is not null)

	insert FAAE.Factura(fact_nro, fact_fecha, fact_total, fact_rese_codigo, fact_habi_nro, fact_hote_codigo)
		select distinct Factura_Nro, CAST(Factura_Fecha AS smalldatetime), Factura_Total, Reserva_Codigo, Habitacion_Numero, FAAE.obtenerHotelCodigo(Hotel_Ciudad,Hotel_Calle,Hotel_Nro_Calle)
		from gd_esquema.Maestra
		where Factura_Nro is not null

	insert FAAE.Item_Factura(item_cantidad, item_precio, item_cons_codigo, item_fact_nro) -- monto y cantidad parecen invertidos en tabla maestra
		select sum(Item_Factura_Monto), Item_Factura_Cantidad, Consumible_Codigo, Factura_Nro
		from gd_esquema.Maestra 
		where Consumible_Codigo is not null
		group by Item_Factura_Cantidad,Consumible_Codigo,Factura_Nro
	
	insert FAAE.Estadia(esta_clie_doc_nro, esta_clie_mail, esta_fecha_salida, esta_habi_nro, esta_hote_codigo, esta_rese_codigo)
		select distinct Cliente_Pasaporte_Nro, Cliente_Mail, cast(dateadd(day,Estadia_Cant_Noches,CAST(Estadia_Fecha_Inicio AS smalldatetime))AS smalldatetime), Habitacion_Numero, FAAE.obtenerHotelCodigo(Hotel_Ciudad,Hotel_Calle,Hotel_Nro_Calle), Reserva_Codigo
		from gd_esquema.Maestra
		where Estadia_Fecha_Inicio is not null

GO

-- LOGIN
CREATE VIEW FAAE.RolXUsuario 
AS
	SELECT usua_username username, rous_rol_nombre rol_nombre
	FROM faae.Usuario u join faae.Rol_Usuario ru 
		 ON (u.usua_doc_tipo = ru.rous_clie_doc_tipo AND u.usua_doc_nro = ru.rous_clie_doc_nro)
GO

CREATE FUNCTION FAAE.Codigo_Hoteles_Usuario (@username NVARCHAR(10))
RETURNS TABLE
AS
RETURN (SELECT hote_codigo, hote_nombre
			FROM FAAE.Hotel_Usuario JOIN FAAE.Usuario ON (hous_usua_doc_tipo = usua_doc_tipo AND hous_usua_doc_nro = usua_doc_nro AND hous_usua_mail = usua_mail)
									JOIN FAAE.Hotel   ON (hous_hote_codigo = hote_codigo)
			WHERE usua_username = @username)
GO

CREATE PROCEDURE FAAE.login_fallido
@username VARCHAR(10)
AS
BEGIN
	
	DECLARE @nueva_cant_login_fallidos NUMERIC(1)
	SET @nueva_cant_login_fallidos = (SELECT usua_cant_log_in_fallidos 
										FROM FAAE.Usuario 
										WHERE usua_username = @username) + 1

	IF @nueva_cant_login_fallidos >= 3
		BEGIN
			UPDATE FAAE.Usuario 
				SET usua_cant_log_in_fallidos = @nueva_cant_login_fallidos, usua_habilitado = 0
				WHERE usua_username = @username
		END
	ELSE
		BEGIN
			UPDATE FAAE.Usuario 
				SET usua_cant_log_in_fallidos = @nueva_cant_login_fallidos
				WHERE usua_username = @username
		END

END
GO

CREATE PROCEDURE FAAE.limpiar_login_fallidos
@username VARCHAR(10)
AS
BEGIN
	UPDATE FAAE.Usuario 
		SET usua_cant_log_in_fallidos = 0
		WHERE usua_username = @username
END
GO

-- ABM Hotel
CREATE PROCEDURE FAAE.guardar_hotel
@hote_codigo numeric(10), @hote_nombre nvarchar(16), @hote_mail nvarchar(25), @hote_telefono nvarchar(16), @hote_dire_calle nvarchar(25), @hote_dire_nro numeric(5), 
@hote_cant_estrellas numeric(1), @hote_ciudad nvarchar(16), @hote_pais nvarchar(16), @hote_fecha_creacion smalldatetime, @hote_recarga_estrellas decimal(4,2)
AS
BEGIN
	IF( EXISTS(SELECT hote_codigo FROM FAAE.Hotel WHERE hote_codigo = @hote_codigo) )
		BEGIN
			UPDATE FAAE.Hotel 
				SET hote_nombre = @hote_nombre, 
					hote_mail = @hote_mail, 
					hote_telefono = @hote_telefono, 
					hote_dire_calle = @hote_dire_calle, 
					hote_dire_nro = @hote_dire_nro, 
					hote_cant_estrellas = @hote_cant_estrellas, 
					hote_ciudad = @hote_ciudad, 
					hote_pais = @hote_pais, 
					hote_fecha_creacion = @hote_fecha_creacion, 
					hote_recarga_estrellas = @hote_recarga_estrellas
				WHERE hote_codigo = @hote_codigo
		END
	ELSE
		BEGIN
			INSERT INTO FAAE.Hotel
			VALUES(@hote_nombre, @hote_mail, @hote_telefono, @hote_dire_calle, @hote_dire_nro, @hote_cant_estrellas, @hote_ciudad, @hote_pais, @hote_fecha_creacion, @hote_recarga_estrellas)
		END
END
GO

CREATE PROCEDURE FAAE.inhabilitar_hotel
@hote_codigo numeric(10),@moti_descripcion nvarchar(50), @hiin_fecha_inicio datetime, @hiin_fecha_fin datetime
AS
BEGIN 
	DECLARE @ErrorMessage NVARCHAR(255)
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM FAAE.Reserva 
							 WHERE rese_fecha_desde BETWEEN @hiin_fecha_inicio AND @hiin_fecha_fin 
							 		AND rese_fecha_hasta BETWEEN @hiin_fecha_inicio AND @hiin_fecha_fin)
			BEGIN
				INSERT INTO FAAE.Historial_Inhabilitado (hiin_hote_codigo,hiin_moti_codigo,hiin_fecha_inicio,hiin_fecha_fin)
										VALUES  (@hote_codigo,@moti_descripcion,@hiin_fecha_inicio,@hiin_fecha_fin)
			END
		    ELSE
			BEGIN
				RAISERROR('Existe una reserva en ese periodo.', 16, 1)
				RETURN
			END			
	END TRY
	BEGIN CATCH
		SELECT @ErrorMessage = ERROR_MESSAGE()
		RAISERROR (@ErrorMessage, 17, 1)
	END CATCH
END
GO

GO
CREATE PROCEDURE FAAE.asignar_regimen_hotel
@hote_codigo NUMERIC(10), @regi_nombre NVARCHAR(30)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM FAAE.Regimen_Hotel 
						WHERE reho_hote_codigo = @hote_codigo AND reho_regi_codigo = @regi_nombre)
		BEGIN
			INSERT INTO FAAE.Regimen_Hotel (reho_hote_codigo, reho_regi_codigo)
				VALUES (@hote_codigo, @regi_nombre)
		END
END

GO
CREATE PROCEDURE FAAE.eliminar_regimenes_hotel
@hote_codigo NUMERIC(10)
AS
BEGIN
	BEGIN TRY
		DELETE FROM FAAE.Regimen_Hotel
			WHERE reho_hote_codigo = @hote_codigo
	END TRY
	BEGIN CATCH
		IF ERROR_NUMBER() != 547
		BEGIN
			DECLARE @ErrorMessage NVARCHAR(255)
			SELECT @ErrorMessage = ERROR_MESSAGE()
			RAISERROR (@ErrorMessage, 17, 1)
		END
	END CATCH
END

GO
CREATE PROCEDURE FAAE.inhabilitar_usuario
@username nvarchar(10)
AS
BEGIN
	UPDATE FAAE.Usuario 
		SET usua_habilitado = 0
		WHERE usua_username = @username
END
GO

CREATE PROCEDURE FAAE.inhabilitar_rol
@nombre nvarchar(16)
AS
BEGIN
	UPDATE FAAE.Rol 
		SET rol_habilitado = 0
		WHERE rol_nombre = @nombre
END
GO

CREATE PROCEDURE FAAE.guardar_rol
@rol_nombre nvarchar(16), @rol_habilitado bit
AS
BEGIN
	IF( NOT EXISTS(SELECT rol_nombre FROM FAAE.Rol WHERE rol_nombre = @rol_nombre) )
		BEGIN
			INSERT INTO FAAE.Rol
				VALUES(@rol_nombre, @rol_habilitado)
		END
	ELSE
		BEGIN
			UPDATE FAAE.Rol
				SET rol_habilitado = @rol_habilitado
				WHERE rol_nombre = @rol_nombre
		END
END
GO

CREATE PROCEDURE FAAE.asignar_funcionalidad_rol
@rol_nombre nvarchar(16), @funcionalidad nvarchar(16)
AS
BEGIN
	IF( NOT EXISTS(SELECT func_rol_nombre, func_funcion  FROM FAAE.Funcionalidad WHERE func_rol_nombre = @rol_nombre AND func_funcion = @funcionalidad) )
		BEGIN
			INSERT INTO FAAE.Funcionalidad
				VALUES(@rol_nombre, @funcionalidad)
		END
END
GO

CREATE PROCEDURE FAAE.eliminar_funcionalidades_rol
@rol_nombre nvarchar(16)
AS
BEGIN
	DELETE FROM FAAE.Funcionalidad
		WHERE func_rol_nombre = @rol_nombre
END
GO

--ABM Habitaciones
--alta
CREATE PROCEDURE FAAE.guardar_habitacion
@habi_nro numeric(10), @habi_hote_codigo numeric(10), @habi_piso numeric(2,0), 
@habi_vista_exterior char(1), @habi_tipo_codigo numeric(10,0), @habi_habilitada bit, @habi_descripcion varchar(100)
AS
BEGIN
	IF( NOT EXISTS(SELECT habi_nro FROM FAAE.Habitacion WHERE habi_nro = @habi_nro AND habi_hote_codigo=@habi_hote_codigo) )
		BEGIN
			INSERT INTO FAAE.Habitacion
			VALUES(@habi_nro, @habi_hote_codigo, @habi_piso, @habi_vista_exterior, @habi_tipo_codigo, @habi_habilitada, @habi_descripcion)
		END
	--ELSE UPDATE?
	
END
GO

--Modificación
CREATE PROCEDURE FAAE.modificar_habitacion
@habi_nro numeric(10), @habi_hote_codigo numeric(10), @habi_piso numeric(2,0), 
@habi_vista_exterior char(1), @habi_habilitada bit, @habi_descripcion varchar(100)
AS
BEGIN
	--IF( EXISTS(SELECT habi_nro FROM FAAE.Habitacion WHERE habi_nro = @habi_nro) ) Ya se controlado en el visual studio
	--	BEGIN
			UPDATE FAAE.Habitacion 
				SET habi_piso = @habi_piso,
					habi_vista_exterior = @habi_vista_exterior,
					habi_habilitada = @habi_habilitada,
					habi_descripcion = @habi_descripcion
				WHERE habi_nro = @habi_nro AND habi_hote_codigo = @habi_hote_codigo
	--	END
	--ELSE INSERT?
END
GO

--Baja
--CREATE PROCEDURE FAAE.baja_habitacion
--@habi_nro numeric(10), @habi_hote_codigo numeric(10)
--AS
--BEGIN
--	DELETE FROM FAAE.Habitacion
--	WHERE habi_nro = @habi_nro
--	AND habi_hote_codigo = @habi_hote_codigo
--END
--GO

--Inhabilitar
CREATE PROCEDURE FAAE.inhabilitar_habitacion
@habi_nro numeric(10), @habi_hote_codigo numeric(10)
AS
BEGIN
		UPDATE FAAE.Habitacion 
		SET habi_habilitada = 0
		WHERE habi_nro = @habi_nro AND habi_hote_codigo = @habi_hote_codigo
END
GO


-- ABM USUARIO

GO
CREATE PROCEDURE FAAE.guardar_usuario
@usua_doc_tipo nvarchar(10), @usua_doc_nro numeric(10), @usua_username nvarchar(10), @usua_password nvarchar(10), @usua_nombre nvarchar(16), @usua_apellido nvarchar(16),
@usua_mail nvarchar(50), @usua_telefono nvarchar(10), @usua_dire_calle nvarchar(25), @usua_dire_nro numeric(5), @usua_fecha_nacimiento smalldatetime, @usua_cant_log_in_fallidos numeric(1),
@usua_hote_codigo_ultimo_log_in numeric(10), @usua_habilitado bit
AS
BEGIN
	IF @usua_hote_codigo_ultimo_log_in = 0 
		SET @usua_hote_codigo_ultimo_log_in = NULL

	IF( EXISTS(SELECT usua_username FROM FAAE.Usuario WHERE usua_username = @usua_username) )
		BEGIN
			UPDATE FAAE.Usuario 
				SET usua_doc_tipo = @usua_doc_tipo,
					usua_doc_nro = @usua_doc_nro,
					usua_username = @usua_username,
					--usua_password = @usua_password,
					usua_nombre = @usua_nombre, 
					usua_mail = @usua_mail, 
					usua_telefono = @usua_telefono, 
					usua_dire_calle = @usua_dire_calle, 
					usua_dire_nro = @usua_dire_nro, 
					usua_fecha_nacimiento = @usua_fecha_nacimiento, 
					usua_cant_log_in_fallidos = @usua_cant_log_in_fallidos, 
					usua_hote_codigo_ultimo_log_in = @usua_hote_codigo_ultimo_log_in, 
					usua_habilitado = @usua_habilitado 
				WHERE usua_username = @usua_username

			IF @usua_password IS NOT NULL AND @usua_password != ''
				UPDATE FAAE.Usuario 
					SET usua_password = @usua_password
					WHERE usua_username = @usua_username
		END
	ELSE
		BEGIN
			INSERT INTO FAAE.Usuario
			VALUES(@usua_doc_tipo, @usua_doc_nro, @usua_username, @usua_password, @usua_nombre, @usua_apellido, @usua_mail, @usua_telefono, @usua_dire_calle, @usua_dire_nro, @usua_fecha_nacimiento, @usua_cant_log_in_fallidos, @usua_hote_codigo_ultimo_log_in, @usua_habilitado)
		END
END

GO
CREATE PROCEDURE FAAE.asignar_rol_usuario
@usua_username NVARCHAR(10), @rol_nombre NVARCHAR(16)
AS
BEGIN
	IF( NOT EXISTS(SELECT rous_clie_doc_tipo, rous_clie_doc_nro, rous_clie_mail, rous_rol_nombre 
						FROM FAAE.Rol_Usuario ru JOIN FAAE.Usuario u ON (ru.rous_clie_doc_tipo = u.usua_doc_tipo AND ru.rous_clie_doc_nro = u.usua_doc_nro AND ru.rous_clie_mail = u.usua_mail)
						WHERE usua_username = @usua_username AND rous_rol_nombre = @rol_nombre) )
		BEGIN
			INSERT INTO FAAE.Rol_Usuario (rous_clie_doc_tipo, rous_clie_doc_nro, rous_clie_mail, rous_rol_nombre)
				SELECT usua_doc_tipo, usua_doc_nro, usua_mail, @rol_nombre
					FROM FAAE.Usuario
					WHERE usua_username = @usua_username
		END
END

GO
CREATE PROCEDURE FAAE.eliminar_roles_usuario
@usua_username NVARCHAR(10)
AS
BEGIN
	DECLARE @doc_tipo NVARCHAR(10), @doc_nro NUMERIC(10)
	
	SELECT @doc_tipo = usua_doc_tipo, @doc_nro = usua_doc_nro
		FROM FAAE.Usuario
		WHERE usua_username = @usua_username

	DELETE FROM FAAE.Rol_Usuario
		WHERE rous_clie_doc_tipo = @doc_tipo AND rous_clie_doc_nro = @doc_nro
END


GO
CREATE PROC FAAE.asignar_hotel_usuario
@usua_username NVARCHAR(10), @hous_hote_codigo NUMERIC (10)
AS
BEGIN
	INSERT INTO FAAE.Hotel_Usuario (hous_hote_codigo, hous_usua_doc_tipo, hous_usua_doc_nro, hous_usua_mail)
		SELECT @hous_hote_codigo, usua_doc_tipo, usua_doc_nro, usua_mail
			FROM FAAE.Usuario
			WHERE usua_username = @usua_username
END

GO
CREATE PROCEDURE FAAE.eliminar_hoteles_usuario
@usua_username NVARCHAR(10)
AS
BEGIN
	DECLARE @doc_tipo NVARCHAR(10), @doc_nro NUMERIC(10), @mail NVARCHAR(50)
	
	SELECT @doc_tipo = usua_doc_tipo, @doc_nro = usua_doc_nro, @mail = usua_mail
		FROM FAAE.Usuario
		WHERE usua_username = @usua_username

	DELETE FROM FAAE.Hotel_Usuario
		WHERE hous_usua_doc_tipo = @doc_tipo AND hous_usua_doc_nro = @doc_nro AND hous_usua_mail = @mail
END


--Modificar cliente

GO
CREATE PROCEDURE FAAE.modificar_cliente
@tipoDoc nvarchar(10), @nroDoc numeric(10,0), @nombre nvarchar(25), @apellido nvarchar(25),@mail nvarchar(50),
@telefono nvarchar(16), @calle nvarchar(50),@numero numeric(10,0),@localidad nvarchar(255),@pais nvarchar(16),
@nacionalidad nvarchar(16), @habilitado bit, @fechaNac datetime,@piso numeric(8,0),@depto nvarchar(5)

AS
BEGIN
		UPDATE FAAE.Cliente 
			SET clie_doc_tipo = @tipoDoc,
					clie_doc_nro = @nroDoc,
					clie_nombre = @nombre,
					clie_apellido = @apellido,
					clie_mail = @mail,
					clie_telefono = @telefono,
					clie_dire_calle = @calle,
					clie_dire_nro = @numero,
					clie_dire_localidad = @localidad,
					clie_dire_pais = @pais,
					clie_nacionalidad = @nacionalidad,
					clie_habilitado = @habilitado,
					clie_fecha_nacimiento = @fechaNac,
					clie_piso = @piso,
					clie_depto = @depto
			WHERE clie_doc_tipo = @tipoDoc AND clie_doc_nro = @nroDoc

END
GO



-- FACTURAR ESTADIA

GO
CREATE FUNCTION FAAE.NuevaFactura (@rese_codigo NUMERIC(10))
RETURNS TABLE
AS
RETURN
SELECT 'A' fact_tipo, (SELECT MAX(fact_nro)+1 FROM FAAE.Factura) fact_nro, GETDATE() fact_fecha, 'efectivo' fact_forma_pago, rese_hote_codigo hote_codigo, hote_nombre, rese_regi_codigo regi_codigo, clie_apellido+', '+clie_nombre nombreApellido
	FROM FAAE.Reserva r JOIN FAAE.Reserva_Habitacion rh ON (r.rese_codigo = rh.reha_rese_codigo)
						JOIN FAAE.Hotel h ON (r.rese_hote_codigo = h.hote_codigo)
						JOIN FAAE.Cliente c ON (r.rese_clie_doc_tipo = c.clie_doc_tipo AND r.rese_clie_doc_nro = c.clie_doc_nro AND r.rese_clie_mail = c.clie_mail)
	WHERE rese_codigo = @rese_codigo


GO
CREATE FUNCTION FAAE.ConsumiblesReserva (@rese_codigo NUMERIC(10))
RETURNS TABLE
AS
RETURN
SELECT 'A' fact_tipo, (SELECT MAX(fact_nro)+1 FROM FAAE.Factura) fact_nro, hote_nombre
	FROM FAAE.Reserva r JOIN FAAE.Reserva_Habitacion rh ON (r.rese_codigo = rh.reha_rese_codigo)
						JOIN FAAE.Hotel h ON (r.rese_hote_codigo = h.hote_codigo)
	WHERE rese_codigo = @rese_codigo


GO
CREATE FUNCTION FAAE.calcularTotalEstadia (@rese_codigo NUMERIC(10))
RETURNS DECIMAL(10,2)
AS
BEGIN
	RETURN (SELECT COALESCE( SUM(regi_precio_base * tipo_cant_personas + tipo_porcentual * DATEDIFF(DAY, rese_fecha_desde, rese_fecha_hasta) + hote_recarga_estrellas) , 0 ) totalEstadia
				FROM FAAE.Reserva res JOIN FAAE.Regimen reg ON (res.rese_regi_codigo = reg.regi_nombre)
									  JOIN FAAE.Reserva_Habitacion rh ON (res.rese_codigo = rh.reha_rese_codigo)
									  JOIN FAAE.Habitacion habi ON (rh.reha_hote_codigo = habi.habi_hote_codigo AND rh.reha_habi_nro = habi.habi_nro)
									  JOIN FAAE.Tipo t ON (habi.habi_tipo_codigo = t.tipo_codigo)
									  JOIN FAAE.Hotel hote ON (res.rese_hote_codigo = hote.hote_codigo)
				WHERE rese_codigo = @rese_codigo)
END

GO
CREATE PROCEDURE FAAE.guardar_factura
@fact_tipo NVARCHAR(10), @fact_nro NUMERIC(10), @fact_fecha DATE, @fact_total DECIMAL(10,2), @fact_rese_codigo NUMERIC(10)
AS
BEGIN
	IF( EXISTS(SELECT rese_codigo FROM FAAE.Reserva WHERE rese_codigo = @fact_rese_codigo) )
		BEGIN
			INSERT INTO FAAE.Factura (fact_tipo, fact_nro, fact_fecha, fact_total, fact_rese_codigo)
			VALUES(@fact_tipo, @fact_nro, @fact_fecha, @fact_total, @fact_rese_codigo)
		END
END

GO
CREATE PROCEDURE FAAE.guardar_items_factura
@fact_tipo NVARCHAR(10), @fact_nro NUMERIC(10), @item_cons_codigo NUMERIC(10), @cantidad NUMERIC(10), @precio DECIMAL(5,2)
AS
BEGIN
	IF( EXISTS(SELECT fact_nro, fact_nro FROM FAAE.Factura WHERE fact_tipo = @fact_tipo AND fact_nro = @fact_nro) )
		BEGIN
			INSERT INTO FAAE.Item_Factura (item_fact_tipo, item_fact_nro, item_cons_codigo, item_cantidad, item_precio)
			VALUES(@fact_tipo, @fact_nro, @item_cons_codigo, @cantidad, @precio)
		END
END



-- LISTADO ESTADISTICO


-- FAAE.HotelesConMasReservasCanceladas

GO
CREATE FUNCTION FAAE.HotelesConMasReservasCanceladas (@fechaDesde DATE, @fechaHasta DATE)
RETURNS TABLE
AS
	RETURN (SELECT hote_nombre, hote_cant_estrellas, hote_dire_calle, hote_dire_nro, hote_ciudad, hote_pais, COUNT(*) reservasCanceladas, COUNT(*) criterioOrdenar
		FROM FAAE.Reserva r JOIN FAAE.Hotel h ON (r.rese_hote_codigo = h.hote_codigo)
		WHERE rese_estado LIKE '%cancelada%' AND rese_fecha_realizacion BETWEEN @fechaDesde AND @fechaHasta
		GROUP BY hote_nombre, hote_cant_estrellas, hote_dire_calle, hote_dire_nro, hote_ciudad, hote_pais)


-- FAAE.HotelesConMasConsumiblesFacturados

GO
CREATE FUNCTION FAAE.HotelesConMasConsumiblesFacturados (@fechaDesde DATE, @fechaHasta DATE)
RETURNS TABLE
AS
RETURN 
SELECT hote_nombre, hote_cant_estrellas, hote_dire_calle, hote_dire_nro, hote_ciudad, hote_pais, cons_descipcion, SUM(ifact.item_cantidad) cantConsumiblesFacturados, SUM(ifact.item_cantidad) criterioOrdenar -- cant_consumibles_facturados
	FROM FAAE.Item_Factura ifact JOIN FAAE.Factura    f ON (ifact.item_fact_tipo = f.fact_tipo AND ifact.item_fact_nro = f.fact_nro) 
								 JOIN FAAE.Hotel      h ON (f.fact_hote_codigo = h.hote_codigo)
								 JOIN FAAE.Consumible c ON (ifact.item_cons_codigo = c.cons_codigo)
	WHERE f.fact_fecha BETWEEN @fechaDesde AND @fechaHasta
	GROUP BY hote_nombre, hote_cant_estrellas, hote_dire_calle, hote_dire_nro, hote_ciudad, hote_pais, cons_descipcion


-- FAAE.HotelesConMasDiasFueraDeServicio

GO
CREATE FUNCTION FAAE.DiasFueraDeServicio (@hote_codigo INT, @fechaDesde DATE, @fechaHasta DATE)
RETURNS TINYINT
AS
BEGIN
	DECLARE @diasFueraDeServicio TINYINT
	DECLARE @hiin_fecha_inicio DATE, @hiin_fecha_fin DATE

	SELECT @hiin_fecha_inicio = hiin_fecha_inicio, @hiin_fecha_fin = hiin_fecha_fin 
		FROM FAAE.Historial_Inhabilitado 
		WHERE hiin_hote_codigo = @hote_codigo

	SET @diasFueraDeServicio = 
		CASE
			WHEN @hiin_fecha_inicio BETWEEN @fechaDesde AND @fechaHasta AND @hiin_fecha_fin BETWEEN @fechaDesde AND @fechaHasta 
				THEN DATEDIFF(DAY, @hiin_fecha_inicio, @hiin_fecha_fin)
			WHEN @hiin_fecha_inicio <= @fechaDesde AND @hiin_fecha_fin BETWEEN @fechaDesde AND @fechaHasta
				THEN DATEDIFF(DAY, @fechaDesde, @hiin_fecha_fin)
			WHEN @hiin_fecha_inicio BETWEEN @fechaDesde AND @fechaHasta AND @hiin_fecha_fin >= @fechaHasta
				THEN DATEDIFF(DAY, @hiin_fecha_inicio, @fechaHasta)
			WHEN @hiin_fecha_inicio <= @fechaDesde AND @hiin_fecha_fin >= @fechaHasta
				THEN DATEDIFF(DAY, @fechaDesde, @fechaHasta)
			ELSE 0
		END

	RETURN @diasFueraDeServicio
END

GO
CREATE FUNCTION FAAE.HotelesConMasDiasFueraDeServicio (@fechaDesde DATE, @fechaHasta DATE)
RETURNS TABLE
AS
RETURN SELECT hote_nombre, hote_cant_estrellas, hote_dire_calle, hote_dire_nro, hote_ciudad, hote_pais, FAAE.DiasFueraDeServicio(hote_codigo, @fechaDesde, @fechaHasta) diasFueraDeServicio, FAAE.DiasFueraDeServicio(hote_codigo, @fechaDesde, @fechaHasta) criterioOrdenar 
		   FROM FAAE.Hotel


-- FAAE.HabitacionesConMasDiasYVecesOcupada

GO
CREATE FUNCTION FAAE.HabitacionesConMasDiasYVecesOcupada (@fechaDesde DATE, @fechaHasta DATE)
RETURNS TABLE
AS
RETURN 
(SELECT hote_nombre, habi_nro, tipo_descripcion, COUNT(*) vecesOcupada, SUM(DATEDIFF(DAY, rese_fecha_desde, rese_fecha_hasta)) cantDiasOcupada, COUNT(*) + SUM(DATEDIFF(DAY, rese_fecha_desde, rese_fecha_hasta)) criterioOrdenar
	FROM FAAE.Habitacion h JOIN FAAE.Reserva_Habitacion rh ON (h.habi_nro = rh.reha_habi_nro)
						   JOIN FAAE.Reserva r ON (rh.reha_rese_codigo = r.rese_codigo)
						   JOIN FAAE.Tipo t ON (h.habi_tipo_codigo = t.tipo_codigo)
						   JOIN FAAE.Hotel hote ON (h.habi_hote_codigo = hote.hote_codigo)
	WHERE rese_fecha_desde BETWEEN @fechaDesde AND @fechaHasta 
	      AND rese_fecha_hasta BETWEEN @fechaDesde AND @fechaHasta 
	GROUP BY hote_nombre, habi_nro, tipo_descripcion)


-- FAAE.ClientesConMasPuntos

GO
CREATE FUNCTION FAAE.ClientesConMasPuntos (@fechaDesde DATE, @fechaHasta DATE) -- FORMATO FECHA: YYYY-MM-DD
RETURNS TABLE
AS
RETURN -- Nombre, Apellido, PuntosTotalEstadia + PuntosTotalConsumibles
	(SELECT clie_nombre, clie_apellido, 
			COALESCE( SUM(regi_precio_base * tipo_cant_personas + tipo_porcentual * DATEDIFF(DAY, rese_fecha_desde, rese_fecha_hasta) + hote_recarga_estrellas) , 0 ) / 20 +
			SUM(item_cantidad*item_precio) / 10 clie_puntos,
			COALESCE( SUM(regi_precio_base * tipo_cant_personas + tipo_porcentual * DATEDIFF(DAY, rese_fecha_desde, rese_fecha_hasta) + hote_recarga_estrellas) , 0 ) / 20 +
			SUM(item_cantidad*item_precio) / 10 criterioOrdenar
		FROM FAAE.Item_Factura ifact JOIN FAAE.Factura f ON (ifact.item_fact_tipo = f.fact_tipo AND ifact.item_fact_nro = f.fact_nro)
									 JOIN FAAE.Reserva res ON (f.fact_rese_codigo = res.rese_codigo)
									 JOIN FAAE.Regimen reg ON (res.rese_regi_codigo = reg.regi_nombre)
					 				 JOIN FAAE.Reserva_Habitacion rh ON (res.rese_codigo = rh.reha_rese_codigo)
									 JOIN FAAE.Habitacion habi ON (rh.reha_hote_codigo = habi.habi_hote_codigo AND rh.reha_habi_nro = habi.habi_nro)
									 JOIN FAAE.Tipo t ON (habi.habi_tipo_codigo = t.tipo_codigo)
									 JOIN FAAE.Hotel hote ON (res.rese_hote_codigo = hote.hote_codigo)
									 JOIN FAAE.Cliente c ON (rese_clie_doc_tipo = c.clie_doc_tipo AND rese_clie_doc_nro = clie_doc_nro AND rese_clie_mail = clie_mail)
		WHERE fact_fecha BETWEEN @fechaDesde AND @fechaHasta
		GROUP BY clie_doc_tipo, clie_doc_nro, clie_mail, clie_nombre, clie_apellido)
go
-- Registrar CheckIN
CREATE PROCEDURE FAAE.guardar_checkIn
@reseCodigo numeric(10), @docTipo nvarchar(10), @docNro numeric(10), @mail nvarchar(50), @docTipoUsua nvarchar(10), @docNroUsua numeric(10), @mailUsua nvarchar(50)
AS
BEGIN
	IF( EXISTS(SELECT rese_codigo FROM FAAE.Reserva WHERE rese_codigo = @reseCodigo) )
		BEGIN
			INSERT INTO FAAE.Estadia (esta_rese_codigo, esta_habi_nro, esta_hote_codigo, esta_clie_doc_tipo, esta_clie_doc_nro, esta_clie_mail, esta_usuaIn_doc_tipo, esta_usuaIn_doc_nro, esta_usuaIn_mail)
			select top 1 @reseCodigo, reha_habi_nro, reha_hote_codigo, @docTipo, @docNro, @mail, @docTipoUsua, @docNroUsua, @mailUsua
			from FAAE.Reserva_Habitacion join FAAE.Habitacion on habi_nro = reha_habi_nro and habi_hote_codigo = reha_hote_codigo
										 join FAAE.Tipo on habi_tipo_codigo = tipo_codigo
			where @reseCodigo = reha_rese_codigo and tipo_cant_personas < (select count(*)
																		   from FAAE.Estadia
																		   where esta_habi_nro = reha_habi_nro and
																		         esta_hote_codigo = reha_hote_codigo and
																				 esta_rese_codigo = @reseCodigo)
		END
END
go

--generar reserva
CREATE PROCEDURE FAAE.guardar_reserva
@rese_fecha_desde smalldatetime, @rese_fecha_hasta smalldatetime, @rese_hote_codigo numeric(10), 
@rese_regi_codigo nvarchar(30), @rese_clie_doc_tipo nvarchar(10), @rese_clie_doc_nro numeric(10), 
@rese_clie_mail nvarchar(50)
AS
BEGIN
		BEGIN --nuevo registro
			INSERT INTO FAAE.Reserva
			(rese_fecha_realizacion, 
			rese_fecha_desde, rese_fecha_hasta, rese_hote_codigo, 
			rese_regi_codigo, rese_clie_doc_tipo, rese_clie_doc_nro, 
			rese_clie_mail)
			VALUES(getdate(), 
			@rese_fecha_desde, @rese_fecha_hasta, @rese_hote_codigo, 
			@rese_regi_codigo, @rese_clie_doc_tipo, @rese_clie_doc_nro, 
			@rese_clie_mail)
		END
END
GO


CREATE FUNCTION FAAE.obtenerPrimeraHabitacionDisponible (@hote_codigo numeric(10), @habi_tipo_codigo numeric(10))
RETURNS numeric(10)
AS
BEGIN
	RETURN  (SELECT top 1 habi_nro
		FROM FAAE.Habitacion 
		WHERE habi_hote_codigo = @hote_codigo --dame todas las habitaciones que esten en este hotel
		AND NOT exists (SELECT NULL FROM FAAE.Reserva_Habitacion 
		WHERE reha_hote_codigo = @hote_codigo AND habi_nro = reha_habi_nro) -- y que no aparezca en ninguna reservaHabi que tenga ese hotel
		AND habi_tipo_codigo = @habi_tipo_codigo) --y que sea de este tipo		   
END
GO

CREATE PROCEDURE FAAE.guardar_reservaPorHabitacion
@reha_rese_codigo numeric(10), @rese_hote_codigo numeric(10), @reha_precio numeric(10), @habi_tipo_codigo numeric(10)
AS
BEGIN
		BEGIN --nuevas reserva_habitacion, la cantidad depende de la reserva(un for se encarga de eso)
		INSERT INTO FAAE.Reserva_Habitacion
		(reha_rese_codigo, reha_habi_nro, reha_hote_codigo, reha_precio)
		VALUES(@reha_rese_codigo, FAAE.obtenerPrimeraHabitacionDisponible(@rese_hote_codigo, @habi_tipo_codigo), @rese_hote_codigo, @reha_precio)
		END
END			
GO

--para generar Reserva
CREATE PROCEDURE FAAE.guardar_cliente
@clie_nombre nvarchar(25), @clie_apellido nvarchar(25), @clie_doc_tipo nvarchar(10), 
@clie_doc_nro numeric(10), @clie_mail nvarchar(50) , @clie_telefono nvarchar(16), 
@clie_dire_calle nvarchar(50), @clie_dire_nro numeric(10), @clie_dire_localidad nvarchar(16),
@clie_dire_pais nvarchar(16), @clie_nacionalidad nvarchar(16),  @clie_fecha_nacimiento smalldatetime
AS
BEGIN
		INSERT INTO FAAE.Cliente
		(clie_nombre, clie_apellido, clie_doc_tipo, clie_doc_nro, clie_mail , clie_telefono, 
		clie_dire_calle, clie_dire_nro, clie_dire_localidad,clie_dire_pais, clie_nacionalidad, clie_fecha_nacimiento)
		VALUES(@clie_nombre, @clie_apellido, @clie_doc_tipo, @clie_doc_nro, @clie_mail , @clie_telefono, 
		@clie_dire_calle, @clie_dire_nro, @clie_dire_localidad, @clie_dire_pais, @clie_nacionalidad, @clie_fecha_nacimiento)
END				
GO


CREATE PROCEDURE FAAE.modificar_reserva
@rese_codigo numeric(10), @rese_fecha_desde smalldatetime, @rese_fecha_hasta smalldatetime, @rese_regi_codigo nvarchar(30)
AS
BEGIN
		UPDATE FAAE.Reserva 
		SET rese_fecha_desde = @rese_fecha_desde,
			rese_fecha_hasta = @rese_fecha_hasta,
			rese_regi_codigo = @rese_regi_codigo,
			rese_estado = 'Reserva modificada'
		WHERE rese_codigo = @rese_codigo
END				
GO

--borra las reservas_habitaciones creadas junto a la reserva (no borra a la reserva ppal.)
CREATE PROCEDURE FAAE.borrar_habitacionesDeReservaAntigua
@rese_codigo numeric(10) 
AS
BEGIN
		DELETE FROM FAAE.Reserva_Habitacion
		WHERE reha_rese_codigo = @rese_codigo
END				
GO