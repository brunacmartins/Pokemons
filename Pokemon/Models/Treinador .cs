using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.Models
{
    public class Treinadores
    {
        public int TreinadorId { get; set; }
        public string Nome { get; set; }

        public virtual List<Pokemons> Treinador { get; set; }
    }

    public class Masterizacao
    {
        public int TipoId { get; set; }
        public string PokemonPrincipal { get; set; }

        public int PokemonId { get; set; }
        public virtual Treinadores Treinador { get; set; }
    }
}