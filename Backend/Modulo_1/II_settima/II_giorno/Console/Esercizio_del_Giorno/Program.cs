using System;

class Program
{
    static void Main()
    {
        CV mioCV = new CV();

        mioCV.InformazioniPersonali = InserisciInformazioniPersonali();

        bool aggiungiStudi = true;
        while (aggiungiStudi)
        {
            mioCV.AddStudi(InserisciStudi());
            Console.Write("Vuoi aggiungere altri studi? (s/n): ");
            aggiungiStudi = Console.ReadLine().ToLower() == "s";
        }

        bool aggiungiImpiego = true;
        while (aggiungiImpiego)
        {
            Impiego impiego = new Impiego();
            bool aggiungiEsperienza = true;
            while (aggiungiEsperienza)
            {
                impiego.AddEsperienza(InserisciEsperienza());
                Console.Write("Vuoi aggiungere altre esperienze a questo impiego? (s/n): ");
                aggiungiEsperienza = Console.ReadLine().ToLower() == "s";
            }
            mioCV.AddImpiego(impiego);
            Console.Write("Vuoi aggiungere altri impieghi? (s/n): ");
            aggiungiImpiego = Console.ReadLine().ToLower() == "s";
        }

        StampaDettagliCVSuSchermo(mioCV);
    }

    static InformazioniPersonali InserisciInformazioniPersonali()
    {
        InformazioniPersonali info = new InformazioniPersonali();
        Console.Write("Inserisci il nome: ");
        info.Nome = Console.ReadLine();
        Console.Write("Inserisci il cognome: ");
        info.Cognome = Console.ReadLine();
        Console.Write("Inserisci il telefono: ");
        info.Telefono = Console.ReadLine();
        Console.Write("Inserisci l'email: ");
        info.Email = Console.ReadLine();
        return info;
    }

    static Studi InserisciStudi()
    {
        Studi studi = new Studi();
        Console.Write("Inserisci il qualifica: ");
        studi.Qualifica = Console.ReadLine();
        Console.Write("Inserisci l'istituto: ");
        studi.Istituto = Console.ReadLine();
        Console.Write("Inserisci il tipo: ");
        studi.Tipo = Console.ReadLine();
        Console.Write("Inserisci la data di inizio (dd/MM/yyyy): ");
        studi.Dal = DateTime.Parse(Console.ReadLine());
        Console.Write("Inserisci la data di fine (dd/MM/yyyy): ");
        studi.Al = DateTime.Parse(Console.ReadLine());
        return studi;
    }

    static Esperienza InserisciEsperienza()
    {
        Esperienza esperienza = new Esperienza();
        Console.Write("Inserisci l'azienda: ");
        esperienza.Azienda = Console.ReadLine();
        Console.Write("Inserisci il job title: ");
        esperienza.JobTitle = Console.ReadLine();
        Console.Write("Inserisci la data di inizio (dd/MM/yyyy): ");
        esperienza.Dal = DateTime.Parse(Console.ReadLine());
        Console.Write("Inserisci la data di fine (dd/MM/yyyy): ");
        esperienza.Al = DateTime.Parse(Console.ReadLine());
        Console.Write("Inserisci la descrizione: ");
        esperienza.Descrizione = Console.ReadLine();
        Console.Write("Inserisci i compiti: ");
        esperienza.Compiti = Console.ReadLine();
        return esperienza;
    }

    static void StampaDettagliCVSuSchermo(CV cv)
    {
        Console.WriteLine("++++ INIZIO Informazioni Personali: ++++");
        Console.WriteLine($"Nome: {cv.InformazioniPersonali.Nome}");
        Console.WriteLine($"Cognome: {cv.InformazioniPersonali.Cognome}");
        Console.WriteLine($"Email: {cv.InformazioniPersonali.Email}");
        Console.WriteLine($"Telefono: {cv.InformazioniPersonali.Telefono}");
        Console.WriteLine("++++ FINE Informazioni Personali: ++++");

        Console.WriteLine("++++ INIZIO Studi e Formazione: ++++");
        foreach (var studi in cv.StudiEffettuati)
        {
            Console.WriteLine($"Istituto: {studi.Istituto}");
            Console.WriteLine($"Qualifica: {studi.Qualifica}");
            Console.WriteLine($"Tipo: {studi.Tipo}");
            Console.WriteLine($"Dal: {studi.Dal:dd/MM/yyyy} al {studi.Al:dd/MM/yyyy}");
        }
        Console.WriteLine("++++ FINE Studi e Formazione: ++++");

        Console.WriteLine("++++ INIZIO Esperienze professionali: ++++");
        foreach (var impiego in cv.Impieghi)
        {
            foreach (var esperienza in impiego.Esperienze)
            {
                Console.WriteLine($"Presso: {esperienza.Azienda}");
                Console.WriteLine($"Tipo di lavoro: {esperienza.JobTitle}");
                Console.WriteLine($"Compito: {esperienza.Compiti}");
                Console.WriteLine($"Dal: {esperienza.Dal:dd/MM/yyyy} al {esperienza.Al:dd/MM/yyyy}");
                Console.WriteLine($"Descrizione: {esperienza.Descrizione}");
            }
        }
        Console.WriteLine("++++ FINE Esperienze professionali: ++++");
    }
}
