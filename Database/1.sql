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

ALTER TABLE cqrs.candidate ADD created TIMESTAMP NOT NULL;
ALTER TABLE cqrs.candidate ADD updated TIMESTAMP NOT NULL;

ALTER TABLE cqrs.candidate
	ADD CONSTRAINT pk_candidate UNIQUE (id);
