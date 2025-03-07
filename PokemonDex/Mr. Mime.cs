using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class MrMime : Pokemon
    {
        public MrMime()
        {
            this.Type = PokemonType.psychic;
            this.Height = 1.3;
            this.Weight = 54.5;
            this.HP = 40;
            this.Attack = 45;
            this.Defense = 65;
            this.SpecialAttack = 100;
            this.SpecialDefense = 120;
            this.Speed = 90;
            this.Total = 460;
            this.Name = "SatoshiFater";
            this.Species = "Barrier, Confusion, Double Slap\n, Light Screen, Meditate, Mimic\n, Psybeam, Reflect\n, Substitute, Thunder Wave";
            this.image =
                Resource1.ResourceManager.GetObject("mr-mime") as byte[] ?? Array.Empty<byte>();
        }
    }
    
}

