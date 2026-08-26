using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Level1
{
    //Write a program to convert Celsius to Fahrenheit.

    internal class Class5
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter temparature in Celsius:");
            float celsius = float.Parse(Console.ReadLine());
            Console.WriteLine($"Farenheit : {celsius * 9 / 5 + 32}");

            //int.Parse() converts the string into an integer.
            //int.Parse("100");          // String → int
            //double.Parse("10.5");      // String → double
            //DateTime.Parse("19-08-2026"); // String → DateTime
            //decimal.Parse("99.50");    // String → decimal
            //Console.WriteLine($"fahrenheit:{(celsius*9/5)+32}");


            //Write a program to convert Celsius to Fahrenheit. 

            Console.WriteLine("Enter temparature into Fahrenheit:");
            float fahrenheit = float.Parse(Console.ReadLine());

            // Console.WriteLine($"Celsius:{(fahrenheit-32)*5/9}");
            Console.WriteLine($"Celsius:{(fahrenheit - 32) + 5 / 9}");
        }
    }
}
