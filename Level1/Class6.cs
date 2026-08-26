using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Level1
{
    //Write a program to check whether a number is even or odd.
    internal class Class6
    {
       public static void Main(String[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

           // Write a program to check whether a number is positive, negative, or zero.
           if(num > 0)
            {
                Console.WriteLine("Positive number");
            }else if(num < 0)
            {
                Console.WriteLine("Negative number");

            }
            else
            {
                Console.WriteLine("Zero");
            }
            
        }
    }
}
