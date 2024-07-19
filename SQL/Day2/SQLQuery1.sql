use librarysystem 
go
create table Author(
[ID] int not null,
[Name] varchar(50) ,
[Address] varchar(50),
constraint AuthorPkey primary key (ID)
)

go 
create table Publisher(
[Name] varchar(50) primary key,
[Address] varchar(50)

)

create table Book(
ISBN varchar(10) not null primary key,
Title varchar(100),
Borrow bit default 1,
PublisherName varchar(50),
publishdate date,
constraint publisherFKey foreign key (PublisherName) references [Publisher]([Name])
)


create table Member (
[ID] int not null primary key,
[Name] varchar(50) ,
[Type] char(7) not null,
constraint Typecheck check ([Type] in ('premuim','regular'))
)

alter table [Member]
alter column [Name] title varc


insert into [Author] (ID,[Name],[Address]) values(1,'Mikha','BNS')


insert into [Author] values(3,'salah','Minia'),(4,'ahmed','BNS'),(5,'ahmed','BNS');


select * from [dbo].[Author] where [Name]='Mo'


