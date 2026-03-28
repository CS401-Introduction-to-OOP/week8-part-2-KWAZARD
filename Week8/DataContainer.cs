namespace Week8;
using System.Collections.Generic;
   


public class DataContainer<T> where T : DataItem
{
    private readonly List<T> items = new();
    public void AddItem(T item)
    {
        items.Add(item);
    }
    public long GetTotalSize()
    {
        long sum = 0;
        foreach (var VARIABLE in items)
        {
            sum += VARIABLE.GetSize();
        }

        return sum;
    }
}
   
