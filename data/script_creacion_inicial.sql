USE [GD2C2015]
GO

/****** Object:  Schema [JUST_DO_IT]    Script Date: 10/5/2015 3:43:38 PM ******/
--CREATE SCHEMA [JUST_DO_IT]
GO
/******DROP TABLES******/

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Aeronaves_Fuera_De_Servicio'))
	drop table JUST_DO_IT.Aeronaves_Fuera_De_Servicio

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rol_Funcionalidad'))
	drop table JUST_DO_IT.Rol_Funcionalidad

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.IntentosFallidos'))
	drop table JUST_DO_IT.IntentosFallidos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Usuario_Rol'))
	drop table JUST_DO_IT.Usuario_Rol

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Paquete'))
	drop table JUST_DO_IT.Paquete
GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Funcionalidades'))
	drop table JUST_DO_IT.Funcionalidades

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Puntos'))
	drop table JUST_DO_IT.Puntos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Paquetes'))
	drop table JUST_DO_IT.Paquetes

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Pasajes'))
	drop table JUST_DO_IT.Pasajes

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.CancelacionesPendientes'))
	drop table JUST_DO_IT.CancelacionesPendientes

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.CancelacionesHechas'))
	drop table JUST_DO_IT.CancelacionesHechas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Compras'))
	drop table JUST_DO_IT.Compras

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.ButacasReservadas'))
	drop table JUST_DO_IT.ButacasReservadas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Butacas'))
	drop table JUST_DO_IT.Butacas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Vuelos'))
	drop table JUST_DO_IT.Vuelos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.RegistroCanjeMillas'))
	drop table JUST_DO_IT.RegistroCanjeMillas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Productos'))
	drop table JUST_DO_IT.Productos
	
GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Usuarios'))
	drop table JUST_DO_IT.Usuarios

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Roles'))
	drop table JUST_DO_IT.Roles

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Aeronaves'))
	drop table JUST_DO_IT.Aeronaves

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rutas'))
	drop table JUST_DO_IT.Rutas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Ciudades'))
	drop table JUST_DO_IT.Ciudades

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.TiposServicios'))
	drop table JUST_DO_IT.TiposServicios

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.MediosDePago'))
	drop table JUST_DO_IT.MediosDePago

GO


IF OBJECT_ID('tempdb..#rutasDeLaMaestra') IS NOT NULL
	drop table #rutasDeLaMaestra
GO

IF OBJECT_ID('tempdb..#temporalParaPasaje') IS NOT NULL
	drop table #temporalParaPasaje
GO

IF OBJECT_ID('tempdb..#temporalUsuarios') IS NOT NULL
	drop table #temporalUsuarios

GO

IF OBJECT_ID('tempdb..#temporalPasajes') IS NOT NULL
	drop table #temporalPasajes

GO

IF OBJECT_ID('tempdb..#temporalPaquete') IS NOT NULL
	drop table #temporalPaquete

GO

IF OBJECT_ID('tempdb..#temporalUsuariosPaquete') IS NOT NULL
	drop table #temporalUsuariosPaquete	

GO

IF OBJECT_ID('tempdb..#temporalParaPaquete') IS NOT NULL
	drop table #temporalParaPaquete	

GO

IF OBJECT_ID('tempdb..#cantidadDeButacas') IS NOT NULL
	drop table #cantidadDeButacas
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarRuta') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarRuta;
GO

IF OBJECT_ID (N'JUST_DO_IT.cancelar_vuelos_y_dar_de_baja_aeronave') IS NOT NULL
    drop PROCEDURE JUST_DO_IT.cancelar_vuelos_y_dar_de_baja_aeronave;
GO

IF OBJECT_ID (N'JUST_DO_IT.reemplazar_vuelos_aeronave_fuera_servicio') IS NOT NULL
    drop procedure JUST_DO_IT.reemplazar_vuelos_aeronave_fuera_servicio;
GO

IF OBJECT_ID (N'JUST_DO_IT.reemplazar_vuelos_aeronave_fin_vida_util') IS NOT NULL
    drop procedure JUST_DO_IT.reemplazar_vuelos_aeronave_fin_vida_util;
GO

IF OBJECT_ID (N'JUST_DO_IT.generar_butacas') IS NOT NULL
    drop procedure JUST_DO_IT.generar_butacas;
GO

IF OBJECT_ID (N'JUST_DO_IT.reemplazar_vuelos_aeronave') IS NOT NULL
    drop procedure JUST_DO_IT.reemplazar_vuelos_aeronave;
GO

IF OBJECT_ID (N'JUST_DO_IT.aeronaves_que_pueden_reemplazar_a') IS NOT NULL
    drop procedure JUST_DO_IT.aeronaves_que_pueden_reemplazar_a;
GO

IF OBJECT_ID (N'JUST_DO_IT.dar_de_baja_aeronave_por_fuera_de_servicio') IS NOT NULL
    drop procedure JUST_DO_IT.dar_de_baja_aeronave_por_fuera_de_servicio;
GO

IF OBJECT_ID (N'JUST_DO_IT.IDCiudad') IS NOT NULL
    drop function JUST_DO_IT.IDCiudad;
GO

IF OBJECT_ID (N'JUST_DO_IT.destinos_con_pasajes_cancelados') IS NOT NULL
    drop function JUST_DO_IT.destinos_con_pasajes_cancelados;
GO

IF OBJECT_ID (N'JUST_DO_IT.AeronavesDisponiblesParaBaja') IS NOT NULL
    drop function JUST_DO_IT.AeronavesDisponiblesParaBaja;
GO

IF OBJECT_ID (N'JUST_DO_IT.buscar_vuelo') IS NOT NULL
    drop function JUST_DO_IT.buscar_vuelo;
GO

IF OBJECT_ID (N'JUST_DO_IT.buscar_vuelo') IS NOT NULL
    drop function JUST_DO_IT.buscar_vuelo;
GO

IF OBJECT_ID (N'JUST_DO_IT.EstaDisponibleParaElVuelo') IS NOT NULL
    drop function JUST_DO_IT.EstaDisponibleParaElVuelo;
GO

IF OBJECT_ID (N'JUST_DO_IT.EstaDisponibleParaReemplazar') IS NOT NULL
    drop function JUST_DO_IT.EstaDisponibleParaReemplazar;
GO

IF OBJECT_ID (N'JUST_DO_IT.obtener_aeronaves_que_reemplacen_a') IS NOT NULL
    drop function JUST_DO_IT.obtener_aeronaves_que_reemplacen_a;
GO

IF OBJECT_ID (N'JUST_DO_IT.obtener_vuelos_segun_id_aeronave_y_fechas') IS NOT NULL
    drop function JUST_DO_IT.obtener_vuelos_segun_id_aeronave_y_fechas;
GO

IF OBJECT_ID (N'JUST_DO_IT.obtener_vuelos_segun_id_aeronave') IS NOT NULL
    drop function JUST_DO_IT.obtener_vuelos_segun_id_aeronave;
GO

IF OBJECT_ID (N'JUST_DO_IT.obtener_id_aeronave_segun_matricula') IS NOT NULL
    drop function JUST_DO_IT.obtener_id_aeronave_segun_matricula;
GO

IF OBJECT_ID (N'JUST_DO_IT.IDTipoDeServicio') IS NOT NULL
    drop function JUST_DO_IT.IDTipoDeServicio;
GO

IF OBJECT_ID (N'JUST_DO_IT.modificarAeronave') IS NOT NULL
    drop procedure JUST_DO_IT.modificarAeronave;
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarAeronave') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarAeronave;
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarFuncionalidad') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarFuncionalidad;
GO

IF OBJECT_ID (N'JUST_DO_IT.cantidadButacas') IS NOT NULL
    drop function JUST_DO_IT.cantidadButacas;
GO

IF OBJECT_ID (N'JUST_DO_IT.vuelosDisponibles') IS NOT NULL
    drop function JUST_DO_IT.vuelosDisponibles;
GO

IF OBJECT_ID (N'JUST_DO_IT.aeronavesDisponiblesParaVuelos') IS NOT NULL
	drop function JUST_DO_IT.aeronavesDisponiblesParaVuelos;
GO

IF OBJECT_ID (N'JUST_DO_IT.IDRol') IS NOT NULL
    drop function JUST_DO_IT.IDRol;
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarRol') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarRol;
GO

IF OBJECT_ID (N'JUST_DO_IT.IDFuncionalidad') IS NOT NULL
    drop function JUST_DO_IT.IDFuncionalidad;
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarRol_Funcionalidad') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarRol_Funcionalidad;
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarVuelo') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarVuelo;
GO

IF OBJECT_ID (N'JUST_DO_IT.butacasLibres') IS NOT NULL
    drop function JUST_DO_IT.butacasLibres;
GO

IF OBJECT_ID (N'JUST_DO_IT.IDMedioDePago') IS NOT NULL
    drop function JUST_DO_IT.IDMedioDePago;
GO

IF OBJECT_ID (N'JUST_DO_IT.reservarButaca') IS NOT NULL
    drop procedure JUST_DO_IT.reservarButaca;

IF OBJECT_ID (N'JUST_DO_IT.almacenarPasaje') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarPasaje;

IF OBJECT_ID (N'JUST_DO_IT.actualizarCliente') IS NOT NULL
    drop procedure JUST_DO_IT.actualizarCliente;

IF OBJECT_ID (N'JUST_DO_IT.bajaRol') IS NOT NULL
    drop procedure JUST_DO_IT.bajaRol;

IF OBJECT_ID (N'JUST_DO_IT.NombreTipoDeServicio') IS NOT NULL
    drop function JUST_DO_IT.NombreTipoDeServicio;

IF OBJECT_ID (N'JUST_DO_IT.eliminar_vuelos') IS NOT NULL
    drop procedure JUST_DO_IT.eliminar_vuelos;

IF OBJECT_ID (N'JUST_DO_IT.altaRolExistente') IS NOT NULL
    drop procedure JUST_DO_IT.altaRolExistente;

IF OBJECT_ID (N'JUST_DO_IT.modificarNombreRol') IS NOT NULL
    drop procedure JUST_DO_IT.modificarNombreRol;

IF OBJECT_ID (N'JUST_DO_IT.nombresRolesYFuncionalidades') IS NOT NULL
    drop function JUST_DO_IT.nombresRolesYFuncionalidades;

IF OBJECT_ID (N'JUST_DO_IT.bajaRol_Funcionalidad') IS NOT NULL
    drop procedure JUST_DO_IT.bajaRol_Funcionalidad;

IF OBJECT_ID (N'JUST_DO_IT.KGsDisponibles') IS NOT NULL
    drop function JUST_DO_IT.KGsDisponibles;

IF OBJECT_ID (N'JUST_DO_IT.buscar_vuelo') IS NOT NULL
    drop function JUST_DO_IT.buscar_vuelo;
	
IF OBJECT_ID (N'JUST_DO_IT.registrar_llegada') IS NOT NULL
    drop procedure JUST_DO_IT.registrar_llegada;

IF OBJECT_ID (N'JUST_DO_IT.BajarRuta') IS NOT NULL
    drop procedure JUST_DO_IT.BajarRuta;
GO

IF OBJECT_ID (N'JUST_DO_IT.NombreCiudad') IS NOT NULL
    drop function JUST_DO_IT.NombreCiudad;

IF OBJECT_ID (N'JUST_DO_IT.ActualizarRuta') IS NOT NULL
    drop procedure JUST_DO_IT.ActualizarRuta;

IF OBJECT_ID (N'JUST_DO_IT.ModificarCiudad') IS NOT NULL
    drop procedure JUST_DO_IT.ModificarCiudad;

IF OBJECT_ID (N'JUST_DO_IT.almacenarCiudad') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarCiudad;

IF OBJECT_ID (N'JUST_DO_IT.agregarCompraADevolver') IS NOT NULL
    drop procedure JUST_DO_IT.agregarCompraADevolver;

IF OBJECT_ID (N'JUST_DO_IT.procesarCancelaciones') IS NOT NULL
    drop procedure JUST_DO_IT.procesarCancelaciones;

IF OBJECT_ID (N'JUST_DO_IT.alta_aeronave_fuera_de_servicio') IS NOT NULL
	drop procedure JUST_DO_IT.alta_aeronave_fuera_de_servicio;

IF OBJECT_ID (N'JUST_DO_IT.LoguearUsuario') IS NOT NULL
	drop procedure JUST_DO_IT.LoguearUsuario;

IF OBJECT_ID (N'JUST_DO_IT.dias_totales_fuera_de_servicio') IS NOT NULL
    drop function JUST_DO_IT.dias_totales_fuera_de_servicio;

IF OBJECT_ID (N'JUST_DO_IT.top_aeroanves_fuera_de_servicio') IS NOT NULL
    drop function JUST_DO_IT.top_aeroanves_fuera_de_servicio;

IF OBJECT_ID (N'JUST_DO_IT.usuarios_con_mas_puntaje') IS NOT NULL
    drop function JUST_DO_IT.usuarios_con_mas_puntaje;

IF OBJECT_ID (N'JUST_DO_IT.DestinosConAeronavesMasVacias') IS NOT NULL
    drop function JUST_DO_IT.DestinosConAeronavesMasVacias;

IF OBJECT_ID (N'JUST_DO_IT.DestinosConPasajesMasComprados') IS NOT NULL
    drop function JUST_DO_IT.DestinosConPasajesMasComprados;
	
IF OBJECT_ID (N'JUST_DO_IT.canjearMillas') IS NOT NULL
	drop procedure JUST_DO_IT.canjearMillas;

IF OBJECT_ID (N'JUST_DO_IT.canjeMillas_leAlcanzanlasMillasPara') IS NOT NULL
	drop function JUST_DO_IT.canjeMillas_leAlcanzanlasMillasPara;

IF OBJECT_ID (N'JUST_DO_IT.canjeMillas_hayStockDe') IS NOT NULL
	drop function JUST_DO_IT.canjeMillas_hayStockDe;
	
IF OBJECT_ID (N'JUST_DO_IT.ConsultaMillas') IS NOT NULL
	drop function JUST_DO_IT.ConsultaMillas;

IF OBJECT_ID (N'JUST_DO_IT.MillasTotalesDe') IS NOT NULL
	drop function JUST_DO_IT.MillasTotalesDe;

IF OBJECT_ID (N'JUST_DO_IT.CantidadDeMillasUsuario') IS NOT NULL
	drop function JUST_DO_IT.CantidadDeMillasUsuario;

IF OBJECT_ID (N'JUST_DO_IT.existeFuncionalidad') IS NOT NULL
	drop procedure JUST_DO_IT.existeFuncionalidad;

IF OBJECT_ID (N'JUST_DO_IT.cantFuncionalidadQuePosee') IS NOT NULL
	drop function JUST_DO_IT.cantFuncionalidadQuePosee;

