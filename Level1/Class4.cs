using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Level1
{
    //Write a program to find the area of a circle.

    public class Class4
    {
        public static void Main(String[] args)
        {
            float pi = 3.14F;
            Console.WriteLine("Enter radis of the circle:");
            int r = Convert.ToInt32(Console.ReadLine());
            //Convert.ToInt32() is used to convert a value into an integer (int).
            Console.WriteLine($"Area of the circle is = {pi *r * r}");
        }
    }
}
