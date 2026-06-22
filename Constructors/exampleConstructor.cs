using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Constructors
{
    internal class exampleConstructor
    {
        int a;
        int b;
        public exampleConstructor(int a, int b) 
        {
            this.a = a;  //5
            this.b = b;  //15
           
        }

        //static constructor must be parameterless 
        static exampleConstructor() //execute automatically when the class is loaded into memory(1st execute)
        {
            Console.WriteLine("This is static constructor");
        }

        public static void Main()
        {
            exampleConstructor c = new exampleConstructor(5, 15);
            Console.WriteLine(c.a);
            Console.WriteLine(c.b);
            

        }


    }
}