IF OBJECT_ID (N'JUST_DO_IT.almacenarCliente') IS NOT NULL
	drop procedure JUST_DO_IT.almacenarCliente;

 IF OBJECT_ID (N'JUST_DO_IT.obtenerIDUsuario') IS NOT NULL
	drop function JUST_DO_IT.obtenerIDUsuario;

IF OBJECT_ID (N'JUST_DO_IT.eliminarFuncionalidad') IS NOT NULL
	drop procedure JUST_DO_IT.eliminarFuncionalidad;

IF OBJECT_ID (N'JUST_DO_IT.existeRol') IS NOT NULL
	drop procedure JUST_DO_IT.existeRol;
	
IF OBJECT_ID (N'JUST_DO_IT.estabaDadoDeBajaElRol') IS NOT NULL
	drop procedure JUST_DO_IT.estabaDadoDeBajaElRol; 

IF OBJECT_ID (N'JUST_DO_IT.asignarRolAUsuario') IS NOT NULL
	drop procedure JUST_DO_IT.asignarRolAUsuario; 

 IF OBJECT_ID (N'JUST_DO_IT.ListadoUsuarios') IS NOT NULL
	drop function JUST_DO_IT.ListadoUsuarios;

IF OBJECT_ID (N'JUST_DO_IT.BuscarUsuario') IS NOT NULL
	drop function JUST_DO_IT.BuscarUsuario; 

IF OBJECT_ID (N'JUST_DO_IT.butacasReservadasParaVuelo') IS NOT NULL
	drop function JUST_DO_IT.butacasReservadasParaVuelo;

IF OBJECT_ID (N'JUST_DO_IT.cantidadDeFuncionalidades') IS NOT NULL
	drop function JUST_DO_IT.cantidadDeFuncionalidades; 

/******CREACION DE TABLAS******/

CREATE TABLE JUST_DO_IT.Ciudades(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre NVARCHAR(255) NOT NULL UNIQUE,
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.TiposServicios(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre VARCHAR(255),
	costo_adicional NUMERIC(18,2) DEFAULT 1,
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.Aeronaves(
	id NUMERIC(18,0) IDENTITY(1,1),
	matricula NVARCHAR(255) UNIQUE NOT NULL,
	modelo NVARCHAR(255) NOT NULL,
	kgs_disponibles NUMERIC(18,2) NOT NULL,
	butacas_totales NUMERIC(18,0) NOT NULL,
	fabricante NVARCHAR(255) NOT NULL,
	tipo_servicio NUMERIC(18,0) NOT NULL,
	fecha_alta DATETIME,
	baja_fuera_servicio BIT DEFAULT 0,
	baja_vida_util BIT DEFAULT 0,
	fecha_fuera_servicio DATETIME,
	fecha_reinicio_servicio DATETIME,
	fecha_baja_definitiva DATETIME,
	PRIMARY KEY(id),
	FOREIGN KEY (tipo_servicio) REFERENCES JUST_DO_IT.TiposServicios
)

GO

CREATE TABLE JUST_DO_IT.Rutas(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo NUMERIC(18,0) NOT NULL,
	precio_baseKG NUMERIC(18,2) NOT NULL,
	precio_basePasaje NUMERIC(18,2) NOT NULL,
	ciu_id_origen NUMERIC(18,0) NOT NULL,
	ciu_id_destino NUMERIC(18,0) NOT NULL,
	tipo_servicio NUMERIC(18,0) NOT NULL,
	eliminada BIT DEFAULT 0,
	PRIMARY KEY(id),
	FOREIGN KEY (ciu_id_origen) REFERENCES JUST_DO_IT.Ciudades,
	FOREIGN KEY (ciu_id_destino) REFERENCES JUST_DO_IT.Ciudades,
	FOREIGN KEY (tipo_servicio) REFERENCES JUST_DO_IT.TiposServicios
) 

GO

CREATE TABLE JUST_DO_IT.Roles(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre varchar(50) UNIQUE NOT NULL,
	baja_rol BIT DEFAULT 0,
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.Usuarios(
	id NUMERIC(18,0) IDENTITY(1,1),
	username NVARCHAR(255),
	pass VARBINARY(8000), 
	dni NUMERIC(18,0) NOT NULL,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	fecha_nacimiento DATETIME NOT NULL,
	PRIMARY KEY(id)
)

GO

CREATE TABLE JUST_DO_IT.IntentosFallidos(
	usuario_id NUMERIC(18,0),
	intentos INT DEFAULT 0,
	FOREIGN KEY(usuario_id) REFERENCES JUST_DO_IT.Usuarios
)

CREATE TABLE JUST_DO_IT.Vuelos(
	id NUMERIC(18,0) IDENTITY(1,1),
	fecha_salida DATETIME NOT NULL, 
	fecha_llegada DATETIME,
	fecha_llegada_estimada DATETIME NOT NULL,
	ruta_id NUMERIC(18,0) NOT NULL,
	aeronave_id NUMERIC(18,0) NOT NULL,
	cantidadDisponible NUMERIC(18,0) NOT NULL DEFAULT 0,
	KGsDisponibles NUMERIC(18,2) NOT NULL DEFAULT 0,
	vuelo_eliminado BIT DEFAULT 0,
	PRIMARY KEY (id),
	FOREIGN KEY (ruta_id) REFERENCES JUST_DO_IT.Rutas,
	FOREIGN KEY (aeronave_id) REFERENCES JUST_DO_IT.Aeronaves,
	CONSTRAINT CK_Fecha CHECK(fecha_salida < fecha_llegada_estimada)
)

GO

CREATE TABLE JUST_DO_IT.Butacas(
	id NUMERIC(18,0) IDENTITY(1,1),
	numero INT,
	piso NUMERIC(18,0),
	tipo NVARCHAR(10) CHECK (tipo in ('Pasillo', 'Ventanilla')),
	aeronave_id NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (aeronave_id) REFERENCES JUST_DO_IT.Aeronaves
)

GO

CREATE TABLE JUST_DO_IT.MediosDePago(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre NVARCHAR(255) NOT NULL UNIQUE,
	cuotas NUMERIC(18,0),
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.Compras(
	codigo NUMERIC(18,0) IDENTITY(672301,1),
	comprador NUMERIC(18,0),
	fecha_compra DATETIME,
	monto NUMERIC(18,2),
	medio_de_pago NUMERIC(18,0),
	numero_tarjeta NUMERIC(18,0),
	vencimiento NUMERIC(18,0),
	codigo_seguridad NUMERIC(18,0),
	cuotas NUMERIC(18,0),
	encomienda BIT DEFAULT 0,
	PRIMARY KEY (codigo),
	FOREIGN KEY (comprador) REFERENCES JUST_DO_IT.Usuarios,
	FOREIGN KEY (medio_de_pago) REFERENCES JUST_DO_IT.MediosDePago
)

GO

CREATE TABLE JUST_DO_IT.CancelacionesPendientes(
	id NUMERIC(18,0) IDENTITY(839212,1),
	compra NUMERIC(18,0),
	tipo BIT,
	codigo NUMERIC(18,0),
	motivo VARCHAR(255),
	monto NUMERIC(18,2),
	fecha DATETIME,
	PRIMARY KEY(id),
	FOREIGN KEY(compra) REFERENCES JUST_DO_IT.Compras,
)

GO

CREATE TABLE JUST_DO_IT.CancelacionesHechas(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo_cancelacion NUMERIC(18,0),
	compra NUMERIC(18,0),
	tipo VARCHAR(255),
	codigo NUMERIC(18,0),
	motivo VARCHAR(255),
	monto_devuelto NUMERIC(18,2),
	fecha DATETIME,
	PRIMARY KEY(id),
	FOREIGN KEY(compra) REFERENCES JUST_DO_IT.Compras
)

GO

CREATE TABLE JUST_DO_IT.Pasajes(
	codigo NUMERIC(18,0) IDENTITY(1,1),
	precio NUMERIC(18,2) NOT NULL,
	fecha_compra DATETIME NOT NULL,
	vuelo_id NUMERIC(18,0) NOT NULL,
	pasajero NUMERIC(18,0) NOT NULL,
	compra NUMERIC(18,0) NOT NULL,
	butaca NUMERIC(18,0) NOT NULL,
	cancelado BIT DEFAULT 0,
	codigo_cancelacion NUMERIC(18,0),
	PRIMARY KEY (codigo),
	FOREIGN KEY (butaca) REFERENCEs JUST_DO_IT.Butacas,
	FOREIGN KEY (vuelo_id) REFERENCES JUST_DO_IT.Vuelos,
	FOREIGN KEY (pasajero) REFERENCES JUST_DO_IT.Usuarios,
	FOREIGN KEY (compra) REFERENCES JUST_DO_IT.Compras
)

GO

CREATE TABLE JUST_DO_IT.Paquetes(
	codigo NUMERIC(18,0) IDENTITY(1,1),
	precio NUMERIC(18,2) NOT NULL,
	kg NUMERIC(18,0) NOT NULL,
	fecha_compra DATETIME NOT NULL,
	vuelo_id NUMERIC(18,0) NOT NULL,
	compra NUMERIC(18,0) NOT NULL,
	cancelado BIT DEFAULT 0,
	codigo_cancelacion NUMERIC(18,0),
	PRIMARY KEY(codigo),
	FOREIGN KEY(vuelo_id) REFERENCES JUST_DO_IT.Vuelos,
	FOREIGN KEY(compra) REFERENCES JUST_DO_IT.Compras
)

GO

CREATE TABLE JUST_DO_IT.Puntos(
	id NUMERIC(18,0) IDENTITY(1,1),
	millas NUMERIC(18,0) NOT NULL,
	vencimiento DATETIME NOT NULL,
	usuario_id NUMERIC(18,0) NOT NULL,
	validos BIT DEFAULT 0,
	vuelo_id NUMERIC(18,0),
	PRIMARY KEY(id),
	FOREIGN KEY(usuario_id) REFERENCES JUST_DO_IT.Usuarios,
	FOREIGN KEY(vuelo_id) REFERENCES JUST_DO_IT.Vuelos
)

GO

CREATE TABLE JUST_DO_IT.Funcionalidades(
	id NUMERIC(18,0) IDENTITY(1,1),
	descripcion NVARCHAR(255) NOT NULL UNIQUE,
	eliminada BIT DEFAULT 0,
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.Rol_Funcionalidad(
	id_rol NUMERIC(18,0) NOT NULL,
	id_funcionalidad NUMERIC(18,0) NOT NULL,
	FOREIGN KEY (id_rol) REFERENCES JUST_DO_IT.Roles,
	FOREIGN KEY (id_funcionalidad) REFERENCES JUST_DO_IT.Funcionalidades
)

GO

CREATE TABLE JUST_DO_IT.Usuario_Rol(
	id_usuario NUMERIC(18,0),
	id_rol NUMERIC(18,0),
	FOREIGN KEY (id_usuario) REFERENCES JUST_DO_IT.Usuarios,
	FOREIGN KEY (id_rol) REFERENCES JUST_DO_IT.Roles
)

GO

CREATE TABLE JUST_DO_IT.ButacasReservadas(
	usuario_id NUMERIC(18,0),
	butaca_id NUMERIC(18,0),
	vuelo_id NUMERIC(18,0),
	FOREIGN KEY (usuario_id) REFERENCES JUST_DO_IT.Usuarios,
	FOREIGN KEY (butaca_id) REFERENCES JUST_DO_IT.Butacas,
	FOREIGN KEY (vuelo_id) REFERENCES JUST_DO_IT.Vuelos
)

GO

CREATE TABLE JUST_DO_IT.Aeronaves_Fuera_De_Servicio(
	id NUMERIC(18,0) IDENTITY(1,1),
	aeronave_id NUMERIC(18,0),
	fecha_fuera_servicio DATETIME,
	fecha_reinicio_servicio DATETIME,
	PRIMARY KEY (id),
	FOREIGN KEY (aeronave_id) REFERENCES JUST_DO_IT.Aeronaves
)

GO

CREATE TABLE JUST_DO_IT.Productos(
	id NUMERIC(18,0) IDENTITY(1,1),
	descripcionProd NVARCHAR(255) NOT NULL UNIQUE,
	cantMillasNecesarias NUMERIC(18,0),
	stockProd NUMERIC(18,0),
	PRIMARY KEY(id)
)

GO

CREATE TABLE JUST_DO_IT.RegistroCanjeMillas(
	id_usuario NUMERIC(18,0),
	id_producto NUMERIC(18,0),
	cantProductoElegido NUMERIC(18,0),
	fechaCanje DATETIME,
	FOREIGN KEY(id_usuario) REFERENCES JUST_DO_IT.Usuarios,
	FOREIGN KEY(id_producto) REFERENCES JUST_DO_IT.Productos
)

GO

/******TABLA AUXILIAR******/
CREATE TABLE #cantidadDeButacas(
	matricula VARCHAR(255),
	cantidadTotal NUMERIC(18,0)
)

INSERT INTO #cantidadDeButacas(matricula, cantidadTotal)
	SELECT Aeronave_Matricula, COUNT (DISTINCT Butaca_Nro)
		FROM  gd_esquema.Maestra
			WHERE Pasaje_Codigo <> 0
				GROUP BY Aeronave_Matricula

/*************************/


/******NORMALIZACION******/

INSERT INTO JUST_DO_IT.Roles(nombre) VALUES ('Administrativo')

INSERT INTO JUST_DO_IT.Roles(nombre) VALUES ('Cliente')

INSERT INTO JUST_DO_IT.TiposServicios(nombre)
	SELECT DISTINCT Tipo_Servicio
		FROM gd_esquema.Maestra

UPDATE JUST_DO_IT.TiposServicios SET costo_adicional = 1.10 WHERE nombre = 'Ejecutivo'
UPDATE JUST_DO_IT.TiposServicios SET costo_adicional = 1.15 WHERE nombre = 'Primera Clase'

INSERT INTO JUST_DO_IT.Usuarios(nombre, apellido, username, pass, dni, direccion, telefono, mail, fecha_nacimiento) 
	SELECT  DISTINCT Cli_Nombre, Cli_Apellido, CONCAT(Cli_Dni,Cli_Nombre,Cli_Apellido), HASHBYTES('SHA2_256', ''), Cli_Dni, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac
		FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.IntentosFallidos(usuario_id)
	SELECT id FROM JUST_DO_IT.Usuarios

INSERT INTO JUST_DO_IT.Usuario_Rol(id_usuario, id_rol)
	SELECT id, 2 FROM JUST_DO_IT.Usuarios

INSERT INTO JUST_DO_IT.Usuarios(username, pass, nombre, apellido, dni, direccion, telefono, mail, fecha_nacimiento)
	VALUES('admin', HASHBYTES('SHA2_256','w23e'), 'Administrador', 'General', 123456789, 'Sheraton', 44444444, 'admin@admin.com', 1/1/1900)

DECLARE @id_admin NUMERIC(18,0)
SET @id_admin = @@IDENTITY

INSERT INTO JUST_DO_IT.Usuario_Rol(id_usuario, id_rol) VALUES (@id_admin, 1)
INSERT INTO JUST_DO_IT.IntentosFallidos(usuario_id) VALUES(@id_admin)

INSERT INTO JUST_DO_IT.Ciudades(nombre)
	SELECT DISTINCT Ruta_Ciudad_Origen AS Ciudad FROM gd_esquema.Maestra
	UNION
	SELECT DISTINCT Ruta_Ciudad_Destino As Ciudad FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Aeronaves(matricula, modelo, kgs_disponibles, butacas_totales, fabricante, tipo_servicio)
	SELECT DISTINCT Aeronave_Matricula, Aeronave_Modelo, Aeronave_KG_Disponibles, cantidadTotal, Aeronave_Fabricante, servicios.id
		FROM gd_esquema.Maestra AS maestra
		INNER JOIN JUST_DO_IT.TiposServicios AS servicios
		ON maestra.Tipo_Servicio = servicios.nombre 
		INNER JOIN #cantidadDeButacas AS cantidad
		ON cantidad.matricula = Aeronave_Matricula

INSERT INTO JUST_DO_IT.Rutas(codigo, precio_baseKG, precio_basePasaje, ciu_id_origen, ciu_id_destino, tipo_servicio)
	SELECT Ruta_Codigo, MAX(Ruta_Precio_BaseKG), MAX(Ruta_Precio_BasePasaje), ciudades1.id, ciudades2.id, servicios.id
		FROM JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2, gd_esquema.Maestra AS maestra, JUST_DO_IT.TiposServicios AS servicios
			WHERE ciudades1.nombre = maestra.Ruta_Ciudad_Origen AND ciudades2.nombre = maestra.Ruta_Ciudad_Destino AND maestra.Tipo_Servicio = servicios.nombre
				 GROUP BY Ruta_Codigo, ciudades1.id, ciudades2.id, servicios.id

/******TABLA AUXILIAR******/
CREATE TABLE #rutasDeLaMaestra(
	id NUMERIC(18,0),
	codigo NUMERIC(18,0),
	origen VARCHAR(255),
	destino VARCHAR(255),
	tipo_servicio VARCHAR(255)
)

INSERT INTO #rutasDeLaMaestra(id, codigo, origen, destino, tipo_servicio)
	SELECT rutas.id AS id, rutas.codigo AS codigo, ciudades1.nombre AS origen, ciudades2.nombre AS destino, servicios.nombre as tipo_servicio
		FROM JUST_DO_IT.Rutas AS rutas, JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2, JUST_DO_IT.TiposServicios AS servicios
			WHERE rutas.ciu_id_origen = ciudades1.id AND rutas.ciu_id_destino = ciudades2.id AND rutas.tipo_servicio = servicios.id
/*************************/

INSERT INTO JUST_DO_IT.Butacas(numero, piso, tipo, aeronave_id)
	SELECT DISTINCT Butaca_Nro, Butaca_Piso, Butaca_Tipo, aeronaves.id
		FROM gd_esquema.Maestra AS maestra, JUST_DO_IT.Aeronaves AS aeronaves
			WHERE maestra.Butaca_Piso <> 0 AND maestra.Aeronave_Matricula = aeronaves.matricula 

INSERT INTO JUST_DO_IT.Vuelos(fecha_salida, fecha_llegada, fecha_llegada_estimada, ruta_id, aeronave_id)
	SELECT DISTINCT maestra.FechaSalida, maestra.FechaLLegada, maestra.Fecha_LLegada_Estimada, rutas.id, aeronaves.id
		FROM gd_esquema.Maestra AS maestra, #rutasDeLaMaestra AS rutas, JUST_DO_IT.Aeronaves AS aeronaves
			WHERE maestra.Ruta_Codigo = rutas.codigo AND maestra.Ruta_Ciudad_Origen = rutas.origen 
				AND maestra.Ruta_Ciudad_Destino = rutas.destino AND maestra.Tipo_Servicio = rutas.tipo_servicio
				AND maestra.Aeronave_Matricula = aeronaves.matricula AND maestra.Aeronave_Fabricante = aeronaves.fabricante

GO

/******TABLAS AUXILIARES PARA EL PASAJE******/
CREATE TABLE #temporalPasajes(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo NUMERIC (18,0),
	fecha_compra DATETIME,
	precio NUMERIC(18,2), 
	cli_dni NUMERIC(18,0),
	cli_nombre NVARCHAR(255),
	cli_apellido NVARCHAR(255),
	fechaSalida DATETIME,
	fechaLlegadaEstimada DATETIME,
	fechaLlegada DATETIME,
	ciudadOrigen NVARCHAR(255),
	ciudadDestino NVARCHAR(255),
	tipo_servicio NVARCHAR(255),
	aeronave_matricula NVARCHAR(255),
	aeronave_fabricante NVARCHAR(255),
	butaca_nro NUMERIC(18,0),
	butaca_tipo NVARCHAR(255)
)

INSERT INTO #temporalPasajes(codigo, fecha_compra, precio, cli_dni, cli_nombre, cli_apellido,
							fechaSalida, fechaLlegada, fechaLlegadaEstimada, ciudadOrigen, ciudadDestino, tipo_servicio,
							aeronave_matricula, aeronave_fabricante, butaca_nro, butaca_tipo)
	SELECT Pasaje_Codigo, Pasaje_FechaCompra, Pasaje_Precio, Cli_Dni, Cli_Nombre, Cli_Apellido, 
			FechaSalida, FechaLLegada, Fecha_LLegada_Estimada, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Tipo_Servicio,
			Aeronave_Matricula, Aeronave_Fabricante,Butaca_Nro, Butaca_Tipo
		FROM gd_esquema.Maestra
		WHERE Pasaje_Codigo <> 0

CREATE TABLE #temporalUsuarios(
	temporalPasaje_id NUMERIC(18,0),
	usuario_id NUMERIC(18,0)
)

