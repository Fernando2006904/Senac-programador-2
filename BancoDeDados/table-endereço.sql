CREATE TABLE endereço( 
id INT PRIMARY KEY AUTO_INCREMENT,
logradouro VARCHAR(100) NOT NULL,
numero VARCHAR(10) NOT NULL,
complemento VARCHAR(50) NULL,
bairro VARCHAR(50) NOT NULL,
municipio VARCHAR(50) NOT NULL,
estado VARCHAR(2) NOT NULL,
cep VARCHAR(8) NOT NULL

);



INSERT INTO endereço (logradouro, numero, complemento, bairro, municipio, estado, cep) VALUES 
('endereço Fernando', '91', 'ap10', 'Moraes', 'Embu Guaçu', 'Maranhão', '12345-10', NULL),
('endereço Valdeci ', '76', 'Ap20', 'Jardim Espirito Santo', 'Vargem Grande', 'Amazonas', '12345-20', NULL),
('endereço Maria ', '10', 'Ap30', 'Jardim Santa Cruz', 'Embu4', 'Rio de Janeiro', '12345-30', NULL);


SELECT * FROM endereço;