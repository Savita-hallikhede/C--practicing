using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.ArraysConcept
{
    internal class ArrayForEach
    {
        public static void Main()
        {
            int[] marks = new int[10];
            for(int i=0; i<10; i++)
            {
                marks[i] = i + 200;
            }

            int index = 0;
            foreach(int value in marks)
            {
                Console.WriteLine("Element[{0}] = {i}", index, value);
                index++;
            }
            Console.ReadKey();
        }
    }
}
