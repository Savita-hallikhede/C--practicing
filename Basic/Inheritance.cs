using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Basic
{
    internal class Inheritance
    {
        public Inheritance()
        {
                       Console.WriteLine("This is the constructor of the base class.");
        }
    }

    internal class Derived : Inheritance
    {
        public Derived()
        {
            Console.WriteLine("This is the constructor of the derived class.");
        }
    }
}
