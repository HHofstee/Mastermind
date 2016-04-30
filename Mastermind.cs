using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mastermind
{
    class Mastermind
    {
        static void Main(string[] args)
        {
            Color[] final_judgement = { Color.Black, Color.Black, Color.Black, Color.Black };
            Color[] all_colors = { Color.Yellow, Color.Orange , Color.Blue, Color.Green, Color.Red, Color.Purple };
            Color[] truth = RandomColorList.GetList(all_colors);
            KnowledgeBase knowledge = new KnowledgeBase();

            Console.WriteLine("Truth:");
            foreach (var i in truth)
                Console.Write($"{i.Name} ");
            Console.WriteLine("");
            Console.WriteLine("");

            var x = new ColorlistPermutations(all_colors);
            var e = x.GetColorlists();

            foreach (var i in x.GetColorlists())
            {
                if (knowledge.Verify(i))
                {
                    var item = new KnowledgeItem(i, Judge.Judgement(i, truth));

                    item.Print();
                    knowledge.Add(item);
                    if (Judge.Equal(item.judgement, final_judgement))
                        break;
                }

//                Console.WriteLine($"i: {i[0]}, j: {i[1]}, k: {i[2]}, l: {i[3]}");

            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
