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
        class Test
        {
            public IEnumerable<int[]> GetInts()
            {
                for (var i = 0; i < 10; ++i)
                    for (var j = 0; j < 10; ++j)
                        yield return new int[] {i, j};
            }
        }

        static void Main(string[] args)
        {

            //          int[] array = { 1, 2, 3, 4 };
            //          new Random().Shuffle(array);
            //          foreach(var i in array)
            //              Console.WriteLine(i.ToString());

            //           var colors = new List<Color> { Color.Blue, Color.White, Color.Black, Color.Red };
            //           new Random().Shuffle(colors);

            //            foreach(var i in colors)
            //               Console.WriteLine(i.ToString());

            Test x = new Test();
            var e = x.GetInts();

            foreach (var i in e)
                Console.WriteLine($"i: {i[0]}, j: {i[1]}");

            Color[] all_colors = { Color.Yellow, Color.Orange, Color.Blue, Color.Green, Color.Red, Color.Purple };

//           new Random().Shuffle<Color>(all_colors);
//           var colors = new ColorList(all_colors);

//           new Random().Shuffle(all_colors);
//           var colors1 = new ColorList(all_colors);

//            Console.WriteLine(colors.ToString());
//            Console.WriteLine(colors1.ToString());

//            Console.WriteLine("Hello world!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
