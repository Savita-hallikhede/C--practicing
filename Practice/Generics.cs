using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Practice
{
    internal class Generics
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Sony");
            list.Add("Samsung");
            list.Add("Apple");
            list.Add("OnePlus");
            list.Add("Android");


            //foreach (string str in list)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine();



            Dictionary<string, int> dict = new Dictionary<string, int>();
                dict.Add("John", 30);
                dict.Add("Alice", 25);
                dict.Add("Bob", 35);

            foreach (KeyValuePair<string, int> entry in dict)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
               // Console.WriteLine(entry);
            }
        }


        
    }
}



