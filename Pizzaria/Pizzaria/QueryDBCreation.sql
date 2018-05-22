CREATE TABLE Pizza(
    Id int NOT NULL IDENTITY(1,1),
	Nome VARCHAR(MAX) NOT NULL,
	Preco decimal NOT NULL,
    PRIMARY KEY (Id)
)


CREATE TABLE Cliente(
    Id INT NOT NULL IDENTITY(1,1),
	Nome VARCHAR(MAX) NOT NULL,
	Endereco VARCHAR(MAX) NOT NULL,
	Telefone VARCHAR(40) NOT NULL
    PRIMARY KEY (Id)
)

CREATE TABLE Pedido(
    Id INT NOT NULL IDENTITY(1,1),
	TipoDePagamento INT NOT NULL,
	MetodoDeEntrega VARCHAR(MAX) NOT NULL,
	IdClient INT NOT NULL,
    PRIMARY KEY (Id),
    FOREIGN KEY (IdClient) REFERENCES Cliente(Id)
)

CREATE TABLE PedidoItem(
    Id INT NOT NULL IDENTITY(1,1),
	PizzaId INT NOT NULL,
	PedidoId INT NOT NULL,
	TamanhoPizza INT NOT NULL,
    PRIMARY KEY (Id),
	FOREIGN KEY (PizzaId) REFERENCES Pizza(Id),
	FOREIGN KEY (PedidoId) REFERENCES Pedido(Id)
)

INSERT INTO Pizza (Nome, Preco)
VALUES ('Mussarela', 18);
INSERT INTO Pizza (Nome, Preco)
VALUES ('Gostosona', 23);
INSERT INTO Pizza (Nome, Preco)
VALUES ('Calabresa', 21);
INSERT INTO Pizza (Nome, Preco)
VALUES ('Brocolis', 20);
INSERT INTO Pizza (Nome, Preco)
VALUES ('Vegana', 30);