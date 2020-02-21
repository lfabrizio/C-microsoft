// recursion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("recursion");
            Console.WriteLine();

            static long Factorial(int n)
            {
                if (n == 0)
                {
                    return 1;
                }
                return n * Factorial(n - 1);
            }


        }
    }
}