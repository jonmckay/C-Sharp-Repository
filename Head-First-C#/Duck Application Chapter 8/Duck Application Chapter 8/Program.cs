using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_Application_Chapter_8
{
    class Program
    {
        

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
            Console.WriteLine("End of ducks!");
        }

        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
            new Duck() { Kind = Duck.KindOfDuck.Mallard, Size = 17},
            new Duck() { Kind = Duck.KindOfDuck.Muscovy, Size = 18},
            new Duck() { Kind = Duck.KindOfDuck.Decoy, Size = 14},
            new Duck() { Kind = Duck.KindOfDuck.Muscovy, Size = 11},
            new Duck() { Kind = Duck.KindOfDuck.Mallard, Size = 14},
            new Duck() { Kind = Duck.KindOfDuck.Decoy, Size = 13},
        };
            PrintDucks(ducks);

            //DuckComparerBySize sizeComparer = new DuckComparerBySize();
            //ducks.Sort(sizeComparer);
            //PrintDucks(ducks);

            //DuckComparerByKind kindComparer = new DuckComparerByKind();
            //ducks.Sort(kindComparer);
            //PrintDucks(ducks);

            DuckComparer comparer = new DuckComparer();

            comparer.SortBy = DuckComparer.SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            comparer.SortBy = DuckComparer.SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Duck[] duckArray = new Duck[6];
            duckArray.GetEnumerator();

            Console.ReadKey();
        }
    }
}
