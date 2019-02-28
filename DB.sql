create database ObligatorioPrimero
go
use ObligatorioPrimero

create table Farmaceutica(
rut bigint primary key,
nombre varchar (30) not null,
mail varchar(30) not null,
direccion varchar (50) not null
)
go
create table Medicamento (
codigo int not null,
rut bigint  not null,
nombre varchar (20) not null,
descipcion varchar(255) not null,
precio money not null,
foreign key(rut) references farmaceutica (rut),
primary key(codigo, rut)
)
go

create table Usuario(
userName varchar(20) primary key,
nombre varchar(20) not null,
apellido varchar(20) not null,
pass varchar(20) not null,
)
go


create table Empleado(
userName varchar(20) primary key,
horaInicio time not null,
horaFin time not null,
foreign key (userName) references Usuario (userName)
)
go

create table Cliente
(
userName varchar(20) primary key,
direccion varchar(50) not null,
telefono varchar (9) not null,
foreign key (userName) references Usuario (userName)
)
go

create table Pedido
(
numero int identity(1,1) primary key,
codMedicamento int not null,
rut bigint,
userName varchar(20) not null,
cantidad int not null,
estado varchar(10) not null,
foreign key (userName) references Cliente (userName),
foreign key (codMedicamento,rut) references Medicamento (codigo,rut)
)
go

--datos de prueba
insert into Farmaceutica values(123456789012,'Bayer','bayer@bayer.com', 'Soriano 1821')
insert into Farmaceutica values(111111111111,'Pharmaton','ventas@Pharmaton.com', 'Canelones 2120')
insert into Farmaceutica values(987654321012,'Roemmers', 'somosRoemmers@roemmeanos.com', 'Colonia 1999')
insert into Farmaceutica values(999999999999,'Otra', 'juanPerez@misterioso.com','18 de julio y Ejido')
go
insert into Medicamento values(1,123456789012,'aspirina','Fórmula mejorada',150)
insert into Medicamento values(2,123456789012,'Redoxon', 'Aprobada por el ISN',350)
insert into Medicamento values(6,123456789012,'Supradyn','Complete multivitamin and multi mineral formula',250)
insert into Medicamento values(2,111111111111,'Pharmaton Complex','ginseng G115',500) 
insert into Medicamento values(1,999999999999,'remedio','para dolores musculares',500) 
insert into Medicamento values(1,987654321012,'DOLOREX','Naproxeno 500 mg',400) 
insert into Medicamento values(8,987654321012,'ALERFAST FORTE','Loratadina 10mg.Dexametasona 2mg.',300)
go
insert into Usuario values('usuario','user','Empleado','pwd')
insert into Usuario values('empleado','Empleado','test','pwd')
insert into Usuario values('cliente','Cliente','test','pwd')
insert into Usuario values('aviera','Agustin','Viera','123456')
insert into Usuario values('agunz','Abril','Gunz','123456')
insert into Usuario values('dgonzalez','Diego','Gonzalez','123456')
go
insert into Empleado values('usuario','09:00','18:00')
insert into Empleado values('empleado','12:00','18:00')

insert into Cliente values('cliente','Bv. Artigas','099123456')
insert into Cliente values('aviera','Rocha','098654321')
insert into Cliente values('agunz','18 de julio','26221324')
insert into Cliente values('dgonzalez','Rivera','099456789')

insert into Pedido(codMedicamento,rut,userName,cantidad,estado) values(1,123456789012,'agunz',5,'Entregado')
insert into Pedido(codMedicamento,rut,userName,cantidad,estado) values(2,123456789012,'dgonzalez',2,'Entregado')
insert into Pedido(codMedicamento,rut,userName,cantidad,estado) values(2,111111111111,'cliente',3,'Entregado')

--sp
go
--Farmaceutica
create proc AltaFarmaceutica
@rut bigint, @nombre varchar(30), @mail varchar(30), @direccion varchar (50)
as
if(exists(select * from Farmaceutica where rut = @rut))
return -1 --ya existe
begin try
insert into Farmaceutica values(@rut, @nombre, @mail, @direccion)
return 1
end try
begin catch
return -1
end catch
go

create proc ModificarFarmaceutica
@rut bigint, @nombre varchar(30), @mail varchar(30), @direccion varchar(50)
as
if (not exists (select * from  Farmaceutica  where rut = @rut))
return -1
begin try
Update Farmaceutica set Nombre= @nombre, mail = @mail, direccion = @direccion where rut = @rut
return 1
end try
begin catch
return -2
end catch
go
create proc EliminarFarmaceutica
@rut bigint
as
if (not exists (select * from  Farmaceutica  where rut = @rut))
return -1-- no existe
if (exists (select * from Pedido where rut = @rut))
return -2-- tiene pedidos
begin try
begin tran
delete Medicamento where rut = @rut
delete Farmaceutica where rut = @rut
commit tran
return 1
end try
begin catch
return -3
rollback tran
end catch
go

create proc  BuscarFarmaceutica
@rut bigint
as
select * from Farmaceutica where rut = @rut;
go

create proc ListarFarmaceuticas
as
select nombre from Farmaceutica
go

--Medicamento
create proc ModificarMedicamento
@rut bigint, @codigo int, @nombre varchar(20), @descipcion varchar(255), @precio money
as
if( not exists(select * from Medicamento where rut = @rut and codigo = @codigo))
return -1 --no existe
begin try
update Medicamento set nombre = @nombre, descipcion = @descipcion, precio = @precio where rut = @rut and codigo = @codigo
return 1
end try
begin catch
return -3
end catch
go

