using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pokemon.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Treinador.Models;

namespace Pokemon.DAL
{
    public class PokemonContext : DbContext
    {

        public PokemonContext() : base("PokemonContext")
        {
        }

        public DbSet<Treinadores> Treinador { get; set; }
        public DbSet<PokemonContext> Pokemon { get; set; }
        public DbSet<TipoPoke> Tipo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}