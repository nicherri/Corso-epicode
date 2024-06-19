using System;

namespace Pratica_S1_L3
{
    internal class Program
    {
        static ContoCorrente conto = new ContoCorrente();

        static void Main(string[] args)
        {
            MenuPrincipale();
        }

        static void MenuPrincipale()
        {
            Console.WriteLine();
            Console.WriteLine("Scegli un'azione:");
            Console.WriteLine("1. Apri conto");
            Console.WriteLine("2. Fai un versamento");
            Console.WriteLine("3. Fai un prelievo");
            Console.WriteLine("4. Visualizza saldo");
            Console.WriteLine("5. Esci");
            Console.WriteLine();

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    ApriConto();
                    break;

                case "2":
                    FaiVersamento();
                    break;

                case "3":
                    FaiPrelievo();
                    break;

                case "4":
                    VisualizzaSaldo();
                    break;

                case "5":
                    Esci();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Scelta non valida.");
                    Console.WriteLine();
                    MenuPrincipale();
                    break;
            }
        }

        static void ApriConto()
        {
            Console.WriteLine();
            Console.WriteLine("Inserisci l'importo del primo versamento:");
            decimal primoVersamento = decimal.Parse(Console.ReadLine());
            conto.ApriConto(primoVersamento);
            Console.WriteLine();
            MenuPrincipale();
        }

        static void FaiVersamento()
        {
            Console.WriteLine();
            Console.WriteLine("Inserisci l'importo da versare:");
            decimal versamento = decimal.Parse(Console.ReadLine());
            conto.Versamento(versamento);
            Console.WriteLine();
            MenuPrincipale();
        }

        static void FaiPrelievo()
        {
            Console.WriteLine();
            Console.WriteLine("Inserisci l'importo da prelevare:");
            decimal prelievo = decimal.Parse(Console.ReadLine());
            conto.Prelievo(prelievo);
            Console.WriteLine();
            MenuPrincipale();
        }

        static void VisualizzaSaldo()
        {
            Console.WriteLine();
            Console.WriteLine($"Il saldo attuale è: {conto.VisualizzaSaldo()} euro.");
            Console.WriteLine();
            MenuPrincipale();
        }

        static void Esci()
        {
            Console.WriteLine();
            Console.WriteLine("Grazie per aver utilizzato il nostro servizio. Arrivederci!");
            Console.WriteLine();
        }
    }
}
