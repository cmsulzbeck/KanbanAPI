using System.Collections.Generic;
using BACK.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BACK.Data
{
    public class KanbanContext : IdentityDbContext
    {
        public KanbanContext(DbContextOptions<KanbanContext> options) : base(options) { }
        
        public DbSet<Card> Cards { get; set; }
        // public DbSet<Usuario> Usuarios { get; set; }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     // Setting initial values to populate database
        //     builder.Entity<Card>()
        //         .HasData(new List<Card>(){
        //             new Card(1, "Montar API", "Integrar API no BACKEND", "lista?")
        //         });

        //         // builder.Ignore<IdentityUserLogin<string>>();
        //         // builder.Ignore<IdentityUserRole<string>>();
        //         // // builder.Ignore<IdentityUserClaim<string>>();
        //         // builder.Ignore<IdentityUserToken<string>>();
        //         // builder.Ignore<IdentityUser<string>>();
        // }
    }
}