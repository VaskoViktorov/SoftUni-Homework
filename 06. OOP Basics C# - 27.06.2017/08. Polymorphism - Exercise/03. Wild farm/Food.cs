using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wild_farm
{
    public abstract class Food
    {
        private int quantity;
        private string type;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        protected Food(int quantity, string type)
        {
            this.quantity = quantity;
            this.type = type;
        }  
    }
}
