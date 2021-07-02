using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Pokemon
{
   public class PokemonPoder:Pokemon
    {
        public PokemonPoder():base()
        {
            this.Poder = 0;
        }

        public PokemonPoder(String nome, String descricao, int poder) : base(nome,descricao)
        {
            this.Poder = poder;
        }

        public int Poder { get; set; }

        public void ExibirDadosPokemonPoder()
        {
            Console.WriteLine("Pokémon: " + this.Nome);
            Console.WriteLine("Elmento: " + this.Descricao);
            Console.WriteLine("Poder:  " + this.Poder);
        }
    }
}
