using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Tuple
{
   public class Tuple<T, U>
    {
        public Tuple(T firstValue, U secondValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
        }
        public T FirstValue
        {
            get; 
        }
        public U SecondValue
        {
            get;
        }

        public override string ToString()
        {
            return $"{this.FirstValue} -> {this.SecondValue}";
        }
    }
}
