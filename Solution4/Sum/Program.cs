using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
   
    internal class Program
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum of {0} and {1} is {2}", a, b, c);
        }
        static void Main(string[] args)
        {

            int a, b;
             Console.WriteLine("Enter Two Numbers");
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());

             Program s = new Program();
             s.Add(a, b);   


            //Area of circle
          /* double rad, area;
            Console.WriteLine("Enter radius");
            rad = Convert.ToDouble(Console.ReadLine());
         
            area=Math.PI * Math.Pow(rad,2);
            Console.WriteLine("Area of circle {0} ",area); */ 
        }
    
    }
}
