CREATE TABLE [dbo].[Tabella Cantiere]
(
	[IdCantiere] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [DenominazioneCantiere] VARCHAR(100) NOT NULL,
    [Indirizzo] VARCHAR(100) NOT NULL,
    [Citta] VARCHAR(50) NOT NULL,
    [CAP] CHAR(5) NOT NULL,
    [PersonaRiferimento] VARCHAR(100) NOT NULL,
    [DataInizioLavori] DATE NOT NULL,
    [DataFineLavori] DATE,
    [LavoriTerminatiSI_NO] BIT NOT NULL
)
