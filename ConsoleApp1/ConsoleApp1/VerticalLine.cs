using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yStart, int yLow, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yStart; y <= yLow; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
