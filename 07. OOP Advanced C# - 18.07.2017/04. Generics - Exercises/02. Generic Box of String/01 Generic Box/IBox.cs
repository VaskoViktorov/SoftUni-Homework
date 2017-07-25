using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Generic_Box
{
    public interface IBox<T>
    {
        T Value { get; }
        void Generate(T value);
        string ToString();
    }
}
