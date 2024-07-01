CREATE TABLE [dbo].[Tabella Cliente]
(
	[IDCliente] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nome] VARCHAR(50) NOT NULL,
    [Cognome] VARCHAR(50) NOT NULL,
    [DataNascita] DATE NOT NULL,
    [Sesso] CHAR(1) NOT NULL,
    [CF] CHAR(16) NOT NULL UNIQUE,
    [PIVA] CHAR(11) NOT NULL UNIQUE,
    [Attivo] BIT NOT NULL,
    [Saldo] DECIMAL(10, 2) NOT NULL
)
