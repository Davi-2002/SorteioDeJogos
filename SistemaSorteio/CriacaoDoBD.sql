CREATE DATABASE SistemaSorteios;
GO
USE SistemaSorteios;
GO

CREATE TABLE endereco(
	cd_cep VARCHAR(10) PRIMARY KEY,
	nm_cidade VARCHAR(200) NOT NULL,
	nm_estado VARCHAR(100) NOT NULL,
	nm_rua VARCHAR(300) NOT NULL,
	nm_bairro VARCHAR(300) NOT NULL
);

CREATE TABLE jogo(
	cd_jogo INT IDENTITY(1,1) PRIMARY KEY,
	nm_jogo VARCHAR(300) NOT NULL,
	nm_generoJogo VARCHAR(100) NOT NULL
);

CREATE TABLE usuario(
	cd_usuario INT IDENTITY(1,1) PRIMARY KEY,
	nm_usuario VARCHAR(200) NOT NULL UNIQUE,
	nm_email VARCHAR(200) NOT NULL UNIQUE,
	cd_senha VARCHAR(100) NOT NULL,
	cd_telefone VARCHAR(15) NOT NULL,
	ic_admin BIT NOT NULL DEFAULT 0,
	cd_numero SMALLINT NOT NULL,
	ds_complemento VARCHAR(300),
	cd_cep VARCHAR(10) NOT NULL,
	FOREIGN KEY (cd_cep) REFERENCES endereco(cd_cep)  
);

CREATE TABLE sorteio(
	cd_sorteio INT IDENTITY(1,1) PRIMARY KEY,
	dt_dataLimite DATE NOT NULL DEFAULT GETDATE(),
	ds_status VARCHAR(20) NOT NULL DEFAULT 'Aberto',
	cd_usuario INT NOT NULL,
	FOREIGN KEY (cd_usuario) REFERENCES usuario(cd_usuario),
	cd_jogo INT NOT NULL,
	FOREIGN KEY (cd_jogo) REFERENCES jogo(cd_jogo)
);

CREATE TABLE usuario_sorteio(
	cd_usuario INT,
	cd_sorteio INT,
	cd_bilhete INT NOT NULL,
	ic_vencedor BIT NOT NULL DEFAULT 0,
	PRIMARY KEY (cd_usuario, cd_sorteio),
	FOREIGN KEY (cd_usuario) REFERENCES usuario(cd_usuario),
	FOREIGN KEY (cd_sorteio) REFERENCES sorteio(cd_sorteio)
);
