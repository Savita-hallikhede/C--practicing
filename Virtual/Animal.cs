using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Virtual
{
    public class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes a sound");
        }


        public virtual string sound(string sound)
        {
            return sound;
        }


        // int _sound;
        // public virtual void sound(int sound)
        // {
        //     _sound = sound;
        // }

        //public virtual int sound1()
        // {
        //     return _sound;
        // }

        int data = 5;
        public virtual int sound1
        {
            get { return data; }
            set { data = value;  }

        }

    } 

    public class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class program1
    {
        static void Main(string[] args)
        {
            Animal obj = new Animal();
            obj.sound();


            Dog obj1 = new Dog();
            obj1.sound();


            Animal obj3 = new Dog();
            obj3.sound();


            Animal obj4 = new Dog();
            //obj4.sound(5);
            //// Console.WriteLine(obj4.sound1());
            //int data = obj4.sound1();
            //Console.WriteLine(data);



            Console.WriteLine(obj4.sound("Woof"));

            Console.WriteLine(obj4.sound1);
            Console.WriteLine(obj4.sound1 = 10);    


        }
    }
}
