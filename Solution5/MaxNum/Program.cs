using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNum
{
    internal class Program
    {
        public void Max(int a, int b, int c)
        {
            int m = a;
            if(m<b)
            {
                m = b;
            }
            if (m < c)
            {
                m = c;
            }
                Console.WriteLine("{0} is max of all",m);
               
            

        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 3 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Program p = new Program();
            p.Max(a, b, c);
        }
    }
}
