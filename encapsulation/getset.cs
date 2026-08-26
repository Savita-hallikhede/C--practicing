using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.encapsulation
{
    internal class getset
    {
        string cityname = "Bangalore";


        public string City
        {
            get { return cityname; }

            set
            { 
                if(value.Length>2)
                {
                    cityname = value;
                }
                else
                {
                    Console.WriteLine("City name should be more than 2 characters");
                }
                    
            }
        }

        public static void Main(string[] args)
        {
            getset obj = new getset();

            Console.WriteLine(obj.City);

            obj.City = "Delhi";
            Console.WriteLine(obj.City);

            obj.City = "NY";
            Console.WriteLine(obj.City);
        }

    }
}
