using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Level1
{
    //Write a program to swap two numbers.
    public class Class3
    {
        public static void Main(String[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Before swapping:a={a},b={b}");

            int temp = a;
            a = b;
            b= temp;
            Console.WriteLine($"After swapping:a={a},b={b}");


            int s1 = 30;
            int s2 = 20;
            Console.WriteLine($"Before swapping:s1={s1},s2={s2}");

            s1 = s1 + s2;
            s2 = s1 - s2;
            s1 = s1 - s2;
            Console.WriteLine($"After swapping:s1={s1},s2={s2}");

        }
    }
}