INSERT INTO #temporalUsuarios(temporalPasaje_id, usuario_id)
	SELECT temporal.id, usuarios.id
		FROM #temporalPasajes AS temporal, JUST_DO_IT.Usuarios AS usuarios
		WHERE temporal.Cli_Dni = usuarios.dni AND temporal.Cli_Apellido = usuarios.apellido 
		AND temporal.Cli_Nombre =  usuarios.nombre

CREATE TABLE #temporalParaPasaje(
	temporalPasaje_id NUMERIC(18,0),
	codigo NUMERIC(18,0),
	fecha_compra DATETIME,
	precio NUMERIC(18,2),
	vuelo_id NUMERIC(18,0),
	butaca_id NUMERIC(18,0)
)

GO
CREATE NONCLUSTERED INDEX [<IndiceTemporalPasajes, JUST_DO_IT,>]
ON #temporalPasajes ([fechaSalida],[fechaLlegada])
INCLUDE ([id],[codigo],[fecha_compra],[precio],[ciudadOrigen],[ciudadDestino],[tipo_servicio],[aeronave_matricula],[aeronave_fabricante],[butaca_nro],[butaca_tipo])
GO

INSERT INTO #temporalParaPasaje(temporalPasaje_id, codigo, fecha_compra, precio, vuelo_id, butaca_id)
	SELECT temporal.id, temporal.codigo, temporal.fecha_compra, temporal.precio, vuelos.id, butacas.id
		FROM #temporalPasajes AS temporal
		JOIN #rutasDeLaMaestra AS rutas
		ON rutas.origen = temporal.ciudadOrigen AND rutas.destino = temporal.ciudadDestino 
		AND temporal.tipo_servicio = rutas.tipo_servicio 
		JOIN JUST_DO_IT.Aeronaves AS aeronaves
		ON temporal.aeronave_matricula = aeronaves.matricula AND temporal.aeronave_fabricante = aeronaves.fabricante
		JOIN JUST_DO_IT.Vuelos AS vuelos
		ON temporal.fechaLlegada = vuelos.fecha_llegada AND temporal.fechaSalida = vuelos.fecha_salida AND vuelos.aeronave_id = aeronaves.id AND rutas.id = vuelos.ruta_id 
		JOIN JUST_DO_IT.Butacas AS butacas
		ON aeronaves.id = butacas.aeronave_id AND temporal.butaca_tipo = butacas.tipo AND temporal.butaca_nro = butacas.numero
/*************************/

GO

INSERT INTO JUST_DO_IT.MediosDePago(nombre) VALUES('Efectivo');
INSERT INTO JUST_DO_IT.MediosDePago(nombre, cuotas) VALUES('VISA', 6);
INSERT INTO JUST_DO_IT.MediosDePago(nombre, cuotas) VALUES('Master Card', 1);

INSERT INTO JUST_DO_IT.Compras(comprador, fecha_compra, medio_de_pago, monto, cuotas)
	SELECT DISTINCT t2.usuario_id, t1.fecha_compra, 1, t1.precio, 1
		FROM #temporalParaPasaje t1
		JOIN #temporalUsuarios t2
		ON t1.temporalPasaje_id = t2.temporalPasaje_id

SET IDENTITY_INSERT JUST_DO_IT.Pasajes ON
INSERT INTO JUST_DO_IT.Pasajes(codigo, fecha_compra, precio, vuelo_id, pasajero, butaca, compra) 
	SELECT DISTINCT t1.codigo, t1.fecha_compra, t1.precio, t1.vuelo_id, t2.usuario_id, t1.butaca_id, compras.codigo
		FROM #temporalParaPasaje t1
		JOIN #temporalUsuarios t2
		ON t1.temporalPasaje_id = t2.temporalPasaje_id
		JOIN JUST_DO_IT.Compras compras
		ON compras.comprador = t2.usuario_id AND compras.monto = t1.precio AND compras.fecha_compra = t1.fecha_compra
SET IDENTITY_INSERT JUST_DO_IT.Pasajes OFF

GO
CREATE NONCLUSTERED INDEX [<IndicePasajes, JUST_DO_IT,>]
ON JUST_DO_IT.Pasajes ([codigo],[compra])
INCLUDE ([precio],[vuelo_id],[pasajero],[butaca],[fecha_compra])
GO
	
/*****TABLAS AUXILIARES PARA PAQUETE*****/
CREATE TABLE #temporalPaquete(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo NUMERIC (18,0),
	fecha_compra DATETIME,
	precio NUMERIC(18,2), 
	kg NUMERIC(18,2),
	cli_dni NUMERIC(18,0),
	cli_nombre NVARCHAR(255),
	cli_apellido NVARCHAR(255),
	fechaSalida DATETIME,
	fechaLlegadaEstimada DATETIME,
	fechaLlegada DATETIME,
	ciudadOrigen NVARCHAR(255),
	ciudadDestino NVARCHAR(255),
	tipo_servicio NVARCHAR(255),
	aeronave_matricula NVARCHAR(255),
	aeronave_fabricante NVARCHAR(255)
)

INSERT INTO #temporalPaquete(codigo, aeronave_matricula, aeronave_fabricante, ciudadDestino,
							ciudadOrigen, cli_apellido, cli_dni, cli_nombre, fecha_compra, fechaLlegada, 
							fechaLlegadaEstimada, fechaSalida, kg, precio, tipo_servicio)

		SELECT Paquete_Codigo, Aeronave_Matricula, Aeronave_Fabricante, Ruta_Ciudad_Destino, 
				Ruta_Ciudad_Origen, Cli_Apellido, Cli_Dni, Cli_Nombre, Paquete_FechaCompra, FechaLLegada,
				Fecha_LLegada_Estimada, FechaSalida, Paquete_KG, Paquete_Precio, Tipo_Servicio
		FROM gd_esquema.Maestra
		WHERE Paquete_Codigo <> 0

CREATE TABLE #temporalUsuariosPaquete(
	temporalPaquete_id NUMERIC(18,0),
	usuario_id NUMERIC(18,0)
)

INSERT INTO #temporalUsuariosPaquete(temporalPaquete_id, usuario_id)
	SELECT temporal.id, usuarios.id
		FROM #temporalPaquete AS temporal, JUST_DO_IT.Usuarios AS usuarios
		WHERE temporal.Cli_Dni = usuarios.dni AND temporal.Cli_Apellido = usuarios.apellido 
		AND temporal.Cli_Nombre =  usuarios.nombre

CREATE TABLE #temporalParaPaquete(
	temporalPaquete_id NUMERIC(18,0),
	codigo NUMERIC(18,0),
	fecha_compra DATETIME,
	kg NUMERIC(18,2),
	precio NUMERIC(18,2),
	vuelo_id NUMERIC(18,0)
)

GO
CREATE NONCLUSTERED INDEX [<IndiceTemporalPaquete, JUST_DO_IT,>]
ON #temporalPaquete ([fechaSalida],[fechaLlegada])
INCLUDE ([id],[codigo],[fecha_compra],[precio],[ciudadOrigen],[ciudadDestino],[tipo_servicio],[aeronave_matricula],[aeronave_fabricante])
GO

INSERT INTO #temporalParaPaquete(temporalPaquete_id, codigo, fecha_compra, kg, precio, vuelo_id)
	SELECT temporal.id, temporal.codigo, temporal.fecha_compra, temporal.kg, temporal.precio, vuelos.id
	FROM #temporalPaquete AS temporal
	JOIN #rutasDeLaMaestra AS rutas
	ON rutas.origen = temporal.ciudadOrigen AND rutas.destino = temporal.ciudadDestino 
	AND temporal.tipo_servicio = rutas.tipo_servicio 
	JOIN JUST_DO_IT.Aeronaves AS aeronaves
	ON temporal.aeronave_matricula = aeronaves.matricula AND temporal.aeronave_fabricante = aeronaves.fabricante
	JOIN JUST_DO_IT.Vuelos AS vuelos
	ON temporal.fechaLlegada = vuelos.fecha_llegada AND temporal.fechaSalida = vuelos.fecha_salida 
	AND vuelos.aeronave_id = aeronaves.id AND rutas.id = vuelos.ruta_id 
/*************************/

INSERT INTO JUST_DO_IT.Compras(comprador, fecha_compra, medio_de_pago, monto, cuotas, encomienda)
	SELECT DISTINCT t2.usuario_id, t1.fecha_compra, 1, t1.precio, 1, 1
		FROM #temporalParaPaquete t1
		JOIN #temporalUsuariosPaquete t2
		ON t1.temporalPaquete_id = t2.temporalPaquete_id

