CREATE TABLE IF NOT EXISTS cliente(



id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
idade VARCHAR(45) NOT NULL,
cidade VARCHAR(45) NOT NULL,
saldo VARCHAR(25) NOT NULL

);

INSERT INTO cliente (id, nome, idade, cidade, saldo) VALUES('1', 'Carlos', '45', 'São paulo', '2500'),
('2', 'Mariana', '32', 'Rio de Janeiro', '3200'),
('3', 'Pedro', '27', 'Belo Horizonte', '1500'),
('4', 'Fernanda', '38', 'Curitiba', '4200');

SELECT * FROM cliente
WHERE cidade BETWEEN "Rio de Janeiro" AND "Rio de Janeiro";



SELECT * FROM cliente
ORDER BY saldo DESC;


SELECT * FROM cliente
WHERE idade BETWEEN "30" AND "45";

-- Exercício 2

SELECT * FROM cliente
WHERE idade BETWEEN "25" AND "40";

SELECT * FROM cliente
WHERE nome BETWEEN "Fernanda" AND "Fernanda";

SELECT * FROM cliente
WHERE nome BETWEEN "Mariana" AND "Pedro";

-- Exercício 3


CREATE TABLE IF NOT EXISTS pedido(


id INT PRIMARY KEY AUTO_INCREMENT,
client_id INT NOT NULL,
valor DECIMAL(20,2) NOT NULL,
data_pedido VARCHAR(50) NOT NULL

);


INSERT INTO pedido (id, client_id, valor, data_pedido) VALUES('1', '1', '500', '2024-03-10'),
('2', '2', '1200', '2024-03-12'),
('3', '3', '300', '2024-03-15'),
('4', '1', '800', '2024-03-18');



SELECT count(*) FROM pedido;


SELECT AVG (valor)
FROM pedido;




-- Exercício 4


SELECT pedido.id, cliente.nome, valor
FROM cliente
INNER JOIN pedido ON cliente.id = pedido.cliente_id;




