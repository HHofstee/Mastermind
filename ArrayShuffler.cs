using System;

namespace Mastermind
{
    static class ArrayShuffler<T>
    {
        public static T[] Shuffle(T[] a)
        {
            random.Shuffle<T>(a);
            return a;
        }

        static readonly System.Random  random = new Random();
    }
}
