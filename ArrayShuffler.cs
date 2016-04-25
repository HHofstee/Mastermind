using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class ArrayShuffler<T>
    {
        public static T[] Shuffle(T[] a)
        {
            new Random().Shuffle<T>(a);
            return a;
        }
    }
}
