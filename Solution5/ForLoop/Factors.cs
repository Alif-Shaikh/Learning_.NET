using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Factors
    {
        static void Main(string[] args)
        {
            int n = 20;
            Console.WriteLine("factors of 20 are ...");
            for (int i = 1; i <= n; i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
