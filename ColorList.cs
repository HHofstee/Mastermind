using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mastermind
{
    class ColorList: List<Color>
    {
        public override String ToString()
        {
            String s = "";

            foreach (var color in this)
                s += color.ToString() + ", ";

            return s;
        }
    }
}
