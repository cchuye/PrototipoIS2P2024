DROP DATABASE sic;
CREATE DATABASE sic;
USE sic;
CREATE TABLE bodegas
(
	codigo_bodega VARCHAR(5) PRIMARY KEY,
    nombre_bodega VARCHAR(60),
    estatus_bodega VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE lineas
(
	codigo_linea VARCHAR(5) PRIMARY KEY,
    nombre_linea VARCHAR(60),
    estatus_linea VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE marcas
(
	codigo_marca VARCHAR(5) PRIMARY KEY,
    nombre_marca VARCHAR(60),
    estatus_marca VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE productos
(
	codigo_producto VARCHAR(18) PRIMARY KEY,
    nombre_producto VARCHAR(60),
    codigo_linea VARCHAR(5),
    codigo_marca VARCHAR(5),
    existencia_producto FLOAT(10,2),
    estatus_producto VARCHAR(1),
    FOREIGN KEY (codigo_linea) REFERENCES lineas(codigo_linea),
    FOREIGN KEY (codigo_marca) REFERENCES marcas(codigo_marca)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE existencias
(
	codigo_bodega VARCHAR(5),
    codigo_producto VARCHAR(18),
    saldo_existencia FLOAT(10,2),
    PRIMARY KEY (codigo_bodega, codigo_producto),
	FOREIGN KEY (codigo_bodega) REFERENCES bodegas(codigo_bodega),
    FOREIGN KEY (codigo_producto) REFERENCES productos(codigo_producto)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE vendedores
(
	codigo_vendedor VARCHAR(5) PRIMARY KEY,
    nombre_vendedor VARCHAR(60),
    direccion_vendedor VARCHAR(60),
    telefono_vendedor VARCHAR(50),
    nit_vendedor VARCHAR(20),
    estatus_vendedor VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE clientes
(
	codigo_cliente VARCHAR(5) PRIMARY KEY,
    nombre_cliente VARCHAR(60),
    direccion_cliente VARCHAR(60),
    nit_cliente VARCHAR(20),
    telefono_cliente VARCHAR(50),
    codigo_vendedor VARCHAR(5),
    estatus_cliente VARCHAR(1),
    FOREIGN KEY (codigo_vendedor) REFERENCES vendedores(codigo_vendedor)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE proveedores
(
	codigo_proveedor VARCHAR(5) PRIMARY KEY,
    nombre_proveedor VARCHAR(60),
    direccion_proveedor VARCHAR(60),
    telefono_proveedor VARCHAR(50),
    nit_proveedor VARCHAR(50),
    estatus_proveedor VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE compras_encabezado
(
	documento_compraenca VARCHAR(10) PRIMARY KEY,
    codigo_proveedor VARCHAR(5),
    fecha_compraenca DATE,
	total_compraenca FLOAT(10,2),
    estatus_compraenca VARCHAR(1),
    FOREIGN KEY (codigo_proveedor) REFERENCES proveedores(codigo_proveedor)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE compras_detalle
(
	documento_compraenca VARCHAR(10),
    codigo_producto VARCHAR(18),
    cantidad_compradet FLOAT(10,2),
    costo_compradet FLOAT(10,2),
	codigo_bodega VARCHAR(5),
    PRIMARY KEY (documento_compraenca, codigo_producto),
    FOREIGN KEY (documento_compraenca) REFERENCES compras_encabezado(documento_compraenca),
    FOREIGN KEY (codigo_producto) REFERENCES productos(codigo_producto),
    FOREIGN KEY (codigo_bodega) REFERENCES bodegas(codigo_bodega)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE ventas_encabezado
(
	documento_ventaenca VARCHAR(10) PRIMARY KEY,
    codigo_cliente VARCHAR(5),
    fecha_ventaenca DATE,
    total_ventaenca FLOAT(10,2),
    estatus_ventaenca VARCHAR(1),
    FOREIGN KEY (codigo_cliente) REFERENCES clientes(codigo_cliente)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE ventas_detalle
(
	documento_ventaenca VARCHAR(10),
    codigo_producto VARCHAR(18),
    cantidad_ventadet FLOAT(10,2),
    costo_ventadet FLOAT(10,2),
    precio_ventadet FLOAT(10,2),
    codigo_bodega VARCHAR(5),
    PRIMARY KEY (documento_ventaenca, codigo_producto),
    FOREIGN KEY (documento_ventaenca) REFERENCES ventas_encabezado(documento_ventaenca),
    FOREIGN KEY (codigo_producto) REFERENCES productos(codigo_producto),
    FOREIGN KEY (codigo_bodega) REFERENCES bodegas(codigo_bodega)
) ENGINE=INNODB DEFAULT CHARSET=latin1;


-- SEGURIDAD
-- Reporteador
-- Crear la tabla Estados
CREATE TABLE tbl_estados (
    pk_id_estado INT AUTO_INCREMENT PRIMARY KEY,
    est_info_estado VARCHAR(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
    est_num_estado INT
);

-- Crear la tabla Reportes
CREATE TABLE tbl_reportes (
    pk_id_reporte INT AUTO_INCREMENT PRIMARY KEY,
    rep_correlativo INT UNIQUE,
    rep_nombre VARCHAR(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
    fk_estado INT,
    rep_fecha DATETIME,
    rep_archivo VARCHAR(120) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
    rep_fechaMod datetime,
    FOREIGN KEY (fk_estado) REFERENCES tbl_estados(pk_id_estado)
)ENGINE = InnoDB CHARACTER SET = utf8 collate = utf8_general_ci;
-- HACER PRIMERO LA CREACION DE LAS TABLAS
-- DESPUES DE CREARLAS, INGRESAR DATOS DE LA TABLA ESTADOS DEFINIDOS A CONTINUACION
insert into `tbl_estados` (`pk_id_estado`, `est_info_estado`, `est_num_estado`) VALUES 
(1, 'Activo', 1),(2, 'Eliminado', 2), (3, 'Modificado', 3) ;

-- CUANDO YA ESTEN LOS DATOS CREADOS DENTRO DE LA TABLA DE ESTADOS, CREAR LOS DATOS INICIALES PARA LA TABLA REPORTES
insert into `tbl_reportes` (`pk_id_reporte`, `rep_correlativo`, `rep_nombre`, `fk_estado`) VALUES 
(10, 10002, 'planilssla.txt', 1);

-- TENIENDO YA TODO CREADO E INGRESADO, HACER EL SELECT DE LA TABLA REPORTES Y YA SE PUEDE TRABAJAR CON EL PROGRAMA EN CONJUNTO
select * from tbl_reportes;

-- Fin Reporteador

/*-----------Seguridad-----------*/

DROP TABLE IF EXISTS tbl_modulos;
CREATE TABLE IF NOT EXISTS tbl_modulos (
	pk_id_modulos INT NOT NULL,
    nombre_modulo VARCHAR(50) NOT NULL,
    descripcion_modulo VARCHAR(150) NOT NULL,
    estado_modulo TINYINT DEFAULT 0,
    primary key (pk_id_modulos)
);

DROP TABLE IF EXISTS tbl_aplicaciones;
CREATE TABLE IF NOT EXISTS tbl_aplicaciones (
	pk_id_aplicacion INT NOT NULL,
    nombre_aplicacion VARCHAR(50) NOT NULL,
    descripcion_aplicacion VARCHAR(150) NOT NULL,
    estado_aplicacion TINYINT DEFAULT 0,
    primary key (pk_id_aplicacion)
);

DROP TABLE IF EXISTS tbl_AsignacionModuloAplicacion;
CREATE TABLE IF NOT EXISTS tbl_AsignacionModuloAplicacion (
  fk_id_modulos INT NOT NULL,
  fk_id_aplicacion INT NOT NULL, 
  PRIMARY KEY (fk_id_modulos,fk_id_aplicacion ),
  FOREIGN KEY (fk_id_modulos) REFERENCES tbl_modulos (pk_id_modulos),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_usuarios;
CREATE TABLE IF NOT EXISTS tbl_usuarios (
  pk_id_usuario INT AUTO_INCREMENT NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(50) NOT NULL,
  username_usuario VARCHAR(20) NOT NULL,
  password_usuario VARCHAR(100) NOT NULL,
  email_usuario VARCHAR(50) NOT NULL,
  estado_usuario TINYINT DEFAULT 0 NOT NULL,
  pregunta varchar(50) not null,
  respuesta varchar(50) not null,
  PRIMARY KEY (pk_id_usuario)
);

DROP TABLE IF EXISTS tbl_perfiles;
CREATE TABLE IF NOT EXISTS tbl_perfiles (
	pk_id_perfil INT AUTO_INCREMENT NOT NULL,
    nombre_perfil VARCHAR(50) NOT NULL,
    descripcion_perfil VARCHAR(150) NOT NULL,
    estado_perfil TINYINT DEFAULT 0,
    primary key (pk_id_perfil)
);

DROP TABLE IF EXISTS tbl_permisosAplicacionesUsuario;
CREATE TABLE IF NOT EXISTS tbl_permisosAplicacionesUsuario (
  fk_id_aplicacion INT NOT NULL, 
  fk_id_usuario INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (fk_id_aplicacion,fk_id_usuario),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_permisosAplicacionPerfil;
CREATE TABLE IF NOT EXISTS tbl_permisosAplicacionPerfil (
  fk_id_perfil INT NOT NULL, 
  fk_id_aplicacion INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (fk_id_perfil,fk_id_aplicacion),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion),
  FOREIGN KEY (fk_id_perfil) REFERENCES tbl_perfiles (pk_id_perfil)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_asignacionesPerfilsUsuario;
CREATE TABLE IF NOT EXISTS tbl_asignacionesPerfilsUsuario (
  fk_id_usuario INT NOT NULL, 
  fk_id_perfil INT NOT NULL,
  PRIMARY KEY (fk_id_usuario,fk_id_perfil ),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario),
  FOREIGN KEY (fk_id_perfil) REFERENCES tbl_perfiles (pk_id_perfil)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS tbl_bitacoraDeEventos;
CREATE TABLE IF NOT EXISTS tbl_bitacoraDeEventos (
  pk_id_bitacora INT AUTO_INCREMENT NOT NULL,
  fk_id_usuario INT NOT NULL,
  fk_id_aplicacion INT NOT NULL,
  fecha_bitacora DATE NOT NULL,
  hora_bitacora TIME NOT NULL,
  host_bitacora VARCHAR(45) NOT NULL,
  ip_bitacora VARCHAR(100) NOT NULL,
  accion_bitacora VARCHAR(50) NOT NULL,
  PRIMARY KEY (pk_id_bitacora),
  FOREIGN KEY (fk_id_usuario) REFERENCES tbl_usuarios (pk_id_usuario),
  FOREIGN KEY (fk_id_aplicacion) REFERENCES tbl_aplicaciones (pk_id_aplicacion)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;


-- vistas Seguridad------------------------------------------------------------------------
CREATE 
VIEW sic.vista_aplicacion_perfil AS 
    SELECT 
        b.fk_id_perfil AS ID,
        a.nombre_perfil AS Perfil,
        b.fk_id_aplicacion AS Aplicacion,
        b.guardar_permiso AS Insertar,
        b.modificar_permiso AS Modificar,
        b.eliminar_permiso AS Eliminar,
        b.buscar_permiso AS Buscar,
        b.imprimir_permiso AS Reporte
    FROM
        (sic.tbl_permisosAplicacionPerfil b
        JOIN sic.tbl_perfiles a ON ((a.pk_id_perfil = b.fk_id_perfil)));
        
CREATE 
VIEW sic.vista_aplicacionusuario AS
    SELECT 
        b.fk_id_aplicacion AS Aplicacion,
        b.fk_id_usuario AS ID,
        a.nombre_usuario AS Usuario,
        b.guardar_permiso AS Insertar,
        b.modificar_permiso AS Editar,
        b.eliminar_permiso AS Eliminar,
        b.buscar_permiso AS Buscar,
        b.imprimir_permiso AS Reporte
    FROM
        (sic.tbl_permisosAplicacionesUsuario b
        JOIN sic.tbl_usuarios a ON ((a.pk_id_usuario = b.fk_id_usuario)));
        
CREATE 
VIEW sic.vista_modulo_aplicacion AS
    SELECT 
        b.fk_id_modulos AS ID,
        a.nombre_modulo AS Modulo,
        b.fk_id_aplicacion AS Aplicacion,
        c.nombre_aplicacion AS Nombre,
        c.descripcion_aplicacion AS Descripcion
    FROM
        ((sic.tbl_AsignacionModuloAplicacion b
        JOIN sic.tbl_modulos a ON ((a.pk_id_modulos = b.fk_id_modulos)))
        JOIN sic.tbl_aplicaciones c ON ((c.pk_id_aplicacion = b.fk_id_aplicacion)));
        
CREATE 
VIEW sic.vista_perfil_usuario AS
    SELECT 
        b.fk_id_usuario AS ID,
        a.nombre_usuario AS Usuario,
        a.username_usuario AS nickName,
        b.fk_id_perfil AS perfil,
        c.nombre_perfil AS Nombre
    FROM
        ((sic.tbl_asignacionesPerfilsUsuario b
        JOIN sic.tbl_usuarios a ON ((a.pk_id_usuario = b.fk_id_usuario)))
        JOIN sic.tbl_perfiles c ON ((c.pk_id_perfil = b.fk_id_perfil)));
-- fin Seguridad--


/*-Cambiar por el nombre de la BD estandarizado- */

/*--------------------SEGURIDAD---------------*/
-- -----MODULOS

INSERT INTO `tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1)
;

-- -----APLICACIONES
INSERT INTO `tbl_aplicaciones` VALUES
('1', 'Menu', 'Ingreso Login', '1'),
('999', 'Cerrar Sesion', 'Cerrar Sesion', '1'),
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('1001', 'Mant. Usuario', 'PARA SEGURIDAD', '1'),
('1002', 'Mant. Aplicación', 'PARA SEGURIDAD', '1'),
('1003', 'Mant. Modulo', 'PARA SEGURIDAD', '1'),
('1004', 'Mant. Perfil', 'PARA SEGURIDAD', '1'),
('1101', 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', '1'),
('1102', 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', '1'),
('1103', 'Asign. Perfil Usuario', 'PARA SEGURIDAD', '1'),
('1201', 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', '1'),
('1301', 'Pcs. BITACORA', 'PARA SEGURIDAD', '1')
;

-- -----USUARIOS
INSERT INTO `tbl_usuarios` VALUES
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A=')
;

-- -----PERFILES
INSERT INTO `tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1)
;

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES
('1000', '1000'),
('1000', '1001'),
('1000', '1002'),
('1000', '1003'),
('1000', '1004'),
('1000', '1102'),
('1000', '1103'),
('1000', '1201'),
('1000', '1301')
;

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `tbl_permisosAplicacionPerfil` VALUES
('1', '1000', '1', '1', '1', '1', '1'),
('1', '1001', '1', '1', '1', '1', '1'),
('1', '1002', '1', '1', '1', '1', '1'),
('1', '1003', '1', '1', '1', '1', '1'),
('1', '1004', '1', '1', '1', '1', '1'),
('1', '1101', '1', '1', '1', '1', '1'),
('1', '1102', '1', '1', '1', '1', '1'),
('1', '1103', '1', '1', '1', '1', '1'),
('1', '1201', '1', '1', '1', '1', '1'),
('1', '1301', '1', '1', '1', '1', '1')
;

-- -----ASIGNACIÓN DE PERFIL A USUARIO
INSERT INTO `tbl_asignacionesPerfilsUsuario` VALUES
('1', '1')
;

INSERT INTO tbl_modulos VALUES
('8000', 'PROTOTIPO ERP', 'Para ERP', 1)
;
 
-- -----APLICACIONES
INSERT INTO tbl_aplicaciones VALUES
('8000', 'MDI PROTOTIPO ERP', 'PARA ERP', '1'),
('8001', 'Mant. Proveedores ', 'PARA ERP', '1'),
('8002', 'Mant. Clientes', 'PARA ERP', '1')
;
 
-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO tbl_asignacionmoduloaplicacion VALUES
('8000', '8000'),
('8000', '8001'),
('8000', '8002')
;
 
-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO tbl_permisosAplicacionPerfil VALUES
('1', '8000', '1', '1', '1', '1', '1'),
('1', '8001', '1', '1', '1', '1', '1'),
('1', '8002', '1', '1', '1', '1', '1')
;
