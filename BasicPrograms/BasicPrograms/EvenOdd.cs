using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class EvenOdd
    {
        public static void evenodd()
        {
            Console.WriteLine("ENTER NUMBER HERE");
            int X = Convert.ToInt32(Console.ReadLine());
            if (X % 2 == 0)
            {
                Console.WriteLine(X + " IS A EVEN NUMBER ");
            }
            else
            {
                Console.WriteLine(X + " IS ODD NUMBER ");
            }
        }
    }
}
