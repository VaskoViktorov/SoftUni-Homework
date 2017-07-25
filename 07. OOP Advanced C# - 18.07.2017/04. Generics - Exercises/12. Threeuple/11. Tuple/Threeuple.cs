using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tuple
{
   public class Threeuple<T, U, V>
    {
        public Threeuple(T firstValue, U secondValue, V thirdValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            this.ThirdValue = thirdValue;
        }
        public T FirstValue
        {
            get; 
        }
        public U SecondValue
        {
            get;
        }
        public V ThirdValue
        {
            get;
        }

        public override string ToString()
        {
            return $"{this.FirstValue} -> {this.SecondValue} -> {this.ThirdValue}";
        }
    }
}
