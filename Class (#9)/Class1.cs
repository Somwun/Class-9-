using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class___9_
{
    class Student
    {
        private static Random generator = new Random();
        private string _firstName;
        private string _lastName;
        private string _studentNum;
        public Student(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._studentNum = "";
            for (int i = 0; i < 3; i++)
            {
                _studentNum += generator.Next(1, 10);
            }
            _studentNum += "555000";
        }
        public string StudentNum { get { return _studentNum; } }
    }
}
