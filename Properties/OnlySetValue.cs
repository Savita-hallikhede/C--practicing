using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Properties
{
    internal class OnlySetValue
    {
        string _name;
        int _age;


        public void Name1(string name)
        {
            _name = name;
        }

        
        public void Age1(int age)
        {
            if(age < 10) 
            {
                _age = age;
            }
            
        }

        public String Name2()
        {
            return _name;
        }

        public int Age2()
        {
            return _age;
        }

    }
        class Program1
            {
                static void Main()
                {
                    OnlySetValue obj = new OnlySetValue();
    
                    // SET value using property
                    obj.Name1("Soumya1");
                    obj.Age1(9);

                 Console.WriteLine(obj.Name2()); // Output: Soumya1
                 Console.WriteLine(obj.Age2());  // Output: 9

            // GET value will cause a compile-time error
            // Console.WriteLine(obj.Name); // ❌ Not allowed, no getter defined
        }
    }
}
