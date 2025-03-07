using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Vaporeon : Pokemon
    {
        public Vaporeon() {
            this.Type = PokemonType.water;
            this.Height = 1.0;
            this.Weight = 29.0;
            this.HP = 130;
            this.Attack = 65;
            this.Defense = 60;
            this.SpecialAttack = 110;
            this.SpecialDefense = 95;
            this.Speed = 65;
            this.Total = 525;
            this.Name = "Vaporeon";
            this.Species = "Water Absorb, Hydration";
            this.image =
                Resource1.ResourceManager.GetObject("vaporeon") as byte[] ?? Array.Empty<byte>();
        }
    }
}
