using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.level2
{
    //Write a program to check whether a year is a leap year.

    internal class Class1
    {
        public static void Main(String[] args)
        {
            //A leap year is a year that has 366 days instead of 365 days.
            Console.WriteLine("Enter your year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 400 == 0 || year%4 == 0 && year%100 != 0  )
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}
