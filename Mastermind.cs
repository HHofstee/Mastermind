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
            Color[] random_color_list = RandomColorList.GetList(all_colors);

            Console.WriteLine($"Randomlist: {random_color_list[0]}, {random_color_list[1]}, {random_color_list[2]}, {random_color_list[3]}");

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
