using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PokeASPMVC.Models
{
    public class PokemonTeamsForm
    {
        [DisplayName("Nom de l'équipe :")]
        public string name { get; set; }
        [DisplayName("Pokémon de tête d'équipe : ")]
        public int pokemon_1_id { get; set; }
        [DisplayName("Pokémon 2 : ")]
        public int? pokemon_2_id { get; set; }
        [DisplayName("Pokémon 3 : ")]
        public int? pokemon_3_id { get; set; }
        [DisplayName("Pokémon 4 : ")]
        public int? pokemon_4_id { get; set; }
        [DisplayName("Pokémon 5 : ")]
        public int? pokemon_5_id { get; set; }
        [DisplayName("Pokémon 6 : ")]
        public int? pokemon_6_id { get; set; }

        public int[] pokemon_list {
            get {
                int[] list = new int[151];
                for (int i = 1; i <= 151; i++)
                {
                    list[i-1] = i;
                }
                return list;
            }
        }
    }
}
