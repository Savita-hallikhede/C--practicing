using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.AccessModifer
{
    internal class ChildClassofSameProject : MainClass
    {
        public static void Main()
        {
                       ChildClassofSameProject obj = new ChildClassofSameProject();
            obj.publicTest1(); // Accessible
            // obj.privateTest2(); // Not Accessible
            obj.protectedTest3(); // Accessible
            obj.internalTest4(); // Accessible
            obj.protectedInternalTest5(); // Accessible
            obj.privateProtectedTest6(); // Accessible
        }
    }
}
