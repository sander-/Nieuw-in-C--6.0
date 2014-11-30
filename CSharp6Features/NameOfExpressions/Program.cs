using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var recept = new Recept() { Naam = "Groentensoep" };
            try
            {
                Console.WriteLine(recept.Naam);                
                if (recept.Ingredienten == null)
                    throw new ArgumentNullException(nameof(Recept.Ingredienten));                
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);                
            }
        }
    }

    class Recept
    {
        public string Naam { get; set; }
        public IEnumerable<Ingredient>  Ingredienten { get; set; }
    }
    class Ingredient
    {
        public string Naam { get; set; }
    }
}

