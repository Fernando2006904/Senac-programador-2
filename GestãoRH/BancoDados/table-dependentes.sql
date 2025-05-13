CREATE TABLE IF NOT EXISTS dependentes(
Id INT PRIMARY KEY AUTO_INCREMENT,
FuncionarioId INT NOT NULL,
NomeCompleto VARCHAR(100) NOT NULL,
Cpf VARCHAR(14) NOT NULL,
Rg VARCHAR(15) NOT NULL,
DataNascimento DATE,
Genero VARCHAR(20) NOT NULL,
Parentesco VARCHAR(30) NOT NULL
 
);
 
INSERT INTO dependentes (FuncionarioId, NomeCompleto, Cpf, Rg, DataNascimento, Genero, Parentesco) VALUES
(1, 'Maria Silva', '987.654.321-00', '98.765.432-1', '2000-02-14', 'Feminino', 'Filha'),
(2, 'Carlos Oliveira', '876.543.210-11', '87.654.321-0', '2010-09-18', 'Masculino', 'Marido'),
(3, 'Ana Beatriz Souza', '765.432.109-22', '76.543.210-9', '2015-05-22', 'Feminino', 'Filha'),
(4, 'João Pedro Mendes', '654.321.098-33', '65.432.109-8', '2012-11-30', 'Masculino', 'Filho'),
(5, 'Cláudia Lima', '543.210.987-44', '54.321.098-7', '1995-07-10', 'Feminino', 'Esposa'),
(6, 'Gabriel Nunes', '432.109.876-55', '43.210.987-6', '2008-03-14', 'Masculino', 'Filho'),
(7, 'Isabela Rocha', '321.098.765-66', '32.109.876-5', '2011-01-08', 'Feminino', 'Filha'),
(8, 'Lucas Fernandes', '210.987.654-77', '21.098.765-4', '2007-12-24', 'Masculino', 'Filho'),
(9, 'Fernanda Dias', '109.876.543-88', '10.987.654-3', '1999-06-15', 'Feminino', 'Esposa'),
(10, 'Mateus Teixeira', '998.765.432-99', '99.876.543-2', '2013-08-19', 'Masculino', 'Filho'),
(11, 'Letícia Campos', '887.654.321-00', '88.765.432-1', '2016-09-05', 'Feminino', 'Filha'),
(12, 'Eduardo Lima', '776.543.210-11', '77.654.321-0', '2017-02-11', 'Masculino', 'Filho'),
(13, 'Amanda Ribeiro', '665.432.109-22', '66.543.210-9', '2005-05-30', 'Feminino', 'Filha'),
(14, 'Bruno Costa', '554.321.098-33', '55.432.109-8', '2003-10-21', 'Masculino', 'Filho'),
(15, 'Renata Gomes', '443.210.987-44', '44.321.098-7', '1987-03-17', 'Feminino', 'Esposa'),
(16, 'Felipe Duarte', '332.109.876-55', '33.210.987-6', '2014-04-12', 'Masculino', 'Filho'),
(17, 'Carolina Freitas', '221.098.765-66', '22.109.876-5', '2006-07-09', 'Feminino', 'Filha'),
(18, 'Vinícius Martins', '110.987.654-77', '11.098.765-4', '2012-02-03', 'Masculino', 'Filho'),
(19, 'Tatiane Barros', '999.876.543-88', '00.987.654-3', '1990-12-01', 'Feminino', 'Esposa'),
(20, 'Rafael Souza', '888.765.432-99', '89.876.543-2', '2009-11-26', 'Masculino', 'Filho');
;