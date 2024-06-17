using System.Security.Cryptography.X509Certificates;

namespace Pratica_S1.L1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Atleta atleta = new Atleta();
            atleta.nome = "Nicola";
            atleta.cognome = "Schirripa";
            atleta.sport = "atlettica";
            atleta.età = 25;
            atleta.Descriviti();

            Dipedente dipedente = new Dipedente();
            dipedente.nome = "Mario";
            dipedente.cognome = "Rossi";
            dipedente.lavoro = "Ingegnere Meccanico";
            dipedente.età = 45;
            dipedente.esperienza = "15 anni";
            dipedente.Descriviti();


            Animale animale = new Animale();
            animale.nome = "pippo";
            animale.specie = "cane";
            animale.età = 5;
            animale.Descriviti();

            Veicolo veicolo = new Veicolo();
            veicolo.marca = "Fiat";
            veicolo.modello = "Panda";
            veicolo.anno = 2010;
            veicolo.Descriviti();
        }

    }
   
    }
