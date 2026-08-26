using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.level2
{
    //Write a program to check whether a person is eligible to vote.

    internal class Class2
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("your eligible for vote");
            }
            else
            {
                Console.WriteLine("your not eligible for vote");
            }
        }
         
        
    }
}
