using System.Collections.Generic;

namespace _05.Comparing_Objects
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length - y.Name.Length;
            if (result == 0)
            {
                char xFirstLetter = char.ToLower(x.Name[0]);
                char yFirstLettr = char.ToLower(y.Name[0]);
                result = xFirstLetter.CompareTo(yFirstLettr);
            }

            return result;
        }
    }
}