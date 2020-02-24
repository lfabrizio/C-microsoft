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
            // int first = 10;
            // int second = 2;
            // string svalue;

            // the method call will expect a single value returned 
            // return value must be assigned 
            // also pass in two args
            // int result = Sum(first, second);
            // Console.WriteLine("The sum of {0} and {1} is : {2}", first, second, result);

            //C# methods typically only return a single value 
            // you can use out or ref  as a way of returning mult items from
            // sValue = "";
            // ReturnMultiOut(out first, out sValue);
            // Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            // using named parameters
            // Area(length: 30, width: 50);

            // using optional parameters
            OptionalParams(10, 20); 
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

        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }

        static void ReturnMultiRef(ref int i, ref string s)
        {
            i = 50;
            s = "using ref";
        }

        static void Area(int length, int width)
        {
            Console.WriteLine("The area is {0}", length * width);
        }

        static void OptionalParams(int one, int two, string s = "default text")
        {
            Console.WriteLine("{0}, {1}, {2}", one, two, s);
        }
#endregion
    }
}