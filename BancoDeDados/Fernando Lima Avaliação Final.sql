CREATE TABLE IF NOT EXISTS produto(

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
categoria VARCHAR(20) NOT NULL,
preço DECIMAL(25,0) NOT NULL,
estoque VARCHAR(100) NOT NULL,
fornecedor_id INT NOT NULL,
FOREIGN KEY (fornecedor_id) REFERENCES fornecedor(id)




);


INSERT INTO produto (id, nome, categoria, preço, estoque, fornecedor_id) VALUES('1', 'Celular X', 'Eletrônicos', '2500.00', '30', '1'),
('2', 'Notebook Y', 'Eletrônicos', '4800.00', '15', '2'),
('3', 'Mesa de madeira', 'Móveis', '750.00', '10', '3'),
('4', 'Cadeira Z', 'Móveis', '300.00', '25', '3'),
('5', 'TV 50" ', 'Eletrônicos', '3500.00', '8', '1');




CREATE TABLE IF NOT EXISTS fornecedor(

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(50) NOT NULL,
cidade VARCHAR(50) NOT NULL,
produto_id INT NOT NULL,
FOREIGN KEY (id_produto) REFERENCES produto(id)

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
cliente_id VARCHAR(100) NOT NULL,
FOREIGN KEY (produto_id) REFERENCES produto(id)

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


SELECT   * FROM produto WHERE categoria = 'Eletronicos'
AND preço > 3000
ORDER BY preço DESC;
   


-- 2
SELECT * FROM cliente WHERE cidade <> 'São Paulo' AND idade > 30;


-- 3
SELECT 
    *
FROM
    pedido
WHERE
    data_pedido BETWEEN '2024-03-10' AND '2024-03-15'
ORDER BY data_pedido;

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
    cidade <> 'Rio de Janeiro'
        AND nome LIKE 'T%';


-- EXERCÍCIO 2

-- 1
SELECT 
categoria,
    AVG(preço)
FROM
    produto GROUP BY categoria;
-- 2
SELECT 

    COUNT(id) as 'Qtda de pedidos'
FROM
    pedido GROUP BY cliente_id;
-- 3
SELECT categoria, SUM(estoque) as 'Total em estoque' FROM produto GROUP BY categoria;

-- 4


SELECT id, produto_id, quantidade
FROM pedido ORDER BY quantidade DESC
LIMIT 1;

   

-- 5


SELECT cidade, COUNT(*) AS total_clientes
FROM cliente
GROUP BY cidade
ORDER BY total_clientes DESC;
    

-- EXERCÍCIO 3

-- 1
SELECT 
    p.nome AS produto, f.nome AS fornecedor
FROM
    produto p
        INNER JOIN
    fornecedor f ON p.fornecedor_id = f.id
ORDER BY f.nome;


SELECT * FROM produto INNER JOIN fornecedor ON produto.fornecedor_id = fornecedor.id;

 
-- 2
    SELECT c.nome AS cliente, pr.nome AS produto, pe.data_pedido FROM pedido pe

    INNER JOIN cliente c ON pe. cliente_id = c.id
    INNER JOIN produto pr ON pe.produto_id = pr.id
      ORDER BY pe.data_pedido;
    
    
    

    
    
-- 3
    
SELECT c.nome AS cliente, pr.nome AS produto, f.nome AS fornecedor
FROM pedido pe 
INNER JOIN cliente c ON pe.cliente_id = c.id
INNER JOIN produto pr ON pe.produto_id = pr.id
INNER JOIN fornecedor f ON pr.fornecedor_id = f.id;
    
    
    
    
-- 4

SELECT c.nome AS cliente, SUM(pe.quantidade) AS total_pedidos FROM pedido pe 
INNER JOIN cliente c ON pe.cliente_id = c.id
GROUP BY c.nome;



 -- EXERCÍCIO 4
    
-- 1
SELECT * FROM produto p 
WHERE preço > (SELECT AVG(preço) FROM produto pr WHERE p.categoria = pr.categoria)
ORDER BY p.categoria; 


-- 2

UPDATE produto 
SET 
    preço = preço * 1.11
WHERE
    categoria = 'Eletrônicos';


-- 3

DELETE FROM cliente
WHERE cliente_id IN (SELECT id FROM cliente WHERE cidade = 'Curitiba');


    SELECT * FROM cliente;

    
-- 4


INSERT INTO cliente(nome, cidade, idade)

VALUES
('Ricardo Lopes', 'Porto Alegre', '38');






-- 5

SELECT * FROM produto WHERE nome = 'NotebookY';

SELECT * FROM cliente WHERE nme = 'joão Silva' AND cidade = 'São Paulo';

INSERT INTO pedido (quantidade, data_pedido, produto_id, cliente_id)
VALUES ( 2, '2024-03-25', (SELECT id FROM produto WHERE nome = 'NotebookY'),
(SELECT id FROM cliente WHERE nome = 'joão Silva' AND cidade = 'São Paulo')
);





    
    
-- 6    
    
 SELECT DISTINCT
    c.nome AS nome_cliente
FROM
    cliente c
        INNER JOIN
    pedido p ON c.id = p.cliente_id
        INNER JOIN
    produto pr ON p.produto_id = pr.id
WHERE
    pr.categoria = 'Móveis';
    
    
    
    
  
    

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    




















