using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var stappenOud = new Dictionary<int, string>()
            {
                { 1, "Breek een ei in het kommetje." },
                { 2, "Laat in de koekenpan de margarine lichtbruin worden." },
                { 3, "Giet het ei in de pan." },                
                { 4, "Bak op een niet te grote vlam zodat het ei gestold is." }
            };

            var stappenNieuw = new Dictionary<int, string>()
            {
                [1] = "Klop in een kom de eieren los met 1 eetlepel water en wat zout en peper.",
                [2] = "Voeg de peterselie, bieslook en dragon toe en kluts de eieren.",
                [3] = "Smelt 1 eetlepel boter in een grote anti-aanbakpan op middelhoog vuur.",
                [4] = "Giet een kwart van het eimengsel in de pan.",
                [5] = "Bak de eieren ca. 1 minuut totdat ze net beginnen te stollen.",
                [6] = "Schuif het ei met een hittebestendige siliconen spatel door de pan.",
                [7] = "Laat het ei rustig stollen.",
                [8] = "Schuif de spatel langs de randjes van de omelet en vouw hem van beide kanten naar het midden toe."
            };
        }
    }
}
