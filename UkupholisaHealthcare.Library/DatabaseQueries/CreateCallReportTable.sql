use UkupholisaDb
GO 
CREATE TABLE [CallReport](
Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
Client_id INT NOT NULL , 
CallBegin DATETIME2 NOT NULL ,
CallEnd DATETIME2 NOT NULL ,
isSatisfied  bit NOT NULL 
)
