CREATE TABLE situacao (
    id INT PRIMARY KEY AUTO_INCREMENT,
    ativo VARCHAR(50) NOT NULL ,
    inativo VARCHAR(20) NOT NULL
);
INSERT INTO situaçao (ativo, inativo) VALUES ('@ativo', '@inativo');