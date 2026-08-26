using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.encapsulation
{
    internal class GatterMathod
    {
        string name = "soumya";

        public string Name()
        {
            return name;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            GatterMathod obj = new GatterMathod();
            Console.WriteLine(obj.Name());

            


        }

       

    }
}
