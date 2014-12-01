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
            var benodigd1 = recept1.Ingredienten.FirstOrDefault().Naam;

            // 2. In =< C# 5.0 moest het zo
            var recept2 = new Recept();
            string benodigd2 = null;
            if(recept2.Ingredienten != null)
            {
                if(recept2.Ingredienten.Count() > 0)
                {
                    benodigd2 = recept2.Ingredienten.First().Naam;
                }
            }

            // 3. In C# 6.0
            var recept3 = new Recept();
            var benodigd3 = recept3.Ingredienten?.FirstOrDefault()?.Naam;
            var hoeveelheid3= recept3.Ingredienten?.FirstOrDefault()?.Hoeveelheid;
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
