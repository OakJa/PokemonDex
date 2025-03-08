using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Meowscarada : Pokemon
    {
        public Meowscarada()
        {
            this.Type = PokemonType.dark;
            this.Type2 = PokemonType.grass;
            this.Height = 0.6;
            this.Weight = 4.2;
            this.HP = 74;
            this.Attack = 110;
            this.Defense = 76;
            this.SpecialAttack = 81;
            this.SpecialDefense = 81;
            this.Speed = 123;
            this.Total = 530;
            this.Name = "Meowscarada";
            this.Species = "Magician Pokémon";
            this.image =
                Resource1.ResourceManager.GetObject("meowscarada") as byte[] ?? Array.Empty<byte>();
        }
    }
    
}

