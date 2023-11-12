USE master
go
--APAGANDO O BANCO DE DADOS COM O MESMO NOME QUE O SEU CASO EXISTA
drop database LancamentoBalistico
go
--CRIANDO O BANCO DE DADOS JÁ DANDO O LOCAL DE CADA ARQUIVO VAI SER SALVO
create database LancamentoBalistico
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LancamentoBalistico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LancamentoBalistico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LancamentoBalistico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\LancamentoBalistico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
--CHAMANDO O BANCO DE DADOS CRIADO PARA SER USADO
USE [LancamentoBalistico]
GO
--ALGUMAS CONFIGURAÇÕES DO BANCO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
--CRIANDO A TABELA DE USUARIO
drop table [dbo].[USUARIO]

CREATE TABLE [dbo].[USUARIO](
	[idUsuario] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[nome] [varchar] (20) NOT NULL,
	[email] [varchar] (60) NOT NULL
)
go

drop table [dbo].[PROJETIL]

CREATE TABLE [dbo].[PROJETIL](
	[idProjetil] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[posicaoInicialX] [float],
	[posicaoFinalX] [float],
	[posicaoInicialY] [float],
	[posicaoFinalY] [float],

)
go

drop table [dbo].[LANCA]

CREATE TABLE [dbo].[LANCA](
	[IdLanca] [int] NOT NULL IDENTITY(1,1),
	[velInicial] [float] ,
	[angulo] [int],
	[idUsuario] [int] ,
	[idProjetil] [int],
	CONSTRAINT PK_id_lanca PRIMARY KEY (idUsuario,idProjetil),
	CONSTRAINT FK_id_usuario FOREIGN KEY (idUsuario) REFERENCES [dbo].[USUARIO] (idUsuario),
	CONSTRAINT FK_idProjetil FOREIGN KEY (idProjetil) REFERENCES [dbo].[PROJETIL] (idProjetil)
)
go
drop table [dbo].[METEORO]

CREATE TABLE [dbo].[METEORO](
	[idMeteoro] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[posicaoInicialX] [float],
	[posicaoFinalX] [float],
	[posicaoInicialY] [float],
	[posicaoFinalY] [float],
)
go

drop table [dbo].[intercepta]

CREATE TABLE [DBO].[INTERCEPTA](
	[idIntercepta] [int] not null IDENTITY(1,1),
	[tempo] [int],
	[pontoX] [float],
	[pontoY] [float],
	[idProjetil] [int],
	[idMeteoro] [int],
	CONSTRAINT PK_id_intercepta PRIMARY KEY (idProjetil,idMeteoro),
	CONSTRAINT FK_id_Projetil FOREIGN KEY (idProjetil) REFERENCES [dbo].[PROJETIL] (idProjetil),
	CONSTRAINT FK_id_Meteoro FOREIGN KEY (idMeteoro) REFERENCES [dbo].[METEORO] (idMeteoro)
)

INSERT INTO dbo.PROJETIL (posicaoInicialX, posicaoFinalX,posicaoInicialY,posicaoFinalY)
	values(88.2,89.2,102.2,100.3)
go
INSERT INTO dbo.PROJETIL (posicaoInicialX, posicaoFinalX,posicaoInicialY,posicaoFinalY)
	values(89.2,79.2,112.2,101.3)
go
INSERT INTO dbo.PROJETIL (posicaoInicialX, posicaoFinalX,posicaoInicialY,posicaoFinalY)
	values(68.2,99.2,112.2,110.3)
go
INSERT INTO dbo.PROJETIL (posicaoInicialX, posicaoFinalX,posicaoInicialY,posicaoFinalY)
	values(85.2,86.2,107.2,108.3)
go
INSERT INTO dbo.PROJETIL (posicaoInicialX, posicaoFinalX,posicaoInicialY,posicaoFinalY)
	values(83.2,82.2,122.2,120.3)
go
INSERT INTO dbo.PROJETIL (posicaoInicialX, posicaoFinalX,posicaoInicialY,posicaoFinalY)
	values(87.2,87.2,105.2,106.3)
go

INSERT INTO dbo.METEORO (posicaoInicialX, posicaoFinalX, posicaoInicialY, posicaoFinalY)
	values(56.1,58.3,82.1,86.3)
go
INSERT INTO dbo.METEORO (posicaoInicialX, posicaoFinalX, posicaoInicialY, posicaoFinalY)
	values(54.1,58.3,82.1,86.3)
go
INSERT INTO dbo.METEORO (posicaoInicialX, posicaoFinalX, posicaoInicialY, posicaoFinalY)
	values(55.1,58.3,82.1,86.3)
go
INSERT INTO dbo.METEORO (posicaoInicialX, posicaoFinalX, posicaoInicialY, posicaoFinalY)
	values(57.1,58.3,82.1,86.3)
go
INSERT INTO dbo.METEORO (posicaoInicialX, posicaoFinalX, posicaoInicialY, posicaoFinalY)
	values(53.1,58.3,82.1,86.3)
go
INSERT INTO dbo.METEORO (posicaoInicialX, posicaoFinalX, posicaoInicialY, posicaoFinalY)
	values(52.1,58.3,82.1,86.3)
go
INSERT INTO dbo.USUARIO(nome,email)
	values('diego', 'teset@teste.com')
go
INSERT INTO dbo.USUARIO(nome,email)
	values('thomas', 'teset@teste.com')
go
INSERT INTO dbo.USUARIO(nome,email)
	values('emilly', 'teset@teste.com')
go
INSERT INTO dbo.USUARIO(nome,email)
	values('otavio', 'teset@teste.com')
go
INSERT INTO dbo.USUARIO(nome,email)
	values('thais', 'teset@teste.com')
go
INSERT INTO dbo.USUARIO(nome,email)
	values('maria', 'teset@teste.com')
go
select * from dbo.PROJETIL
select * from dbo.METEORO
select * from dbo.USUARIO

SET @idUsuario = LAST_INSERT_idUsuario();
INSERT INTO dbo.LANCA (angulo,velInicial,idProjetil, idUsuario)
	values(30,33.5,(select p.idProjetil from dbo.PROJETIL p where idProjetil=1),(select u.idUsuario from dbo.USUARIO u where idUsuario=1))
go
INSERT INTO dbo.LANCA (angulo,velInicial, idProjetil)
	values(30,31.5,2,2)
go
INSERT INTO dbo.LANCA (angulo,velInicial)
	values(32,32.5,3,3)
go
INSERT INTO dbo.LANCA (angulo,velInicial)
	values(33,32.5,4,4)
go
INSERT INTO dbo.LANCA (angulo,velInicial)
	values(30,42.5,5,5)
go
INSERT INTO dbo.LANCA (angulo,velInicial)
	values(41,32.5,6,6)
go

select * from dbo.LANCA