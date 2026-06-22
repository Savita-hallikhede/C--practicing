using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Methods
{
    internal class Instantmethod
    {
        //void type --> no return
         public int c;
        public void soumya(int a,int b)
        {
            //int c;  //local variable
            c = a + b;
           // Console.WriteLine(c);

        }

        public int akhila(int d, int e)
        {
            int f;
            f = d+ e;
            return f;

        }


        public static void Main()
        {
            //Instantmethod obj = new Instantmethod();
            //obj.soumya(10, 20);
            //Console.WriteLine(obj.c);

            Instantmethod obj1 = new Instantmethod();
            int val=obj1.akhila(20,20);
            Console.WriteLine(val);

            
        }
    }
}
