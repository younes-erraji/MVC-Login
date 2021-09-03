Create Database Library
Go
Use Library
Go
Create Table Users (
  ID int Identity(0,1) Primary Key,
  username varchar(22) not null unique,
  [password] nvarchar(22) not null
)
GO
Insert Into Users Values ('safae', '123'), ('ilham', '123'), ('Younes', '123')
GO
Select * from Users
