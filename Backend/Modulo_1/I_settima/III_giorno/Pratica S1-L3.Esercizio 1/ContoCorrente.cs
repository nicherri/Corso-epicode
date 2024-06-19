using System;

namespace Pratica_S1_L3
{
    public class ContoCorrente
    {
        private decimal saldo;   // Proprietà privata per memorizzare il saldo del conto
        private bool contoAperto; // Proprietà privata per indicare se il conto è aperto

        // Costruttore della classe, inizializza il saldo a 0 e il conto come chiuso
        public ContoCorrente()
        {
            saldo = 0;
            contoAperto = false;
        }

        // Metodo per aprire il conto con un versamento iniziale
        public void ApriConto(decimal primoVersamento)
        {
            if (!contoAperto)
            {
                if (primoVersamento >= 10)
                {
                    saldo = primoVersamento;
                    contoAperto = true;
                    Console.WriteLine("Il conto è stato aperto con successo.");
                }
                else
                {
                    Console.WriteLine("Per aprire il conto è necessario un versamento minimo di 10 euro.");
                }
            }
            else
            {
                Console.WriteLine("Il conto è già stato aperto.");
            }
        }

        // Metodo per effettuare un versamento
        public void Versamento(decimal importo)
        {
            if (contoAperto)
            {
                saldo += importo;
                Console.WriteLine($"Versamento effettuato. Nuovo saldo: {saldo} euro.");
            }
            else
            {
                Console.WriteLine("Il conto non è aperto.");
            }
        }

        // Metodo per effettuare un prelievo
        public void Prelievo(decimal importo)
        {
            if (contoAperto)
            {
                if (saldo >= importo)
                {
                    saldo -= importo;
                    Console.WriteLine($"Prelievo effettuato. Nuovo saldo: {saldo} euro.");
                }
                else
                {
                    Console.WriteLine("Saldo insufficiente per effettuare il prelievo.");
                }
            }
            else
            {
                Console.WriteLine("Il conto non è aperto.");
            }
        }

        // Metodo per visualizzare il saldo attuale
        public decimal VisualizzaSaldo()
        {
            return saldo;
        }
    }
}
