-- Exercício 1

CREATE TABLE IF NOT EXISTS  empregado(
 

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
idade VARCHAR(45) NOT NULL,
departamento INT NOT NULL,
salario VARCHAR(20) NOT NULL 

);



INSERT INTO empregado (id, nome, idade, departamento, salario) VALUES('1', 'João', '30', 'RH', '50000'),
('2', 'Sarah', '28', 'TI', '60000'),
('3', 'Miguel', '35', 'Vendas', '55000'),
('4', 'Ana', '27', 'TI', '62000');


SELECT * FROM empregado
WHERE departamento BETWEEN "TI" AND "TI";



SELECT * FROM empregado
WHERE salario BETWEEN "55000" AND "62000";


SELECT * FROM empregado
WHERE idade BETWEEN "27" AND "35";

-- Exercício2

SELECT * FROM empregado
WHERE idade BETWEEN "28" AND "35";

SELECT * FROM empregado
WHERE nome BETWEEN "Miguel" AND "Miguel";

SELECT
nome, departamento
FROM
empregado
WHERE 
departamento NOT LIKE 'RH';



-- Exercício3

SELECT  count(*) FROM empregado;

SELECT AVG (salario) 
FROM empregado;

SELECT SUM(salario)
FROM empregado WHERE departamento ='Vendas';





-- Exercício4

CREATE TABLE IF NOT EXISTS departamento(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL

);

INSERT INTO departamento (id, nome) VALUES ('1', 'RH'),
('2', 'TI'),
('3', 'Vendas');









