CREATE TABLE profissoes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	cargo VARCHAR(100));

CREATE TABLE funcionarios(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_profissao INTEGER,
	nome VARCHAR(100),
	cpf VARCHAR(14),
	data_nascimento DATETIME2,
	cep VARCHAR(9),
	endereco VARCHAR(150),
	numero INTEGER,
	data_admissao DATETIME2,
	salario DECIMAL(11,2)

	FOREIGN KEY (id_profissao) REFERENCES profissoes(id));


CREATE TABLE tipo_produto(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(120));

CREATE TABLE produto(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_tipo_produto INTEGER,

	nome VARCHAR(100),
	data_vencimento DATETIME2,
	preco DECIMAL
	
	FOREIGN KEY (id_tipo_produto) REFERENCES tipo_produto(id));

CREATE TABLE distribuidora(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cnpj VARCHAR(18),
	estado VARCHAR(60),
	cidade VARCHAR(100),
	bairro VARCHAR(50),
	logradouro VARCHAR(100),
	numero INTEGER
);

SELECT * FROM distribuidora;

INSERT INTO distribuidora(nome, cnpj, estado, cidade, bairro, logradouro, numero) VALUES
('Claúdio', '18968241000194', 'SC', 'Bnu City', 'Progresso', 'Rua Progreso', 154);


SELECT * FROM distribuidora;

INSERT INTO distribuidora(nome, cnpj, cidade, bairro, logradouro, numero) VALUES
('Tete', '18968241000194', 'Bc City', 'Zendron', 'Rua Antonio', 587);


CREATE TABLE estoque_produto(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_distribuidora INTEGER,
	id_tipo_produto INTEGER,
	nome VARCHAR(70),
	quantidade_produto INTEGER,
	validade_produto DATETIME2,
	data_produto_entrada_estoque DATETIME2

	FOREIGN KEY (id_distribuidora) REFERENCES distribuidora(id),
	FOREIGN KEY (id_tipo_produto) REFERENCES tipo_produto(id)
);

SELECT * FROM estoque_produto;

INSERT INTO estoque_produto (nome, quantidade_produto, validade_produto, data_produto_entrada_estoque) 
	VALUES
		('respiridona', 15, '2024/05/14', '2022/07/26');
		
INSERT INTO estoque_produto (nome, quantidade_produto, validade_produto, data_produto_entrada_estoque) 
	VALUES
		('respiridona', 15, '2024/05/14', '2022/07/26');

