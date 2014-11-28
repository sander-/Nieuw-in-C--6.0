using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var recept = new Recept()
                { Kookduur = 600, Naam = "Runderstoofschotel", Niveau = 300 };
                Console.WriteLine("Start recept " + recept.Naam);
                recept.Uitvoeren();

                var anderRecept = new Recept()
                { Kookduur = 60, Naam = "Gebardeerde Patrijs met jeneverbessensaus", Niveau = 500 };
                Console.WriteLine("Start recept " + anderRecept.Naam);
                anderRecept.Uitvoeren();
            }

            catch (Exception e) if (CheckDuur(e))
            {
                Console.WriteLine("Dit duurt te lang.");
            }
            catch (Exception e) if (CheckNiveau(e))
            {
                Console.WriteLine("Dit is te moeilijk.");
            }

            //catch (Exception e) if (Log(e) || CheckDuur(e))
            //{
            //    Console.WriteLine("Dit duurt te lang.");
            //}
            //catch (Exception e) if (Log(e) || CheckNiveau(e))
            //{
            //    Console.WriteLine("Dit is te moeilijk.");
            //}
        }

        static bool CheckDuur(Exception e)
        {
            return e.Message.Contains("tijd");
        }
        static bool CheckNiveau(Exception e)
        {
            return e.Message.Contains("niveau");
        }
        //static bool Log(Exception e)
        //{
        //    Console.WriteLine("Fout gevonden: " + e.Message);
        //    return false;
        //}
    }

    class Recept
    {
        public int Kookduur { get; set; }
        public string Naam { get; set; }
        public int Niveau { get; set; }

        public void Uitvoeren()
        {
            if (DateTime.Now.AddMinutes(this.Kookduur) > DateTime.Now.Date.AddDays(1))
            {
                throw new Exception("tijd");
            }
            if (this.Niveau > 400)
            {
                throw new Exception("niveau");
            }
        }
    }
}
