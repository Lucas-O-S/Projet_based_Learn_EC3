--==============================================================================--
--CRIAÇÃO DE STORAGE PROCEDURES E TRIGGERS PARA PROGRAMA DE LANÇAMENTO BALISTICO--
--==============================================================================--
/*INTEGRANTES:
		ADRIANA
		BEATRIZ 
		DIEGO SOUZA LIMA
		LUCAS OLIVEIRA SILVA
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
		l.velinicial as Velocidade_Inicial,
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

--==================================================================================


--SP QUE CONFORME A VELOCIDADE FORNECIDA BUSCA OS PONTO FINAL DE X E Y
--DO PROJETIL E DO METEORO E JUNTA EM UMA TABELA TEMPORARIA
CREATE OR ALTER PROCEDURE sp_ex_dados_velocidade (@velocidade float) as
begin
	
	SELECT
		l.angulo as Angulo,
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

--=================================================================================


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

--============================================================================================


--SP QUE RECEBE OS DADOS EXTERNOS E CARREGA A TABELA USUARIOS
CREATE OR ALTER PROCEDURE SP_INSERT_USUARIO (@NOME VARCHAR(20), @EMAIL VARCHAR(60))AS
BEGIN
	--INSERE OS DADOS EXTERNOS RECEBIDOS NA TABELA USUARIO
	INSERT INTO dbo.USUARIO(nome, email)
		VALUES(@NOME, @EMAIL);

END

--==========================================================================================


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
	DECLARE @ID_USUARIO INT = (SELECT Top 1(U.idUsuario)
						FROM USUARIO U
						ORDER BY U.idUsuario DESC);
	DECLARE @ID_PROJETIL INT = (SELECT Top 1(P.idProjetil)
						FROM PROJETIL P
						ORDER BY P.idProjetil DESC);
	--INSERE OS DADOS EXTERNOS RECEBIDOS NA TABELA LANÇA
	INSERT INTO LANCA(angulo,velInicial,idProjetil, idUsuario)
		VALUES(@ANGULO, @VELOCIDADE_INICIAL,@ID_PROJETIL,@ID_USUARIO);

END


