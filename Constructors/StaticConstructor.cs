using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Constructors
{
    internal class StaticConstructor
    {
        public static int b = 10;
        int a = 20;
        public StaticConstructor(Boolean a , string b)
        {
            this.a = 22;
            StaticConstructor.b = 30;

        }



        public static void main()
        {
            StaticConstructor obj = new StaticConstructor(true, "soumya");
            Console.WriteLine(obj.a);
            Console.WriteLine(b);
        }
    }
}
