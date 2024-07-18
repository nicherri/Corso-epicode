USE Azienda;
GO

-- Inserimento dei dati nella tabella IMPIEGATO
INSERT INTO IMPIEGATO (Cognome, Nome, CodiceFiscale, Eta, RedditoMensile, DetrazioneFiscale)
VALUES
('Rossi', 'Mario', 'RSSMRA85M01H501Z', 34, 1200.00, 1),
('Bianchi', 'Luigi', 'BCHLGU78L01L219F', 46, 1000.00, 0),
('Verdi', 'Carlo', 'VRDCRL80A01H501U', 28, 900.00, 1),
('Neri', 'Giulia', 'NRGLU85A01H501V', 30, 1100.00, 1),
('Gialli', 'Francesca', 'GLLFNC90A01H501W', 32, 850.00, 0),
('Blu', 'Simone', 'BLSMN85A01H501X', 50, 950.00, 0),
('Marroni', 'Paola', 'MRRPLA75A01H501Y', 42, 1050.00, 1),
('Rosa', 'Anna', 'RSANN85A01H501Z', 37, 1150.00, 1),
('Grigi', 'Marco', 'GRGMRC80A01H501A', 29, 1250.00, 0),
('Bianchi', 'Elena', 'BCHLNE85A01H501B', 41, 1300.00, 1),
('Verdi', 'Davide', 'VRDDVD90A01H501C', 35, 1400.00, 0),
('Rossi', 'Federica', 'RSSFRC85A01H501D', 48, 900.00, 0),
('Gialli', 'Giorgio', 'GLLGRG85A01H501E', 33, 1100.00, 1),
('Blu', 'Luca', 'BLLLC85A01H501F', 45, 1200.00, 1),
('Marroni', 'Chiara', 'MRRCHR85A01H501G', 39, 800.00, 0),
('Rosa', 'Valeria', 'RSVLR85A01H501H', 31, 950.00, 1),
('Grigi', 'Sara', 'GRGSRA85A01H501I', 27, 1000.00, 0),
('Bianchi', 'Alessandro', 'BCHALS85A01H501J', 38, 1050.00, 1),
('Verdi', 'Marta', 'VRDMRT85A01H501K', 36, 1150.00, 0),
('Rossi', 'Giacomo', 'RSSGCM85A01H501L', 40, 1250.00, 1);
GO

-- Inserimento dei dati nella tabella IMPIEGO
INSERT INTO IMPIEGO (TipoImpiego, Assunzione, IDImpiegato)
VALUES
('Amministrativo', '2010-01-15', 1),
('Tecnico', '2009-05-22', 2),
('Commerciale', '2011-02-10', 3),
('Amministrativo', '2012-03-15', 4),
('Tecnico', '2008-04-12', 5),
('Commerciale', '2007-05-10', 6),
('Amministrativo', '2010-06-15', 7),
('Tecnico', '2009-07-20', 8),
('Commerciale', '2011-08-25', 9),
('Amministrativo', '2012-09-30', 10),
('Tecnico', '2008-10-05', 11),
('Commerciale', '2007-11-10', 12),
('Amministrativo', '2010-12-15', 13),
('Tecnico', '2009-01-20', 14),
('Commerciale', '2011-02-25', 15),
('Amministrativo', '2012-03-30', 16),
('Tecnico', '2008-04-05', 17),
('Commerciale', '2007-05-10', 18),
('Amministrativo', '2010-06-15', 19),
('Tecnico', '2009-07-20', 20);
GO
