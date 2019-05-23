using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flattened_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Iterator o = new Iterator(new List<int> { 0, 5 });
            Iterator a = new Iterator(new List<int> { 1, 2, 6, 3, 5, 7 });
            Iterator b = new Iterator(new List<int> { });
            Iterator c = new Iterator(new List<int> { 6, 7, 8 });

            List<Iterator> Iterators = new List<Iterator>();
            Iterators.Add(o);
            Iterators.Add(a);
            Iterators.Add(b);
            Iterators.Add(c);

            List<int> flattened = FlattenedIterator.Flatten(Iterators);

            printList(o.Iteratee);
            printList(a.Iteratee);
            printList(b.Iteratee);
            printList(c.Iteratee);

            printList(flattened);

            Console.ReadLine();
        }

        static void printList(List<int> list)
        {
            Console.Write("[");

            foreach (int x in list)
            {
                Console.Write(x + ", ");
            }

            Console.Write("]");

            Console.WriteLine();
        }
    }
}
