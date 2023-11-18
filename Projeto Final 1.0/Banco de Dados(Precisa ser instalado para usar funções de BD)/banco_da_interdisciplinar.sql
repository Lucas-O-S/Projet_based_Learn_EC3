--==============================================================================--
--CRIAÇÃO DE STORAGE PROCEDURES E TRIGGERS PARA PROGRAMA DE LANÇAMENTO BALISTICO--
--==============================================================================--
/*INTEGRANTES:
		ADRIANA
		BEATRIZ
		DIEGO DE SOUZA LIMA
		LUCAS
		VITORIA

*/
--==============================================================================--
USE master
go

--==============================================================================

--APAGANDO O BANCO DE DADOS COM O MESMO NOME QUE O SEU CASO EXISTA
drop database LancamentoBalistico
go

--==================================================================================

--CRIANDO O BANCO DE DADOS JÁ DANDO O LOCAL DE CADA ARQUIVO VAI SER SALVO
create database LancamentoBalistico
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LancamentoBalistico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LancamentoBalistico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LancamentoBalistico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\LancamentoBalistico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

--==================================================================================

--CHAMANDO O BANCO DE DADOS CRIADO PARA SER USADO
USE [LancamentoBalistico]
GO

--===================================================================================

--ALGUMAS CONFIGURAÇÕES DO BANCO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

--=====================================================================================

--CRIANDO A TABELA DE USUARIO
drop table [dbo].[USUARIO]

CREATE TABLE [dbo].[USUARIO](
	[idUsuario] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[nome] [varchar] (20) NOT NULL,
	[email] [varchar] (60) NOT NULL
)
go

--CRIANDO A TABELA DE PROJETIL
drop table [dbo].[PROJETIL]

CREATE TABLE [dbo].[PROJETIL](
	[idProjetil] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[posicaoInicialX] [float],
	[posicaoFinalX] [float],
	[posicaoInicialY] [float],
	[posicaoFinalY] [float],
	[tempo] [int]
)
go

--CRIANDO A TABELA DE LANÇA
drop table [dbo].[LANCA]

CREATE TABLE [dbo].[LANCA](
	[IdLanca] [int] NOT NULL IDENTITY(1,1),
	[velInicial] [float] ,
	[angulo] [int],
	[idUsuario] [int] ,
	[idProjetil] [int],
	[data_inclusao] [DATETIME],
	CONSTRAINT PK_id_lanca PRIMARY KEY (idUsuario,idProjetil),
	CONSTRAINT FK_id_usuario FOREIGN KEY (idUsuario) REFERENCES [dbo].[USUARIO] (idUsuario),
	CONSTRAINT FK_idProjetil FOREIGN KEY (idProjetil) REFERENCES [dbo].[PROJETIL] (idProjetil)
)
go

--CRIANDO A TABELA DE METEORO
drop table [dbo].[METEORO]

CREATE TABLE [dbo].[METEORO](
	[idMeteoro] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[posicaoInicialX] [float],
	[posicaoFinalX] [float],
	[posicaoInicialY] [float],
	[posicaoFinalY] [float],
)
go

--CRIANDO A TABELA INTERCEPTA
drop table [dbo].[INTERCEPTA]

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
