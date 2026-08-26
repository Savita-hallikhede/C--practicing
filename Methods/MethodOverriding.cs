using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Methods
{
    internal class MethodOverriding
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        public class  Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat meows");
            }

        }

        public static void Main()
        {
            Animal obj = new Animal();
            obj.MakeSound(); 
           

            Dog dog = new Dog();
            dog.MakeSound();

            //Reference of base class pointing to derived class object--> display the derived class method
            Animal animal = new Dog();
            animal.MakeSound();
        }
    }
}
