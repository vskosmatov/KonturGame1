using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonturGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGame g = new SimpleGame(1, 2, 3, 3, 5, 6, 7, 8, 0);
            g.Shift(8);
            g.Shift(5);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(g[i, j] + " ");
                Console.WriteLine();
            }
            
            Console.Read();
        }
    }
}
