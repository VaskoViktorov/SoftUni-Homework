﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Generic_Box
{
    public class Box<T> : IBox<T>
    {

        public void Generate(T value)
        {
            this.Value = value;
           
        }

        public T Value { get; protected set; }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
