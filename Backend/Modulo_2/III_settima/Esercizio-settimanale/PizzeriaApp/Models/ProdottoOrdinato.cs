using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ProdottoOrdinato
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public Prodotto Prodotto { get; set; }
    public int Quantita { get; set; }
    public Ordine Ordine { get; set; }
}
