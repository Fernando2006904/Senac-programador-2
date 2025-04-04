CREATE TABLE IF NOT EXISTS produto(

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
categoria VARCHAR(20) NOT NULL,
preço DECIMAL(25,0) NOT NULL,
estoque VARCHAR(100) NOT NULL,
fornecedor_id VARCHAR(50) NOT NULL

);


INSERT INTO produto (id, nome, categoria, preço, estoque, fornecedor_id) VALUES('1', 'Celular X', 'Eletrônicos', '2500.00', '30', '1'),
('2', 'Notebook Y', 'Eletrônicos', '4800.00', '15', '2'),
('3', 'Mesa de madeira', 'Móveis', '750.00', '10', '3'),
('4', 'Cadeira Z', 'Móveis', '300.00', '25', '3'),
('5', 'TV 50" ', 'Eletrônicos', '3500.00', '8', '1');




CREATE TABLE IF NOT EXISTS fornecedor(

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(50) NOT NULL,
cidade VARCHAR(50) NOT NULL


);


INSERT INTO fornecedor (id, nome, cidade) VALUES('1', 'Tech Brasil', 'São Paulo'),
('2', 'Computech', 'Rio de Janeiro'),
('3', 'Moveis&co', 'Curitiba');


SELECT * FROM fornecedor;

CREATE TABLE IF NOT EXISTS pedido(
id INT PRIMARY KEY AUTO_INCREMENT,
produto_id VARCHAR(50) NOT NULL,
quantidade VARCHAR(50) NOT NULL,
data_pedido DATETIME,
cliente_id VARCHAR(100) NOT NULL


);


INSERT INTO pedido (id, produto_id, quantidade, data_pedido, cliente_id) VALUES('1', '1', '2', '2024-03-10', '1'),
('2', '3', '1', '2024-03-11', '2'),
('3', '2', '1', '2024-03-15', '3'),
('4', '5', '3', '2024-03-18', '1'),
('5', '4', '4', '2024-03-20', '4');


SELECT * FROM pedido;




CREATE TABLE IF NOT EXISTS cliente(

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
cidade VARCHAR(50) NOT NULL,
idade VARCHAR(20) NOT NULL

);


INSERT INTO cliente (id, nome, cidade, idade) VALUES('1', 'João Silva', 'São Paulo', '35'),
('2', 'Maria Santos', 'Belo Horizonte', '28'),
('3', 'Carlos Lima', 'Rio de Janeiro', '42') ,
('4', 'Fernanda Rocha', 'Curitiba', '30');

SELECT * FROM cliente;

-- EXERCÍCIO 1

-- 1

SELECT 
    categoria, preço
FROM
    produto
WHERE
    preço > 3500.00;

-- 2
SELECT 
    *
FROM
    cliente
WHERE
    nome LIKE 'c%';


-- 3

SELECT * FROM pedido WHERE data_pedido BETWEEN 2024-03-11 AND 2024-03-20;


-- 4

SELECT 
    *
FROM
    produto
WHERE
    estoque < 10
ORDER BY estoque DESC;


-- 5

SELECT 
    *
FROM
    fornecedor
WHERE
    nome LIKE 'T%';


-- EXERCÍCIO 2


SELECT AVG(preço) FROM produto;

SELECT count(cliente_id) FROM pedido;


