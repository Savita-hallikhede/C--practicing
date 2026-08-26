using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.level2
{
    //Write a simple calculator using switch.

    internal class Class3
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your choice (1-4)");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine($"Addition:{a+b}");
                    break;
                case 2: Console.WriteLine($"Substraction:{a-b}");
                    break;
                case 3: Console.WriteLine($"Multiplication:{a*b}");
                    break;
                case 4:
                    if(b==0)
                    {
                        Console.WriteLine("Invalid number");
                    }
                    else
                    {
                        Console.WriteLine($"Multiplication:{a / b}");
                    }
                   break;
                default: Console.WriteLine("Try again");
                    break;

            }
                

            
        }
    }
}
