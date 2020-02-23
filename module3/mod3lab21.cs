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
            // PrintSomething();

            // create some variables for use in a method call
            int first = 10;
            int second = 2;
            string svalue;

            // the method call will expect a single value returned 
            // return value must be assigned 
            // also pass in two args
            int result = Sum(first, second);
            Console.WriteLine("The sum of {0} and {1} is : {2}", first, second, result);

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