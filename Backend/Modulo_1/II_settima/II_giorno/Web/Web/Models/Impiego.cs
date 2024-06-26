using System.Collections.Generic;

namespace CVWebApp.Models
{
    public class Impiego
    {
        public List<Esperienza> Esperienze { get; set; }

        public Impiego()
        {
            Esperienze = new List<Esperienza>();
        }

        public void AddEsperienza(Esperienza esperienza)
        {
            Esperienze.Add(esperienza);
        }
    }
}
