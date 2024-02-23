using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            str.Insert(5, "World");
            Console.WriteLine(str); //will print Hello only as strings are immutable
        }
    }
}
