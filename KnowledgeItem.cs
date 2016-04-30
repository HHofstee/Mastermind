using System;
using System.Drawing;

namespace Mastermind
{
    class KnowledgeItem
    {
        public KnowledgeItem(Color[] _colors, Color[] _judgement)
        {
            colors = _colors;
            judgement = _judgement;
        }

        public bool Verify(Color[] truth)
        {
            return Judge.Equal(Judge.Judgement(colors, truth), judgement);
        }

        public void Print()
        {
            foreach (var i in colors)
                Console.Write($"{i.Name} ");
            foreach (var i in judgement)
                Console.Write($"{i.Name} ");

            Console.WriteLine("");
        }

        public Color[] colors {get; set;}
        public Color[] judgement { get; set; }
    }
}
