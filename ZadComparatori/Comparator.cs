using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadComparatori
{
    internal class Comparator : IComparer<Olimpiada>
    {
        public int Compare(Olimpiada x, Olimpiada y)
        {
            return x.NameOlimpiada.CompareTo(y.NameOlimpiada);
        }
    }
}
