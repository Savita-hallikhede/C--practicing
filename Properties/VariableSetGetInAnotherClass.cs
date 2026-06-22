using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Properties
{
    internal class VariableSetGetInAnotherClass
    {
        public static void Main()
        {
            VariableSetGet obj = new VariableSetGet();

            // GET value
            Console.WriteLine(obj.clgName);

            // SET value
            obj.clgName = "Bangalore University";

            // GET updated value
            Console.WriteLine(obj.clgName);
        }
    }
}
