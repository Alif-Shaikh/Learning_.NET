using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class PrintArray
    {
        public static void PrintingArray(int n, int[] a)
        {
           /* for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);

            }*/
           foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args) {
                int[] arr = new int[] { 23, 45, 6, 7 };
                PrintArray p=new PrintArray();
                PrintingArray(arr.Length, arr);
            }
         


    }
}
