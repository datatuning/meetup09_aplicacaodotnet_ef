CREATE DATABASE dotNetConf
GO
USE dotNetConf
GO
DROP TABLE IF EXISTS dbo.Clientes
GO
CREATE TABLE dbo.Clientes(
	Id INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(100),
	CpfCnpj VARCHAR(14),
	DataCadastro DATE,
	LimiteCredito DECIMAL(10,2)
)
GO
insert into Clientes(Nome,CpfCnpj,DataCadastro,LimiteCredito)
select Nome,CpfCnpj,DataCadastro,LimiteCredito from dotNetConf..Clientes
/*
INSERT INTO dbo.Clientes(Nome,CpfCnpj,DataCadastro,LimiteCredito)
SELECT FirstName,'11111111111111',GETDATE(),0 FROM AdventureWorks2017.Person.Person
GO 5
*/
CREATE INDEX idx_cliente_nome ON Clientes(Nome)
GO
CREATE INDEX idx_cliente_nome ON Clientes(Nome) INCLUDE(CpfCnpj) WITH(DROP_EXISTING=ON)
GO

