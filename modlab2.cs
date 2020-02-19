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
            // create your own of of example
            // create variables of different data types
            // initialize with a "default" value
            string firstName = "";
            string lastName = "";
            int years = 0;
            string work = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            // Assign some values
            firstName = "Lou";
            lastName = "F";
            years = 5;
            work = "Zoning";
            city = "Johnston";
            country = "MyCountry";
            birthDate = new DateTime(2015, 6, 1);

            // output to the console window

            // use simple output with just variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            // use placeholder style
            Console.WriteLine("{0} years worked at current job.", years);

            // use string concatenation
            Console.WriteLine(years + "doing " + work + "in " + city);

            // use string interpolation
            // NOTE: This line of code only works with Visual Studio 2015 or C# 6.0 and later.
            // If you are using an earlier version, then comment out this line of code.
            Console.WriteLine($"started on {birthDate}");
        }
    }
}