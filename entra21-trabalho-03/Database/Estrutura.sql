CREATE TABLE tipo_produto(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(120),
	observacao TEXT);

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