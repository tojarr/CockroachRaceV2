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
        int distance = 0;
        int Snapshot { get; set; }
        int count = 0;
        int Distance
        {
            get
            {
                return distance;
            }
        }

        public Cockroach()
        {

        }

        public Cockroach(int n)
        {
            Name = "Bag" + n;
        }

        void BugRun(object obj)
        {
            Speed = Rand();
            distance += Speed;
        }

        public void MyTimer(Cockroach cockroach)
        {
            TimerCallback tcb = new TimerCallback(cockroach.BugRun);
            var timer = new Timer(tcb, 1000, 0, 1000);

        }

        int Rand()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(1, 5);
        }

        List<Cockroach> SortResult()
        {
            var list = Cockroaches.AllCockroaches.OrderBy(x => x.Distance);
            return list.ToList();
        }

        void PrintResult(object obj)
        {
            ForPrintResult forPrint = (ForPrintResult)obj;
            if (count == (forPrint.TimeOut / 1000))
            {
                Console.WriteLine("Round stop");
                count++;
            }
            else if (count < (forPrint.TimeOut / 1000))
            {
                SortResult().ForEach(x => Console.WriteLine($"Name: {x.Name} - distance(sm/sec): {x.Distance}"));
                Console.WriteLine(new string('-', 35));
                count += forPrint.Snapshot / 1000;
            }
            else
            {
                return;
            }

        }

        public void TimerPrintResult(int snapshot, int timeOut)
        {
            TimerCallback tcb = new TimerCallback(PrintResult);
            Timer timer = new Timer(tcb, new ForPrintResult { TimeOut = timeOut, Snapshot = snapshot }, snapshot, snapshot);
        }
    }

    public static class Cockroaches
    {
        public static List<Cockroach> AllCockroaches = new List<Cockroach>();
    }

    public class ForPrintResult
    {
        public int TimeOut { get; set; }
        public int Snapshot { get; set; }
        public Timer IsTimer { get; set; }
    }
}
