create database Ejemplo
--drop database Ejemplo
use Ejemplo


--||========================================================================|| GESTION DE LOS ROLES DE USUARIO ||=================================||
create table Rol(
IdRol int identity(1,1) primary key not null,
NombreRol nvarchar(20) not null,
EstadoR bit default 1
)

Insert into Rol Values('Lector',1)
Insert into Rol Values('Lector Escritor',1)
Insert into Rol Values('Administrador',1)

alter proc SP_VRol
as
select dbo.Rol.IdRol as [Id], dbo.Rol.NombreRol as [Rol], dbo.Rol.EstadoR as [Estado] from Rol where EstadoR = 1

--||===========================================================================|| GESTION DEL USUARIO ||===========================================||

create table Usuario(
IdUsuario int identity(1,1) primary key not null,
username nvarchar(35) not null,
contra varbinary(8000) not null,
IdRol int foreign key references Rol(IdRol) not null,
Estado bit default 1
)

Insert into Usuario Values('Omar123','123',1,1)
Insert into Usuario Values('Jerry256','123',2,1)
Insert into Usuario Values('Steven789','123',3,1)

--||===================================================|| PROCEDIMIENTOS ALMACENADOS || ================================||

alter proc SP_INUsuario
@NU nvarchar(35),
@CU nvarchar(35),
@IDR int
as
declare @Rol as int
set @Rol = (select IdRol from Rol where IdRol =@IDR)
declare @ER as bit
set @ER = (select EstadoR from Rol where IdRol =@IDR )

if(@Rol =@IDR)
begin
	if(@ER = 1)
	begin
		Insert into Usuario Values(@NU,(dbo.FN_Contra(@CU)),@IDR,1)
	end
	else
	begin
		print 'Usuario dado de Baja'
	end
end
else
begin
	print 'Usuario no encontrado'
end

SP_INUsuario 'Omar','MOMO123',4


select * from Usuario

alter proc SP_VUsuario
as
SELECT IdUsuario as[Id] , username as [Usuario], dbo.FN_DesContra (contra) as [Contrasena], Estado as [Estado] FROM  Usuario

--||===================================================|| FUNCIONES ||====================================||
--|| CIFRADO DE UNA CONTRASENA
alter function FN_Contra
(
	@clave varchar(20) 
)
returns VarBinary(8000)
as
begin
    declare @pass as VarBinary (8000)
    set @pass = ENCRYPTBYPASSPHRASE('dbUser20',@clave)
    return @pass
end

	

--|| Descrifrado de Contrasena
alter function FN_DesContra
(
    @clave varbinary(8000)
)
returns varchar(20)
as
begin
    declare @pass as varchar(20)
    set @pass = DECRYPTBYPASSPHRASE('dbUser20',@clave)
    return @pass
end

--||======================================================================|| GESTION DE LOS FRAMES SIGUIENTES
create table Clientes(
	IdCliente int identity(1,1) primary key not null,
	PNombre nvarchar(15) not null,
	SNombre nvarchar(15),
	PApell nvarchar(15) not null,
	SApell nvarchar(15),
	DirC nvarchar(70) not null,
	TelC char(8) check(TelC like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	EstadoC bit default 1
)

--Procedimientos Almacenados

create proc SP_INCliente
@PN nvarchar(15),
@SN nvarchar(15),
@PA nvarchar(15),
@SA nvarchar(15),
@DC nvarchar(70),
@TC char(8)
as
declare @Tel as char(1)
set @Tel = (select SUBSTRING (@TC,1,1))
if(@Tel='2' or @Tel='5' or @Tel='7' or @Tel='8' )
begin
	Insert into Clientes Values(@PN,@SN,@PA,@SA,@DC,@TC,1)
end
else
begin print 'Error Con el Numero' end

create proc SP_UPCliente
@Id int,
@PN nvarchar(15),
@SN nvarchar(15),
@PA nvarchar(15),
@SA nvarchar(15),
@DC nvarchar(70),
@TC char(8)
as
declare @Tel as char(1)
set @Tel = (select SUBSTRING (@TC,1,1))
declare @idd as int
set @idd = (select IdCliente from Clientes WHere IdCliente = @Id)
declare @EC as bit
set @EC = (select EstadoC From Clientes where IdCliente = @Id)
if(@idd =@Id and @EC = 1)
begin
	if(@Tel='2' or @Tel='5' or @Tel='7' or @Tel='8' )
	begin
		update Clientes set PNombre =@PN, SNombre =@SN, PApell = @PA, SApell =@SA, DirC =@DC , TelC=@TC where IdCliente =@Id
	end
	else
	begin print 'Error Con el Numero' end
end
else
begin
	print 'No se encuentra el Cliente'
end


create proc SP_DBCliente
@Id int
as
declare @idd as int
set @idd = (select IdCliente from Clientes WHere IdCliente = @Id)
declare @EC as bit
set @EC = (select EstadoC From Clientes where IdCliente = @Id)
if(@idd =@Id)
begin
	if(@EC = 1)
	begin
		Update Clientes set EstadoC = 0 where IdCliente =@Id
	end
	else
	begin
		print 'Cliente Ya dado de Baja'
	end
end
else
begin
	print 'No se encuentra el Cliente'
end

create proc SP_SACliente
@Id int
as
declare @idd as int
set @idd = (select IdCliente from Clientes WHere IdCliente = @Id)
declare @EC as bit
set @EC = (select EstadoC From Clientes where IdCliente = @Id)
if(@idd =@Id)
begin
	if(@EC = 1)
	begin
		select * from V_Cliente where Id = @Id
	end
	else
	begin
		print 'Cliente Ya dado de Baja'
	end
end
else
begin
	print 'No se encuentra el Cliente'
end


create proc SP_VCliente
as
select * from V_Cliente where Estado = 1

--Vista
create View V_Cliente
as
SELECT IdCliente AS Id, PNombre AS [Primer Nombre], SNombre AS [Segundo Nombre], PApell AS [Primer Apellido], SApell AS [Segundo Apellido], DirC AS Direccion, TelC AS Telefono, EstadoC AS Estado
FROM  dbo.Clientes


sp_addlogin 'Omar2020','Sist20','Ejemplo'
sp_addsrvrolemember 'Omar2020','sysadmin'

sp_adduser 'Omar2020','YAZE'
sp_addrolemember 'db_datareader','YAZE'


select name,password from sys.syslogins
where name='Omar2020'


