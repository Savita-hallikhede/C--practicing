using System;
namespace CSharppracticing
{
    internal class Program
    {
        static void Main()
        {
            string var = "Hii Soumya";
            Console.WriteLine(var);


            //float , decimal , double 
            float f1 = 1.5f;
            double d1 = 1.5;
            decimal m1 = 1.5m;
            Console.WriteLine("Float value: " + f1);
            Console.WriteLine("Double value: " + d1);
            Console.WriteLine("Decimal value: " + m1);

            //boolean, string , datetime
            bool b1 = true;
            string s1 = "Hello, World!";
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(b1);
            Console.WriteLine(s1);
            Console.WriteLine(dateTime);


            // var 
            var variable = 10;
            Console.WriteLine(variable.GetType());

            // dynamic
            dynamic dy = 77;
            dy = 55;
            dy = "hii";// we will get error during runtime
            Console.WriteLine(dy);


            //object
            object obj = 100;
            int y = (int)obj;
            Console.WriteLine(obj.GetType()); 

            // taking input form the user 
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            //Console.WriteLine("Your name is:" + name);
            name = name.ToUpper();

            if (name == "SOUMYA")
            {
                Console.WriteLine(name);
            }

            if (name == "HARSH")
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }
        }
    }
}
