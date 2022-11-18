using LabbSolidBase.Strategy.Interfaces;

namespace LabbSolidBase.Strategy;

public class QuickSortStrategy : ISortStrategy
{
    public void DoSort(ref int[] arr)
    {
        QuickSort(ref arr, 0, arr.Length - 1);
    }

    void QuickSort(ref int[] data, int left, int right)
    {
        var pivot = data[(left + right) / 2];
        var leftHold = left;
        var rightHold = right;

        while (leftHold < rightHold)
        {
            while ((data[leftHold] < pivot) && (leftHold <= rightHold)) leftHold++;
            while ((data[rightHold] > pivot) && (rightHold >= leftHold)) rightHold--;

            if (leftHold >= rightHold) continue;

            (data[leftHold], data[rightHold]) = (data[rightHold], data[leftHold]);
            if (data[leftHold] == pivot && data[rightHold] == pivot)
                leftHold++;
        }
        if (left < leftHold - 1) QuickSort(ref data, left, leftHold - 1);
        if (right > rightHold + 1) QuickSort(ref data, rightHold + 1, right);
    }
}