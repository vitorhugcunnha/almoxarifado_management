create database amoxarifado;
use amoxarifado;

create table usuario(
	id_usuario int primary key auto_increment,
	nome_usuario varchar(100),
    senha varchar(100)
);