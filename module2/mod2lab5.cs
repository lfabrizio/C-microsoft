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
            // Create a while loop
            // We start with n = 1
            // The condition check for the while, tests if n is less than 6, if so, the loop body code executes
            // inside the loop, we output the value of n and then increment it by 1
            // Once n = 6, the loop stops
            // Pay attention to the output to see what the last value is to ensure you understand
            // how the evaluation of the condition is done and how the while loop executes
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }
        }
        }
        }