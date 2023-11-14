--==============================================================================--
--CRIAÇÃO DE STORAGE PROCEDURES E TRIGGERS PARA PROGRAMA DE LANÇAMENTO BALISTICO--
--==============================================================================--
/*INTEGRANTES:
		ADRIANA
		BIANCA
		DIEGO
		LUCAS
		VITORIA

*/
--==============================================================================--

USE [LancamentoBalistico]
GO

--SP QUE CONFORME O ANGULO FORNECIDO BUSCA OS PONTO FINAL DE X E Y 
--DO PROJETIL E DO METEORO E JUNTA EM UMA TABELA TEMPORARIA
CREATE OR ALTER PROCEDURE sp_ex_dados_angulo (@angulo int) as
begin
	SELECT
		p.posicaoFinalX as Projetil_final_X,
		p.posicaoFinalY as Projetil_final_Y,
		m.posicaoFinalX as Meteoro_final_X,
		m.posicaoFinalY as Meteoro_final_Y
	FROM LANCA l
	JOIN PROJETIL p ON l.idProjetil = p.idProjetil
	JOIN INTERCEPTA i on p.idProjetil = i.idProjetil
	join METEORO m on i.idMeteoro = m.idMeteoro
	WHERE @angulo = l.angulo
end

select * from dbo.LANCA
select * from dbo.METEORO
select * from dbo.PROJETIL p
join dbo.LANCA l on l.idProjetil=p.idProjetil

declare @res int
exec @res =  sp_ex_dados_angulo 30;

--SP QUE CONFORME A VELOCIDADE FORNECIDA BUSCA OS PONTO FINAL DE X E Y
--DO PROJETIL E DO METEORO E JUNTA EM UMA TABELA TEMPORARIA
CREATE OR ALTER PROCEDURE sp_ex_dados_velocidade (@velocidade float) as
begin
	
	SELECT
		p.posicaoFinalX as Projetil_final_X,
		p.posicaoFinalY as Projetil_final_Y,
		m.posicaoFinalX as Meteoro_final_X,
		m.posicaoFinalY as Meteoro_final_Y
	FROM LANCA l
	JOIN PROJETIL p ON l.idProjetil = p.idProjetil
	JOIN INTERCEPTA i on p.idProjetil = i.idProjetil
	join METEORO m on i.idMeteoro = m.idMeteoro
	WHERE @velocidade = l.velInicial
end

select * from dbo.METEORO
select * from dbo.PROJETIL p
join dbo.LANCA l on l.idProjetil=p.idProjetil

declare @vel FLOAT
exec @vel =  sp_ex_dados_velocidade 32.5;

--SP QUE RECEBE OS DADOS EXTERNOS E CARREGA A TABELA METEORO
CREATE OR ALTER PROCEDURE SP_INSERT_DADOS_METEORO (
	@POSICAO_INICIAL_X FLOAT,
	@POSICAO_FINAL_X FLOAT,
	@POSICAO_INICIAL_Y FLOAT,
	@POSICAO_FINAL_Y FLOAT) AS
BEGIN
	--INSERE OS DADOS EXTERNOS RECEBIDOS NA TABELA METEORO
	INSERT INTO dbo.METEORO(posicaoInicialX, posicaoFinalX, posicaoInicialY, posicaoFinalY) 
		values (@POSICAO_INICIAL_X,@POSICAO_FINAL_X,@POSICAO_INICIAL_Y,@POSICAO_FINAL_Y);
END

select * from METEORO
exec SP_INSERT_DADOS_METEORO 58.2,102.5,25.3,89.3

--SP QUE RECEBE OS DADOS EXTERNOS E CARREGA A TABELA USUARIOS
CREATE OR ALTER PROCEDURE SP_INSERT_USUARIO (@NOME VARCHAR(20), @EMAIL VARCHAR(60))AS
BEGIN
	--INSERE OS DADOS EXTERNOS RECEBIDOS NA TABELA USUARIO
	INSERT INTO dbo.USUARIO(nome, email)
		VALUES(@NOME, @EMAIL);

END

--SP QUE RECEBE OS DADOS EXTERNOS E CARREGA AS TABELAS 
-- LANÇA E PROJETIL
CREATE OR ALTER PROCEDURE SP_INSERT_DADOS_LP (
	@VELOCIDADE_INICIAL FLOAT,
	@ANGULO INT,
	@POSICAO_INICIAL_X FLOAT,
	@POSICAO_FINAL_X FLOAT,
	@POSICAO_INICIAL_Y FLOAT,
	@POSICAO_FINAL_Y FLOAT, 
	@TEMPO INT
	) AS
BEGIN 
	
	--INSERE OS DADOS EXTERNOS RECEBIDOS NA TABELA PROJÉTIL
	INSERT INTO dbo.PROJETIL(posicaoInicialX, posicaoFinalX,posicaoInicialY,posicaoFinalY,tempo)
		VALUES(@POSICAO_INICIAL_X,@POSICAO_FINAL_X,@POSICAO_INICIAL_Y,@POSICAO_FINAL_Y,@TEMPO);
	--OBTEM O ID DA TABELA USUARIO E DA TABELA PROJETIL
	DECLARE @ID_USUARIO INT = (SELECT Top 1(L.idUsuario)
						FROM USUARIO L
						ORDER BY L.idUsuario DESC);
	DECLARE @ID_PROJETIL INT = (SELECT Top 1(P.idProjetil)
						FROM PROJETIL P
						ORDER BY P.idProjetil DESC);
	--INSERE OS DADOS EXTERNOS RECEBIDOS NA TABELA LANÇA
	INSERT INTO dbo.LANCA(angulo,velInicial,idProjetil, idUsuario)
		VALUES(@ANGULO, @VELOCIDADE_INICIAL,@ID_PROJETIL,@ID_USUARIO);

END


exec SP_INSERT_DADOS_LP 35.3,30,1.1,89.5,1.1,100.1;
select * from USUARIO
select * from PROJETIL
select * from LANCA