using System;

namespace Pratica_S1_L3.eSERCIZIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RicercaNomi();
        }

        static void RicercaNomi()
        {
            // Chiede all'utente quanti nomi vuole inserire
            Console.WriteLine("Quanti nomi vuoi inserire?");
            int dimensione = int.Parse(Console.ReadLine());

            string[] nomi = new string[dimensione];

            // Carica i nomi nell'array
            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine($"Inserisci il nome {i + 1}:");
                nomi[i] = Console.ReadLine();
            }

            // Chiede all'utente quale nome vuole cercare
            Console.WriteLine("Inserisci il nome da cercare:");
            string nomeDaCercare = Console.ReadLine();

            // Verifica se il nome è presente nell'array
            bool trovato = false;
            foreach (string nome in nomi)
            {
                if (nome.Equals(nomeDaCercare, StringComparison.OrdinalIgnoreCase))
                {
                    trovato = true;
                    break;
                }
            }

            // Stampa il risultato della ricerca
            if (trovato)
            {
                Console.WriteLine("Nome trovato nell'array.");
            }
            else
            {
                Console.WriteLine("Nome non trovato nell'array.");
            }

            // Richiama il metodo per ritornare al menu principale o uscire
            FineOperazione();
        }

        static void FineOperazione()
        {
            Console.WriteLine();
            Console.WriteLine("Vuoi eseguire un'altra operazione? (S/N)");
            string risposta = Console.ReadLine();

            if (risposta.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Main(new string[0]); // Richiama il menu principale
            }
            else
            {
                Console.WriteLine("Grazie per aver utilizzato il programma. Arrivederci!");
                Environment.Exit(0); // Esce dal programma
            }
        }
    }
}
