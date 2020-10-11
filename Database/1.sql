CREATE DATABASE cqrs;

CREATE TABLE cqrs.candidate (
	id varchar(36) NOT NULL,
	nome varchar(100) NOT NULL,
	telefone varchar(25) NULL,
	url_linkedin varchar(500) NULL,
	usuario_github varchar(100) NULL
)
ENGINE=InnoDB
DEFAULT CHARSET=utf8
COLLATE=utf8_general_ci;
