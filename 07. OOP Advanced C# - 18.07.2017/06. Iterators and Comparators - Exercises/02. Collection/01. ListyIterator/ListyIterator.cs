﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> data;
        private int currentIndex;

        public ListyIterator()
        {
            this.data = new List<T>();
            this.CurrentIndex = 0;
        }

        public ListyIterator(List<T> items)
        {
            this.data = items;
        }

        public int CurrentIndex
        {
            get { return this.currentIndex; }
            set { this.currentIndex = value; }
        }

        public bool Move()
        {
            if (this.data.Count - 1 > this.currentIndex)
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public T Print()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return this.data[this.CurrentIndex];
        }

        public bool HasNext()
        {
            if (this.data.Count - 1 > this.currentIndex)
            {
                return true;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}