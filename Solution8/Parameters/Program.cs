
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        public static void Fref(int n ,ref int f)
        {
            for(int i = 1; i <=n;i++)
            {
                f = f * i;
            }

        }
       static void Main(string[] args)
        {
            int n, f = 1;
            Console.WriteLine("enter num");
            n=Convert.ToInt32(Console.ReadLine());
            Fref(n, ref f);
            Console.WriteLine("fact " + f);
        }
    }
}
