using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CockroachRaceV2
{
    class InitOfCockroaches
    {
        private readonly int _numberOfCocroach;

        public InitOfCockroaches(int numberOfCockroach)
        {
            _numberOfCocroach = numberOfCockroach;
            InitCockroaches();
        }

        void InitCockroaches()
        {
            ArrTasks.tasks = new Task[_numberOfCocroach];
            for (int i = 0; i < _numberOfCocroach; i++)
            {
                Cockroach cockroach = new Cockroach(i + 1);
                Cockroaches.AllCockroaches.Add(cockroach);
                Task task = Task.Factory.StartNew(() => cockroach.MyTimer(cockroach));
                ArrTasks.tasks[i] = task;
            }
        }
    }

    static class ArrTasks
    {
        public static Task[] tasks;
    }
}

