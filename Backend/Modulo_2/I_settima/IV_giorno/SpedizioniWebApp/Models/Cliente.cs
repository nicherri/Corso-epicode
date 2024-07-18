namespace SpedizioniWebApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIVA { get; set; }
        public string TipoCliente { get; set; } // 'Privato' o 'Azienda'
    }
}
