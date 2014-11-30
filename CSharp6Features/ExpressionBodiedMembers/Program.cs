﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodiedMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Recept r1 = new Recept() { Stappen = new List<string> { "stap 1", "stap 2" } };
            Recept r2 = new Recept() { Stappen = new List<string> { "stap 3", "stap 4" } };
            Recept r3 = r1 + r2;
            r3.PrintStappen();
        }
    }

    public class Recept
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public IEnumerable<string> Stappen { get; set; }

        private IQueryable<Recept> repository;

        // 1. Expression bodies voor methoden
        public static Recept NieuwRecept(string naam) => new Recept() { Naam = naam };

        // 2. Expression bodies voor operators
        public static Recept operator +(Recept r1, Recept r2) => new Recept() { Stappen = r1.Stappen.Union(r2.Stappen) };

        // 3. Expression bodies voor void
        public void PrintStappen() => Stappen.ToList().ForEach(p => Console.WriteLine(p));

        // 4. Expression bodies voor indexers
        public Recept this[int id] => repository.FirstOrDefault(p=>p.Id == id);

        public Recept()
        {
            repository = new List<Recept>().AsQueryable();
        }
    }
}
