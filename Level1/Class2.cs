using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Level1
{
    //Write a program to perform addition, subtraction, multiplication, and division.

    public class Class2
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("Enter num 1:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num 2:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose your choice(1-4):");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            int data = Convert.ToInt32(Console.ReadLine());

            switch (data)
            {
                case 1 :
                    Console.WriteLine(a+b);
                    break;

                    case 2 :
                    Console.WriteLine(a-b);
                    break; 

                    case 3 :
                    Console.WriteLine(a*b);
                    break;

                    case 4 :
                    if (b == 0)
                    {
                        Console.WriteLine("Invalid number");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                       
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;




            }

        }
     
    }
}
