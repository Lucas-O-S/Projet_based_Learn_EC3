--==============================================================================--
--******SCRIPT DE CRIAÇÃO DE TRIGGERS PARA BANCO DE DADOS LANÇAMENTO BALISTICO****
--==============================================================================--
/*INTEGRANTES:
		ADRIANA
		BIANCA
		DIEGO DE SOUZA LIMA
		LUCAS
		VITORIA

*/
--==============================================================================--

USE [LancamentoBalistico]
GO
--TRIGGER QUE INSERE A DATA PARA CADA REGISTRO QUE É INSERIDO
-- NA TABELA LANCA
CREATE OR ALTER TRIGGER TRG_INSERCAO_DATA_HORA ON LANCA
FOR INSERT AS
BEGIN
	--DECLARAÇÃO DA VARIAVEL QUE PUXA DATA E HORA--
	DECLARE @DATA_E_HORA DATETIME = GETDATE();
	--LOGICA DE INSERÇÃO DE DATA E HORA--
	UPDATE LANCA 
		SET data_inclusao = @DATA_E_HORA
END

INSERT INTO LANCA (angulo,velInicial,idProjetil, idUsuario)
	values(30,33.5, 1 , 1);
go

--===========================================================================================

--TRIGGER QUE ALIMENTA A TABELA INTERCEPTA
--CASO OS VALORES FINAIS DE X E X NAS TABELAS PROJETIL E METEORO
--SEJAM IGUAIS ELE ARMAZENA OS VALORES DE X E Y COMO PONTO DE INTERCEPTAÇÃO,
--JUNTO COM O TEMPO QUE LEVOU DO PONTO ZERO ATÉ INTERCEPTAR
CREATE OR ALTER TRIGGER TRG_ALIMENTA_INTERCEPTA ON PROJETIL
AFTER INSERT AS
BEGIN
	--DECLARA AS VARIAVEIS--
	DECLARE @POSICAO_FINALX_PROJETIL FLOAT,
			@POSICAO_FINALY_PROJETIL FLOAT,
			@POSICAO_FINALX_METEORO FLOAT,
			@POSICAO_FINALY_METEORO FLOAT,
			@ID_PROJETIL INT,
			@ID_METEORO INT,
			@TEMPO INT
	--OBTENDO OS VALORES FINAIS DE X E Y
	SELECT 
		@POSICAO_FINALX_PROJETIL = posicaoFinalX, 
		@POSICAO_FINALY_PROJETIL = posicaoFinalY,
		@TEMPO = tempo,
		@ID_PROJETIL = idProjetil
	from inserted;
	--OBTENDO VALORES FINAIS DE X E Y DE METEOROS
	SELECT	
		@POSICAO_FINALX_METEORO = M.posicaoFinalX, 
		@POSICAO_FINALY_METEORO = M.posicaoFinalY,
		@ID_METEORO = M.idMeteoro
	FROM METEORO M 
	WHERE M.idMeteoro = @ID_PROJETIL 


	--VERIFICA SE O VALOR EM X E Y FINAL PARA O PROJETIL É IGUAL AO DO METEORO
	IF (abs(@POSICAO_FINALX_METEORO - @POSICAO_FINALX_PROJETIL) <= 250
	and abs(@POSICAO_FINALY_METEORO - @POSICAO_FINALY_PROJETIL) <= 250)
		BEGIN
			INSERT INTO INTERCEPTA (tempo, pontoX, pontoY, idProjetil, idMeteoro) 
				values (@TEMPO, @POSICAO_FINALX_PROJETIL,
						@POSICAO_FINALY_PROJETIL,@ID_PROJETIL, @ID_METEORO);
		END
	ELSE
		BEGIN
			INSERT INTO INTERCEPTA (tempo, pontoX, pontoY, idProjetil, idMeteoro)
				VALUES(NULL, NULL, NULL,@ID_PROJETIL, @ID_METEORO)
		END
END

SELECT * FROM PROJETIL
--===========================================================================================

--TRIGGER QUE IMPEDE A INSERÇÃO DE DADOS DUPLICADOS PARA
--ANGULO E VELOCIDADE INICIAL
CREATE OR ALTER TRIGGER TRG_STOP_DUPLICATE ON LANCA 
for INSERT AS
BEGIN
	--DECLARANDO VARIAVEIS
	DECLARE @ANGULO_DUPLICATE INT,
			@VEL_INICIAL_DUPLICATE FLOAT,
			@IdLanca int
	--OBTENDO DADO INSERIDO
	SELECT @ANGULO_DUPLICATE = angulo, @VEL_INICIAL_DUPLICATE = velinicial , @IdLanca = IdLanca
	FROM INSERTED
	
	--LAÇO CONDICIONAL QUE VERIFICA DUPLICIDADE
	IF  exists(select * from LANCA where @ANGULO_DUPLICATE = angulo and @VEL_INICIAL_DUPLICATE = velInicial AND @IdLanca != IDLANCA) 
		BEGIN
			ROLLBACK TRANSACTION
			declare @lastProjetil int =  (select top 1(idProjetil) from PROJETIL order by idProjetil desc)
			declare @lastMeteoro int =  (select top 1(idMeteoro) from METEORO order by idMeteoro desc)
			declare @lastiNTERCEPTA int =  (select top 1(idINTERCEPTA) from INTERCEPTA order by idINTERCEPTA desc)
			
			DELETE INTERCEPTA WHERE idINTERCEPTA = @lastiNTERCEPTA
			delete PROJETIL where idProjetil = @lastProjetil
			delete METEORO where IDMETEORO  = @lastMeteoro
			RAISERROR('Dado duplicado, não é permitido a inserção de angulo e velocidade inicial duplicados',15,1);
			RETURN;
		END
END

