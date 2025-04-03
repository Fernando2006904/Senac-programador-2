-- Exercício 1

CREATE TABLE IF NOT EXISTS  empregado(
 
 

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
idade INT NOT NULL,
id_departamento INT NOT NULL,
salario INT NOT NULL,
FOREIGN KEY (id_departamento) REFERENCES departamento(id)
);



INSERT INTO empregado ( nome, idade, id_departamento, salario) 



VALUES
('João', '30', 1, '50000'),
( 'Sarah', '28', 2, '60000'),
( 'Miguel', '35', 3, '55000'),
( 'Ana', '27', 2, '62000');


SELECT * FROM empregado
WHERE departamento BETWEEN "TI" AND "TI";



select nome, salario from empregado where salario > 55000;

select * from empregado order by idade desc;

SELECT * FROM empregado
WHERE idade BETWEEN "27" AND "35";

-- Exercício2

SELECT * FROM empregado
WHERE idade BETWEEN 28 AND 35;

SELECT * FROM empregado
WHERE nome Like"m%";

SELECT * FROM empregado WHERE departamento != 'RH';



-- Exercício3

SELECT  count(*) FROM empregado;

SELECT AVG (salario) 
FROM empregado;

SELECT SUM(salario)
FROM empregado WHERE id_departamento ='Vendas';





-- Exercício4

CREATE TABLE IF NOT EXISTS departamento(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL

);

INSERT INTO departamento (nome) VALUES ('RH'),
('TI'),
('Vendas');

INSERT INTO departamento (nome) VALUES ('RH'),
('TI'),
('Vendas');



SELECT * FROM empregado;

SELECT * FROM departamento;



SELECT 
    empregado.nome, departamento.nome
FROM
    empregado
        INNER JOIN
    departamento ON empregado.id_departamento = departamento.id;



SELECT 
    d.nome AS departamento, e.nome AS empregado
FROM
    departamento d
        LEFT JOIN
    empregado e ON d.id = e.id_departamento;


-- Exercício 5 Subqueries




SELECT 
    e.nome AS empregado, d.nome AS departamento
FROM
    empregado e
        INNER JOIN
    departamento d ON e.id_departamento = d.id
WHERE
    id_departamento = (SELECT 
            e.id_departamento
        FROM
            empregado e
        WHERE
            nome = 'Sarah');



















