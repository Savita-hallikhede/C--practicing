using System;

namespace C_practicing.Abstract
{
    // Abstract class declaration
    abstract class Abstract1
    {
        // Abstract method (only declaration)
        public abstract void Show();

        public abstract void Show1();

        // Normal method with body
        public void Display()
        {
            Console.WriteLine("This is a non-abstract method in the abstract class.");
        }
    }

    // Derived class
    class Demo : Abstract1
    {
        // Implementing abstract method
        public override void Show()
        {
            Console.WriteLine("This is the implementation of the abstract method in the derived class.");
        }

        public override void Show1()
        {
            Console.WriteLine("This is the implementation of the second abstract method in the derived class.");
        }
    }

    class Program
    {
        // Entry point of program
        public static void Main(string[] args)
        {
            // Creating object of derived class
            Demo d = new Demo();

            // Calling abstract method implementation
            d.Show();

            // Calling normal inherited method
            d.Display();
        }
    }
}