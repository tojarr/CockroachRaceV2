using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CockroachRaceV2
{
    class Program
    {
        private const int numberOfCocroach = 3; 
        static void Main(string[] args)
        {
            for (int i = 0; i < numberOfCocroach; i++)
            {
                Cockroach cockroach = new Cockroach(i + 1);
                Cockroaches.AllCockroaches.Add(cockroach);
            }
            



            Console.ReadKey();
        }
    }
}
