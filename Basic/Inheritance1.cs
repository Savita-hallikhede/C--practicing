using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharppracticing.Basic;

namespace CSharppracticing.Basic
{

    internal class Inheritance1
    {
        public void Method1()
        {
            Console.WriteLine("This is method 1 of the base class.");
        }

        public void Method2()
        {
            Console.WriteLine("This is method 2 of the base class.");
        }

        public long MyPhone { get; set; }   // ✔ changed
    }

    internal class Derived1 : Inheritance1
    {
        public void Method3()
        {
            Console.WriteLine("This is method 3 of the derived class.");
        }

        public void Method4()
        {
            Console.WriteLine("This is method 4 of the derived class.");
        }

        public int MyLaptop { get; set; }
    }

    internal class Derived2 : Derived1
    {
        public void Method5()
        {
            Console.WriteLine("This is method 5 of the derived class.");
        }

        public static void Main()
        {
            Derived2 d2 = new Derived2();

            d2.Method1();
            d2.Method2();
            d2.Method3();
            d2.Method4();
            d2.Method5();

            Console.Write("Enter phone: ");
            d2.MyPhone = long.Parse(Console.ReadLine());

            Console.Write("Enter laptop: ");
            d2.MyLaptop = int.Parse(Console.ReadLine());

            Console.WriteLine($"Phone: {d2.MyPhone}");
            Console.WriteLine($"Laptop: {d2.MyLaptop}");

        }
    }
}

// ✅ ONLY ONE ENTRY POINT (Program.cs)

