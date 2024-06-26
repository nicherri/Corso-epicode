using System.Collections.Generic;
using Web.Models;

namespace CVWebApp.Models
{
    public class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public List<Impiego> Impieghi { get; set; }

        public CV()
        {
            StudiEffettuati = new List<Studi>();
            Impieghi = new List<Impiego>();
        }

        public void AddStudi(Studi studi)
        {
            StudiEffettuati.Add(studi);
        }

        public void AddImpiego(Impiego impiego)
        {
            Impieghi.Add(impiego);
        }
    }
}
