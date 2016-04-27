using System.Drawing;

namespace Mastermind
{
    static class RandomColorList
    {
        public static Color[] GetList(Color[] all_colors)
        {
            Color[] a = new Color[4];

            for (var i = 0; i < a.Length; ++i)
                a[i] = ArrayShuffler<Color>.Shuffle(all_colors)[0];

            return a;
        }
    }
}
