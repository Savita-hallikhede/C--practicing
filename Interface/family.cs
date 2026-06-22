using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Interface
{
    public class family
    {
        public static void Main(string[] args)
        {
            home dad = new home();
            home1 mom = new home1();
            dad.office();
            dad.responsibility();
            mom.homeMaker();
            mom.responsibility();
        }

    }
}
