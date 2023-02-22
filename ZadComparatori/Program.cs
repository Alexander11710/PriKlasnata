using System.Threading.Channels;

namespace ZadComparatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Olimpiada olimp1 = new Olimpiada("IT", 98);
            Olimpiada olimp2 = new Olimpiada("Math", 100);
            List<Olimpiada> olimpiadas = new List<Olimpiada>
            {
                olimp1,
                olimp2
            };
            olimpiadas.Sort();
            var comparator = new Comparator();
            olimpiadas.Sort(comparator);
            Console.WriteLine(string.Join(", ", olimpiadas.Select(x=>x.BrTochki)));
            Console.WriteLine(string.Join(", ", olimpiadas.Select(x => x.NameOlimpiada)));
        }
    }
}