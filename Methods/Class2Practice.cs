using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Methods
{
    internal class Class2Practice
    {
        int c;
        public void method1( int a,int b)
        {
            c = a + b;
        }

        public void method2(int a1,int b1)
        {
            int C1;
            C1 = a1 + b1;
            Console.WriteLine(C1);
        }

        public string method3(string name)
        {
            return name;
        }

        public static void method4(int a2,int b2)
        {
            int c2;
            c2 = a2 + b2;
            Console.WriteLine(c2);
        }

        static int c3;
        public static void method5(int a3,int b3)
        {
            c3 = a3 + b3;
        }   


        public void sonu()
        {
            Console.WriteLine("This is a non-static method");
        }

        int C;
        public void sonu(int A,int B)
        {
           
            C = A + B;
         
        }
        public static void Main()
        {
            Class2Practice obj = new Class2Practice();
            obj.method1(10, 20);
            Console.WriteLine(obj.c);


            Class2Practice obj1 = new Class2Practice();
            obj1.method2(30, 40);
            //Console.WriteLine(obj1.C1); // This will give an error because C1 is not accessible outside method2

            Class2Practice obj2 = new Class2Practice();
            string Name = obj2.method3("Soumya");
            Console.WriteLine(Name);

            Class2Practice class2Practice = new Class2Practice();
            Class2Practice.method4(50, 60);
            //Console.WriteLine(c2);

            Class2Practice.method5(70, 80);
            Console.WriteLine(Class2Practice.c3);


            Class2Practice obj3 = new Class2Practice();
            obj3.sonu();
           
            obj3.sonu(9, 1);
            Console.WriteLine(obj3.C);
        }
    }
}