SET IDENTITY_INSERT JUST_DO_IT.Paquetes ON
INSERT INTO JUST_DO_IT.Paquetes(codigo, fecha_compra, kg, precio, vuelo_id, compra)
	SELECT DISTINCT t1.codigo, t1.fecha_compra, t1.kg, t1.precio, t1.vuelo_id, compras.codigo
	FROM #temporalParaPaquete t1
	JOIN #temporalUsuariosPaquete t2
	ON t1.temporalPaquete_id = t2.temporalPaquete_id
	JOIN JUST_DO_IT.Compras compras
	ON compras.encomienda = 1 
	AND compras.comprador = t2.usuario_id AND compras.monto = t1.precio AND compras.fecha_compra = t1.fecha_compra		
SET IDENTITY_INSERT JUST_DO_IT.Paquetes OFF

GO
CREATE NONCLUSTERED INDEX [<IndicePaquetes, JUST_DO_IT,>]
ON JUST_DO_IT.Paquetes ([codigo],[compra])
INCLUDE ([precio],[vuelo_id],[kg],[fecha_compra])
GO

INSERT INTO JUST_DO_IT.Puntos(millas, vencimiento, usuario_id, vuelo_id, validos)
	SELECT (pasajes.precio * 0.1), DATEADD(year, 1, pasajes.fecha_compra), compras.comprador , pasajes.vuelo_id, 1
		FROM JUST_DO_IT.Pasajes AS pasajes, JUST_DO_IT.Compras AS compras
		 WHERE pasajes.compra = compras.codigo

GO

--Funcionalidades
INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) VALUES ('Puede loguearse')
INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) VALUES ('Puede habilitar aeronaves')
INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) VALUES ('Puede deshabilitar aeronaves')
INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) VALUES ('Puede agregar roles')
INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) VALUES ('Puede eliminar funcionalidades')
INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) VALUES ('Puede deshabilitar roles')

-- Funcionalidades que posee un rol
INSERT INTO JUST_DO_IT.Rol_Funcionalidad(id_funcionalidad, id_rol) VALUES (1, 1)

GO

CREATE FUNCTION JUST_DO_IT.butacasLibres(@Vuelo NUMERIC(18,0))
RETURNS TABLE
AS RETURN
	SELECT DISTINCT butacas.id id, butacas.numero numero, butacas.tipo tipo, butacas.aeronave_id aeronave
		FROM JUST_DO_IT.Butacas butacas
		JOIN JUST_DO_IT.Vuelos vuelos
		ON vuelos.id = @Vuelo AND vuelos.aeronave_id = butacas.aeronave_id 
		AND NOT EXISTS (SELECT @Vuelo
							FROM JUST_DO_IT.Pasajes pasajes
							LEFT JOIN JUST_DO_IT.ButacasReservadas reservadas
							ON pasajes.vuelo_id = reservadas.vuelo_id 
							WHERE pasajes.vuelo_id = @Vuelo
								AND (pasajes.butaca = butacas.id OR reservadas.butaca_id = butacas.id)
								AND pasajes.cancelado = 0)
								
GO 

CREATE FUNCTION JUST_DO_IT.KGsDisponibles(@Vuelo NUMERIC(18,0))
RETURNS NUMERIC(18,0)
AS BEGIN
	DECLARE @ocupados NUMERIC(18,0)
	DECLARE @maximo NUMERIC(18,0)
	SELECT  @ocupados = SUM(paquetes.kg)
		FROM JUST_DO_IT.Paquetes paquetes
		WHERE paquetes.vuelo_id = @Vuelo
		GROUP BY paquetes.vuelo_id

	SELECT @maximo = aeronaves.kgs_disponibles
	FROM JUST_DO_IT.Vuelos vuelos, JUST_DO_IT.Aeronaves aeronaves
	WHERE vuelos.id = @vuelo AND vuelos.aeronave_id = aeronaves.id

	RETURN @maximo - @ocupados
END		
					
GO 

UPDATE JUST_DO_IT.Vuelos 
SET cantidadDisponible = (SELECT COUNT(butacas.numero) 
						FROM JUST_DO_IT.butacasLibres(JUST_DO_IT.Vuelos.id) butacas
						GROUP BY butacas.aeronave)

UPDATE JUST_DO_IT.Vuelos 
SET KGsDisponibles = (SELECT JUST_DO_IT.KGsDisponibles(JUST_DO_IT.Vuelos.id))

GO

CREATE PROCEDURE JUST_DO_IT.actualizarCliente(@Usuario NUMERIC(18,0), @Mail NVARCHAR(255), @Direccion NVARCHAR(255), @Telefono NUMERIC(18,0))
AS BEGIN
	UPDATE JUST_DO_IT.Usuarios
		SET mail = @Mail, direccion = @Direccion, telefono = @Telefono
		WHERE id = @Usuario
END

GO

CREATE PROCEDURE JUST_DO_IT.almacenarCliente(@dni NUMERIC(18,0), @nombre VARCHAR(255), @apellido VARCHAR(255),
											@mail VARCHAR(255), @direccion VARCHAR(255), @telefono NUMERIC(18,0),
											@fechaNacimiento DATETIME)
AS BEGIN
	DECLARE @id NUMERIC(18,0)
	SELECT @id = id FROM JUST_DO_IT.Usuarios WHERE dni = @dni AND nombre = @nombre AND apellido = @apellido
	IF (@id IS NOT NULL)
		RAISERROR('Ya existe un cliente con el dni, nombre y apellido ingresados',16,217) WITH SETERROR

	BEGIN TRANSACTION agregarCliente
	BEGIN TRY
		INSERT INTO JUST_DO_IT.Usuarios(dni, apellido, nombre, mail, direccion, telefono, fecha_nacimiento, username, pass)
			VALUES(@dni, @apellido, @nombre, @mail, @direccion, @telefono, @fechaNacimiento,
			CONCAT(@dni, @nombre, @apellido), HASHBYTES('SHA2_256', ''))

		INSERT INTO JUST_DO_IT.Usuario_Rol(id_usuario, id_rol) 
			VALUES(@@IDENTITY, 2)
		COMMIT TRANSACTION agregarCliente
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION agregarCliente
		RAISERROR('No se pudo crear al cliente nuevo',16,217) WITH SETERROR
	END CATCH
END

GO

CREATE FUNCTION JUST_DO_IT.obtenerIDUsuario(@dni NUMERIC(18,0), @apellido VARCHAR(255), @nombre VARCHAR(255))
RETURNS NUMERIC(18,0)
AS BEGIN
	RETURN (SELECT id FROM JUST_DO_IT.Usuarios WHERE dni = @dni AND apellido = @apellido AND nombre = @nombre)
END

GO

CREATE PROCEDURE JUST_DO_IT.LoguearUsuario(@username VARCHAR(255), @pass VARCHAR(255))
AS BEGIN
	DECLARE @usuario NUMERIC(18,0)
	DECLARE @intentos INT
	SELECT @intentos = intentos FROM JUST_DO_IT.IntentosFallidos i
								JOIN JUST_DO_IT.Usuarios u ON i.usuario_id = u.id
								WHERE u.username = @username
	IF (@intentos >= 3)
		RAISERROR('El usuario se encuentra bloqueado por tener 3 intentos de logueo fallidos',16,217) WITH SETERROR
			
	SELECT @usuario = id FROM JUST_DO_IT.Usuarios WHERE username = @username AND pass = HASHBYTES('SHA2_256', @pass)
	IF (@usuario IS NULL)
	BEGIN	
		UPDATE intentos SET intentos = @intentos + 1 
		FROM JUST_DO_IT.Usuarios usuarios
		JOIN JUST_DO_IT.IntentosFallidos intentos ON intentos.usuario_id = usuarios.id
		WHERE usuarios.username = @username
		RAISERROR('Los datos ingresados no son validos',16,217) WITH SETERROR
	END
	ELSE
	BEGIN
		IF NOT EXISTS (SELECT * FROM JUST_DO_IT.Usuario_Rol 
						JOIN JUST_DO_IT.Roles ON id = id_rol
						WHERE nombre = 'Administrativo' AND @usuario = id_usuario)
			RAISERROR('El usuario no tiene los permisos necesarios',16,217) WITH SETERROR
	END
	UPDATE intentos SET intentos = 0 
	FROM JUST_DO_IT.Usuarios usuarios
	JOIN JUST_DO_IT.IntentosFallidos intentos ON intentos.usuario_id = usuarios.id
	WHERE usuarios.username = @username
END

GO

CREATE PROCEDURE JUST_DO_IT.almacenarPasaje(@Vuelo NUMERIC(18,0), @Costo NUMERIC(18,2), @Comprador NUMERIC(18,0),
											@NumeroTarjeta NUMERIC(18,0), @CodigoTarjeta NUMERIC(18,0),
											@VencimientoTarjeta NUMERIC(18,0), @Cuotas NUMERIC(18,0),
											@MedioDePago NUMERIC(18,0), @KGs NUMERIC(18,2), 
											@EsEncomienda BIT)
AS BEGIN
	BEGIN TRANSACTION almacenarPasaje
	DECLARE @error BIT
	SET @error = 1
	BEGIN TRY
		DECLARE @CantidadPasajes INT
		DECLARE @CostoKG NUMERIC(18,0)

		IF (@Costo > 0)
		BEGIN
			SELECT @CantidadPasajes = COUNT(*) FROM JUST_DO_IT.ButacasReservadas 
								WHERE vuelo_id = @Vuelo GROUP BY vuelo_id
		END
		ELSE
			SET @CantidadPasajes = 0

		SELECT @CostoKG = r.precio_baseKG
		FROM JUST_DO_IT.Vuelos v, JUST_DO_IT.Rutas r
		WHERE v.id = @Vuelo AND v.ruta_id = r.id
		INSERT INTO JUST_DO_IT.Compras(comprador, medio_de_pago, monto, fecha_compra, numero_tarjeta, codigo_seguridad, vencimiento, cuotas)
			VALUES(@Comprador, @MedioDePago, @Costo * @CantidadPasajes + @KGs * @CostoKG, 
			GETDATE(),@NumeroTarjeta, @CodigoTarjeta, @VencimientoTarjeta, @Cuotas)

		DECLARE @compra_id INT
		SELECT @compra_id = @@IDENTITY

		IF (@KGs < 0)
		BEGIN
			SET @error = 0
			RAISERROR('La cantidad de KGs ingresada para encomienda debe ser positiva',16,217) WITH SETERROR
		END
		IF (@KGs <> 0)
		BEGIN
			DECLARE @KGsDisponibles NUMERIC(18,2)
			SELECT @KGsDisponibles = vuelos.KGsDisponibles
			FROM JUST_DO_IT.Vuelos vuelos 
			WHERE vuelos.id = @Vuelo
			IF (@KGs > @KGsDisponibles)
			BEGIN
				SET @error = 0
				RAISERROR('La cantidad de KGs ingresada supera la disponible',16,217) WITH SETERROR
			END
			UPDATE JUST_DO_IT.Vuelos SET KGsDisponibles = KGsDisponibles - @KGs
				WHERE id = @Vuelo
			INSERT INTO JUST_DO_IT.Paquetes(vuelo_id,compra,fecha_compra,kg,precio)
				VALUES(@Vuelo, @compra_id, GETDATE(), @KGs, @KGs * @CostoKG)
		END

		IF (@EsEncomienda = 0)
		BEGIN
			DECLARE @CantidadAOcupar NUMERIC(18,0)
			SELECT @CantidadAOcupar = COUNT(*) FROM JUST_DO_IT.ButacasReservadas WHERE vuelo_id = @Vuelo

			UPDATE JUST_DO_IT.Vuelos SET cantidadDisponible = cantidadDisponible - @CantidadAOcupar
				WHERE id = @Vuelo

			INSERT INTO JUST_DO_IT.Pasajes(vuelo_id, compra, fecha_compra, precio, pasajero, butaca)
				SELECT @Vuelo, @compra_id, GETDATE(), @Costo, reservadas.usuario_id, reservadas.butaca_id
					FROM JUST_DO_IT.ButacasReservadas reservadas
						WHERE reservadas.vuelo_id = @Vuelo
		
			DELETE FROM JUST_DO_IT.ButacasReservadas WHERE vuelo_id = @Vuelo
		END

		INSERT INTO JUST_DO_IT.Puntos(millas, vencimiento, usuario_id, vuelo_id)
			VALUES ((@Costo * @CantidadPasajes + @KGs * @CostoKG) * 0.1, DATEADD(year, 1, GETDATE()), @Comprador, @Vuelo)

		COMMIT TRANSACTION almacenarPasaje	
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION almacenarPasaje
		IF (@error = 1)
			RAISERROR('El pasaje no pudo ser almacenado',16,217) WITH SETERROR
		ELSE
		BEGIN
			DECLARE @ErrorMessage VARCHAR(255)
			SET @ErrorMessage = ERROR_MESSAGE()
			RAISERROR(@ErrorMessage,16,217) WITH SETERROR
		END
	END CATCH	
END 

GO

CREATE PROCEDURE JUST_DO_IT.reservarButaca(@usuario NUMERIC(18,0), @vuelo NUMERIC(18,0), @butaca NUMERIC(18,0))
AS BEGIN
	INSERT INTO JUST_DO_IT.ButacasReservadas(usuario_id, vuelo_id, butaca_id)
		VALUES(@usuario, @vuelo, @butaca)
END

GO

CREATE FUNCTION JUST_DO_IT.IDMedioDePago(@Nombre varchar(255))
RETURNS int 
AS
BEGIN
    DECLARE @id int;
    SELECT @id = id
	FROM JUST_DO_IT.MediosDePago 
    WHERE nombre LIKE @Nombre
    RETURN @id;
END

GO

CREATE FUNCTION JUST_DO_IT.IDCiudad(@Ciudad varchar(255))
RETURNS int 
AS
BEGIN
    DECLARE @id int;
    SELECT @id = id
	FROM JUST_DO_IT.Ciudades 
    WHERE nombre LIKE @Ciudad
    RETURN @id;
END

GO

CREATE FUNCTION JUST_DO_IT.IDTipoDeServicio(@Nombre varchar(255))
RETURNS int 
AS
BEGIN
    DECLARE @id int;
    SELECT @id = id
	FROM JUST_DO_IT.TiposServicios 
    WHERE nombre LIKE @Nombre
    RETURN @id;
END

GO

CREATE FUNCTION JUST_DO_IT.NombreTipoDeServicio(@id NUMERIC(18,0))
RETURNS VARCHAR(255) 
AS
BEGIN
    DECLARE @nombre VARCHAR(255);
    SELECT @nombre = nombre
	FROM JUST_DO_IT.TiposServicios 
    WHERE id = @id
    RETURN @nombre;
END

GO

