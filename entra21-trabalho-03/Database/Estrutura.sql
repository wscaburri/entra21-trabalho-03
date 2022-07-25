CREATE TABLE tipo_produto(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(120),
	observacao TEXT);

CREATE TABLE farmacia(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cnpj VARCHAR(13),
	cidade VARCHAR(100),
	bairro VARCHAR(50),
	logradouro VARCHAR(100),
	numero INTEGER
);

SELECT * FROM farmacia;

INSERT INTO farmacia (nome, cidade) VALUES
('Claúdio', 'Bnu City'),
('Tete', 'Bc City');

SELECT * FROM farmacia;
 