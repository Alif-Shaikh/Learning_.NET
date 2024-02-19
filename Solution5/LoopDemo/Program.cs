using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDemo
{
    internal class Program
    {
        public static void Loop(int n)
        {
            int i = 0;
            while(i<=n)
            { 
            Console.WriteLine("Happy Birthday");
                i++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            Program p=new Program();
            Loop(n);
        }
    }
}
