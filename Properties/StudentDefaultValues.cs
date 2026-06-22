using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Properties
{
    internal class StudentDefaultValues
    {
       // int empId;
        //string empName;
        //long empNo;
       // string empAdress;
        public StudentDefaultValues(int _empId, string _empName, long _empNo, string _empAdress)
        {
            id = _empId;
            name = _empName;
            number = _empNo;
            adress = _empAdress;
        }

        public int id { get; set; } = 0;
        public string name { get; set; } = "adi";
        public long number { get; set; } = 1234567890;
        public string adress { get; set; } = "Ballari";

    }


   
}

