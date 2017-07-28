using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Comparing_Objects
{
    public class Person :IComparable<Person>
    {
        public Person(string name, string age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; }
        public string Age { get; }
        public string Town { get; }


        public int CompareTo(Person otherPerson)
        {
            int result = this.Name.CompareTo(otherPerson.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(otherPerson.Age);
                if (result == 0)
                {
                    result = this.Town.CompareTo(otherPerson.Town);
                }
            }

            return result;
        }
    }
}
