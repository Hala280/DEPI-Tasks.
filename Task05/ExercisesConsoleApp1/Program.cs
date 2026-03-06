using System;
using System.Runtime.Intrinsics.Arm;
    
class Functions
{
   public List<int> ReversedArray(List<int> arr)
    {

        int pointer1 = 0;
        int pointer2 = arr.Count-1;

        while (pointer1 < pointer2)
        {
            int temp = arr[pointer1];
            arr[pointer1] = arr[pointer2];
            arr[pointer2] = temp;

            pointer1++;
            pointer2--;
        }

        return arr;

    }

    public List<int> EvenList(List<int> arr)
    {
        List<int> evenArr = new List<int>();

        for(int i=0;i<arr.Count; i++)
        {
            if(arr[i] % 2 == 0)
            {
                evenArr.Add(arr[i]);
            }
        }
        return evenArr;
    }


}


public class FixedSizeList<T>
{

    private T[] _array;
    private int _count;

    public int Count => _count;
    public int Capacity => _array.Length;

    public FixedSizeList(int capacity=10
    {
        _array = new T[capacity];
        _count = 0;
    }

    public void Add(T item)
    {
        if (_count >= _array.Length)
        {
            throw new InvalidOperationException("List is full.");
        }
        _array[_count] = item;
        _count++;
    }

    public T Get(int index) {
        if (index < 0 || index >= _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }
        return _array[index];
    }



}