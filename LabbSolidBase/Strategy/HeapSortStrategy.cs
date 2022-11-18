using LabbSolidBase.Strategy.Interfaces;

namespace LabbSolidBase.Strategy;

public class HeapSortStrategy : ISortStrategy
{
    public void DoSort(ref int[] arr)
    {
        int heapSize = arr.Length;

        for (int p = (heapSize - 1) / 2; p >= 0; --p)
            Heapify(ref arr, heapSize, p);

        for (int i = arr.Length - 1; i > 0; --i)
        {
            (arr[i], arr[0]) = (arr[0], arr[i]);

            --heapSize;
            Heapify(ref arr, heapSize, 0);
        }
    }

    private void Heapify(ref int[] data, int heapSize, int index)
    {
        int left = (index + 1) * 2 - 1;
        int right = (index + 1) * 2;
        int largest = 0;

        if (left < heapSize && data[left] > data[index])
            largest = left;
        else
            largest = index;

        if (right < heapSize && data[right] > data[largest])
            largest = right;

        if (largest != index)
        {
            (data[index], data[largest]) = (data[largest], data[index]);

            Heapify(ref data, heapSize, largest);
        }
    }
}