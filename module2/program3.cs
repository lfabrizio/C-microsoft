//while loop 
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

            int whileCounter = 0;
            int doCounter = 0;
            Console.WriteLine();
            Console.WriteLine("while loop");
            Console.WriteLine();

            while (whileCounter < 5)
            {
                Console.WriteLine("whileCounter is at : ", whileCounter);
                    whileCounter++;
            }
        }
    }
}