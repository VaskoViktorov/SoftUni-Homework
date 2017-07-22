
using System.Runtime.InteropServices.ComTypes;

public static class ArrayCreator
{

    public static T[] Create<T>(int length, T item)
    {
        T[] array = new T[length];
       
        return array;
    }
}

