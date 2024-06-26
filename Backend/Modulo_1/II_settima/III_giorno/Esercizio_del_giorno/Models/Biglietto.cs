namespace Esercizio_del_giorno.Models
{
    public class Biglietto
    {
        public string? Sala { get; set; }
        public bool Ridotto { get; set; }
        public Utente Utente { get; set; }
    }
}