CREATE FUNCTION JUST_DO_IT.NombreCiudad(@id NUMERIC(18,0))
RETURNS VARCHAR(255) 
AS
BEGIN
    DECLARE @nombre VARCHAR(255);
    SELECT @nombre = nombre
	FROM JUST_DO_IT.Ciudades 
    WHERE id = @id
    RETURN @nombre;
END

GO

CREATE FUNCTION JUST_DO_IT.vuelosDisponibles(@Origen NUMERIC(18,0), @Destino NUMERIC(18,0), @Salida DATETIME)
RETURNS TABLE
AS RETURN
	SELECT vuelos.id AS vuelo, vuelos.cantidadDisponible AS cantidad, vuelos.KGsDisponibles AS kgsDisponibles, 
	vuelos.fecha_salida AS salida, vuelos.fecha_llegada_estimada AS llegada, tipos.nombre AS tipoServicio, (rutas.precio_basePasaje * tipos.costo_adicional) AS costoViaje,
	rutas.precio_baseKG AS costoEncomienda
	FROM JUST_DO_IT.Vuelos vuelos
	JOIN JUST_DO_IT.Rutas rutas
	ON rutas.id = vuelos.ruta_id AND rutas.ciu_id_origen = @Origen AND rutas.ciu_id_destino = @Destino 
		AND CAST(vuelos.fecha_salida AS date) = @Salida
	JOIN JUST_DO_IT.Aeronaves aeronaves
	ON aeronaves.id = vuelos.aeronave_id
	JOIN JUST_DO_IT.TiposServicios tipos
	ON tipos.id = aeronaves.tipo_servicio
	WHERE vuelo_eliminado = 0

GO

CREATE PROCEDURE JUST_DO_IT.almacenarRuta(@Codigo NUMERIC(18,0), @PrecioKgs NUMERIC(18,2), @PrecioPasaje NUMERIC(18,2),
	@Origen NUMERIC(18,0), @Destino NUMERIC(18,0), @TipoServicio NUMERIC(18,0))
AS BEGIN
	IF (@PrecioKgs > 0 AND  @PrecioPasaje > 0 AND @Origen <> @Destino)
		IF (NOT EXISTS (SELECT * FROM JUST_DO_IT.Rutas 
			WHERE codigo = @Codigo AND precio_baseKG = @PrecioKgs AND precio_basePasaje = @PrecioPasaje 
				AND ciu_id_origen = @Origen AND ciu_id_destino = @Destino AND tipo_servicio = @TipoServicio))
		BEGIN
			INSERT INTO JUST_DO_IT.Rutas(codigo, precio_baseKG, precio_basePasaje, ciu_id_origen, ciu_id_destino, tipo_servicio) 
				VALUES(@Codigo, @PrecioKgs, @PrecioPasaje, @Origen, @Destino, @TipoServicio)
		END ELSE
			RAISERROR('La ruta ingresada ya existe',16,217) WITH SETERROR
	ELSE 
		RAISERROR('Los precios tienen que ser validos y la ciudad origen debe ser distinta a la de destino',16,217) WITH SETERROR

END

GO


CREATE PROCEDURE JUST_DO_IT.almacenarAeronave(@matricula NVARCHAR(255), @modelo NVARCHAR(255), @fabricante NVARCHAR(255), @tipo_servicio NUMERIC(18,0), @kgs_disponibles NUMERIC(18,2), @cant_butacas NUMERIC(18,0))
AS BEGIN
	IF (@kgs_disponibles >= 0)
		IF (NOT EXISTS (SELECT * FROM JUST_DO_IT.Aeronaves
			WHERE matricula = matricula AND modelo = @modelo AND fabricante = @fabricante AND tipo_servicio = @tipo_servicio
				AND kgs_disponibles = @kgs_disponibles AND butacas_totales = @cant_butacas))
		BEGIN
			INSERT INTO JUST_DO_IT.Aeronaves(matricula, modelo, fabricante, tipo_servicio, kgs_disponibles, butacas_totales, fecha_alta)
				VALUES(@matricula, @modelo, @fabricante, @tipo_servicio, @kgs_disponibles, @cant_butacas, GETDATE())
		END ELSE
			RAISERROR('La aeronave ingresada ya existe',16,217) WITH SETERROR
	ELSE 
		RAISERROR('No se pudo agregar la aeronave',16,217) WITH SETERROR

END 

GO

CREATE PROCEDURE JUST_DO_IT.modificarAeronave(@id NUMERIC(18,0), @matricula NVARCHAR(255), @modelo NVARCHAR(255), @fabricante NVARCHAR(255),
	@tipo_servicio NUMERIC(18,0), @kgs_disponibles NUMERIC(18,2), @cant_butacas NUMERIC(18,0))
AS BEGIN
	IF (@kgs_disponibles >= 0)
		BEGIN TRY
			UPDATE JUST_DO_IT.Aeronaves
				SET matricula = @matricula, modelo = @modelo, fabricante = @fabricante, tipo_servicio = @tipo_servicio, 
				kgs_disponibles = @kgs_disponibles, butacas_totales = @cant_butacas
				WHERE Aeronaves.id = @id
		END TRY
		BEGIN CATCH
			RAISERROR('Fallo la actualización de la aeronave',16,217) WITH SETERROR
		END CATCH
	ELSE 
		RAISERROR('La cantidad de kilogramos disponibles no puede ser menor a cero, no se actualizo la aeronave',16,217) WITH SETERROR

END 

GO

CREATE FUNCTION JUST_DO_IT.aeronavesDisponiblesParaVuelos(@Salida DATETIME, @LlegadaEstimada DATETIME)
RETURNS TABLE
AS RETURN
	SELECT aeronaves.* FROM JUST_DO_IT.Aeronaves AS aeronaves 
	WHERE aeronaves.id NOT IN 
		(SELECT aeronave_id FROM JUST_DO_IT.Vuelos 
		WHERE ((@Salida < fecha_salida AND @LlegadaEstimada > fecha_salida)
			   OR (@Salida > fecha_salida AND @Salida < fecha_llegada_estimada))
		GROUP BY aeronave_id)

GO

------------ Funcionalidades ------------

CREATE PROCEDURE JUST_DO_IT.almacenarFuncionalidad(@Descripcion VARCHAR(255))
AS BEGIN
		BEGIN TRY
			INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) 
				VALUES(@Descripcion)
		END TRY
		BEGIN CATCH
			RAISERROR('La funcionalidad ingresada ya existe',16,217) WITH SETERROR
		END CATCH
END

GO

CREATE FUNCTION JUST_DO_IT.cantidadDeFuncionalidades(@rol NUMERIC(18,0))
RETURNS INT
AS BEGIN
	RETURN (SELECT COUNT(*) FROM JUST_DO_IT.Rol_Funcionalidad WHERE id_rol = @rol)
END

GO

CREATE PROCEDURE JUST_DO_IT.eliminarFuncionalidad(@Descripcion VARCHAR(255))
AS BEGIN
	DECLARE @funcionalidad NUMERIC(18,0)
	SELECT @funcionalidad = id FROM JUST_DO_IT.Funcionalidades WHERE descripcion = @Descripcion

	IF (NOT EXISTS
			(SELECT * FROM JUST_DO_IT.Roles r
			JOIN JUST_DO_IT.Rol_Funcionalidad rf ON r.id = rf.id_rol
			WHERE rf.id_funcionalidad = @funcionalidad AND JUST_DO_IT.cantidadDeFuncionalidades(r.id) = 1))
		UPDATE JUST_DO_IT.Funcionalidades SET eliminada = 1 WHERE descripcion LIKE @Descripcion
	ELSE
		RAISERROR('No pueden quedar roles sin funcionalidades',16,217) WITH SETERROR
	
END
GO

CREATE FUNCTION JUST_DO_IT.nombresRolesYFuncionalidades(@idRol NUMERIC(18,0))
RETURNS TABLE
AS RETURN
	SELECT F.descripcion AS nombreFuncionalidad
	FROM JUST_DO_IT.Funcionalidades AS F, JUST_DO_IT.Rol_Funcionalidad AS RF
	WHERE RF.id_rol = @idRol AND F.id = RF .id_funcionalidad AND f.eliminada = 0
		
GO

CREATE FUNCTION JUST_DO_IT.cantFuncionalidadQuePosee(@idRol NUMERIC(18,0))
RETURNS int 
AS
BEGIN
    DECLARE @cantDeFuncionalidades int;
	SELECT @cantDeFuncionalidades = COUNT(*) FROM JUST_DO_IT.nombresRolesYFuncionalidades(@idRol)
    RETURN @cantDeFuncionalidades;
END

GO


CREATE PROCEDURE JUST_DO_IT.existeFuncionalidad(@descrFuncionalidad NVARCHAR(255))
AS BEGIN
		DECLARE @existe INT = 0;
		SELECT @existe = COUNT(*) FROM JUST_DO_IT.Funcionalidades AS F WHERE F.descripcion LIKE @descrFuncionalidad
		IF (@existe = 0)
			RAISERROR('La funcionalidad ingresada no existe',16,217) WITH SETERROR
END

GO


CREATE FUNCTION JUST_DO_IT.IDFuncionalidad(@Descripcion nvarchar(255))
RETURNS int 
AS
BEGIN
    DECLARE @id int;
    SELECT @id = id
	FROM JUST_DO_IT.Funcionalidades
    WHERE descripcion LIKE @Descripcion
	RETURN @id;

END

GO
------------- Roles -------------

CREATE FUNCTION JUST_DO_IT.IDRol(@Nombre varchar(255))
RETURNS int 
AS
BEGIN
    DECLARE @id int;
    SELECT @id = id
	FROM JUST_DO_IT.Roles 
    WHERE nombre LIKE @Nombre
	RETURN @id;
END

GO


CREATE PROCEDURE JUST_DO_IT.almacenarRol(@Nombre VARCHAR(50), @funcionalidad NUMERIC(18,0))
AS BEGIN
	BEGIN TRANSACTION guardarRol
	BEGIN TRY
		INSERT INTO JUST_DO_IT.Roles VALUES(@Nombre, 0)
		INSERT INTO JUST_DO_IT.Rol_Funcionalidad(id_funcionalidad, id_rol)
			VALUES(@funcionalidad, @@IDENTITY)
		COMMIT TRANSACTION guardarRol
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION guardarRol
		RAISERROR('El rol ingresado ya existe',16,217) WITH SETERROR
	END CATCH
END

GO

CREATE PROCEDURE JUST_DO_IT.almacenarRol_Funcionalidad(@IdRol NUMERIC(18,0), @IdFuncionalidad NUMERIC(18,0))
AS BEGIN
	BEGIN TRY
		DECLARE @estaRepetido BIT;
		SELECT @estaRepetido = COUNT(*) FROM JUST_DO_IT.Rol_Funcionalidad where id_rol = @IdRol AND id_funcionalidad = @IdFuncionalidad

		IF(@estaRepetido=0)
			INSERT INTO JUST_DO_IT.Rol_Funcionalidad(id_rol, id_funcionalidad) VALUES(@IdRol,@IdFuncionalidad);
		ELSE 
			RAISERROR('La funcionalidad ingresada ya existe para ese rol',16,217) WITH SETERROR

	END TRY
	BEGIN CATCH
		RAISERROR('La funcionalidad ingresada ya existe para ese rol',16,217) WITH SETERROR
	END CATCH
END
GO

CREATE PROCEDURE JUST_DO_IT.bajaRol(@nombre VARCHAR(50))
AS BEGIN
	DECLARE @idRol INT;
	BEGIN TRY
		SELECT @idRol = R.id FROM JUST_DO_IT.Roles AS R WHERE R.nombre LIKE @nombre;
		UPDATE JUST_DO_IT.Roles SET baja_rol = 1 WHERE nombre = @nombre
		
		-- Eliminar el rol para los usuarios que lo poseen
		DELETE FROM JUST_DO_IT.Usuario_Rol WHERE id_rol = @idRol
	END TRY
	BEGIN CATCH
		RAISERROR('Fallo la baja de rol',16,217) WITH SETERROR
	END CATCH
END 
GO

CREATE PROCEDURE JUST_DO_IT.altaRolExistente(@nombre VARCHAR(50))
AS BEGIN
	BEGIN TRY
		DECLARE @estaDadoDeBaja BIT
		SELECT @estaDadoDeBaja=baja_rol FROM JUST_DO_IT.Roles WHERE nombre = @nombre

		IF( @estaDadoDeBaja = 1)
			UPDATE JUST_DO_IT.Roles SET baja_rol = 0 WHERE nombre = @nombre
	END TRY
	BEGIN CATCH
		RAISERROR('El rol ya se encontraba habilitado',16,217) WITH SETERROR
	END CATCH
END 
GO


CREATE PROCEDURE JUST_DO_IT.modificarNombreRol(@idRol NUMERIC(18,0),@nombreNuevo VARCHAR(50))
AS BEGIN
	BEGIN TRY
		UPDATE JUST_DO_IT.Roles SET nombre = @nombreNuevo WHERE id = @idRol
	END TRY
	BEGIN CATCH
		RAISERROR('Fallo la modificación del nombre',16,217) WITH SETERROR
	END CATCH
END 

GO

CREATE PROCEDURE JUST_DO_IT.bajaRol_Funcionalidad(@idRol NUMERIC(18,0),@idFuncionalidad NUMERIC(18,0))
AS BEGIN
	BEGIN TRY
		DELETE FROM JUST_DO_IT.Rol_Funcionalidad WHERE id_rol = @idRol AND id_funcionalidad = @idFuncionalidad
	END TRY
	BEGIN CATCH
		RAISERROR('Fallo la baja de la funcionalidad',16,217) WITH SETERROR
	END CATCH
END 
GO

CREATE PROCEDURE JUST_DO_IT.existeRol(@nombre VARCHAR(50))
AS BEGIN
	DECLARE @existe INT;
	BEGIN TRY
		SELECT @existe = COUNT(*) from JUST_DO_IT.Roles  AS R WHERE R.nombre LIKE @nombre
		IF (@existe = 0 )
			RAISERROR('El rol no existe',16,217) WITH SETERROR
	END TRY
	BEGIN CATCH
		RAISERROR('El rol no existe',16,217) WITH SETERROR
	END CATCH
END 
GO

CREATE PROCEDURE JUST_DO_IT.estabaDadoDeBajaElRol(@nombre VARCHAR(50))
AS BEGIN
	DECLARE @existe INT;
	BEGIN TRY
		SELECT @existe = R.baja_rol from JUST_DO_IT.Roles  AS R WHERE R.nombre LIKE @nombre
		IF (@existe = 0 )
			RAISERROR('El rol que seleccionó se encontraba habilitado',16,217) WITH SETERROR
	END TRY
	BEGIN CATCH
		RAISERROR('El rol no se encuentra inhabilitado',16,217) WITH SETERROR
	END CATCH
