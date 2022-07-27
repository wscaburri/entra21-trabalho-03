CREATE TABLE tipo_produto(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(120));

CREATE TABLE cliente(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	data_nascimento DATETIME2,
	cep VARCHAR(9),
	endereco VARCHAR(100),
	numero INTEGER
);

CREATE TABLE farmacia(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cnpj VARCHAR(14),
	cidade VARCHAR(100),
	bairro VARCHAR(50),
	logradouro VARCHAR(100),
	numero INTEGER
);

SELECT * FROM farmacia;

INSERT INTO farmacia (nome, cnpj, cidade, bairro, logradouro, numero) VALUES
('Claúdio', '18968241000194', 'Bnu City', 'Progresso', 'Rua Progreso', 154);


SELECT * FROM farmacia;

INSERT INTO farmacia (nome, cnpj, cidade, bairro, logradouro, numero) VALUES
('Tete', '18968241000194', 'Bc City', 'Zendron', 'Rua Antonio', 587);


CREATE TABLE estoque_produto(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_farmacia INTEGER,
	id_tipo_produto INTEGER,
	nome VARCHAR(70),
	quantidade_produto INTEGER,
	validade_produto DATETIME2,
	data_produto_entrada_estoque DATETIME2

	FOREIGN KEY (id_farmacia) REFERENCES farmacia(id),
	FOREIGN KEY (id_tipo_produto) REFERENCES tipo_produto(id)
);

SELECT * FROM estoque_produto;

INSERT INTO estoque_produto (nome, quantidade_produto, validade_produto, data_produto_entrada_estoque) 
	VALUES
		('respiridona', 15, '2024/05/14', '2022/07/26');
		
INSERT INTO estoque_produto (nome, quantidade_produto, validade_produto, data_produto_entrada_estoque) 
	VALUES
		('respiridona', 15, '2024/05/14', '2022/07/26');

