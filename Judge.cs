using System.Drawing;
using System.Linq;

namespace Mastermind
{
    class Judge
    {
        public static Color[] Judgement(Color[] hypo, Color[] truth)
        {
            Color[] result = new Color[] { };
            bool[] matched = new bool[4];   // which elements in the truth have been matched already
            bool[] skip_hypo = new bool[4]; // which elements in hypo have been matched already

            // same color on the same position
            for (int i = 0; i < hypo.Length; ++i)
                if (hypo[i] == truth[i])
                {
                    skip_hypo[i] = matched[i] = true;
                    result = result.Concat(new Color[] { Color.Black }).ToArray();
                }
            // Same color in different positions
            for (int i = 0; i < hypo.Length; ++i)
                if (!skip_hypo[i])
                    for (int j = 0; j < truth.Length; ++j)
                        if (!matched[j] && hypo[i] == truth[j])
                        {
                            matched[j] = true;
                            result = result.Concat(new Color[] { Color.White }).ToArray();
                            break;
                        }

            return result;
        }

        public static bool Equal(Color[] l1, Color[] l2)
        {
            return l1.SequenceEqual(l2);
        }
    }
}
