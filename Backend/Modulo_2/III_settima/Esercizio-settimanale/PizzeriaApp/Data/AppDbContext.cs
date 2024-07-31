using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Prodotto> Prodotti { get; set; }
        public DbSet<Ingrediente> Ingredienti { get; set; }
        public DbSet<Utente> Utenti { get; set; }
        public DbSet<Ruolo> Ruoli { get; set; }
        public DbSet<Ordine> Ordini { get; set; }
        public DbSet<ProdottoOrdinato> ProdottiOrdinati { get; set; }
        public DbSet<UtenteRuolo> UtentiRuoli { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UtenteRuolo>()
                .HasKey(ur => new { ur.UtenteId, ur.RuoloId });

            modelBuilder.Entity<UtenteRuolo>()
                .HasOne(ur => ur.Utente)
                .WithMany(u => u.UtentiRuoli)
                .HasForeignKey(ur => ur.UtenteId);

            modelBuilder.Entity<UtenteRuolo>()
                .HasOne(ur => ur.Ruolo)
                .WithMany(r => r.UtentiRuoli)
                .HasForeignKey(ur => ur.RuoloId);
        }
    }
}

