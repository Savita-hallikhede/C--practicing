using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Level1
{

//    Write a C# program to print Hello World.
//Write a program to add two numbers.

   public class Class1
   {
        //Console.WriteLine() must be inside a method, usually Main().
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter num 1:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num 2:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a+b);

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

        }
       
   }
}