create proc AltaMedicamento
@rut bigint, @codigo int, @nombre varchar(20), @descipcion varchar(255), @precio money
as
if( exists(select * from Medicamento where rut = @rut and codigo = @codigo))
return -1 --ya existe
if( not exists(select * from Farmaceutica where rut = @rut))
return -2 --no existe Farmaceutica
begin try
insert into Medicamento values(@codigo,@rut,@nombre,@descipcion,@precio)
return 1
end try
begin catch
return -3
end catch
go

create proc BuscarMedicamento
@rut bigint, @codigo int
as
select *  from  Medicamento where descipcion = @rut and codigo = @codigo;
go

create proc EliminarMedicamento
@rut bigint, @codigo int
as
if (not exists (select * from  Medicamento  where rut = @rut and codigo = @codigo))
return -1-- no existe
begin try
begin tran
delete Pedido where rut = @rut and codMedicamento = @codigo
delete Medicamento where rut = @rut and codigo = @codigo
commit tran
return 1
end try
begin catch
rollback tran
return -2
end catch
go

create proc ListarMedicamentos
as
select * from Medicamento order by nombre
go

create proc MedicamentosxFarmaceutica
@rut bigint
as
select * from Medicamento where rut = @rut
go

--Empleado
Create proc AgregarEmpleado
@userName varchar(20), @nombre varchar(20), @apellido varchar(20), @pass varchar(20),
@horaInicio time,  @horaFin time
as
if (exists (select * from  Usuario  where userName = @userName))
return -1 --ya  esta creado
begin try
begin tran
insert into Usuario Values(@userName,@nombre,@apellido,@pass)
insert into Empleado values(@userName,@horaInicio,@horaFin)
commit tran
return 1
end try
begin catch
rollback tran
return -2
end catch
go

create proc BuscarEmpleado
@userName varchar(20)
as
if (exists (select * from Cliente where userName = @userName))
return -1 --Es cliente.
select * from  Empleado where userName = @userName
go

create proc BuscarCliente
@userName varchar(20)
as
if (exists (select * from Empleado where userName = @userName))
return -1 --Es Empleado.
select * from  Cliente where userName = @userName
go
create proc ModificarEmpleado
@userName varchar(20), @nombre varchar(20), @apellido varchar(20), @pass varchar(20),
@horaInicio time,  @horaFin time
as
if (not exists (select * from Empleado where userName = @userName))
return -1 --no existe
begin try
begin tran
update Usuario set nombre = @nombre, apellido = @apellido, pass = @pass where userName = @userName
update Empleado  set horaInicio = @horaInicio, horaFin = @horaFin where userName = @userName
commit tran
return 1
end try
begin catch
rollback tran
return -2
end catch
go

create proc EliminarEmpleado
@username varchar(20)
as
if (not exists (select * from  Empleado  where userName = @userName))
return -1 --no existe
begin try
begin tran
delete Empleado  where userName = @username
delete Usuario where userName = @username
commit tran
 return 1
end try
begin catch
rollback tran
return -2
end catch
go

--cliente

create proc AgregarCliente
@userName varchar(20), @nombre varchar(20), @apellido varchar(20), @pass varchar(20),
@direccion varchar,  @telefono varchar
as
if (exists (select * from  Usuario  where userName = @userName))
return -1 --ya  esta creado
begin try
begin tran
insert into Usuario Values(@userName,@nombre,@apellido,@pass)
insert into Cliente values(@userName,@direccion,@telefono)
commit tran
return 1
end try
begin catch
rollback tran
return -2
end catch
go

--pedido

create proc AltaPedido
@codMedicamento int , @rut bigint, @userName varchar(20), @cantidad int
as
if (not exists (select * from Cliente where userName = @userName))
return -1
if (not exists (select * from Medicamento where codigo = @codMedicamento and rut = @rut))
return -2
if (@cantidad < 1)
return -3
begin try
insert into Pedido (codMedicamento,rut,userName,cantidad,estado ) values (@codMedicamento,@rut,@userName,@cantidad,'generado')
return 1
end try
begin catch
return -4
end catch
go
create proc EliminarPedido
@numero int
as
if (not exists (select * from Pedido where numero = @numero))
return -1
if (not ((select estado from Pedido where numero = @numero) = 'generado'))
return -2
begin try
delete Pedido where @numero = numero
return 1
end try
begin catch
return -3
end catch
go
create proc BuscarPedido
@num  int
as
select * from Pedido where numero = @num
go
create proc CambiarEstado
@num int
as
if((select estado from Pedido where numero = @num ) ='entregado')
return -1
if((select estado from Pedido where numero = @num ) not in('generado','enviado'))
return -2
begin try
if ((select estado from Pedido where numero = @num ) ='generado')
update Pedido set estado = 'enviado' where numero = @num
else
update Pedido set estado = 'entregado' where numero = @num
return 1
end try
begin catch
return -3
end catch
go

create proc ListarPedido
@estado int
as
if (@estado = 0)
select * 
from Pedido 
else if (@estado = 1)
select * from Pedido where estado ='generado' order by numero
else if (@estado = 2)
select * from Pedido where estado ='entregado' order by numero
else if (@estado = 3)
select * from pedido where  estado = 'generado' or  estado = 'enviado' order by numero
go

create proc PedidosporMedicamento
@codMed int , @rut bigint
as
select * from Pedido where  codMedicamento = @codMed and rut = @rut
go
create proc PedidosGeneradosxCliente
@user varchar
as
select * from Pedido where estado = 'generado' and userName = @user
go


create proc Login
@userName varchar(20),
@password varchar(20)
as
select *
from Usuario u
where @userName = u.userName
and @password = u.pass
go