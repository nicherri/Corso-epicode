namespace Pratica_S1.L1
{
    internal class Animale
    {
        public string nome;
        public string specie;
        public int età;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Specie
        {
            get { return specie; }
            set { specie = value; }
        }

        public int Età
        {
            get { return età; }
            set { età = value; }
        }

        public void Descriviti()
        {
            Console.WriteLine("Mi chiamo " + nome + ", sono un " + specie + " e ho " + età + " anni.");
        }
    }
}
