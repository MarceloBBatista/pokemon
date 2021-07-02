using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Pokemon
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializarLista();
        }

        private List<PokemonPoder> pokemons;

        public List<PokemonPoder> Pokemons
        {
            get { return pokemons; }
        }

        private void InicializarLista()
        {
           
          this.pokemons = new List<PokemonPoder>();
            PokemonPoder p = new PokemonPoder("Charmander", "FOGO", 50);
            this.pokemons.Add(p);
            Console.WriteLine("--------------------");
            p = new PokemonPoder("Pikachu", "ELÉTRICO", 100);
            this.pokemons.Add(p);
            p = new PokemonPoder("Meowth", "NORMAL", 25);
            this.pokemons.Add(p);
            p = new PokemonPoder("Alakazam", "PSÍQUICO", 500);
            this.pokemons.Add(p);
            p = new PokemonPoder("Machamp", "LUTADOR", 150);
            this.pokemons.Add(p);
            p = new PokemonPoder("Gengar", "FANTASMA/VENENOSO", 500);
            this.pokemons.Add(p);
            p = new PokemonPoder("Onix", "PEDRA/TERRESTRE", 75);
            this.pokemons.Add(p);
            p = new PokemonPoder("Electrode", "ELÉTRICO", 50);
            this.pokemons.Add(p);
            p = new PokemonPoder("Gyarados", "ÁGUA/VOADOR", 500);
            this.pokemons.Add(p);
            p = new PokemonPoder("Bulbasauro", "PLANTA/VENENOSO", 50);
            this.pokemons.Add(p);

        }

        public void ListaPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                Console.WriteLine("ID do Pokémon: " + i);
                this.Pokemons[i].ExibirDadosPokemon();
                //kemon p = this.Pokemons[i];
              //p.ExibirDadosPokemon();
            }
        }

    }
}
