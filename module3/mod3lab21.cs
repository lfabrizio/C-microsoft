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
            #region Methods
            // Demonstrating methods
            // first method returns nothing anf accepts no paramteters
            PrintSomething();

            #endregion
        }
        #region Called Methods
        static void PrintSomething()
        {
            Console.WriteLine("PrintSomething() method was called");
        }

        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
#endregion
    }
}