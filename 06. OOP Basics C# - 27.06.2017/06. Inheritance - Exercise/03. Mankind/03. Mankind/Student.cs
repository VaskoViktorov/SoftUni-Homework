using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Mankind
{
    public class Student:Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

       
        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                Regex reg = new Regex(@"^([a-zA-Z0-9])+$");
               
                if (value.Length < 5 || value.Length > 10 || !reg.IsMatch(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\nLast Name: {this.LastName}\nFaculty number: {this.facultyNumber}";
        }
    }
}
