using C_practicing.ArraysConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Practice
{

    internal class MultidimentionalArray
    {
        int[,] a = new int[3, 4]
        {
            {1,2,3,4 },
            {5,6,7,8},
            {9,10,11,12}
        };


        public void Display()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }

        public static void Main(string[] args)
        {
            MultidimentionalArray m = new MultidimentionalArray();
            m.Display();
        }
    }
}
        

    

