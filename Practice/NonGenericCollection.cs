using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Practice
{
    internal class NonGenericCollection
    {

        //ArrayList(Non-Generic)
        /* ArrayList list = new ArrayList();

         public void AddElements()
         {
             list.Add(10);
             list.Add("Hello");
             list.Add(3.14);
         }


         public static void Main(string[] args)
         {
             NonGenericCollection c = new NonGenericCollection();
             c.AddElements();


             foreach (object obj in c.list)
             {
                 Console.WriteLine(obj);
             }
         }*/

        //ArrayList(Non-Generic)
        /*public static void Main(String[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
            list.Add(3.14);


            foreach (var value in list)
            {
                Console.WriteLine(value);
            }
        }*/




        /* public static void Main(String[] args)
         {
             Hashtable hashtable = new Hashtable();

             hashtable.Add("Name", "John");
             hashtable.Add("Age", 30);
             hashtable.Add("Height", 5.9);

             //foreach (DictionaryEntry entry in hashtable)
             //{
             //    Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

             //}

             //Console.WriteLine("Name: " + hashtable["Name"]);
             //    Console.WriteLine("Age: " + hashtable["Age"]);
             //    Console.WriteLine("Height: " + hashtable["Height"]);

             Console.WriteLine($"Name: {hashtable["Name"]}");
             Console.WriteLine($"Age: {hashtable["Age"]}");
             Console.WriteLine($"Height: {hashtable["Height"]}");

        }*/

        /* public static void Main()
         {
             SortedList sortedList = new SortedList();
             sortedList.Add("Banana", 1.5);
             sortedList.Add("Apple", 2.0);
             sortedList.Add("Orange", 1.0);

             foreach (DictionaryEntry entry in sortedList)
             {
                 Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
             }
         }*/

        /*public static void Main()
        { 
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }*/

        public static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    
    }
}

