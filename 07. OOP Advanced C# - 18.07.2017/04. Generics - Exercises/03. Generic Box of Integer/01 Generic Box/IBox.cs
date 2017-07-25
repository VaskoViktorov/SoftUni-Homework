namespace _01_Generic_Box
{
    public interface IBox<T>
    {
        T Value { get; }
        void Generate(T value);
        string ToString();
    }
}
