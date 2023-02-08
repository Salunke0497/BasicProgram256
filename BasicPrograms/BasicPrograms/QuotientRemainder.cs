using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class QuotientRemainder
    {
        public static void value()
        {
            int dividend = 210;
            int divisior = 20;

            int quotient = dividend / divisior;
            int remainder = dividend % divisior;

            Console.WriteLine("Dividend : {0} Divisior : {1}", dividend, divisior);
            Console.WriteLine("Quotient = {0}", quotient);
            Console.WriteLine("remainder = " + remainder);
        }
    }
}
