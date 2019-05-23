using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flattened_Iterator
{
    public class FlattenedIterator
    {

        public static List<int> Flatten(List<Iterator> iterators)
        {
            List<int> flattenedIterator = new List<int>();


            while (true)
            {
                bool hasNext = false;
                foreach (Iterator iterator in iterators)
                {
                    if (iterator.HasNext() == true)
                    {
                        hasNext = hasNext || true;
                        flattenedIterator.Add(iterator.Next());
                    }
                    else
                    {
                        hasNext = hasNext || false;
                    }
                }

                if(hasNext == false)
                {
                    break;
                }
            }
            

            return flattenedIterator;
        }

    }
}
