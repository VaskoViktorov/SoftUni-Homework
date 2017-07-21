
using System.Linq;

namespace _09.Collection_Hierarc.Intefaces
{
    public class MyList: AddRemoveCollection,IMyList
    {
        public int Used { get; private set; }

        public override int Add(string item)
        {
            var index = 0;
            base.Items.Insert(index, item);
            this.Used++;
            return index;
        }

        public override string Remove()
        {
            var elementToRemove = this.Items.FirstOrDefault();
            this.Items.RemoveAt(0);
            this.Used--;
            return elementToRemove;
        }
    }
}
