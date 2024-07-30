using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class PrenotazioneServizio
    {
        public int Id { get; set; }

        [Required]
        public int PrenotazioneId { get; set; }

        [Required]
        public int ServizioId { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public int Quantita { get; set; }

        [Required]
        public decimal Prezzo { get; set; }

        public Prenotazione Prenotazione { get; set; }
        public Servizio Servizio { get; set; }
    }
}
