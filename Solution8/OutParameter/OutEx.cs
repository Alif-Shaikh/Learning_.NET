using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class OutEx
    {
        public void Show(int empno, out String name,out double basic)
        {
            if(empno==1)
            {
                name = "Lokesh";
                basic = 88345;
            } else if (empno==3)
            {
                name = "Shivam";
                basic = 848484;
            }
            else
            {
                name = "not found";
                basic = 0;
            }
        }
        static void Main(string[] args)
        {
            int empno;
            string name;
            double basic;
            Console.WriteLine("Emp no");
            empno = Convert.ToInt32(Console.ReadLine());
            OutEx employ = new OutEx();
            employ.Show(empno, out name, out basic);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Basic is " + basic);
        }
    }
}
