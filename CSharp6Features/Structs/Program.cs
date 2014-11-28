using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{

    // 1. Parameterless constructors in structs    
    struct Duur
    {
        public int Minuten;
        public int Uur;
        public Duur(int uur, int minuten)
        {
            Uur = uur;
            Minuten = minuten;
        }

        // Dit kon niet in =< C# 5.0
        public Duur() : this(1, 30) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
