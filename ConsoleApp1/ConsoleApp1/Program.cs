using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Snake!");
            int x1 = 1;
            int y1 = 3;
            char symbol1 = '*';

            Console.SetCursorPosition(x1, y1);
            Console.Write(symbol1);

            int x2 = 4;
            int y2 = 5;
            char symbol2 = '#';

            Console.SetCursorPosition(x2, y2);
            Console.Write(symbol2);


            Console.ReadKey();

        }
    }
}
