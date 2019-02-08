using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorisontalLine line = new HorisontalLine(0, 20, 0,'*');
            line.Draw();

            VerticalLine lines = new VerticalLine(0, 0, 20, '*');
            lines.Druw();

            HorisontalLine linez = new HorisontalLine(0, 20, 20, '*');
            linez.Draw();
            Console.ReadLine();
        }

    }
}
