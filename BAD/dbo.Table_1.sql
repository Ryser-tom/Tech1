CREATE TABLE [dbo].[T_Commandes]
(
	[IdCommande] INT NOT NULL PRIMARY KEY, 
    [DateCommande] DATETIME NULL, 
    [Reference] VARCHAR(20) NULL, 
    [IdClient] INT NULL, 
    CONSTRAINT [FK_T_Commandes_T_Clients] FOREIGN KEY ([IdClient]) REFERENCES [T_Clients]([IdClient])
)
