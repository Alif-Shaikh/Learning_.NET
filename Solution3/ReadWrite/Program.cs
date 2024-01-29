using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter Your Name...");
            
            name= Console.ReadLine();

            //  Console.WriteLine("My name is " + name);
            Console.WriteLine("My name is {0} ",name);
        }
    }
}
