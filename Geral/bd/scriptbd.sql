show databases;
create database db_filme;
use db_filme;
CREATE TABLE tb_filme;
show tables;
desc tb_filme;
drop table tb_filme;
select * from tb_filme;

CREATE TABLE tb_filme (
    id_filme INT AUTO_INCREMENT,
    nm_filme VARCHAR(100) NOT NULL,
    ds_genero VARCHAR(60),
    nr_duracao INT,
    vl_avaliacao DECIMAL(10 , 2 ),
    bt_disponivel TINYINT(1),
    dt_lancamento DATE,
    PRIMARY KEY (id_filme)
);

CREATE TABLE tb_diretor (
    id_diretor INT AUTO_INCREMENT,
    nm_diretor VARCHAR(70),
    dt_nascimento DATE,
    id_filme INT,
    FOREIGN KEY (id_filme)
        REFERENCES tb_filme (id_filme),
    PRIMARY KEY (id_diretor)
);

CREATE TABLE tb_ator (
    id_ator INT AUTO_INCREMENT,
    nm_ator VARCHAR(70),
    dt_nascimento DATE,
    vl_altura DECIMAL(10 , 2 ),
    PRIMARY KEY (id_ator)
);

CREATE TABLE tb_filme_ator (
    id_filme_ator INT AUTO_INCREMENT,
    nm_personagem VARCHAR(80),
    id_filme INT,
    id_ator INT,
    FOREIGN KEY (id_filme)
        REFERENCES tb_filme (id_filme),
    FOREIGN KEY (id_ator)
        REFERENCES tb_ator (id_ator),
    PRIMARY KEY (id_filme_ator)
);

insert into tb_filme (`nm_filme`, `ds_genero`, `nr_duracao`, `vl_avaliacao`, `bt_disponivel`, `dt_lancamento`) values ('JoJos Bizarre Adventures: 3', 'Ação', 160, 10.0, true, '2008-02-04');
insert into tb_filme (`nm_filme`, `ds_genero`, `nr_duracao`, `vl_avaliacao`, `bt_disponivel`, `dt_lancamento`) values ('Amazing Spider Man: 2', 'Ação', 180, 8.80, true, '2018-06-02');
insert into tb_filme (`nm_filme`, `ds_genero`, `nr_duracao`, `vl_avaliacao`, `bt_disponivel`, `dt_lancamento`) values ('Venom', 'Suspense', 200, 7.8, false, '2019-01-11');
insert into tb_filme (`nm_filme`, `ds_genero`, `nr_duracao`, `vl_avaliacao`, `bt_disponivel`, `dt_lancamento`) values ('A Cabana', 'Terror', 120, 5.0, false, '2012-05-06');

insert into tb_ator (`nm_ator`, `dt_nascimento`, `vl_altura`) values ('Jotaro Joestar', '1999-08-02', 1.80);
insert into tb_ator (`nm_ator`, `dt_nascimento`, `vl_altura`) values ('Tobey Maguire', '1996-01-01', 1.70);
insert into tb_ator (`nm_ator`, `dt_nascimento`, `vl_altura`) values ('Louro José', '1988-05-12', 1.20);

insert into tb_diretor (`nm_diretor`, `dt_nascimento`, `id_filme`) values ('José E.', '1980-09-09', '2');
insert into tb_diretor (`nm_diretor`, `dt_nascimento`, `id_filme`) values ('Araki B.', '1988-01-02', '1');
insert into tb_diretor (`nm_diretor`, `dt_nascimento`, `id_filme`) values ('Chris E.', '1999-07-01', '3');

insert into tb_filme_ator (`nm_personagem`, `id_filme`, `id_ator`) values ('Homem Aranha', '2','1');
insert into tb_filme_ator (`nm_personagem`, `id_filme`, `id_ator`) values ('Edie Brok', '3', '3');
insert into tb_filme_ator (`nm_personagem`, `id_filme`, `id_ator`) values ('Boneco Malvado', '4','3');
insert into tb_filme_ator (`nm_personagem`, `id_filme`, `id_ator`) values ('Dio Brando', '1', '1');

