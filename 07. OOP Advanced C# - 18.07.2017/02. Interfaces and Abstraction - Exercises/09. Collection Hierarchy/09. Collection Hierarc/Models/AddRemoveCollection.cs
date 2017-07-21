
using System.Collections.Generic;
using System.Linq;

namespace _09.Collection_Hierarc
{
    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        public virtual string Remove()
        {
            var last = this.Items.LastOrDefault();
            this.Items.RemoveAt(this.Items.Count-1);
            return last;
        }
        public override int Add(string item)
        {
            base.Items.Add(item);
            return 0;
        }
    }
}

