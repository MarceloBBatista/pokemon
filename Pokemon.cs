using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Pokemon
{
    public class Pokemon
    {

        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public Pokemon(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set
            {
                String texto = value.ToUpper();
                nome = texto;
            }

        }

        private String descricao; // armazena o valor da propriedade Descrição

        public String Descricao // representa a caracteristica Descrição do Pokemon
        {
            get { return this.descricao; }
            set { this.descricao = value.ToUpper(); }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Pokémon: " + this.Nome);
            Console.WriteLine("Elemento: " + this.Descricao);
        }

        public void ExibirDadosPokemon(Boolean formatar)
        {
            if(formatar == true)
            {
                Console.WriteLine("Pokémon: " + this.Nome + ": " + this.Descricao.ToLower());
            }
            else
            {
                Console.WriteLine("Pokémon: " + this.Nome);
                Console.WriteLine("Elmento: " + this.Descricao);
            }
            
        }

    }
}
