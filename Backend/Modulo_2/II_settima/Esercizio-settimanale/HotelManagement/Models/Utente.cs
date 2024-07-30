using System.ComponentModel.DataAnnotations;
using Hotel.Utilities;

namespace Hotel.Models
{
    public class Utente
    {
        public int IdUtenti { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "La password e la password di conferma non coincidono.")]
        public string ConfermaPassword { get; set; }

        public string Immagine { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Cognome { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Il Codice Fiscale deve essere di 16 caratteri.")]
        public string CodiceFiscale { get; set; }

        [Required]
        public DateTime DataDiNascita { get; set; }

        [Required]
        [StringLength(50)]
        public string LuogoDiNascita { get; set; }

        [Required]
        [StringLength(50)]
        public string LuogoDiResidenza { get; set; }

        [Required]
        [StringLength(100)]
        public string Indirizzo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public void GeneraCodiceFiscale()
        {
            this.CodiceFiscale = CodiceFiscaleHelper.CalcolaCodiceFiscale(this.Nome, this.Cognome, this.DataDiNascita, this.LuogoDiNascita, "M");
        }
    }
}
