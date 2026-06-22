using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Interface
{
    internal interface Dad
    {
        public void office();

        public void responsibility();

    }

    public class home : Dad
    {
        public void office()
        {
                       Console.WriteLine("Dad is going to office.");
        }

        public void responsibility()
        {
                       Console.WriteLine("Dad is responsible for the family.");
        }
    }


}
