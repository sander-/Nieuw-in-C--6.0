using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperty
{
    // 1. Initializers for auto-properties 
    public class ReceptOud
    {
        public string Titel { get; set; }
        public int Niveau { get; set; }
        public ReceptOud()
        {
            this.Titel = "[Nieuw]";
            this.Niveau = 300;
        }
    }

    public class ReceptNieuw
    {
        public string Titel { get; set; } = "[Nieuw]";
        public int Niveau { get; set; } = 300;
    }


    // 2. Getter-only auto-properties 
    public class IngredientOud
    {
        public int Aantal { get; private set; }
        public IngredientOud()
        {
            this.Aantal = 5;
        }
    }

    public class IngredientNieuw
    {
        public int Aantal { get; } = 5;
    }


    // 3. Ctor assignment to getter-only autoprops
    public class Keuken
    {
        public string Naam { get; }
        public Keuken()
        {
            // Dit kon niet in =< C# 5.0
            this.Naam = "Frans";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
