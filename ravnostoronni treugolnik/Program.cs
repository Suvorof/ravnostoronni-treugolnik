using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ravnostoronni_treugolnik
{
    class Program
    {
        static void Main()
        {
            int i1 = 8, i2 = 8;
            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 20; b++)
                {
                    if (b == i1 || b == i2) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                i1--;
                i2++;
            }
            for (int b = 0; b < 17; b++)
            {
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
