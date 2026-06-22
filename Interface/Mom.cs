using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Interface
{
    internal interface Mom
    {
        public void homeMaker();
        public void responsibility();
        
    }

    public class home1 : Mom
    {
        public void homeMaker()
        {
            Console.WriteLine("Mom is a homemaker.");
        }
        public void responsibility()
        {
            Console.WriteLine("Mom is responsible for the family.");
        }
    }
}
