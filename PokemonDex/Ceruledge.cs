using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Ceruledge : Pokemon
    {
        public Ceruledge() { 
        this.Type = PokemonType.ghost;
            this.Type2 = PokemonType.dark;
            this.Height = 1.5;
            this.Weight = 61.0;
            this.HP = 75;
            this.Attack = 125;
            this.Defense = 80;
            this.SpecialAttack = 60;
            this.SpecialDefense = 100;
            this.Speed = 85;
            this.Total = 525;
            this.Name = "Ceruledge";
            this.Species = "Fire Blades Pokémon";
            this.image = Resource1.ResourceManager.GetObject("ceruledge") as byte[] ?? Array.Empty<byte>();
        }
    }
}
