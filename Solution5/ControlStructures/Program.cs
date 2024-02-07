using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructures
{
    internal class Program
    {
        public void IfElse(int n)
        {
            if(n>0)
            {
                Console.WriteLine(  "positive");
            }
            else
            {
                Console.WriteLine(  "negative");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n=Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.IfElse(n);
        }
    }
}
