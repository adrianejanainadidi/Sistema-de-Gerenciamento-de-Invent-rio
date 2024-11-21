CREATE DATABASE SistemaInventario;

USE SistemaInventario;

CREATE TABLE Produtos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
    Quantidade INT NOT NULL,
    Preco DECIMAL(10, 2) NOT NULL,
    DataCadastro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Movimentacoes (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ProdutoID INT FOREIGN KEY REFERENCES Produtos(ID),
    TipoMovimentacao VARCHAR(50) NOT NULL, -- Entrada ou Saída
    Quantidade INT NOT NULL,
    DataMovimentacao DATETIME DEFAULT GETDATE()
);
