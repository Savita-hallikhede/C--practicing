using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.encapsulation
{
    internal class Setter
    {
        string _name;
        int _age;

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAge(int age)
        {
            _age = age;
        }


        public string GetName()
        {
            return _name;
        }

        public int GetAge()
        {
            return _age;
        }

    }

    class Program1
    {
        public static void Main(String[] args)
        {
            Setter obj1 = new Setter();
            obj1.SetName("Akhila");
            obj1.SetAge(22);

            Console.WriteLine(obj1.GetName());
            Console.WriteLine(obj1.GetAge());


        }
    }
    

    
}
