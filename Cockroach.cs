using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CockroachRaceV2
{
    public class Cockroach
    {
        public string Name { get; set; }
        int Speed { get; set; }
        public int Distance  { get; }
        int count = 0;
        //public int time;
        Random rnd = new Random(DateTime.Now.Millisecond);

        public Cockroach(int n)
        {
            Name = "Bug" + n;
            Distance = 0;
            Speed = (rnd.Next(1, 5));
        }

        public void BugRun()
        {
        }
    }

    public class Cockroaches
    {
        public static List<Cockroach> AllCockroaches = new List<Cockroach>();
    }
}
