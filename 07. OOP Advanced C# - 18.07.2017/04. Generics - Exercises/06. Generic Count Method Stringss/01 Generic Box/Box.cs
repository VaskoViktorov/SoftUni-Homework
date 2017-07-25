using System.Collections;
using System.Collections.Generic;

namespace _01_Generic_Box
{

    public class Box<T>: IBox<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.Value}";
        }
       
    }
}
