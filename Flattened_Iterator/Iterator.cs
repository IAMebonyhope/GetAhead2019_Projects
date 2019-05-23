using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flattened_Iterator
{
    public class Iterator
    {
        private List<int> iteratee;
        private int counter;
        public Iterator(List<int> iteratee)
        {
            this.iteratee = iteratee;
            counter = -1;
        }

        public List<int> Iteratee { get { return iteratee; } }

        public int Next()
        {
            counter++;
            return iteratee[counter];
            
        }

        public bool HasNext()
        {
            if ((iteratee != null) && (counter < iteratee.Count-1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
