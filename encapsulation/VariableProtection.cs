using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.encapsulation
{
    internal class VariableProtection
    {

        public string clgName="Presidency University";

        public static void Main(String[] args)
        {
            // A static method belongs to the class itself, so it cannot directly access instance variables.

            //get = to read/access data
            //set = to write/change data/modify data

            //Get value
            VariableProtection vp = new VariableProtection();

            Console.WriteLine(vp.clgName);

            //Set value
            vp.clgName = "BMS College of Engineering";


            Console.WriteLine(vp.clgName);



        }
    }
}
