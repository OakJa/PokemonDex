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
            this.Type = PokemonType.normal;
            this.Height = 0.6;
            this.Weight = 4.2;
            this.HP = 74;
            this.Attack = 48;
            this.Defense = 76;
            this.SpecialAttack = 83;
            this.SpecialDefense = 81;
            this.Speed = 104;
            this.Total = 476;
            this.Name = "Meowscarada";
            this.Species = "Technician, \n" +
                 "Pickup, " +
                 "Unnerve";
            this.image =
                Resource1.ResourceManager.GetObject("meowscarada") as byte[] ?? Array.Empty<byte>();
        }
    }
    
}

