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
        }

        public IEnumerable<Color[]> GetColorlists()
        {
            foreach (var i in ArrayShuffler<Color>.Shuffle(all_colors))
                foreach (var j in ArrayShuffler<Color>.Shuffle(all_colors))
                    foreach (var k in ArrayShuffler<Color>.Shuffle(all_colors))
                        foreach (var l in ArrayShuffler<Color>.Shuffle(all_colors))
                            yield return new Color[] { i, j, k, l };
        }

        private Color[] all_colors;
    }
}
