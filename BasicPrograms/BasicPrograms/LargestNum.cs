using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class LargestNum
    {
        public static void max()
        {
            Console.WriteLine("enter 1st number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 3rd number");
            int z = Convert.ToInt32(Console.ReadLine());

            //logic
            int result = (Math.Max(Math.Max(x, y), z));
            Console.WriteLine(result + " is a largest number");
        }
    }
}
