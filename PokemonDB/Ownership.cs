using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDB
{
    class Ownership
    {
        public int PokemonID { get; set; }
        public int PlayerID { get; set; }
        public int Level { get; set; }
        public int numOwned { get; set; }
    }
}
