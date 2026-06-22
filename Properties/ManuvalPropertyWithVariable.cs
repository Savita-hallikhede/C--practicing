using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practicing.Properties
{
    class ManuvalPropertyWithVariable
    {
        //Constructor
        public ManuvalPropertyWithVariable
            (
            int _empId,
            string _empName,
            long _empNo,
            string _country
            )
        {
            this._EmpId = _empId;
            this._EmpName = _empName;
            this._EmpNo = _empNo;
            this._Country = _country;
        }

        //Private variables
        private int _EmpId;
        private string _EmpName;
        private long _EmpNo;
        private string _Country;

        //Manuval properties
        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public long EmpNo
        {
            get { return _EmpNo; }
            set { _EmpNo = value; }
        }

    }
}
