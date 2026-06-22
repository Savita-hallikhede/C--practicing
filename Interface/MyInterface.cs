using System;

namespace C_practicing.Interface
{
    // First interface
    internal interface MyInterface
    {
        void Study();
    }



    // One class implementing both interfaces
    internal class Person : MyInterface
    {
        public void Study()
        {
            Console.WriteLine("Person is studying.");
        }

        //public void Play()
        //{
        //    Console.WriteLine("Person is playing sports.");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Study();   // Output: Person is studying.
            //p.Play();    // Output: Person is playing sports.
        }
    }
}
