using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.AccessModifer
{
    internal class AontherClassOfSameProject
    {

        public static void Main()
        {
            MainClass obj = new MainClass();
            obj.publicTest1(); // Accessible
            // obj.privateTest2(); // Not Accessible
            // obj.protectedTest3(); // Not Accessible
            obj.internalTest4(); // Accessible
            obj.protectedInternalTest5(); // Accessible
           // obj.privateProtectedTest6(); // Not Accessible
        }
    }
}
