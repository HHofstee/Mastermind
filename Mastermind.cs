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
            Color[] all_colors = { Color.Yellow, Color.Orange , Color.Blue, Color.Green, Color.Red, Color.Purple };

            var x = new ColorlistPermutations(all_colors);
            var e = x.GetColorlists();

            foreach (var i in x.GetColorlists())
               Console.WriteLine($"i: {i[0]}, j: {i[1]}, k: {i[2]}, l: {i[3]}");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
