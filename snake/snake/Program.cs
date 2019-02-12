using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorisontalLine upline = new HorisontalLine(0, 78, 0,'+');  
            VerticalLine rigthline = new VerticalLine(0, 0, 24, '+'); 
            HorisontalLine downline = new HorisontalLine(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(78, 0, 24, '+');
            upline.Draw();
            rigthline.Draw();
            downline.Draw();
            leftline.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 3, Direction.RIGTH);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }

    }
}
