using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class toss
    {
           public static void Flip()
           {
            Console.WriteLine("Enter number for how many time flip coin");
                 int flipcount = Convert.ToInt32(Console.ReadLine());
                 double Heads = 0;
                 double Tails = 0;
                 for (int i = 1; i <= flipcount; i++)
                 {
                      Random random = new Random();
                      int flip = random.Next(0, 2);
                      if (flip < 0.5)
                      {
                            Console.WriteLine("Tails");
                            Tails += 1;
                      }
                      else
                      {
                            Console.WriteLine("Heads");
                            Heads += 1;
                      }
                      Console.WriteLine(+(Heads / flipcount) * 100 + "%");
                      Console.WriteLine(+(Tails / flipcount) * 100 + "%");
                 }
           }

    }
}
