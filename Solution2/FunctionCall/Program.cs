using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCall
{
    class Demo
    {
        public void Alif()
        {
            Console.WriteLine("hiii...Im Alif");
        }
        internal void Amol()
        {
            Console.WriteLine("hiii...Im Amol");
        }
        private void Aniket()
        {
            Console.WriteLine("hiii...Im Aniket");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo obj=new Demo();
            obj.Alif();
            obj.Amol();


        }
    }
}
