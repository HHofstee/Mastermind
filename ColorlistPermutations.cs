using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mastermind
{
    class ColorlistPermutations
    {
        public ColorlistPermutations(Color[] all)
        {
            all_colors = all;
            for (var i = 0; i < all_color_lists.Length; ++i)
                all_color_lists[i] = ArrayShuffler<Color>.Shuffle((Color[]) all_colors.Clone());
        }

        public IEnumerable<Color[]> GetColorlists()
        {
            foreach(var e in GetColorlists(all_color_lists))
                yield return e;
        }

        private static IEnumerable<Color[]> GetColorlists(Color[][] l)
        {
            if (l.Length != 0)
                foreach (var color in l[0])
                    if (l.Length != 1)
                    {
                        foreach (var perm in GetColorlists(l.Skip(1).ToArray())) // recursion with list minus the head
                            yield return (Color[])(new Color[] { color }).Concat(perm).ToArray();
                    }
                    else
                        yield return new Color[] { color };
        }

        private readonly Color[] all_colors;
        private Color[][] all_color_lists = new Color[4][];
    }
}
