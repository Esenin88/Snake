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
            Point p1 = new Point(1, 3, '*');

            p1.Drow();

            Point p2 = new Point(4, 5, '#');

            p2.Drow();

            Point p3 = new Point(5, 7, '&');

            p3.Drow();

            Point p4 = new Point(10, 23, '^');

            p4.Drow();

            List<Point> points = new List<Point>();
            points.Add(p1);
            points.Add(p2);

            foreach (Point p in points)
            {
                Console.WriteLine(p);
            }
            //// лист с целыми числами
            //List<int> numList = new List<int>();
            //numList.Add(2);
            //numList.Add(4);
            //numList.Add(12);

            //foreach (int a in numList)
            //{
            //    Console.WriteLine(a);
            //}

            //// лист с символами
            //List<char> charlist = new List<char>();
            //charlist.Add('$');
            //charlist.Add('&');

            //foreach (char i in charlist)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }

    }
}
