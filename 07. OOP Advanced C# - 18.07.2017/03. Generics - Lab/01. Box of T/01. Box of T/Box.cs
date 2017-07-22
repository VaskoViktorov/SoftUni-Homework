
using System.Collections.Generic;

public class Box<T>
{
    private List<T> data = new List<T>();

    public void Add(T element)
    {
        data.Add(element);
    }

    public T Remove()
    {
        var last = this.data[data.Count-1];
        this.data.RemoveAt(this.data.Count - 1);
        return last;
    }

    public int Count => this.data.Count;
}

