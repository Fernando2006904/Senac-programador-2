-- Exercício 1

CREATE TABLE IF NOT EXISTS  empregado(
 

id INT PRIMARY KEY AUTO_INCREMENT,
nome_empregado VARCHAR(100) NOT NULL,
idade VARCHAR(45) NOT NULL,
id_departamento INT NOT NULL,
salario VARCHAR(20) NOT NULL,
FOREIGN KEY (id_departamento) REFERENCES departamento(id)
);



INSERT INTO empregado (id, nome, idade, departamento, salario) VALUES('1', 'João', '30', '1', '50000'),
('2', 'Sarah', '28', '2', '60000'),
('3', 'Miguel', '35', '3', '55000'),
('4', 'Ana', '27', '2', '62000');


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

INSERT INTO departamento (nome) VALUES ('RH'),
('TI'),
('Vendas');

select*
from departamento;

SELECT empregado.nome AS nome_empregado, departamento.nome_departamento
FROM empregado
INNER JOIN departamento
ON empregados.departamento_id = departamento.id_departamento;









