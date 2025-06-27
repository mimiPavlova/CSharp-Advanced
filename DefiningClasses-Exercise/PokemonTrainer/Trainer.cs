using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public  class Trainer
    {
        public string Name {  get; set; }
        public int NumberOfBadges { get; set; } = 0;
        public List<Pokemon> Pokemons = new();

        public void RemoveDeadPokemons()
        {
            this.Pokemons.RemoveAll(p=>p.Health<=0);    
        }
    }
}
