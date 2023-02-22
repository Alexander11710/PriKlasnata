using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ZadComparatori
{
    internal class Olimpiada:IPrint,IComparable<Olimpiada>
    {
        private string nameOlimpiada;
        private int brTochki;

        public string NameOlimpiada
        {
            get { return nameOlimpiada; }
            set
            {
                nameOlimpiada = value;
            }
        }
        public int BrTochki
        {
            get { return brTochki; }
            set { brTochki = value; }
        }
        public Olimpiada(string nameOlimpiada, int brTochki)
        {
            NameOlimpiada = nameOlimpiada;
            BrTochki = brTochki;
        }

        public void Print()
        {
            Console.WriteLine($"{this.nameOlimpiada}-->{brTochki}");
        }

        public int CompareTo(Olimpiada other)
        {
            return brTochki.CompareTo(other.brTochki);
        }
    }
}
