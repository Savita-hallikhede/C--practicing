using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Properties
{
    internal class onlyGetValue
    {
        String name = "Soumya";

        public string Name()
        {
            return name;
        }
    }

        class Program
        {
            public static void Main()
            {
                onlyGetValue obj = new onlyGetValue();

                // GET value using property
                Console.WriteLine(obj.Name());

                // Trying to SET value will cause a compile-time error
                // obj.Name = "New Name"; // ❌ Not allowed, no setter defined
            }
        }
    }
    

