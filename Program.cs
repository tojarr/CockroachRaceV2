using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CockroachRaceV2
{
    class Program
    {
        private static int snapshot = 1000, tourTime = 6000, numberOfCockroach = 3;
        static void Main(string[] args)
        {
            InitOfCockroaches init = new InitOfCockroaches(numberOfCockroach);
            Cockroach cockroach = new Cockroach();

            Console.WriteLine("Round run");
            cockroach.TimerPrintResult(snapshot, tourTime);


            Console.ReadKey();
        }
    }
}
