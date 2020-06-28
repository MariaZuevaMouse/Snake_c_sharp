using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VerticalLine : Figure
    {       
        public VerticalLine(int yStart, int yLow, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yStart; y <= yLow; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
       
    }
}
