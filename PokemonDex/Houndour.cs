using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public class Houndour : Pokemon
    {
        public Houndour()
        {
            this.Type = Pokemon_Type.Fire;
            this.Height = 0.6;
            this.Weight = 10.8;
            this.HP = 45;
            this.Attack = 60;
            this.Defense = 30;
            this.SpecialAttack = 80;
            this.SpecialDefense = 50;
            this.Speed = 65;
            this.Total = 330;
            this.Name = "Houndour";
            this.image =
               Resource1.ResourceManager.GetObject("houndour1") as byte[] ?? Array.Empty<byte>();
        }
    }
}
