--CREATE DATABASE Details;

CREATE TABLE [Details].dbo.[Customer]
(
    PersonID int,
    Surname varchar(255),
    FirstName varchar(255),
    Email varchar(100),
    UserName varchar(50) 
)

INSERT INTO [Details].dbo.[Customer]
(PersonID, Surname, FirstName, Email, UserName)
VALUES(1, 'Williams', 'Jon', 'jon@w.com', 'jonw')

select *
from [Details].dbo.[Customer]