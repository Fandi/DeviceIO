namespace System.Collections.Generic
{
    public interface IReadOnlyCollection<T> : IEnumerable<T>, IEnumerable
    {
        int Count { get; }
    }
}
