using CSharppracticing.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.TypeCasting
{
    internal class Class1
    {
        //Implicit Type Casting:Automatic conversion of a smaller data type into a larger data type.
        int a = 10;
        double b;

        double a1 = 10.5;
        int b1;

        object obj = 100;
        int x;

        object obj1 = 20;
        double y;

        object obj2 = 300;
        string str;  

        double d1 = 19.9;
        object obj3; 
        //var can only be used inside a method, constructor, or local scope.


        //  The constructor is used to assign b = a because field initializers cannot access another non-static field directly, and the assignment performs implicit casting from int to double.
        public Class1()
        {
            b = a;
            b1 = (int)a1;
            x = (int)obj;
            y = (int)obj1;
            var z = 11;
            double w = z;
            Console.WriteLine(z);
            Console.WriteLine(w);
            str= Convert.ToString(obj2);
            obj3 = d1;
        }

        public void Display()
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(str);
            Console.WriteLine(obj3);

        }

        
    }

    class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.Display();
        }
    }
}
