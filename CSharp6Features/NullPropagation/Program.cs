using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPropagation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Dit gaat fout
            var recept1 = new Recept();
            //var benodigd1 = recept1.Ingredienten.FirstOrDefault().Naam;

            // 2. Dit gaat goed
            var recept2 = new Recept();
            var benodigd2 = recept2.Ingredienten?.FirstOrDefault()?.Naam;
            var hoeveelheid2= recept2.Ingredienten?.FirstOrDefault()?.Hoeveelheid;
        }
    }

    public class Kookboek
    {
        public IEnumerable<Recept> Recepten { get; set; }
    }
    public class Recept
    {
        public string Naam { get; set; }
        public IEnumerable<Ingredient> Ingredienten { get; set; }
    }

    public class Ingredient
    {
        public string Naam { get; set; }
        public float Hoeveelheid { get; set; }
    }

}
