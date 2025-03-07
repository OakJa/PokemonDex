using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{
    public enum PokemonType 
    {
        normal,
        flying,
        electric,
        fire,
        water,
        grass,
        ice,
        fighting,
        poison,
        ground,
        rock,
        bug,
        dragon,
        ghost,
        dark,
        psychic,


    }
    public class Pokemon
    {
        //class attributes
        public string Name;
        public int HP;
        public int Attack;
        public int Defense;
        public int SpecialAttack;
        public int SpecialDefense;
        public int Speed;
        public int Total;
        public double Height;
        public double Weight;
        public string Species;
        public PokemonType Type;
        public byte[] image;
        //constructor
        public Pokemon() { }
        //methods
        public string getName() { 
            return this.Name;
        }
        public byte[] getImage()
        {
            return this.image;
        }
    }
}
