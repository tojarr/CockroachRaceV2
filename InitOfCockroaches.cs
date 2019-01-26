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

        public List<Cockroach> GetCockroaches()
        {
            List<Cockroach> list = new List<Cockroach>();
            for (int i = 0; i < _numberOfCocroach; i++)
            {
                Cockroach cockroach = new Cockroach(i + 1);
                list.Add(cockroach);
            }
            return list;
        }
    }
}
