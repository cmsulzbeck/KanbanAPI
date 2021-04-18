using System.Collections.Generic;
using BACK.Models;
using Microsoft.EntityFrameworkCore;

namespace BACK.Data
{
    public class KanbanContext : DbContext
    {
        public KanbanContext(DbContextOptions<KanbanContext> options) : base(options) { }
        
        public DbSet<Card> Cards { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Card>()
                .HasData(new List<Card>(){
                    new Card(1, "Montar API", "Integrar API no BACKEND", "lista?")
                });
        }
    }
}