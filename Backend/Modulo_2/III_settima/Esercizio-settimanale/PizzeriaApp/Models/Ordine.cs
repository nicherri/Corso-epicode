using Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ordine
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public Utente Utente { get; set; }
    public bool Evaso { get; set; }
    public string Indirizzo { get; set; }
    public string NoteAggiuntive { get; set; }
    public List<ProdottoOrdinato> ProdottiOrdinati { get; set; } = new();
}
