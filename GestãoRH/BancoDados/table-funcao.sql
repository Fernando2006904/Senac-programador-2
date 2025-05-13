CREATE TABLE IF NOT EXISTS funcao(
Id  INT PRIMARY KEY AUTO_INCREMENT,
FuncionarioId INT NOT NULL,
Cargo VARCHAR(50) NOT NULL,
Departamento VARCHAR(60) NOT NULL,
DataAdmissao DATE NOT NULL,
Salario DECIMAL(10,2) NOT NULL,
FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(Id)
);
 
 
INSERT INTO funcao (FuncionarioId, Cargo, Departamento, DataAdmissao, Salario) VALUES
(1, 'Desenvolvedor', 'TI', '2022-03-01', 3500.00),
(2, 'Analista', 'RH', '2018-06-10', 4200.00),
(3, 'Gerente de Projetos', 'TI', '2017-04-15', 6500.00),
(4, 'Assistente Administrativo', 'Administrativo', '2019-01-20', 2800.00),
(5, 'Coordenador de RH', 'RH', '2016-11-05', 5400.00),
(6, 'Técnico de Suporte', 'TI', '2020-07-12', 3100.00),
(7, 'Analista de Dados', 'TI', '2021-02-18', 4300.00),
(8, 'Recrutador', 'RH', '2018-09-25', 3900.00),
(9, 'Financeiro Júnior', 'Financeiro', '2020-05-30', 3200.00),
(10, 'Contador', 'Financeiro', '2015-12-01', 4800.00),
(11, 'Marketing Digital', 'Marketing', '2019-06-17', 3700.00),
(12, 'Designer Gráfico', 'Marketing', '2021-08-09', 3300.00),
(13, 'Auditor Interno', 'Financeiro', '2017-03-11', 5200.00),
(14, 'Treinador Corporativo', 'RH', '2016-05-20', 4600.00),
(15, 'Scrum Master', 'TI', '2022-10-01', 6000.00),
(16, 'Desenvolvedor Front-End', 'TI', '2023-01-05', 3400.00),
(17, 'Analista de Sistemas', 'TI', '2019-02-22', 4100.00),
(18, 'Auxiliar de Escritório', 'Administrativo', '2021-07-14', 2700.00),
(19, 'Gestor de Marketing', 'Marketing', '2014-08-19', 5900.00),
(20, 'Controller', 'Financeiro', '2013-04-23', 6800.00);
