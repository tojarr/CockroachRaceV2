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

        public InitOfCockroaches(int n)
        {
            _numberOfCocroach = n;
        }

        public void InitCockroaches()
        {
            for (int i = 0; i < _numberOfCocroach; i++)
            {
                Cockroach cockroach = new Cockroach(i + 1);
                Cockroaches.AllCockroaches.Add(cockroach);
            }
        }
    }
}
