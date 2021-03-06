USE [Tienda]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Ingreso]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Ingreso](
	[id_detalle_ingreso] [int] IDENTITY(1,1) NOT NULL,
	[id_ingreso] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio_compra] [money] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[stock_inicial] [int] NOT NULL,
	[stock_actual] [int] NOT NULL,
	[fecha_produccion] [date] NULL,
	[fecha_vence] [date] NULL,
 CONSTRAINT [PK_Detalle_Ingreso] PRIMARY KEY CLUSTERED 
(
	[id_detalle_ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_venta]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_venta](
	[id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NOT NULL,
	[id_detalle_ingreso] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_venta] [money] NOT NULL,
	[descuento] [money] NULL,
 CONSTRAINT [PK_Detalle_venta] PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellidos] [varchar](20) NOT NULL,
	[sexo] [varchar](1) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[num_documento] [varchar](12) NOT NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[acceso] [varchar](20) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingreso](
	[id_ingreso] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[tipo_comprobante] [varchar](20) NOT NULL,
	[serie] [varchar](10) NOT NULL,
	[correlativo] [varchar](10) NOT NULL,
	[iva] [decimal](4, 2) NOT NULL,
	[estado] [varchar](7) NOT NULL,
 CONSTRAINT [PK_Ingreso] PRIMARY KEY CLUSTERED 
(
	[id_ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presentacion]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presentacion](
	[id_presentacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Presentacion] PRIMARY KEY CLUSTERED 
(
	[id_presentacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[codigo_barra] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[id_categoria] [int] NOT NULL,
	[id_presentacion] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [varchar](100) NOT NULL,
	[sector_comercial] [varchar](50) NOT NULL,
	[tipo_documento] [varchar](20) NULL,
	[numero_documento] [varchar](20) NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](10) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[tipo_comprobante] [varchar](20) NOT NULL,
	[serie] [varchar](4) NULL,
	[correlativo] [varchar](7) NULL,
	[iva] [decimal](4, 2) NULL,
	[cliente] [varchar](60) NULL,
	[abono] [money] NULL,
	[saldo] [money] NULL,
	[total] [money] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle_Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ingreso_Ingreso] FOREIGN KEY([id_ingreso])
REFERENCES [dbo].[Ingreso] ([id_ingreso])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalle_Ingreso] CHECK CONSTRAINT [FK_Detalle_Ingreso_Ingreso]
GO
ALTER TABLE [dbo].[Detalle_Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ingreso_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[Detalle_Ingreso] CHECK CONSTRAINT [FK_Detalle_Ingreso_Producto]
GO
ALTER TABLE [dbo].[Detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_venta_Detalle_Ingreso] FOREIGN KEY([id_detalle_ingreso])
REFERENCES [dbo].[Detalle_Ingreso] ([id_detalle_ingreso])
GO
ALTER TABLE [dbo].[Detalle_venta] CHECK CONSTRAINT [FK_Detalle_venta_Detalle_Ingreso]
GO
ALTER TABLE [dbo].[Detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_venta_Venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[Venta] ([id_venta])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalle_venta] CHECK CONSTRAINT [FK_Detalle_venta_Venta]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_Empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [FK_Ingreso_Empleado]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [FK_Ingreso_Proveedor]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Presentacion] FOREIGN KEY([id_presentacion])
REFERENCES [dbo].[Presentacion] ([id_presentacion])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Presentacion]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Empleado]
GO
/****** Object:  StoredProcedure [dbo].[sp_anular_ingreso]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_anular_ingreso]
@id_ingreso int
as
update Ingreso set estado='ANULADO' where id_ingreso=@id_ingreso
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_categoria]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_buscar_categoria]
@textobuscar varchar(50)
as
select * from Categoria where nombre like @textobuscar
+ '%' 
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_empleado]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[sp_buscar_empleado]
 @textobuscar varchar(20)
 as
 select * from Empleado where apellidos like @textobuscar + '%' or num_documento like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_ingreso_fecha]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_buscar_ingreso_fecha]
@fecha date,
@fecha2 date
as
select i.id_ingreso,(e.apellidos+' '+e.nombre)as Trabajador,
p.razon_social as Proveedor, i.fecha,i.tipo_comprobante,i.serie,i.correlativo,i.estado,
SUM(d.precio_compra*d.stock_inicial) as Total

from Detalle_Ingreso d inner join Ingreso i on d.id_ingreso =i.id_ingreso
inner join Proveedor p on i.id_proveedor=p.id_proveedor
inner join Empleado e on i.id_empleado= e.id_empleado

group by i.id_ingreso,e.apellidos+' '+e.nombre,
p.razon_social, i.fecha,i.tipo_comprobante,i.serie,i.correlativo,i.estado

having i.fecha>=@fecha and i.fecha<=@fecha2
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_presentacion]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_buscar_presentacion]
@textbuscar varchar(50)
as
select * from Presentacion where nombre like @textbuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_producto_nombre]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_buscar_producto_nombre]
@textobuscar varchar(50)
as
Select  Producto.id_producto,Producto.codigo_barra,Producto.nombre,Producto.descripcion,Categoria.nombre,Presentacion.nombre
from Categoria inner join Producto on Categoria.id_categoria=Producto.id_categoria 
inner join Presentacion on Producto.id_presentacion= Presentacion.id_presentacion
where Producto.codigo_barra like @textobuscar + '%' or Producto.nombre like @textobuscar + '%' 
order by Producto.id_producto desc
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_proveedor_razon]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_buscar_proveedor_razon]
@textobuscar varchar(50)
as
select * from Proveedor where razon_social like @textobuscar + '%'
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_venta_fecha]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_buscar_venta_fecha]
@fecha date,
@fecha2 date
as
select v.id_venta,(e.apellidos+' '+e.nombre)as Empleado,v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.cliente,
SUM((d.cantidad*d.precio_venta)-d.descuento)as Total

from Detalle_venta d inner join Venta v on d.id_venta=v.id_venta inner join Empleado e on v.id_empleado=e.id_empleado

group by v.id_venta,(e.apellidos+' '+e.nombre),v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.cliente

having v.fecha>=@fecha and v.fecha<=@fecha2
GO
/****** Object:  StoredProcedure [dbo].[sp_disminuir_stock_venta]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_disminuir_stock_venta]
@id_detalle_ingreso int,
@cantidad int
as
update Detalle_Ingreso set stock_actual=stock_actual-@cantidad
where id_detalle_ingreso=@id_detalle_ingreso
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_categoria]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_editar_categoria]
@id int,
@nombre varchar(50),
@descripcion varchar(100)
as
update Categoria set nombre=@nombre, descripcion=@descripcion
where id_categoria=@id
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_empleado]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[sp_editar_empleado]
 @id_empleado int,
 @nombre varchar(20),
 @apellidos varchar(20),
 @sexo varchar(1),
 @fecha_nac date,
 @num_doc varchar(12),
 @direccion varchar(100),
 @telefono varchar(10),
 @email varchar(50),
 @acceso varchar(20),
 @usuario varchar(20),
 @password varchar(20)
 as
 update Empleado set nombre=@nombre,apellidos=@apellidos,sexo=@sexo,fecha_nacimiento=@fecha_nac,num_documento=@num_doc,
 direccion=@direccion,telefono=@telefono,email=@email,acceso=@acceso,usuario=@usuario,password=@password
 where id_empleado=@id_empleado
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_presentacion]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_editar_presentacion]
@id int,
@nombre varchar(50),
@descripcion varchar(100)
as
update Presentacion set nombre=@nombre,descripcion=@descripcion where id_presentacion=@id
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_producto]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_editar_producto]
@id_producto int,
@codigo_barra varchar(50),
@nombre varchar(50),
@descripcion varchar(100),
@id_categoria int,
@id_presentacion int
as
update Producto set codigo_barra=@codigo_barra,nombre=@nombre,descripcion=@descripcion,id_categoria=@id_categoria,id_presentacion=@id_presentacion
where id_producto=@id_producto
GO
/****** Object:  StoredProcedure [dbo].[sp_editar_proveedor]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_editar_proveedor]
@id_proveedor int,
@razon varchar(50),
@sector varchar(50),
@tipo_doc varchar(20),
@numero_doc varchar(20),
@direccion varchar(100),
@telefono varchar(10),
@email varchar(50)
as
update Proveedor set razon_social=@razon,sector_comercial=@sector,tipo_documento=@tipo_doc,numero_documento=@numero_doc,
direccion=@direccion,telefono=@telefono,email=@email
where id_proveedor=@id_proveedor
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_categoria]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_eliminar_categoria]
@id int
as
delete from Categoria where id_categoria=@id
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_empleado]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[sp_eliminar_empleado]
 @id_empleado int
 as
 delete from Empleado where id_empleado=@id_empleado
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_presentacion]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_presentacion]
@id int
as
delete from Presentacion where id_presentacion=@id
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_producto]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_producto]
@id_producto int
as
delete from Producto where id_producto=@id_producto
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_proveedor]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_proveedor]
@id_proveedor int
as
delete from Proveedor where id_proveedor=@id_proveedor
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_venta]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_eliminar_venta]
@id_venta int
as
delete from Venta where id_venta=@id_venta
GO
/****** Object:  StoredProcedure [dbo].[sp_generar_serie_correlativo]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_generar_serie_correlativo]
@tipo varchar(20)
as
select isnull(max(convert(int,correlativo)),0) as Correlativo,
isnull(max(convert(int,serie)),0) as Serie

from Venta where serie=(select max(convert(int, serie))from Venta where tipo_comprobante=@tipo)
GO
/****** Object:  StoredProcedure [dbo].[sp_iniciar_sesion]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_iniciar_sesion]
@user varchar(20),
@pass varchar(20)
as
select  id_empleado,nombre,apellidos, acceso from Empleado
where usuario=@user and password=@pass
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_categoria]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertar_categoria]
@nombre varchar(50),
@descripcion varchar(100)
as
insert into Categoria (nombre, descripcion) values (@nombre, @descripcion)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_detalle_ingreso]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_detalle_ingreso]
@id_ingreso int,
@id_producto int,
@precio_compra money,
@precio_venta money,
@stock_inicial int,
@stock_actual int,
@fecha_produccion date,
@fecha_vence date
as
insert into Detalle_Ingreso(id_ingreso,id_producto,precio_compra,precio_venta,stock_inicial,stock_actual,fecha_produccion,fecha_vence)
values(@id_ingreso,@id_producto,@precio_compra,@precio_venta,@stock_inicial,@stock_actual,@fecha_produccion,@fecha_vence)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_detalle_venta]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_detalle_venta]
@id_venta int,
@id_detalle_ingreso int,
@cantidad int,
@precio_venta money,
@descuento money
as
insert into Detalle_venta(id_venta,id_detalle_ingreso,cantidad,precio_venta,descuento) values(@id_venta,@id_detalle_ingreso,
@cantidad,@precio_venta,@descuento)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_empleado]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[sp_insertar_empleado]
 @nombre varchar(20),
 @apellidos varchar(20),
 @sexo varchar(1),
 @fecha_nac date,
 @num_doc varchar(12),
 @direccion varchar(100),
 @telefono varchar(10),
 @email varchar(50),
 @acceso varchar(20),
 @usuario varchar(20),
 @password varchar(20)
 as
 insert into Empleado(nombre,apellidos,sexo,fecha_nacimiento,num_documento,direccion,telefono,email,acceso,usuario,password)
 values(@nombre, @apellidos, @sexo, @fecha_nac, @num_doc, @direccion, @telefono, @email, @acceso, @usuario, @password)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_ingreso]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_ingreso]
@id_ingreso int=null output,
@id_empleado int,
@id_proveedor int,
@fecha date,
@tipo_comprobante varchar(20),
@serie varchar(10),
@correlativo varchar(10),
@iva decimal(4,2),
@estado varchar(7)
as
insert into Ingreso(id_empleado,id_proveedor,fecha,tipo_comprobante,serie,correlativo,iva,estado)
values(@id_empleado,@id_proveedor,@fecha,@tipo_comprobante,@serie,@correlativo,@iva,@estado)
--OBTENER EL CODIGO AUTOGENERADO
SET @id_ingreso=@@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_presentacion]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_presentacion]
@nombre varchar(50),
@descripcion varchar(100)
as
insert into Presentacion(nombre,descripcion) values(@nombre, @descripcion)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_producto]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_producto]
@codigo_barra varchar(50),
@nombre varchar(50),
@descripcion varchar(100),
@id_categoria int,
@id_presentacion int
as
insert into Producto(codigo_barra, nombre,descripcion,id_categoria,id_presentacion) values(@codigo_barra,@nombre,@descripcion,@id_categoria,@id_presentacion)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_proveedor]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_proveedor]
@razon varchar(50),
@sector varchar(50),
@tipo_doc varchar(20),
@numero_doc varchar(20),
@direccion varchar(100),
@telefono varchar(10),
@email varchar(50)
as
insert into Proveedor(razon_social,sector_comercial,tipo_documento,numero_documento,direccion,telefono,email)
values(@razon,@sector,@tipo_doc,@numero_doc,@direccion,@telefono,@email)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_venta]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertar_venta]
@id_venta int=null output,
@id_empleado int,
@fecha date,
@tipo_comprobante varchar(20),
@serie varchar(8),
@correlativo int,
@iva decimal(4,2),
@cliente varchar(60)
as
insert into Venta(id_empleado,fecha,tipo_comprobante,serie,correlativo,iva,cliente)
values(@id_empleado,@fecha,@tipo_comprobante,@serie,@correlativo,@iva,@cliente)

set @id_venta=@@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_categoria]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_categoria]
as
select top 200 *from categoria
order by id_categoria desc 
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_detalle_ingreso]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_detalle_ingreso]
@textobuscar int
as
select d.id_producto,p.nombre as producto, d.precio_compra,d.precio_venta,d.stock_inicial,d.fecha_produccion,d.fecha_vence,
(d.stock_inicial * d.precio_compra)as SubTotal

from Detalle_Ingreso d inner join Producto p on d.id_producto=p.id_producto 

where d.id_ingreso=@textobuscar
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_detalle_venta]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_detalle_venta]
@id_venta int
as
select d.id_detalle_ingreso,p.nombre as Producto,d.cantidad,d.precio_venta,d.descuento,((d.precio_venta*d.cantidad)-d.descuento)as SubTotal

from Detalle_venta d inner join Detalle_Ingreso di on d.id_detalle_ingreso=di.id_detalle_ingreso
inner join Producto p on di.id_producto=p.id_producto

where id_venta=@id_venta
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_empleado]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_mostrar_empleado]
as
select top 100 * from Empleado order by apellidos desc
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_ingreso]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_ingreso]
as
select top 100 i.id_ingreso,(e.apellidos+' '+e.nombre)as Trabajador,
p.razon_social as Proveedor, i.fecha,i.tipo_comprobante,i.serie,i.correlativo,i.estado,
SUM(d.precio_compra*d.stock_inicial) as Total

from Detalle_Ingreso d inner join Ingreso i on d.id_ingreso =i.id_ingreso
inner join Proveedor p on i.id_proveedor=p.id_proveedor
inner join Empleado e on i.id_empleado= e.id_empleado

group by i.id_ingreso,e.apellidos+' '+e.nombre,
p.razon_social, i.fecha,i.tipo_comprobante,i.serie,i.correlativo,i.estado

order by i.id_ingreso desc
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_presentacion]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_presentacion]
as
select top 200 *from Presentacion
order by id_presentacion desc
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_producto]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--INNER JOIN CREADO POR MI PARA MOSTRAR PRODUCTO
create proc [dbo].[sp_mostrar_producto]
as
Select top 100 Producto.id_producto,Producto.codigo_barra,Producto.nombre,Producto.descripcion,Categoria.nombre,Presentacion.nombre
from Categoria inner join Producto on Categoria.id_categoria=Producto.id_categoria 
inner join Presentacion on Producto.id_presentacion= Presentacion.id_presentacion
order by Producto.id_producto desc
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_producto_venta]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_mostrar_producto_venta]
@textobuscar varchar(50)
as
select d.id_detalle_ingreso,a.codigo_barra,a.nombre,c.nombre as Categoria,p.nombre as Presentacion,
d.stock_actual,d.precio_compra,d.precio_venta,d.fecha_vence

from Producto a inner join Categoria c on a.id_categoria=c.id_categoria 
inner join Presentacion p on a.id_presentacion=p.id_presentacion
inner join Detalle_Ingreso d on a.id_producto=d.id_producto
inner join Ingreso i on d.id_ingreso=i.id_ingreso

where a.nombre like @textobuscar + '%' or a.codigo_barra=@textobuscar
and d.stock_actual>0 and i.estado<>'ANULADO'
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_proveedor]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_proveedor]
as
begin
select top 100 * from Proveedor order by id_proveedor desc
end
GO
/****** Object:  StoredProcedure [dbo].[sp_mostrar_ventas]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_mostrar_ventas]
as
select top 100 v.id_venta,(e.apellidos+' '+e.nombre)as Empleado,v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.cliente,
SUM((d.cantidad*d.precio_venta)-d.descuento)as Total

from Detalle_venta d inner join Venta v on d.id_venta=v.id_venta inner join Empleado e on v.id_empleado=e.id_empleado

group by v.id_venta,(e.apellidos+' '+e.nombre),v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.cliente

order by v.id_venta desc

GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_factura]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_reporte_factura]
@id_venta int
as
select v.id_venta,(e.apellidos+' '+e.nombre)as Empleado,v.fecha,v.tipo_comprobante,v.serie,v.correlativo,v.iva,v.cliente,
p.codigo_barra,p.nombre,dv.precio_venta,dv.cantidad,dv.descuento,(dv.cantidad*dv.precio_venta-dv.descuento)as Total_Parcial
from Detalle_venta dv inner join detalle_ingreso di
on dv.id_detalle_ingreso= di.id_detalle_ingreso inner join Producto p 
on p.id_producto=di.id_producto inner join Venta v on v.id_venta=dv.id_venta
inner join Empleado e on e.id_empleado=v.id_empleado

where v.id_venta=@id_venta
GO
/****** Object:  StoredProcedure [dbo].[sp_stock_producto]    Script Date: 14/2/2021 23:01:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_stock_producto]
as
SELECT dbo.Producto.codigo_barra, dbo.Producto.nombre, dbo.Categoria.nombre AS Categoria, 
sum(dbo.Detalle_Ingreso.stock_inicial)as Cantidad_ingreso, sum(dbo.Detalle_Ingreso.stock_actual)as Cantidad_stock,
(sum(dbo.Detalle_Ingreso.stock_inicial)-sum(dbo.Detalle_Ingreso.stock_actual))as Cantidad_venta
FROM   dbo.Ingreso INNER JOIN
             dbo.Detalle_Ingreso ON dbo.Ingreso.id_ingreso = dbo.Detalle_Ingreso.id_ingreso INNER JOIN
             dbo.Producto ON dbo.Detalle_Ingreso.id_producto = dbo.Producto.id_producto INNER JOIN
             dbo.Categoria ON dbo.Producto.id_categoria = dbo.Categoria.id_categoria

where Ingreso.estado<>'ANULADO'

group by dbo.Producto.codigo_barra, dbo.Producto.nombre, dbo.Categoria.nombre
GO