END 
GO

------------------- Roles y usuarios ----------------------

CREATE PROCEDURE JUST_DO_IT.asignarRolAUsuario(@IdRol NUMERIC(18,0), @id_usuario NUMERIC(18,0))
AS BEGIN
	BEGIN TRY
		DECLARE @estaRepetido BIT;
		SELECT @estaRepetido = COUNT(*) FROM JUST_DO_IT.Usuario_Rol AS U where id_rol = @IdRol AND U.id_usuario = @id_usuario

		IF(@estaRepetido=0)
			INSERT INTO JUST_DO_IT.Usuario_Rol(id_rol, id_usuario) VALUES(@IdRol,@id_usuario);
		ELSE 
			RAISERROR('Error. El usuario ya poseía con anterioridad dicho rol',16,217) WITH SETERROR

	END TRY
	BEGIN CATCH
		RAISERROR('Error. El usuario ya poseía con anterioridad dicho rol',16,217) WITH SETERROR
	END CATCH
END
GO

CREATE FUNCTION JUST_DO_IT.ListadoUsuarios()
RETURNS TABLE
AS RETURN
	SELECT usuarios.nombre AS nombre, usuarios.apellido AS apellido, usuarios.dni AS dni
	FROM JUST_DO_IT.Usuarios AS usuarios
GO

CREATE FUNCTION JUST_DO_IT.BuscarUsuario(@nombre NVARCHAR(255), @apellido NVARCHAR(255), @dni NUMERIC(18,0))
RETURNS TABLE
AS RETURN
	SELECT usuarios.id AS id 
	FROM JUST_DO_IT.Usuarios AS usuarios
	WHERE usuarios.apellido LIKE @apellido AND usuarios.nombre LIKE @nombre AND usuarios.dni LIKE @dni
GO



-----------------------------------------

CREATE PROCEDURE JUST_DO_IT.almacenarVuelo(@FechaSalida DATETIME, @FechaLlegadaEstimada DATETIME, @RutaID NUMERIC(18,0), @AeronaveId NUMERIC(18,0), @CantidadDisponible NUMERIC(18,0), @RutaTipo VARCHAR(255), @AeronaveTipo VARCHAR(255), @KGsDisponibles NUMERIC(18,2))
AS BEGIN
	IF @AeronaveTipo = @RutaTipo
		BEGIN
			INSERT INTO JUST_DO_IT.Vuelos(fecha_salida, fecha_llegada_estimada, ruta_id, aeronave_id, cantidadDisponible, KGsDisponibles)
				VALUES(@FechaSalida, @FechaLlegadaEstimada, @RutaID, @AeronaveId, @CantidadDisponible, @KGsDisponibles)
		END
	ELSE
		RAISERROR('El servicio de la ruta debe ser el mismo que el de la aeronave',16,217) WITH SETERROR
END

GO



CREATE FUNCTION JUST_DO_IT.obtener_id_aeronave_segun_matricula(@matricula NVARCHAR(255))
RETURNS NUMERIC(18,0)
AS
BEGIN
	DECLARE @retorno NUMERIC(18,0)
	SELECT @retorno = (SELECT aeronaves.id
						FROM JUST_DO_IT.Aeronaves AS aeronaves
						WHERE aeronaves.matricula = @matricula)
	RETURN @retorno
END

GO

CREATE PROCEDURE JUST_DO_IT.eliminar_vuelos(@id_vuelo NUMERIC(18,0))
AS BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			UPDATE JUST_DO_IT.Vuelos	
			SET vuelo_eliminado = 1
			WHERE id = @id_vuelo
		
			UPDATE pas
			SET pas.cancelado = 1
			FROM JUST_DO_IT.Pasajes pas
			WHERE pas.vuelo_id = @id_vuelo

			UPDATE paq
			SET paq.cancelado = 1
			FROM JUST_DO_IT.Pasajes paq
			WHERE paq.vuelo_id = @id_vuelo

			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			RAISERROR('No se ha podido eliminar los vuelos con sus pasajes y encomiendas',16,217) WITH SETERROR
		END CATCH
END

GO

CREATE FUNCTION JUST_DO_IT.obtener_vuelos_segun_id_aeronave(@idAeronave NUMERIC(18,0))
RETURNS TABLE
AS RETURN
	SELECT vuelos.id AS vuelos 
	FROM JUST_DO_IT.Vuelos vuelos 
	WHERE vuelos.fecha_llegada IS NULL 
		AND vuelos.fecha_salida > CURRENT_TIMESTAMP 
		AND vuelos.vuelo_eliminado = 0 
		AND vuelos.aeronave_id = @idAeronave				
GO 

CREATE FUNCTION JUST_DO_IT.obtener_vuelos_segun_id_aeronave_y_fechas(@idAeronave NUMERIC(18,0), @fecha_fuera_servicio DATETIME, @fecha_reinicio_servicio DATETIME)
RETURNS TABLE
AS RETURN
	SELECT vuelos.id vuelos
	FROM JUST_DO_IT.Vuelos AS vuelos 
	WHERE ((@fecha_fuera_servicio BETWEEN vuelos.fecha_salida AND vuelos.fecha_llegada_estimada) OR 
			(@fecha_reinicio_servicio BETWEEN vuelos.fecha_salida AND vuelos.fecha_llegada_estimada) OR
			(@fecha_fuera_servicio < vuelos.fecha_salida AND @fecha_reinicio_servicio > vuelos.fecha_llegada_estimada)) 
				AND vuelos.vuelo_eliminado = 0 AND vuelos.aeronave_id = 3
GO



CREATE PROCEDURE JUST_DO_IT.dar_de_baja_aeronave_por_fuera_de_servicio(@matricula NVARCHAR(255), @fecha_fuera_servicio DATETIME, @fecha_reinicio_servicio DATETIME)
AS BEGIN
	IF (@fecha_fuera_servicio <= @fecha_reinicio_servicio  AND @fecha_fuera_servicio >= CONVERT(DATETIME, CONVERT(DATE, CURRENT_TIMESTAMP)))
		UPDATE JUST_DO_IT.Aeronaves
		SET baja_fuera_servicio = 1, fecha_fuera_servicio = @fecha_fuera_servicio, fecha_reinicio_servicio = @fecha_reinicio_servicio
		WHERE matricula = @matricula
	ELSE
		RAISERROR('Fallo la baja de Aeronave',16,217) WITH SETERROR
END

GO

CREATE FUNCTION JUST_DO_IT.EstaDisponibleParaElVuelo(@aeronave NUMERIC(18,0), @aeronave_a_reemplazar NUMERIC(18,0), @vueloId NUMERIC(18,0))
RETURNS BIT
AS BEGIN
	IF (EXISTS(SELECT 1
	FROM JUST_DO_IT.Vuelos vuelosAeronaveNueva, JUST_DO_IT.Vuelos vueloAeronaveVieja, JUST_DO_IT.Aeronaves aeronave_vieja, JUST_DO_IT.Aeronaves aeronave_nueva
	WHERE vuelosAeronaveNueva.aeronave_id = @aeronave
		AND vueloAeronaveVieja.id = @vueloId AND aeronave_vieja.id = @aeronave_a_reemplazar AND aeronave_nueva.id = @aeronave
		AND aeronave_vieja.tipo_servicio = aeronave_nueva.tipo_servicio AND aeronave_vieja.fabricante = aeronave_nueva.fabricante AND
			((vuelosAeronaveNueva.fecha_salida <= vueloAeronaveVieja.fecha_salida AND vuelosAeronaveNueva.fecha_llegada_estimada <= vueloAeronaveVieja.fecha_salida)
			OR
			(vuelosAeronaveNueva.fecha_salida >= vueloAeronaveVieja.fecha_salida AND vuelosAeronaveNueva.fecha_salida >= vueloAeronaveVieja.fecha_llegada_estimada)
			OR
			(vuelosAeronaveNueva.fecha_salida >= vueloAeronaveVieja.fecha_llegada_estimada))

			

	)) RETURN 1
	RETURN 0
END
GO

CREATE FUNCTION JUST_DO_IT.EstaDisponibleParaReemplazar(@aeronave NVARCHAR(255), @aeronaveAReemplazar NVARCHAR(255),@fin_vida_util BIT, @fecha_fin_servicio DATETIME, @fecha_reinicio_servicio DATETIME)
RETURNS BIT
AS BEGIN
	DECLARE @vueloId NUMERIC(18,0)
	DECLARE @idAeronave NUMERIC(18,0)
	SELECT @idAeronave = (SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula(@aeronave))
	DECLARE @idAeronaveAReemplazar NUMERIC(18,0)
	SELECT @idAeronaveAReemplazar = (SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula(@aeronaveAReemplazar))
	IF (@fin_vida_util = 1)
		BEGIN
			DECLARE busqueda CURSOR
			FOR SELECT vuelos.id FROM JUST_DO_IT.Vuelos vuelos
				WHERE vuelos.aeronave_id = @idAeronaveAReemplazar 
					AND vuelos.fecha_salida > CONVERT(DATETIME, CONVERT(DATE, CURRENT_TIMESTAMP))
		END
	ELSE
		BEGIN
			DECLARE busqueda CURSOR
			FOR SELECT vuelos.id FROM JUST_DO_IT.Vuelos vuelos
				WHERE vuelos.aeronave_id = @idAeronaveAReemplazar 
					AND ((@fecha_fin_servicio <= vuelos.fecha_salida AND @fecha_reinicio_servicio >= vuelos.fecha_llegada_estimada) 
					OR (@fecha_fin_servicio >= vuelos.fecha_salida AND @fecha_fin_servicio <= vuelos.fecha_llegada_estimada))			
		END

	OPEN busqueda
	FETCH NEXT FROM busqueda INTO  @vueloId
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF (JUST_DO_IT.EstaDisponibleParaElVuelo(@idAeronave, @idAeronaveAReemplazar, @vueloId) = 0) /* 0 no esta disponible, 1 si */
		BEGIN 
			CLOSE busqueda
			DEALLOCATE busqueda
			RETURN 0
		END
		FETCH NEXT FROM busqueda INTO  @vueloId
	END
	CLOSE busqueda
	DEALLOCATE busqueda
	RETURN 1
END

GO

CREATE FUNCTION JUST_DO_IT.obtener_aeronaves_que_reemplacen_a(@aeronave NVARCHAR(255), @fin_vida_util BIT, @fecha_fin_servicio DATETIME, @fecha_reinicio_servicio DATETIME)
RETURNS TABLE
AS RETURN
	SELECT aeronaves.matricula AS matricula, aeronaves.butacas_totales AS butacas, aeronaves.kgs_disponibles AS kgs,
		tipoServicios.nombre AS tipoServicio, aeronaves.fabricante AS fabricante
	FROM JUST_DO_IT.Aeronaves aeronaves, JUST_DO_IT.TiposServicios tipoServicios
	WHERE aeronaves.tipo_servicio = tipoServicios.id AND
	aeronaves.matricula <> @aeronave AND JUST_DO_IT.EstaDisponibleParaReemplazar(aeronaves.matricula, @aeronave, @fin_vida_util, @fecha_fin_servicio, @fecha_reinicio_servicio) = 1
		AND aeronaves.baja_fuera_servicio = 0 AND aeronaves.baja_vida_util = 0

GO 


CREATE PROCEDURE JUST_DO_IT.reemplazar_vuelos_aeronave_fin_vida_util(@aeronaveVieja NVARCHAR(255), @aeronaveNueva NVARCHAR(255))
AS BEGIN
	DECLARE @idAeronaveVieja NUMERIC(18,0)
	SELECT @idAeronaveVieja = (SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula(@aeronaveVieja))
	DECLARE @idAeronaveNueva NUMERIC(18,0)
	SELECT @idAeronaveNueva = (SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula(@aeronaveNueva))
	BEGIN TRANSACTION reemplazarVuelos
		BEGIN TRY
			UPDATE JUST_DO_IT.Vuelos
				SET aeronave_id = @idAeronaveNueva
				WHERE vuelos.aeronave_id = @idAeronaveVieja
				AND vuelos.fecha_salida > CONVERT(DATETIME, CONVERT(DATE, CURRENT_TIMESTAMP))

			UPDATE JUST_DO_IT.Aeronaves 
				SET baja_vida_util = 1, fecha_baja_definitiva = CURRENT_TIMESTAMP
				WHERE matricula = @aeronaveVieja
			
			COMMIT TRANSACTION reemplazarVuelos
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION reemplazarVuelos
			RAISERROR('No se pudieron reemplazar los vuelos ni dar de baja la aeronave',16,217) WITH SETERROR
		END CATCH
END

GO

CREATE PROCEDURE JUST_DO_IT.reemplazar_vuelos_aeronave_fuera_servicio(@aeronaveVieja NVARCHAR(255), @aeronaveNueva NVARCHAR(255), @fechaFueraServicio DATETIME, @fechaReinicioServicio DATETIME)
AS BEGIN
	DECLARE @idAeronaveVieja NUMERIC(18,0)
	SELECT @idAeronaveVieja = (SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula(@aeronaveVieja))
	DECLARE @idAeronaveNueva NUMERIC(18,0)
	SELECT @idAeronaveNueva = (SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula(@aeronaveNueva))
	BEGIN TRANSACTION reemplazarVuelos
		BEGIN TRY
			UPDATE JUST_DO_IT.Vuelos
				SET aeronave_id = @idAeronaveNueva
				WHERE vuelos.aeronave_id = @idAeronaveVieja 
					AND ((@fechaFueraServicio <= vuelos.fecha_salida AND @fechaReinicioServicio >= vuelos.fecha_llegada_estimada) 
					OR (@fechaFueraServicio >= vuelos.fecha_salida AND @fechaFueraServicio <= vuelos.fecha_llegada_estimada))

			IF (@fechaFueraServicio <= @fechaReinicioServicio  AND @fechaFueraServicio >= CONVERT(DATETIME, CONVERT(DATE, CURRENT_TIMESTAMP)))
				UPDATE JUST_DO_IT.Aeronaves
				SET baja_fuera_servicio = 1, fecha_fuera_servicio = @fechaFueraServicio, fecha_reinicio_servicio = @fechaReinicioServicio
				WHERE id = @idAeronaveVieja
			ELSE
				RAISERROR('La fecha de fuera de servicio debe ser menor a la fecha de reinicio de servicio y mayor a la actual',16,217) WITH SETERROR

			COMMIT TRANSACTION reemplazarVuelos
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION reemplazarVuelos
			RAISERROR('No se pudieron reemplazar los vuelos ni dar de baja la aeronave',16,217) WITH SETERROR
		END CATCH
END

GO


