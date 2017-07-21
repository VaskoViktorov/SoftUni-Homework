using System.Collections.Generic;

namespace _09.Collection_Hierarc
{
    public class AddCollection : IAddCollection
    {
        public AddCollection()
        {
            this.Items = new List<string>();
        }

        public List<string> Items { get; }

        public virtual int Add(string item)
        {
            this.Items.Add(item);
            return this.Items.IndexOf(item);
        }
    }
}

