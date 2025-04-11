CREATE TABLE cliente(

id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
nome_social VARCHAR(100) NULL,
data_nascimento date NOT NULL,
telefone VARCHAR(11) NOT NULL UNIQUE,
email VARCHAR(25) NOT NULL UNIQUE,
genero INT NOT NULL,
estrangeiro BIT NOT NULL,
tipo INT NOT NULL,
id_endereço INT NOT NULL,
FOREIGN KEY (id_endereco)
REFERENCES endereco (id) 




);

INSERT INTO cliente (nome, data_nascimento, telefone, email, genero, estrangeiro, tipo, id_endereço) VALUES
('Fernando', '1990-01-01', '11999999999', 'Fefe18++@gmail.com', 'Masculino',  1, 0, 0, (SELECT id FROM endereço WHERE logradouro = 'endereçoFernando')),
('Valdeci', '1990-01-01', '119999999777', 'Valdeci14!@gmail.com', 'Masculino',  1, 0, 0, (SELECT id FROM endereço WHERE logradouro = 'endereçoValdeci')),
('Maria', '1990-01-01', '11999999988', 'Maria10*@gmail.com', 'Feminino',  1, 0, 0, (SELECT id FROM endereço WHERE logradouro = 'endereçoMaria'));
