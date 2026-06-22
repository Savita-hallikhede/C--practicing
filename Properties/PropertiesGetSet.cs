using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Properties
{
    internal class PropertiesGetSet
    {
        string CityName = "Bangalore";

        
        public string City
        {
            get 
            { 
                return CityName;
            }

            set
            { 
                if(value.Length > 0)
                {
                CityName = value;
                }
                else
                {
                    Console.WriteLine("City name cannot be empty.");
                }
              
            }
        }
        public static void Main()
        {
            PropertiesGetSet ob = new PropertiesGetSet();
            Console.WriteLine("City: " + ob.City); // Output: City: Bangalore
            ob.City = "Mysore";
            Console.WriteLine("City: " + ob.City); // Output: City: Mysore


        }
    }
}
