using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorisontalLine
    {
        List<Point> pList;

        public HorisontalLine(int xLeft, int xRigth, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRigth; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Drow();
            }
            
        }
    }
}
