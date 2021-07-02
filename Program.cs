using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = Menu();
                Console.Clear();
                if (resp == 1)
                {
                    pokedex.ListaPokemons();
                }
                if (resp == 2)
                {
                    pokedex.ListaPokemons();
                    Console.WriteLine("Digite o ID do Pokémon: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    //Pokémon do Player
                    PokemonPoder pPlayer = pokedex.Pokemons[number];
                    //Pokémon do PC
                    Random r = new Random();
                    number = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPoder pPC = pokedex.Pokemons[number];
                    //Batalha
                    Console.WriteLine("---Dados da Batalha---");

                    Console.WriteLine("---PLAYER---");
                    pPlayer.ExibirDadosPokemonPoder();

                    Console.WriteLine("---PC---");
                    pPC.ExibirDadosPokemonPoder();

                    if (pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("Você Ganhou a Batalha!!");
                    }
                    else
                    {
                        Console.WriteLine("Você Perdeu a Batalha...");
                    }
                }

                Console.ReadKey();
                Console.Clear();
            }        
        }

        static int Menu()
        {
            Console.WriteLine("-----Batalha Pokémon-----");
            Console.WriteLine("0 - Sair da jogo");
            Console.WriteLine("1 - Lista de Pokémons");
            Console.WriteLine("2 - MINI-GAME BATALHA");
            Console.WriteLine("Escolha uma das opções!");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
