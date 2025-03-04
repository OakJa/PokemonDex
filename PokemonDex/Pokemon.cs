using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonDex;

namespace PokemonDex

{
    public enum Pokemon_Type
    {
        Dark,

        Fire,

        Dragon,

        Flying


    }
        
    }
public class Pokemon
{
    protected string Name;
    protected int HP;
    protected int Attack;
    protected int Defense;
    protected int SpecialAttack;
    protected int SpecialDefense;
    protected int Speed;
    protected int Total;
    protected double Height;
    protected double Weight;
    protected string Species;
    protected Pokemon_Type Type;
    protected byte[] image;

    public Pokemon() { }

    public string getName()
    {
        return this.Name;
    }

    public byte[] getImage()
    {
        return this.image;
    }
}




