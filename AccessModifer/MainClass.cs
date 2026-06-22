using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.AccessModifer
{
    public class MainClass
    {
        public void publicTest1()
        {
                Console.WriteLine("This is a public method.");
        }

        private void privateTest2()
        {
                Console.WriteLine("This is a private method.");
        }

        protected void protectedTest3()
        {
                Console.WriteLine("This is a protected method.");
        }

        internal void internalTest4()
        {
                Console.WriteLine("This is an internal method.");
        }

        protected internal void protectedInternalTest5()
        {
                Console.WriteLine("This is a protected internal method.");
        }
    
        private protected void privateProtectedTest6()
        {
                Console.WriteLine("This is a private protected method.");
        }

        //public static void Main()
        //{
        //        MainClass obj = new MainClass();
        //        obj.publicTest1();
        //        obj.privateTest2();
        //        obj.protectedTest3();
        //        obj.internalTest4();
        //        obj.protectedInternalTest5();
        //        obj.privateProtectedTest6();
        //}
    }
    
}
