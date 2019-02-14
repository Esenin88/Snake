using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class FoodCreator
    {
        int MapHeigth;
        int MapWidth;
        char sym;

        Random random = new Random();
        public FoodCreator(int MapWidth, int MapHeigth, char sym)
        {
            this.MapHeigth = MapHeigth;
            this.MapWidth = MapWidth;
            this.sym = sym;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, MapWidth - 2);
            int y = random.Next(2, MapHeigth - 2);
            return new Point(x, y, sym);
        }
            

    }
}
