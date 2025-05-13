CREATE TABLE IF NOT EXISTS funcionario(
Id INT PRIMARY KEY AUTO_INCREMENT,
NomeCompleto VARCHAR(100) NOT  NULL,
Cpf VARCHAR(14) NOT NULL UNIQUE,
Rg VARCHAR(20) NOT NULL,
DataNascimento DATE,
Genero VARCHAR(20) NOT NULL,
EstadoCivil VARCHAR(20) NOT NULL,
Situacao VARCHAR(20) NOT NULL
);
 
INSERT INTO funcionario (Id, NomeCompleto, Cpf, Rg, DataNascimento, Genero, EstadoCivil, Situacao)
VALUES 
(1, 'João da Silva', '123.456.789-00', 'MG-12.345.678', '1990-05-12', 'Masculino', 'Solteiro', 'Ativo'),
(2, 'Maria Oliveira', '987.654.321-00', 'SP-98.765.432', '1988-11-23', 'Feminino', 'Casada', 'Ativo'),
(3, 'Carlos Pereira', '321.654.987-11', 'RJ-45.789.123', '1985-03-10', 'Masculino', 'Casado', 'Inativo'),
(4, 'Ana Souza', '654.321.987-22', 'RS-23.456.789', '1992-07-18', 'Feminino', 'Solteira', 'Ativo'),
(5, 'Marcos Lima', '111.222.333-44', 'BA-11.223.344', '1989-01-05', 'Masculino', 'Divorciado', 'Ativo'),
(6, 'Patrícia Gomes', '555.666.777-88', 'PE-55.667.788', '1993-09-14', 'Feminino', 'Solteira', 'Ativo'),
(7, 'Fernando Alves', '999.888.777-66', 'SC-99.888.777', '1991-12-20', 'Masculino', 'Casado', 'Inativo'),
(8, 'Juliana Rocha', '222.333.444-55', 'GO-22.334.455', '1987-06-30', 'Feminino', 'Viúva', 'Ativo'),
(9, 'Rafael Costa', '777.888.999-00', 'CE-77.889.900', '1994-08-25', 'Masculino', 'Solteiro', 'Ativo'),
(10, 'Luciana Martins', '444.555.666-77', 'PR-44.556.677', '1990-04-17', 'Feminino', 'Casada', 'Ativo'),
(11, 'André Barbosa', '123.123.123-12', 'DF-12.312.312', '1986-11-02', 'Masculino', 'Casado', 'Ativo'),
(12, 'Elaine Ferreira', '456.789.123-00', 'PA-45.678.912', '1995-03-22', 'Feminino', 'Solteira', 'Inativo'),
(13, 'Bruno Mendes', '321.987.654-33', 'AM-32.198.765', '1989-07-29', 'Masculino', 'Solteiro', 'Ativo'),
(14, 'Camila Santos', '654.123.789-44', 'MA-65.412.378', '1992-01-11', 'Feminino', 'Casada', 'Ativo'),
(15, 'Diego Ramos', '789.456.123-55', 'PB-78.945.612', '1988-10-05', 'Masculino', 'Divorciado', 'Ativo'),
(16, 'Vanessa Lima', '888.777.666-55', 'SE-88.776.655', '1996-12-08', 'Feminino', 'Solteira', 'Ativo'),
(17, 'Eduardo Nascimento', '999.333.222-11', 'AC-99.332.211', '1991-02-14', 'Masculino', 'Casado', 'Ativo'),
(18, 'Renata Almeida', '111.444.777-22', 'RO-11.447.772', '1987-05-19', 'Feminino', 'Solteira', 'Inativo'),
(19, 'Thiago Teixeira', '222.666.999-33', 'TO-22.669.933', '1993-08-13', 'Masculino', 'Casado', 'Ativo'),
(20, 'Beatriz Cardoso', '333.555.777-44', 'RN-33.557.774', '1985-09-27', 'Feminino', 'Viúva', 'Ativo');


SELECT * FROM funcionario WHERE Id IN (1, 2);
 
SELECT 
    f.NomeCompleto,
    f.Cpf,
    e.Cep,
    e.Logradouro,
    e.Numero,
    e.Complemento,
    e.Bairro,
    e.Cidade,
    e.Estado
FROM
    funcionario f
        INNER JOIN
    endereco e ON f.Id = e.FuncionarioId;
 
ALTER TABLE funcionario
ADD COLUMN Salario  DECIMAL(10,2) NOT NULL;
 
SELECT * FROM funcionario;
 
SELECT 
f.NomeCompleto,
f.Cpf,
f.Genero,
fn.Cargo,
fn.Departamento,
fn.DataAdmissao,
fn.Salario
FROM funcionario f
INNER JOIN funcao fn ON f.Id = fn.FuncionarioId;
 
SELECT 
f.NomeCompleto AS NomeFuncionario,
f.Cpf AS CpfFuncionario,
d.NomeCompleto AS NomeDependente,
d.Cpf AS CpfDependente,
d.Parentesco,
d.DataNascimento,
d.Genero
 
FROM funcionario f
INNER JOIN dependentes d ON f.Id = d.FuncionarioId;
 
SELECT 
f.Id AS IdFuncionario,
f.NomeCompleto AS NomeSistema,
dp.NomeCompleto AS NomeOficial,
dp.Cpf,
dp.Rg,
dp.datadenascimento,
dp.Genero,
dp.estadocivil
 
FROM funcionario f
INNER JOIN dadospessoais dp ON f.Id = dp.FuncionarioId;