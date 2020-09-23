CREATE DATABASE Edux;
--Usamos ela
USE Edux;

CREATE TABLE Perfil
(
	IdPerfil UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Permissao VARCHAR(50)
);

CREATE TABLE Instituicao
(
	IdInstituicao UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Nome VARCHAR (255) NOT NULL,
	Logradouro VARCHAR (255) NOT NULL,
	Numero VARCHAR (255) NOT NULL,
	Complemento VARCHAR (255),
	Bairro VARCHAR (255) NOT NULL,
	Cidade VARCHAR (255) NOT NULL,
	CEP VARCHAR (15) NOT NULL,
	UF VARCHAR (2) NOT NULL,
);


CREATE TABLE Curso
(
	IdCurso UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Titulo VARCHAR(255) NOT NULL,

	--FK
	IdInstituicao UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Instituicao (IdInstituicao)
);


CREATE TABLE Usuario
(
	IdUsuario UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Nome VARCHAR (255) NOT NULL,
	Email VARCHAR (100) NOT NULL,
	Senha VARCHAR (255) NOT NULL,
	DataCadastro DATETIME NOT NULL,
	DataUltimoAcesso DATETIME NOT NULL,

	--FK
	IdPerfil UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Perfil (IdPerfil)
);

CREATE TABLE Dica
(
	IdDica UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Texto VARCHAR(255) NOT NULL,
	Imagem VARCHAR(255),

	--FK
	IdUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Usuario (IdUsuario)
);

CREATE TABLE Curtida
(
	--FK
	IdUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Usuario (IdUsuario),
	IdDica UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Dica (IdDica)
);

CREATE TABLE Turma
(
	IdTurma UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Descricao VARCHAR(255) NOT NULL,

	--FK
	IdCurso UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Curso (IdCurso)
);

CREATE TABLE Categoria
(
	IdCategoria UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,	
	Tipo VARCHAR(255) NOT NULL,
);

CREATE TABLE Objetivo
(
	IdObjetivo UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Tipo VARCHAR(255) NOT NULL,

	--FK
	IdCategoria UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Categoria (IdCategoria)
);

CREATE TABLE AlunoTurma
(
	IdAlunoTurma UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Descricao VARCHAR(255) NOT NULL,

	--FKs
	IdUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Usuario (IdUsuario),
	IdTurma UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Turma (IdTurma)
);

CREATE TABLE ProfessorTurma
(
	IdProfessorTurma UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Descricao VARCHAR(255) NOT NULL,

	--FKs
	IdUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Usuario (IdUsuario),
	IdTurma UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Turma (IdTurma)
);

CREATE TABLE ObjetivoAluno
(
	IdObjetivoAluno UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
	Nota DECIMAL DEFAULT 0 NULL,
	DataAlcancado DATETIME NOT NULL,

	--FK
	IdAlunoTurma UNIQUEIDENTIFIER FOREIGN KEY REFERENCES AlunoTurma (IdAlunoTurma),
	IdObjetivo UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Objetivo (IdObjetivo)
);

