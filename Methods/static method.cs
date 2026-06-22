using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Methods
{
    internal class static_method
    {
        //void type

        static int c;
        public static void ram(int a,int b)
        {
            //int c;
            c = a + b;
            
        }

        //non-void type static method
        public static int sum(int c , int d)
        {
            int z = c + d;
            return z;
           
        }

        public static void Main()
        {
            static_method.ram(10, 20);
            Console.WriteLine(c);


            int result =  static_method.sum(22, 33);
            Console.WriteLine(result);

        }


    }
}
