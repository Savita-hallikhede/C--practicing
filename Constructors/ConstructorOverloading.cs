using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Constructors
{
    internal class ConstructorOverloading
    {
        int b;
        int c;
        string name;
        int age;

        public ConstructorOverloading(int b)
        {
            this.b = b;
        }

        public ConstructorOverloading(int a, int b)
        {
            c = a + b;
        }

        public ConstructorOverloading(string name,int age)
        {
           this.name = "soumya";
           this.age = 20;

        }
        public ConstructorOverloading(string name)
        {
            this.name = name;
        }
        public static void Main()
        {
            ConstructorOverloading obj1 = new ConstructorOverloading(10);
            Console.WriteLine(obj1.b);
            ConstructorOverloading obj2 = new ConstructorOverloading(10, 20);
            Console.WriteLine(obj2.c);
            ConstructorOverloading obj3 = new ConstructorOverloading("soniya", 21);
            Console.WriteLine(obj3.name);
            Console.WriteLine(obj3.age);
            ConstructorOverloading obj4 = new ConstructorOverloading("jaan");
            Console.WriteLine(obj4.name);
        }
    }
}
