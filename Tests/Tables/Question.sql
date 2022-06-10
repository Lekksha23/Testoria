CREATE TABLE [dbo].[Question]
(
	[Id] INT NOT NULL PRIMARY KEY identity (1, 1),
	[Text] varchar (1000) not null,
	[Number] int not null,
	[TestId] int not null,
	[Difficulty] int not null
)
