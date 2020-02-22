using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod2_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a nested for loop
            // This sample uses a nested loop to find prime numbers
            // less than 100

            int outer;
            int inner;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                    if ((outer % inner) == 0) break; // if factor found, not prime
                if (inner > (outer / inner))
                    Console.WriteLine("{0} is prime", outer);
            }
        }
        }
    }
