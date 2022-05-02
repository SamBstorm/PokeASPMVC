using System;
using System.Collections.Generic;
using System.Text;

namespace PokeApiDAL.Models
{
    public class PokeApiResult
    {
        public int id { get; set; }
        public string name { get; set; }
        public PokeApiResultSprites sprites { get; set; }
    }
}
