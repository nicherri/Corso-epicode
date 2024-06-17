namespace Pratica_S1.L1
{
    internal class Dipedente
    {
        public string nome;
        public string cognome;
        public int età;
        public string lavoro;
        public string esperienza;


        public string Nome { get { return nome; } set { nome = value; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public string Lavoro { get { return lavoro; } set { lavoro = value; } }

        public string Esperienza { get { return esperienza; } set { esperienza = value; } }
        public int Età { get { return età; } set { età = value; } }

        public void Descriviti()
        {
            Console.WriteLine("Mi chiamo " + nome + " " + cognome + " età " + età + "  lavoro " + lavoro+"ed esperineza"+ esperienza);
        }
    }
}