using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Properties
{
    internal class Class1
    {
        public static void Main()
        {
            StudentDefaultValues obj = new StudentDefaultValues(1, "Aditya", 9876543210, "Bangalore");


            Console.WriteLine("Employee Id: " + obj.id);
            Console.WriteLine("Employee Name: " + obj.name);
            Console.WriteLine("Employee Number: " + obj.number);
            Console.WriteLine("Employee Address: " + obj.adress);


        }
    }
}
