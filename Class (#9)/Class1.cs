using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class___9_
{
    class Student : IComparable<Student>
    {
        private static Random generator = new Random();
        private string _email;
        private string _firstName;
        private string _lastName;
        private int _studentNum;
        public Student(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            _studentNum = generator.Next(100, 1000) + 555000;
            GenerateEmail();
        }
        public int StudentNum { get { return _studentNum; } }
        public string FirstName { get { return _firstName; } set { this._firstName = value; GenerateEmail(); } }
        public string LastName { get { return _lastName; } set { this._lastName = value; GenerateEmail(); } }
        public string Email { get { return _email; } }
        public override bool Equals(object obj)
        {
            Student student = obj as Student; //cast obj to Student
            if (student == null) //protects us in case obj is null
                return false;
            else if (FirstName == student.FirstName & LastName == student.LastName & StudentNum == student.StudentNum)
            {
                return true;
            }
            else
                return false;
        }
        public int CompareTo(Student student)
        {
            if (this.LastName.CompareTo(student.LastName) == 0)
                return this.FirstName.CompareTo(student.FirstName);
            else
                return this.LastName.CompareTo(student.LastName);
        }
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
        public void ResetStudentNumber()
        {
            _studentNum = generator.Next(100, 1000) + 555000;
            GenerateEmail();
        }
        private void GenerateEmail()
        {
            _email = "";
            if (!(FirstName.Count() < 3))
            {
                for (int i = 0; i < 3; i++)
                {
                    _email += FirstName[i];
                }
            }
            else
            {
                for (int i = 0; i < FirstName.Count(); i++)
                {
                    _email += FirstName[i];
                }
            }

            if (!(LastName.Count() < 3))
            {
                for (int i = 0; i < 3; i++)
                {
                    _email += LastName[i];
                }
            }
            else
            {
                for (int i = 0; i < LastName.Count(); i++)
                {
                    _email += LastName[i];
                }
            }
            _email += _studentNum - 555000;
            _email += "@gmail.com";
        }
    }
}
