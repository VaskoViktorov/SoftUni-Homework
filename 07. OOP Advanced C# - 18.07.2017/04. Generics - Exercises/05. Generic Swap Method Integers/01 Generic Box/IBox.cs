using System.Collections.Generic;

namespace _01_Generic_Box
{
    public interface IBox<T>
    {
        T Value { get; }

        string ToString();
    }
}
