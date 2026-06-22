using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Interface
{
    internal interface YourInterface
    {
         void Play();
        
    }
    public class person1 : YourInterface
    {
        public void Play()
        {
            Console.WriteLine("Person is playing sports.");
        }
    }
     class program
     {
        static void Main(string[] args)
        {
            person1 person = new person1();
            person.Play();
        }
     }
}