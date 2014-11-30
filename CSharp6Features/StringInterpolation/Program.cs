using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var recept = new { Naam = "Spinazie ovenschotel", Duur = 25 };

            // 1. Oude manier
            var tekst1 = string.Format("Het recept {0} duurt {1} minuten.", recept.Naam, recept.Duur);

            // 2. Nieuwe manier
            var tekst2 = "Het recept \{recept.Naam} duurt \{recept.Duur} minuten.";

            // 3. Nieuwe manier met formattering
            var tekst3 = "Het recept \{recept.Naam, 50} duurt \{recept.Duur : D4} minuten.";

            // 4. Nieuwe manier met allerlei expressies
            var tekst4 = "Het recept duurt \{recept.Duur < 20 ? "minder" : "meer"} dan 20 minuten";

            // NB in een latere release kan de notatie zo zijn
            // var s = $"Het recept {recept.Naam, 50} duurt {recept.Duur : D4} minuten.";
        }
    }
}
