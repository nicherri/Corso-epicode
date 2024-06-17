namespace Pratica_S1.L1
{
    internal class Veicolo
    {
        public string marca;
        public string modello;
        public int anno;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modello
        {
            get { return modello; }
            set { modello = value; }
        }

        public int Anno
        {
            get { return anno; }
            set { anno = value; }
        }

        public void Descriviti()
        {
            Console.WriteLine("Questo è un " + marca + " " + modello + " del " + anno);
        }
    }
}