CREATE PROCEDURE JUST_DO_IT.generar_butacas(@matriculaAeronave NVARCHAR(255), @cantidadButacas int)
AS BEGIN
	DECLARE @contador int
	DECLARE @numeroButaca int
	DECLARE @cambioPiso int
	SELECT @contador = 1
	SELECT @numeroButaca = 1
	SELECT @cambioPiso = 0
	DECLARE @idAeronave NUMERIC(18,0)
	SELECT @idAeronave = (SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula(@matriculaAeronave))

	WHILE(@contador <= @cantidadButacas)
	BEGIN
		IF(@contador <= @cantidadButacas/2)
		BEGIN
			IF(@contador % 2 = 0)
			BEGIN
				INSERT INTO JUST_DO_IT.Butacas (numero, piso, tipo, aeronave_id)
				VALUES(@numeroButaca, 1, 'Ventanilla', @idAeronave)
			END
			ELSE
				INSERT INTO JUST_DO_IT.Butacas (numero, piso, tipo, aeronave_id)
				VALUES(@numeroButaca, 1, 'Pasillo', @idAeronave)
		END
		ELSE
		BEGIN
			IF(@contador % 2 = 0)
			BEGIN
				INSERT INTO JUST_DO_IT.Butacas (numero, piso, tipo, aeronave_id)
				VALUES(@numeroButaca, 2, 'Ventanilla', @idAeronave)
			END	
			ELSE
			BEGIN
				INSERT INTO JUST_DO_IT.Butacas (numero, piso, tipo, aeronave_id)
				VALUES(@numeroButaca, 2, 'Pasillo', @idAeronave)
			END
		END

		IF(@contador >= @cantidadButacas / 2 AND @cambioPiso = 0)
		BEGIN
			SET @numeroButaca = 0
			SET @cambioPiso = 1
		END

		SET @contador = @contador + 1;
		SET @numeroButaca = @numeroButaca + 1;
	END
END

GO

CREATE FUNCTION JUST_DO_IT.buscar_vuelo(@aeronave_id NUMERIC(18,0), @ciudad_origen NVARCHAR(255), @ciudad_destino NVARCHAR(255), @fecha_salida DATETIME)
RETURNS NUMERIC(18,0)
AS
BEGIN
	DECLARE @vuelo_id NUMERIC(18,0) 
	
	select @vuelo_id = v.id
	from JUST_DO_IT.Vuelos v
	join JUST_DO_IT.Aeronaves a on v.aeronave_id = @aeronave_id
	join JUST_DO_IT.Rutas r on v.ruta_id = r.id
	join JUST_DO_IT.Ciudades co on r.ciu_id_origen = co.id AND co.nombre = @ciudad_origen
	join JUST_DO_IT.Ciudades cd on r.ciu_id_destino = cd.id AND cd.nombre = @ciudad_destino
	where YEAR(@fecha_salida) = YEAR(v.fecha_salida) AND MONTH(@fecha_salida) = MONTH(v.fecha_salida) AND DAY(@fecha_salida) = DAY(v.fecha_salida) AND v.fecha_llegada IS NULL

	RETURN @vuelo_id
END

GO

CREATE PROCEDURE JUST_DO_IT.registrar_llegada @vuelo_id NUMERIC(18,0), @fecha_llegada DATETIME
AS
BEGIN
	BEGIN TRANSACTION registro
	BEGIN TRY
		UPDATE JUST_DO_IT.Vuelos
		SET fecha_llegada = @fecha_llegada
		where id = @vuelo_id

		UPDATE JUST_DO_IT.Puntos
		SET validos = 1
		WHERE vuelo_id = @vuelo_id

		COMMIT TRANSACTION registro
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION registro
		RAISERROR('No se pudo registrar la llegada del vuelo',16,217) WITH SETERROR
	END CATCH
END

GO

CREATE FUNCTION JUST_DO_IT.AeronavesDisponiblesParaBaja()
RETURNS TABLE
AS  
RETURN
	SELECT matricula
	FROM JUST_DO_IT.Aeronaves 
	WHERE baja_fuera_servicio = 0 AND baja_vida_util = 0

GO

CREATE PROCEDURE JUST_DO_IT.BajarRuta(@Ruta NUMERIC(18,0))
AS BEGIN
	CREATE TABLE #AuxiliarEliminarRuta(
		compra NUMERIC(18,0),
		monto NUMERIC(18,2),
		codigo NUMERIC(18,0),
		tipo VARCHAR(255)
	)
	BEGIN TRY
		BEGIN TRANSACTION bajaRuta
		UPDATE JUST_DO_IT.Rutas SET eliminada = 1
			WHERE id = @Ruta
		
		INSERT INTO #AuxiliarEliminarRuta(compra, monto, codigo, tipo)
		SELECT DISTINCT compra, p.precio, p.codigo, 'Pasaje'
		FROM JUST_DO_IT.Pasajes p, JUST_DO_IT.Vuelos v
		WHERE ruta_id = @Ruta AND vuelo_id = v.id
		UNION
		SELECT DISTINCT compra, p.precio, p.codigo, 'Paquete'
		FROM JUST_DO_IT.Paquetes p, JUST_DO_IT.Vuelos v
		WHERE ruta_id = @Ruta AND vuelo_id = v.id 

		/* Se lo almacena primero en cancelaciones pendientes porque es la que se encarga de generar el codigo */			
		INSERT INTO JUST_DO_IT.CancelacionesPendientes(compra, fecha, monto, motivo, tipo, codigo)
			SELECT a.compra, GETDATE(), a.monto, 'La ruta fue dada de baja', 
			CASE WHEN a.tipo = 'Pasaje' THEN 0 ELSE 1 END, a.codigo
			FROM #AuxiliarEliminarRuta a
		
		INSERT INTO JUST_DO_IT.CancelacionesHechas(codigo_cancelacion, compra, fecha, monto_devuelto, motivo, tipo)
			SELECT id, compra, fecha, monto, motivo, 
			CASE WHEN tipo = 0 THEN 'Pasaje' ELSE 'Paquete' END FROM JUST_DO_IT.CancelacionesPendientes

		UPDATE JUST_DO_IT.Vuelos SET vuelo_eliminado = 1 WHERE ruta_id = @Ruta

		UPDATE JUST_DO_IT.Pasajes SET cancelado = 1
				WHERE EXISTS (SELECT 1
							 FROM JUST_DO_IT.Vuelos v
							 WHERE v.ruta_id = @Ruta AND JUST_DO_IT.Pasajes.vuelo_id = v.id
							 AND v.fecha_salida > GETDATE())

		UPDATE JUST_DO_IT.Paquetes SET cancelado = 1
				WHERE EXISTS (SELECT 1
							 FROM JUST_DO_IT.Vuelos v
							 WHERE v.ruta_id = @Ruta AND JUST_DO_IT.Paquetes.vuelo_id = v.id
							 AND v.fecha_salida > GETDATE())

		COMMIT TRANSACTION bajaRuta
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION bajaRuta
		DECLARE @error VARCHAR(255)
		SET @error = ERROR_MESSAGE()
		RAISERROR(@error,16,217) WITH SETERROR
		--RAISERROR('No se pudo dar de baja la ruta',16,217) WITH SETERROR
	END CATCH
	DROP TABLE #AuxiliarEliminarRuta
END

GO

CREATE PROCEDURE JUST_DO_IT.ActualizarRuta(@ruta NUMERIC(18,0), @codigo NUMERIC(18,0), @kg NUMERIC(18,2),
										   @pasaje NUMERIC(18,2), @origen NUMERIC(18,0), @destino NUMERIC(18,0),
										   @tipo_servicio NUMERIC(18,0))
AS BEGIN
	IF (@pasaje <= 0 OR @kg <= 0)
		RAISERROR('Debe ingresar un precio para pasaje y para kgs mayor a cero',16,217) WITH SETERROR
	IF (@origen = @destino)
		RAISERROR('La ciudad de origen debe ser distinta a la de destino',16,217) WITH SETERROR
	UPDATE JUST_DO_IT.Rutas SET codigo = @codigo, precio_baseKG = @kg, precio_basePasaje = @pasaje,
								ciu_id_origen = @origen, ciu_id_destino = @destino, tipo_servicio = @tipo_servicio
							WHERE id = @ruta
END

GO

CREATE PROCEDURE JUST_DO_IT.almacenarCiudad(@nombre VARCHAR(255))
AS BEGIN
	BEGIN TRY
		INSERT INTO JUST_DO_IT.Ciudades(nombre) VALUES (@nombre)
	END TRY
	BEGIN CATCH
		RAISERROR('La ciudad ingresada ya existe',16,217) WITH SETERROR
	END CATCH
END
SELECT * FROM JUST_DO_IT.Ciudades ORDER BY nombre

GO

CREATE PROCEDURE JUST_DO_IT.modificarCiudad(@ciudad NUMERIC(18,0), @nombre VARCHAR(255))
AS BEGIN
	BEGIN TRY
		UPDATE JUST_DO_IT.Ciudades SET nombre = @nombre WHERE id = @ciudad
	END TRY
	BEGIN CATCH
		RAISERROR('La ciudad ingresada ya existe',16,217) WITH SETERROR
	END CATCH
END	

GO

CREATE PROCEDURE JUST_DO_IT.agregarCompraADevolver(@compra NUMERIC(18,0), @tipo BIT, @codigo NUMERIC(18,0), 
												   @motivo VARCHAR(255))
AS BEGIN
	DECLARE @monto NUMERIC(18,2)
	IF (@tipo = 0) /* Pasajes */
	BEGIN
		SELECT @monto = precio FROM JUST_DO_IT.Pasajes p
		WHERE p.compra = @compra AND p.codigo = @codigo AND p.cancelado = 0
	END
	ELSE /* Paquetes */
	BEGIN
		SELECT @monto = precio FROM JUST_DO_IT.Paquetes p
		WHERE p.compra = @compra AND p.codigo = @codigo AND p.cancelado = 0
	END
	BEGIN TRY
		IF (@monto IS NULL)
			RAISERROR('Los datos ingresados no existen',16,217) WITH SETERROR

		IF EXISTS (SELECT 1 FROM JUST_DO_IT.CancelacionesPendientes WHERE compra = @compra AND @codigo = codigo AND tipo = @tipo)
			RAISERROR('La compra ingresada ya ha sido encolada para darse de baja',16,217) WITH SETERROR

		INSERT INTO JUST_DO_IT.CancelacionesPendientes(compra, tipo, codigo, motivo, monto, fecha)
			VALUES(@compra, @tipo, @codigo, @motivo, @monto, GETDATE())
	END TRY
	BEGIN CATCH
		DECLARE @error NVARCHAR(255)
		SET @error = ERROR_MESSAGE()
		RAISERROR (@error, 16, 217) WITH SETERROR
	END CATCH
END

GO

CREATE PROCEDURE JUST_DO_IT.procesarCancelaciones
AS BEGIN
	BEGIN TRANSACTION procesarCancelaciones
	DECLARE cancelar CURSOR
	FOR SELECT id, compra, tipo, codigo, motivo, fecha FROM JUST_DO_IT.CancelacionesPendientes
	OPEN cancelar
	BEGIN TRY
		DECLARE @id NUMERIC(18,0)
		DECLARE @compra NUMERIC(18,0)
		DECLARE @tipo BIT
		DECLARE @codigo NUMERIC(18,0)
		DECLARE @motivo VARCHAR(255)
		DECLARE @fecha DATETIME

		FETCH cancelar INTO @id, @compra, @tipo, @codigo, @motivo, @fecha
		WHILE (@@FETCH_STATUS = 0)
		BEGIN
			DECLARE @monto NUMERIC(18,2)
			DECLARE @vuelo NUMERIC(18,0)
			IF (@tipo = 0)
			BEGIN
				SELECT @vuelo = vuelo_id FROM JUST_DO_IT.Pasajes WHERE codigo = @codigo
				UPDATE JUST_DO_IT.Pasajes SET cancelado = 1, codigo_cancelacion = @id WHERE codigo = @codigo
				UPDATE JUST_DO_IT.Vuelos SET cantidadDisponible = cantidadDisponible + 1
					WHERE id = @vuelo
			END
			ELSE
			BEGIN
				DECLARE @KGs NUMERIC(18,2)
				SELECT @vuelo = vuelo_id, @KGs = kg FROM JUST_DO_IT.Paquetes WHERE codigo = @codigo
				UPDATE JUST_DO_IT.Paquetes SET cancelado = 1, codigo_cancelacion = @id WHERE codigo = @codigo
				UPDATE JUST_DO_IT.Vuelos SET KGsDisponibles = KGsDisponibles + @KGs
					WHERE id = @vuelo
			END
			FETCH cancelar INTO @id, @compra, @tipo, @codigo, @motivo, @fecha
		END
				
		INSERT INTO JUST_DO_IT.CancelacionesHechas(codigo_cancelacion, codigo, compra, fecha, monto_devuelto, motivo, tipo)
		SELECT id, codigo, compra, fecha, monto, motivo, CASE WHEN tipo=0 THEN 'Pasaje' ELSE 'Paquete' END
		FROM JUST_DO_IT.CancelacionesPendientes

		DELETE FROM JUST_DO_IT.CancelacionesPendientes
		COMMIT TRANSACTION procesarCancelaciones
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION procesarCancelaciones
		RAISERROR('Se produjo un error procesando las cancelaciones',16,217) WITH SETERROR
	END CATCH
	CLOSE cancelar
	DEALLOCATE cancelar
END

GO

CREATE PROCEDURE JUST_DO_IT.alta_aeronave_fuera_de_servicio(@id NUMERIC(18,0))
AS
BEGIN
	DECLARE @fecha_fuera_servicio DATETIME 
	SELECT fecha_fuera_servicio = @fecha_fuera_servicio FROM JUST_DO_IT.Aeronaves	WHERE id = @id
	BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO JUST_DO_IT.Aeronaves_Fuera_De_Servicio(aeronave_id, fecha_fuera_servicio, fecha_reinicio_servicio)
			VALUES(@id, @fecha_fuera_servicio, CURRENT_TIMESTAMP)
			
			UPDATE JUST_DO_IT.Aeronaves
			SET baja_fuera_servicio = 0, fecha_fuera_servicio = NULL, fecha_reinicio_servicio = NULL
			WHERE id = @id
			
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			RAISERROR('No se ha podido dar de alta la aeronave',16,217) WITH SETERROR
		END CATCH
END

GO

