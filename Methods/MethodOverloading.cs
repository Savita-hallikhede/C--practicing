using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_practicing.Methods
{
    internal class MethodOverloading
    {
        static string Name;
        public static int ravi(int a, string name)
        {
            Name = name;
            return a;
           
        }

        public static string ravi(string name,int a)
        {
            return name;
        }

        public static void Main()
        {
            int result = MethodOverloading.ravi(10, "akhila");
            Console.WriteLine(result);
            Console.WriteLine(Name);




        }
    }
}
