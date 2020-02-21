// do while
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
            int doCounter = 5;

            Console.WriteLine();
            Console.WriteLine("do-while loop");
            Console.WriteLine();

            do
            {
                Console.WriteLine("doCounter is at : " + doCounter);
                doCounter++;
            } while (doCounter < 5);
        }
    }
}