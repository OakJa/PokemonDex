using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Noibat : Pokemon
    {
        public Noibat()
        {
            this.Type = Pokemon_Type.Flying;
            this.Height = 0.5;
            this.Weight = 8.0;
            this.HP = 40;
            this.Attack = 30;
            this.Defense = 35;
            this.SpecialAttack = 45;
            this.SpecialDefense = 40;
            this.Speed = 55;
            this.Total = 245;
            this.Name = "Noibat";
            this.image =
               Resource1.ResourceManager.GetObject("noibat1") as byte[] ?? Array.Empty<byte>();
        }
    }
}
