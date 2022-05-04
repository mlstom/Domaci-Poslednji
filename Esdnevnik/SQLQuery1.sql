create database Esdnevnik
use Esdnevnik

create table Osoba(
id int primary key identity (1,1),
ime nvarchar(20 ) not null,
prezime nvarchar(20 ) not null,
adresa nvarchar(50 ) ,
jmbg nvarchar(13 ) not null,
email nvarchar(30 ) not null,
pass nvarchar(20 ) not null,
uloga nvarchar(20 ) not null,
)

create table Smer(
id int primary key identity(1,1),
naziv nvarchar(50) not null,
)

create table Predmet(
id int primary key identity(1,1),
naziv nvarchar(50) not null,
razred int not null,
)

create table SkolskaGodina(
id int primary key identity(1,1),
naziv nvarchar(50) not null,
)

create table Odeljenje(
id int primary key identity (1,1),
razred int not null,
indeks nvarchar(2) not null,
smer int foreign key references Smer(id),
razredni int foreign key references Osoba(id),
skolskagodina int foreign key references SkolskaGodina(id)
)

create table Upisnica(
id int primary key identity(1,1),
osoba int foreign key references Osoba(id),
odeljenje int foreign key references Odeljenje(id),
)

create table Raspodela(
id int primary key identity(1,1),
nastavnik int foreign key references Osoba(id),
skolskaGodina int foreign key references SkolskaGodina(id),
predmet int foreign key references Predmet(id),
odeljenje int foreign key references Odeljenje(id),
)



create table Ocena(
id int primary key identity(1,1),
datum date,
raspodela int foreign key references Raspodela(id),
ocena int not null,
ucenik int foreign key references Osoba(id),
)







