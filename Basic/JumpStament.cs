using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Basic
{
    internal class JumpStament
    {
       public static void Main()
        {

             for(int i = 0; i < 10; i++)
             {
                 if (i == 5)
                 {
                     continue; // Skip the rest of the loop when i is 5
                 }
                 Console.WriteLine(i);
             }
       }
    }
}
