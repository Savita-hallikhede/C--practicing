using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.encapsulation
{
    internal class VariableAcces
    {
        public static void Main(String[] args)
        {
         VariableProtection vp1 = new VariableProtection();

            //Getvalue
            Console.WriteLine(vp1.clgName);

            //Setvalue
            vp1.clgName = "ABC College";

            //Get updated value 
            Console.WriteLine(vp1.clgName);

        }
    }
}