CREATE FUNCTION JUST_DO_IT.dias_totales_fuera_de_servicio(@aeronave_id NUMERIC(18,0))
RETURNS INT
AS
BEGIN
	DECLARE @cant_dias INT

	SELECT @cant_dias = SUM(DATEDIFF(DAY, fecha_fuera_servicio, fecha_reinicio_servicio))
	FROM JUST_DO_IT.Aeronaves_Fuera_De_Servicio
	WHERE aeronave_id = @aeronave_id

	SELECT @cant_dias = @cant_dias + DATEDIFF(DAY,fecha_fuera_servicio, CURRENT_TIMESTAMP)
	FROM JUST_DO_IT.Aeronaves
	WHERE id = @aeronave_id AND baja_fuera_servicio = 1

	RETURN @cant_dias
END
GO

CREATE FUNCTION JUST_DO_IT.top_aeroanves_fuera_de_servicio()
RETURNS TABLE
AS RETURN
	SELECT TOP 5 matricula, ISNULL(JUST_DO_IT.dias_totales_fuera_de_servicio(id), 0) as cantidad_dias
	FROM JUST_DO_IT.Aeronaves
	GROUP BY matricula, id
	ORDER BY 2 desc
GO

CREATE FUNCTION JUST_DO_IT.usuarios_con_mas_puntaje()
RETURNS TABLE
AS RETURN
	SELECT TOP 5 SUM(p.millas) as millas_totales, p.usuario_id, u.nombre, u.apellido
	FROM JUST_DO_IT.Puntos p
	join JUST_DO_IT.Usuarios u on p.usuario_id = u.id
	WHERE validos = 1
	GROUP BY p.usuario_id, u.nombre, u.apellido
	ORDER BY 1 desc
GO

CREATE FUNCTION JUST_DO_IT.DestinosConAeronavesMasVacias()
RETURNS TABLE
AS RETURN
	SELECT TOP 5 ciudades.nombre AS destino, MAX(vuelos.cantidadDisponible) AS cantidad
	FROM JUST_DO_IT.Ciudades ciudades, JUST_DO_IT.Vuelos vuelos
	JOIN JUST_DO_IT.Rutas rutas ON vuelos.ruta_id = rutas.id
	WHERE rutas.ciu_id_destino = ciudades.id
	GROUP BY ciudades.nombre
	ORDER BY MAX(vuelos.cantidadDisponible) DESC
GO

CREATE FUNCTION JUST_DO_IT.DestinosConPasajesMasComprados()
RETURNS TABLE
AS RETURN
	SELECT TOP 5 ciudades.nombre ciudad, COUNT(pasajes.codigo) cantidad 
	FROM JUST_DO_IT.Ciudades ciudades, JUST_DO_IT.Pasajes pasajes, JUST_DO_IT.Vuelos vuelos, JUST_DO_IT.Rutas rutas 
    WHERE vuelos.id = Pasajes.vuelo_id AND rutas.id = vuelos.ruta_id AND rutas.ciu_id_destino = ciudades.id
    GROUP BY ciudades.nombre 
	ORDER BY cantidad DESC

GO

CREATE FUNCTION JUST_DO_IT.destinos_con_pasajes_cancelados()
RETURNS TABLE
AS RETURN
	SELECT TOP 5 ciudades.nombre AS nombre_ciudad, COUNT(pasajes.codigo) AS pasajes_cancelados
	FROM JUST_DO_IT.Pasajes pasajes, JUST_DO_IT.Vuelos vuelos, JUST_DO_IT.Rutas rutas, JUST_DO_IT.Ciudades ciudades
	WHERE pasajes.vuelo_id = vuelos.id
		AND vuelos.ruta_id = rutas.id
		AND rutas.ciu_id_destino = ciudades.id
		AND pasajes.cancelado = 1
	GROUP BY ciudades.nombre
	ORDER BY 2 DESC

GO

GO

/* Productos para el canje de millas */
INSERT INTO JUST_DO_IT.Productos VALUES ('Licuadora',200,50)
INSERT INTO JUST_DO_IT.Productos VALUES ('Campera de cuero de dama',500,15)
INSERT INTO JUST_DO_IT.Productos VALUES ('Microondas',1000,120)
INSERT INTO JUST_DO_IT.Productos VALUES ('Una tarde con Laly Esposito',100000,1)
INSERT INTO JUST_DO_IT.Productos VALUES ('Set de maquillajes',200,90)
INSERT INTO JUST_DO_IT.Productos VALUES ('Cortapelo',400,60)
INSERT INTO JUST_DO_IT.Productos VALUES ('Libro "Secretos verdaderos" por Luis Ventura',100,500)

GO

CREATE FUNCTION JUST_DO_IT.canjeMillas_hayStockDe(@DescripcionProd  NVARCHAR(255), @cantProducto NUMERIC(18,0))
RETURNS int 
AS
BEGIN
    DECLARE @hayStock int;
    SELECT @hayStock = stockProd FROM JUST_DO_IT.Productos WHERE descripcionProd LIKE @DescripcionProd
    
	IF(@hayStock >= @cantProducto)
		RETURN 1
	
	RETURN 0
END

GO

CREATE FUNCTION JUST_DO_IT.MillasTotalesDe(@usuario NUMERIC(18,0))
RETURNS NUMERIC(18,0)
AS BEGIN
	DECLARE @millasUsuario NUMERIC(18,0)
	SELECT @millasUsuario = SUM(P.millas) FROM JUST_DO_IT.Puntos AS P 
	WHERE P.usuario_id = @usuario AND P.vencimiento > CURRENT_TIMESTAMP AND P.validos=1
	GROUP BY P.usuario_id
	IF (@millasUsuario IS NULL)
		RETURN 0

	RETURN @millasUsuario
END

GO

CREATE FUNCTION JUST_DO_IT.CantidadDeMillasUsuario(@dni NUMERIC(18,0), @nombre VARCHAR(255), @apellido VARCHAR(255))
RETURNS NUMERIC(18,0)
AS BEGIN
	DECLARE @id NUMERIC(18,0)
	SELECT @id = id FROM JUST_DO_IT.Usuarios WHERE dni = @dni AND @nombre = nombre AND @apellido = apellido
	RETURN JUST_DO_IT.MillasTotalesDe(@id)
END

GO

CREATE FUNCTION JUST_DO_IT.canjeMillas_leAlcanzanlasMillasPara(@DescripcionProd  NVARCHAR(255),@cantProducto NUMERIC(18,0), @dni NUMERIC(18,0))
RETURNS int 
AS
BEGIN
    DECLARE @tieneMillasSuficientes int;
	DECLARE @millasUsuario NUMERIC(18,0);
	DECLARE @millasRequeridas NUMERIC(18,0);
	DECLARE @idUsuario int;

	SELECT @idUsuario = U.id FROM JUST_DO_IT.Usuarios AS U WHERE U.dni LIKE @dni; 

	
	SELECT @millasUsuario = JUST_DO_IT.MillasTotalesDe(@idUsuario)
	SELECT @millasRequeridas = Prod.cantMillasNecesarias FROM JUST_DO_IT.Productos AS Prod WHERE Prod.descripcionProd LIKE @DescripcionProd;
	
	SET @millasRequeridas = @millasRequeridas * @cantProducto;	

	IF(@millasUsuario > @millasRequeridas)
		return 1;
	ELSE
		return 0;	
		
	RETURN -1;
END

GO

CREATE PROCEDURE JUST_DO_IT.canjearMillas(@dni NUMERIC(18,0), @nombre VARCHAR(255), @apellido VARCHAR(255), @descripcionProd  NVARCHAR(255), @cantProducto NUMERIC(18,0))
AS BEGIN
	BEGIN TRANSACTION canjearMillas
	DECLARE @error BIT
	SET @error = 0
	BEGIN TRY
		
		DECLARE @millasNecesarias INT;
		DECLARE @hayStock BIT = 0;
		DECLARE @tieneSuficientesMillas BIT = 0;
		DECLARE @millasUsuario int;
		DECLARE @idUsuario int;
		
		SELECT @idUsuario = U.id FROM JUST_DO_IT.Usuarios AS U WHERE  U.dni = @dni AND U.nombre = @nombre AND U.apellido = @apellido;
		
		-- Millas del usuario
		select @millasUsuario = SUM(P.millas) From JUST_DO_IT.Puntos AS P 
		Where P.id = @idUsuario AND p.vencimiento > CURRENT_TIMESTAMP ;
	
		EXEC @hayStock = JUST_DO_IT.canjeMillas_hayStockDe @descripcionProd, @cantProducto;
		EXEC @tieneSuficientesMillas = JUST_DO_IT.canjeMillas_leAlcanzanlasMillasPara @descripcionProd,@cantProducto, @dni;
		
		-- Controla si hay stock y si le alcanzan las millas 
		IF(@hayStock = 0)
		BEGIN
			SET @error = 1;
			RAISERROR('No hay stock suficiente del producto',16,217) WITH SETERROR
		END
		IF(@tieneSuficientesMillas = 0)
		BEGIN 
			SET @error = 1;
			RAISERROR('Millas insuficientes para realizar el canje',16,217) WITH SETERROR
		END
		-- Obtiene las millas necesarias para el canje
		SELECT @millasNecesarias = P.cantMillasNecesarias FROM JUST_DO_IT.Productos AS P 
		WHERE P.descripcionProd LIKE @descripcionProd;

		DECLARE @stockActual INT;
		SELECT @stockActual = P.stockProd FROM JUST_DO_IT.Productos AS P WHERE P.descripcionProd LIKE @descripcionProd;
		IF(@stockActual - @cantProducto >= 1)
			UPDATE JUST_DO_IT.Productos SET stockProd = stockProd - @cantProducto WHERE descripcionProd LIKE @descripcionProd;
		ELSE
			DELETE FROM JUST_DO_IT.Productos WHERE descripcionProd LIKE @descripcionProd;

		DECLARE @producto NUMERIC(18,0)
		SELECT @producto = id FROM JUST_DO_IT.Productos WHERE descripcionProd = @descripcionProd
		INSERT INTO JUST_DO_IT.RegistroCanjeMillas(id_usuario,cantProductoElegido, id_producto, fechaCanje) VALUES (@idUsuario,@cantProducto, @producto, CURRENT_TIMESTAMP);
		INSERT INTO JUST_DO_IT.Puntos(usuario_id, millas, validos, vencimiento)
			VALUES (@idUsuario, @millasNecesarias * @cantProducto * (-1), 1, DATEADD(YEAR, 1, CURRENT_TIMESTAMP))

		COMMIT TRANSACTION canjearMillas	
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION canjearMillas
		IF (@error = 0)
			RAISERROR('El canje no pudo ser efectuado',16,217) WITH SETERROR
		ELSE
		BEGIN
			DECLARE @ErrorMessage VARCHAR(255)
			SET @ErrorMessage = ERROR_MESSAGE()
			RAISERROR(@ErrorMessage,16,217) WITH SETERROR
		END
	END CATCH	
END 

GO

CREATE FUNCTION JUST_DO_IT.ConsultaMillas(@dni NUMERIC(18,0), @nombre VARCHAR(255), @apellido VARCHAR(255))
RETURNS TABLE
AS RETURN
	SELECT puntos.millas millas, puntos.vencimiento vencimiento 
	FROM JUST_DO_IT.Puntos AS puntos, JUST_DO_IT.Usuarios AS usuarios
	WHERE usuarios.id = puntos.usuario_id AND usuarios.dni = @dni AND usuarios.nombre = @nombre
                    AND usuarios.apellido = @apellido AND puntos.vencimiento > CURRENT_TIMESTAMP
					AND puntos.validos = 1

GO

CREATE PROCEDURE JUST_DO_IT.cancelar_vuelos_y_dar_de_baja_aeronave(@aeronave NVARCHAR(255), @fin_vida_util BIT, @fecha_fin_servicio DATETIME, @fecha_reinicio_servicio DATETIME)
AS BEGIN
	DECLARE @vueloId NUMERIC(18,0)
	DECLARE @idAeronave NUMERIC(18,0)
	
	CREATE TABLE #vuelosAEliminar(
		id NUMERIC(18,0)
	)

	BEGIN TRANSACTION eliminarVueloYDarDeBajaAeronave
	BEGIN TRY
		SELECT @idAeronave = (SELECT JUST_DO_IT.obtener_id_aeronave_segun_matricula(@aeronave))
	
		IF (@fin_vida_util = 1)
			BEGIN
				INSERT INTO #vuelosAEliminar(id)
					SELECT vuelos.id FROM JUST_DO_IT.Vuelos vuelos
								WHERE vuelos.aeronave_id = @idAeronave
								AND vuelos.fecha_salida > CONVERT(DATETIME, CONVERT(DATE, CURRENT_TIMESTAMP))

				UPDATE JUST_DO_IT.Aeronaves 
				SET baja_vida_util = 1, 
					fecha_baja_definitiva = CONVERT(DATETIME, CONVERT(DATE, CURRENT_TIMESTAMP)) 
				WHERE id = @idAeronave
			END
		ELSE
			BEGIN
				INSERT INTO #vuelosAEliminar(id)
					SELECT vuelos.id FROM JUST_DO_IT.Vuelos vuelos
					WHERE vuelos.aeronave_id = @idAeronave 
						AND ((@fecha_fin_servicio <= vuelos.fecha_salida AND @fecha_reinicio_servicio >= vuelos.fecha_llegada_estimada) 
						OR (@fecha_fin_servicio >= vuelos.fecha_salida AND @fecha_fin_servicio <= vuelos.fecha_llegada_estimada))			
			
				UPDATE JUST_DO_IT.Aeronaves
				SET baja_fuera_servicio = 1, 
					fecha_fuera_servicio = @fecha_fin_servicio, 
					fecha_reinicio_servicio = @fecha_reinicio_servicio
				WHERE id = @idAeronave
			END

		
			UPDATE JUST_DO_IT.Vuelos	
			SET vuelo_eliminado = 1
			WHERE id IN (SELECT * FROM #vuelosAEliminar)
		
			UPDATE pas
			SET pas.cancelado = 1
			FROM JUST_DO_IT.Pasajes pas
			WHERE pas.vuelo_id IN (SELECT * FROM #vuelosAEliminar)

			UPDATE paq
			SET paq.cancelado = 1
			FROM JUST_DO_IT.Pasajes paq
			WHERE paq.vuelo_id IN (SELECT * FROM #vuelosAEliminar)

	COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		RAISERROR('No se pudieron cancelar los vuelos ni dar de baja la aeronave',16,217) WITH SETERROR
	END CATCH

	DROP TABLE #vuelosAEliminar
END

GO

CREATE FUNCTION JUST_DO_IT.butacasReservadasParaVuelo(@vuelo NUMERIC(18,0))
RETURNS TABLE
AS RETURN
	SELECT apellido, nombre 
	FROM JUST_DO_IT.Usuarios u
	JOIN JUST_DO_IT.ButacasReservadas b
	ON b.usuario_id = u.id
	WHERE b.vuelo_id = @vuelo

GO