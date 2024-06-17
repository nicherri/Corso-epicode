namespace Pratica_S1.L1
{
    internal class Atleta
    {
         public string nome;
        public string cognome;
         public string sport;
        public int età;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public string Sport { get { return sport; } set { sport = value; } }

        public int Età { get { return età; } set { età = value; } }

        public void Descriviti()
        {
            Console.WriteLine("Mi chiamo " + nome + " " + cognome + " età " + età + " e pratico " + sport);
        }
    }
}