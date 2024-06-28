// Models/Biglietteria.cs
using Esercizio_del_giorno.Models;
using System.Collections.Generic;
using System.Linq;

namespace EsercizioCinema.Models
{
    public static class Biglietteria
    {
        public static List<Biglietto> BigliettiVenduti = new List<Biglietto>();
        public const int CapienzaSala = 120;

        public static int BigliettiVendutiNord => BigliettiVenduti.Count(b => b.Sala == "SALA NORD");
        public static int BigliettiRidottiNord => BigliettiVenduti.Count(b => b.Sala == "SALA NORD" && b.Ridotto);

        public static int BigliettiVendutiEst => BigliettiVenduti.Count(b => b.Sala == "SALA EST");
        public static int BigliettiRidottiEst => BigliettiVenduti.Count(b => b.Sala == "SALA EST" && b.Ridotto);

        public static int BigliettiVendutiSud => BigliettiVenduti.Count(b => b.Sala == "SALA SUD");
        public static int BigliettiRidottiSud => BigliettiVenduti.Count(b => b.Sala == "SALA SUD" && b.Ridotto);
    }
}
