using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

public class FixedSizedQueue<T> : ConcurrentQueue<T>
{
    private readonly object _syncObject = new object();

    private int Size { get; }

    public FixedSizedQueue(int size)
    {
        Size = size;
    }

    public new void Enqueue(T obj)
    {
        base.Enqueue(obj);
        lock (_syncObject)
            while (Count > Size)
                TryDequeue(out _);
    }

    public List<T> GetAllItems()
    {
        return ToArray().ToList();
    }
}