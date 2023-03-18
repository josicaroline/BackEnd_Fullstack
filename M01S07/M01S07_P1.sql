
-- Criação do banco de dados
CREATE DATABASE M01S07

USE M01S07


-- Criação da tabela clientes (exercicio 01)
CREATE TABLE CLIENTES (
    ID INT PRIMARY KEY,
	NOME VARCHAR(50),
	TELEFONE VARCHAR(11), 
	ENDERECO VARCHAR(50)
)

-- DROP TABLE CLIENTES


-- Inserir 3 clientes na tabela (exercicio 02)

INSERT INTO CLIENTES (ID, NOME, TELEFONE, ENDERECO) VALUES (1, 'Vinicius Silva', '987654', 'Rua Girassol')
INSERT INTO CLIENTES (ID, NOME, TELEFONE, ENDERECO) VALUES (2, 'Maria Antonia', '123456', 'Rua Rosas')
INSERT INTO CLIENTES (ID, NOME, TELEFONE, ENDERECO) VALUES (3, 'Marcus Vinicius', '654123', 'Rua Itajai')



-- Selecionar todos os clientes (exercicio 03)

SELECT * FROM CLIENTES



-- Selecionar os clientes por id (exercicio 04)
SELECT * FROM CLIENTES
WHERE ID = 1



-- Selecionar os clientes por nome (exercicio 05)
SELECT * FROM CLIENTES
WHERE NOME Like '%vinicius%'


-- Atualizar cliente (exercicio 06)

--BEGIN TRAN

UPDATE CLIENTES
SET ENDERECO = 'Rua do Limão'
WHERE ID = 3

--COMMIT


-- Deletar cliente (exercicio 07)

--BEGIN TRAN

DELETE CLIENTES
WHERE ID = 2

--COMMIT



