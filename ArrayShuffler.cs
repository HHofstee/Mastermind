using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class ArrayShuffler<T>
    {
        public T[] Shuffle(T[] a)
        {
            random.Shuffle<T>(a);
            return a;
        }

        System.Random random = new Random();
    }
}
