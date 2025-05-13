CREATE TABLE IF NOT EXISTS Endereco(
Id INT PRIMARY KEY AUTO_INCREMENT,
FuncionarioId INT NOT NULL,
Cep VARCHAR(50) NOT NULL,
Logradouro VARCHAR(50) NOT NULL,
Numero VARCHAR(10) NOT NULL,
Complemento VARCHAR(30) NOT NULL,
Bairro VARCHAR(100) NOT NULL,
Cidade VARCHAR(100) NOT NULL, 
Estado VARCHAR (2) NOT NULL,
FOREIGN KEY (FuncionarioId) REFERENCES Funcionario(Id)
);
 
 
INSERT INTO Endereco (FuncionarioId, CEP, Logradouro, Numero, Complemento, Bairro, Cidade, Estado) 
VALUES
(1, '12345-678', 'Rua das Flores', '123', 'Apto 301', 'Jardim das Rosas', 'São Paulo', 'SP'),
(2, '98765-432', 'Avenida Paulista', '456', '', 'Centro', 'São Paulo', 'SP'),
(3, '11223-445', 'Rua das Acácias', '89', '', 'Bela Vista', 'Campinas', 'SP'),
(4, '55667-889', 'Travessa do Sol', '22', 'Casa 2', 'Vila Nova', 'Rio de Janeiro', 'RJ'),
(5, '99887-665', 'Rua Amazonas', '300', 'Fundos', 'Jardim América', 'Belo Horizonte', 'MG'),
(6, '44332-110', 'Avenida Brasil', '1500', 'Bloco B', 'Centro', 'Curitiba', 'PR'),
(7, '22000-000', 'Rua das Palmeiras', '77', '', 'Boa Viagem', 'Recife', 'PE'),
(8, '33000-111', 'Alameda Santos', '999', 'Sala 12', 'Jardins', 'São Paulo', 'SP'),
(9, '88000-222', 'Rua João Pessoa', '45', '', 'Centro', 'Florianópolis', 'SC'),
(10, '70000-333', 'Quadra 202 Sul', '10', 'Apto 502', 'Plano Piloto', 'Brasília', 'DF'),
(11, '66000-444', 'Travessa Rui Barbosa', '231', '', 'Marco', 'Belém', 'PA'),
(12, '59000-555', 'Rua Potengi', '87', '', 'Tirol', 'Natal', 'RN'),
(13, '40000-666', 'Avenida Sete de Setembro', '1345', '', 'Campo Grande', 'Salvador', 'BA'),
(14, '74000-777', 'Rua 10', '200', 'Casa', 'Setor Oeste', 'Goiânia', 'GO'),
(15, '64000-888', 'Avenida Frei Serafim', '312', '', 'Centro', 'Teresina', 'PI'),
(16, '69000-999', 'Rua do Comércio', '66', '', 'Centro', 'Manaus', 'AM'),
(17, '50000-000', 'Rua das Laranjeiras', '88', 'Casa 1', 'Boa Vista', 'Recife', 'PE'),
(18, '35000-111', 'Rua Afonso Pena', '1400', '', 'Centro', 'Ipatinga', 'MG'),
(19, '45000-222', 'Avenida Olívia Flores', '278', '', 'Candeias', 'Vitória da Conquista', 'BA'),
(20, '36000-333', 'Rua Halfeld', '505', 'Loja 3', 'Centro', 'Juiz de Fora', 'MG');