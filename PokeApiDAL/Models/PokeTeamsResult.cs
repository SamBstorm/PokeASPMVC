using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApiDAL.Models
{
    public class PokeTeamsResult
    {
        public int id { get; set; }
        public int pokemon_1_id { get; set; }
        public int? pokemon_2_id { get; set; }
        public int? pokemon_3_id { get; set; }
        public int? pokemon_4_id { get; set; }
        public int? pokemon_5_id { get; set; }
        public int? pokemon_6_id { get; set; }
        public string name { get; set; }
    
    
    }
}
