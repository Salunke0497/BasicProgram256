using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class swap
    {
        public static void SwapNumber()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("befor swap a = " + a + "b = " + b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("after swap a = " + a + "b = " + b);
        }
    }
}
