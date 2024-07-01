CREATE TABLE [dbo].[Tabella Operaio]
(
	[IdDipendente] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nome] VARCHAR(50) NOT NULL,
    [Cognome] VARCHAR(50) NOT NULL,
    [CF] CHAR(16) NOT NULL UNIQUE,
    [FigliACarico] INT NOT NULL,
    [Sposato] BIT NOT NULL,
    [LivelloLavorativo] VARCHAR(50) NOT NULL,
    [DescrizioneMansione] TEXT NOT NULL,
    [Salario] DECIMAL(10, 2) NOT NULL
)
