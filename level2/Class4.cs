using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.level2
{
    //Write a program to print numbers from 1 to 100.

    internal class Class4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Printing 1 to 100 numbers:");

            for(int i = 0; i<=100; i++)
            {
               Console.WriteLine($"{i}");
            }
        //Write a program to print all even numbers from 1 to 100.

            for(int j=0; j<=100; j++)
            {
               if(j%2 ==0)
               {
                    Console.WriteLine($"{j}");
               }
               else
               {
                    Console.WriteLine("");
               }
            }
            //Write a program to print all odd numbers from 1 to 100.

            for(int j=1; j<=100;j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine($"{j}");
                }
                else
                {
                    Console.WriteLine("");
                }
            }
           // Write a program to print the multiplication table of a given number.
           for (int k=0; k<=10; k++)
           {
                Console.WriteLine($"{2 * k}");
           }

            //Write a program to find the sum of numbers from 1 to N.
            Console.WriteLine("Enter n:");
            int data = Convert.ToInt32( Console.ReadLine() );
            int sum = 0;
            for (int l=1; l<=data; l++)
            {
                
                sum = sum + l;
              

            }
            Console.WriteLine($"{sum}");

            //Write a program to find the factorial of a number.
            Console.WriteLine("enter your number");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int m=1; m<=n; m++)
            {
                fact = fact* m;
            }
            //Factorial means multiplying a number by all the positive numbers smaller than it, down to 1.
            Console.WriteLine($"{fact}");


            //Write a program to count the digits of a number.
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while(num != 0)
            {
                num = num / 10;
                count++;
            }

            Console.WriteLine("Number of digits:" +count);
        }
    }
}
