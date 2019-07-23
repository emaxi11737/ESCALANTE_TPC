CREATE DATABASE COMERCIO
SET ANSI_NULLS ON
set dateformat dmy
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDORES](
		[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[CUIT] [varchar](50) NULL,
	[MAIL] [varchar](50) NULL,
	[DIRECCION] [varchar](50) NULL,
	[TELEFONO] [varchar](50) NULL,
	[LOCALIDAD] [varchar](50) NULL,
	[PROVINCIA] [varchar](50) NULL,
	[CONDICIONIVA] [varchar](50) NULL,
	[CONDICIONPAGO] [int] NULL,
	[ACTIVO] [bit] NULL,

 CONSTRAINT [PK_PROVEEDORES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[CLIENTES](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[CUIT] [varchar](50) NULL,
	[MAIL] [varchar](50) NULL,
	[DIRECCION] [varchar](50) NULL,
	[TELEFONO] [varchar](50) NULL,
	[LOCALIDAD] [varchar](50) NULL,
	[PROVINCIA] [varchar](50) NULL,
	[CONDICIONIVA] [varchar](50) NULL,
	[CONDICIONPAGO] [int] NULL,
	[ACTIVO] [bit] NULL,
	


 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]





CREATE TABLE [dbo].[MARCA](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [varchar](50) NULL,


 CONSTRAINT [PK_MARCA] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
CREATE TABLE [dbo].[CATEGORIA](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NULL
	


 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[PRODUCTOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[precioCompra] [float] NULL,
	[precioVenta] [float] NULL,
	[stockMinimo] [float] NULL,
	[stockActual] [float] NULL,
	[ACTIVO] [bit] NULL
	


 CONSTRAINT [PK_PRODUCTOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[EMPLEADOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[apellido] [varchar](30) NULL,
	[dni] [varchar](30) NULL,
	[direccion] [varchar](30) NULL,
	[localidad] [varchar](30) NULL,
	[mail] [varchar](30) NULL,
	[telefono] [varchar](30) NULL,
	[ACTIVO] [bit] NULL
	


 CONSTRAINT [PK_EMPLEADOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[CATEGORIAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [varchar](50) NULL,


 CONSTRAINT [PK_CATEGORIAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO CATEGORIAS(DESCRIPCION) VALUES ('Pallets')
INSERT INTO CATEGORIAS(DESCRIPCION) VALUES ('Cajones')

Create Table FACTURAVENTA(
numeroFactura varchar(15) not null primary key,
idCliente int foreign key references CLIENTES(id),
fechaFactura datetime not null,
activo bit not null,
importeNeto decimal(10,2) not null,
IVA21 decimal(10,2) not null,
importeTotal decimal(10,2) not null,
importenoGravado decimal(10,2) not null,
tipoComprobante varchar(30),
estado varchar(30),
condicionPago int not null
)

Create Table REMITOS(
numeroRemito varchar(15) not null primary key
idCliente int foreign key references CLIENTES(id),
fechaRemito datetime not null,
numerofactura varchar(15)  null foreign key references FACTURAVENTA(numeroFactura),
activo bit not null,
estado varchar(20) not null
)


Create Table DETALLES(
id int identity(1,1) not null primary key,
precioventa decimal(10,2) not null,
cantidad int not null,
precioParcial decimal(10,2) not null,
activo bit not null,
idRemito varchar(15) not null foreign key references Remitos(numeroRemito),
idProducto int not null foreign key references Productos(id),
numeroCertificado varchar(20)  null foreign key references Certificados(numeroCertificado)
)

INSERT INTO REMITOS(idCliente,fechaRemito,numeroRemito) values (5,'2/2/2019','3050')

Create Table TRATAMIENTOS(
numeroTratamiento varchar(30) not null primary key,
cantidadPallets int null,
cantidadCajones int null,
cantidadMadera int null,
fecha Datetime not null,
estado varchar(30),
activo bit not null
)
Create Table CERTIFICADOS(
numeroTratamiento varchar(30) not null foreign key references Tratamientos(numeroTratamiento),
tipo varchar(20) not null,
numeroCertificado varchar(20) not null primary key,
numeroRemito varchar(15)  null foreign key references Remitos(numeroRemito),
codigo varchar(5) not null,
cantidadTotal int not null,
cantidadEntregada int null,
fecha Datetime not null,
estado varchar(30),
activo bit not null
)
Create Table PAGOS(
id bigint identity(1,1) not null primary key,
fechaPago date not null,
idCliente int not null foreign key references Clientes(id),
activo bit not null
)
Create Table FACTURASXPAGO(
id bigint identity(1,1) not null  primary key,
idPago bigint not null foreign key references PAGOS(id),
numeroFactura varchar(15) not null foreign key references FACTURAVENTA(numeroFactura),
activo bit not null
)
Create table CHEQUES(
id bigint identity(1,1) not null primary key,
numeroCheque varchar(20) not null,
banco varchar(30) not null,
importe decimal(10,2) not null,
idCliente int foreign key references Clientes(id),
idPago bigint not null foreign key references Pagos(id),
fechaPago date not null,
localidad varchar(30) null,
cuitEmisor varchar(30) null,
activo bit not null
)
create table TRANSFERENCIAS(
id bigint identity(1,1) not null primary key,
banco varchar(30) not null,
numeroTransferencia varchar(20) not null,
idCliente int foreign key references Clientes(id),
idPago bigint not null foreign key references Pagos(id),
importe decimal(10,2) not null,
activo bit not null
)
create table EFECTIVOS(
id bigint identity(1,1) not null primary key,
idCliente int foreign key references Clientes(id),
idPago bigint not null foreign key references Pagos(id),
importe decimal(10,2) not null,
activo bit not null
)
CREATE Table Usuario (
    LoginId INT Identity (1,1) ,
    UserName VARCHAR(50) primary key not null,
    Llave varchar(20) not null,
	tipo varchar(20),
	activo bit not null
)