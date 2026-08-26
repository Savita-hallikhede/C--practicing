using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_practicing.Level1
{
    internal class Class7
    {
        //Write a program to find the largest of two numbers.

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter num 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("num1 is a largest number");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("num2 is a largest number");
            }
            else
            {
                Console.WriteLine("num1 and num2 are equal number");
            }

            //Write a program to find the largest of three numbers.

            Console.WriteLine("Enter n1");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n2");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n3");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if(n1> n2 && n1>n3)
            {
                Console.WriteLine("n1 is the largest number");
            }else if(n2>n1 && n2 > n3)
            {
                Console.WriteLine("n2 is the largest number");
            }
            else
            {
                Console.WriteLine("n3 is the largest number");
            }
            
        }

        



    }
}
