USE Azienda;
GO

-- a. Visualizzare tutti gli impiegati oltre i 29 anni
SELECT * FROM IMPIEGATO WHERE Eta > 29;
GO

-- b. Visualizzare tutti gli impiegati con un reddito di almeno 800 euro mensili
SELECT * FROM IMPIEGATO WHERE RedditoMensile >= 800;
GO

-- c. Visualizzare tutti gli impiegati che posseggono la detrazione fiscale
SELECT * FROM IMPIEGATO WHERE DetrazioneFiscale = 1;
GO

-- d. Visualizzare tutti gli impiegati che non posseggono la detrazione fiscale
SELECT * FROM IMPIEGATO WHERE DetrazioneFiscale = 0;
GO

-- e. Visualizzare tutti gli impiegati cui il cognome cominci con una lettera G e li visualizzi in ordine alfabetico
SELECT * FROM IMPIEGATO WHERE Cognome LIKE 'G%' ORDER BY Cognome;
GO

-- f. Visualizzare il numero totale degli impiegati registrati nella base dati
SELECT COUNT(*) AS NumeroTotaleImpiegati FROM IMPIEGATO;
GO

-- g. Visualizzare il totale dei redditi mensili di tutti gli impiegati
SELECT SUM(RedditoMensile) AS TotaleRedditiMensili FROM IMPIEGATO;
GO

-- h. Visualizzare la media dei redditi mensili di tutti gli impiegati
SELECT AVG(RedditoMensile) AS MediaRedditiMensili FROM IMPIEGATO;
GO

-- i. Visualizzare l’importo del reddito mensile maggiore
SELECT MAX(RedditoMensile) AS RedditoMensileMaggiore FROM IMPIEGATO;
GO

-- j. Visualizzare l’importo del reddito mensile minore
SELECT MIN(RedditoMensile) AS RedditoMensileMinore FROM IMPIEGATO;
GO

-- k. Visualizzare gli impiegati assunti dall’01/01/2007 all’01/01/2008
SELECT * FROM IMPIEGO WHERE Assunzione BETWEEN '2007-01-01' AND '2008-01-01';
GO

-- l. Tramite una query parametrica che identifichi il tipo di impiego, visualizzare tutti gli impiegati che corrispondono a quel tipo di impiego
DECLARE @TipoImpiego NVARCHAR(50);
SET @TipoImpiego = 'Amministrativo'; -- Cambiare secondo necessità
SELECT i.* FROM IMPIEGATO i
JOIN IMPIEGO e ON i.IDImpiegato = e.IDImpiegato
WHERE e.TipoImpiego = @TipoImpiego;
GO

-- m. Visualizzare l’età media dei lavoratori all’interno dell’azienda
SELECT AVG(Eta) AS EtaMedia FROM IMPIEGATO;
GO
