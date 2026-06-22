using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Properties
{
    internal class Class2
    {
        public static void Main()
        {
            ManuvalPropertyWithVariable obj = new ManuvalPropertyWithVariable(2, "Adarsh", 9876543750, "India");
            Console.WriteLine("Employee Id: " + obj.EmpId);
            Console.WriteLine("Employee Name: " + obj.EmpName);
            Console.WriteLine("Employee Number: " + obj.EmpNo);
            Console.WriteLine("Employee Country: " + obj.Country);
        }
    }
}
