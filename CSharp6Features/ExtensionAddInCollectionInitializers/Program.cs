using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionAddInCollectionInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gebruik de extensie methode in de initialisatie van de collectie. 
            // Dit kon niet in =< C# 5.0
            var stappen = new List<string> {
                { 1, "Zeef de bloem boven een beslagkom." },
                { 2, "Voeg bakpoeder, kruiden en zout toe." } ,
                { 3, " Doe de boter er in klontjes bij." } };
        }
    }

    public static class ListExtensions
    {        
        public static void Add(this List<string> list, int number, string stap)
        {
            list.Add("\{number} - \{stap}");
        }
    }
}
