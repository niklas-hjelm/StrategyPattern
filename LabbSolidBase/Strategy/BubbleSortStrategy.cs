using LabbSolidBase.Strategy.Interfaces;

namespace LabbSolidBase.Strategy;

public class BubbleSortStrategy : ISortStrategy
{
    public void DoSort(ref int[] arr)
    {
        for (var j = 0; j <= arr.Length - 2; j++)
        {
            for (var i = 0; i <= arr.Length - 2; i++)
            {
                if (arr[i] <= arr[i + 1]) continue;

                (arr[i + 1], arr[i]) = (arr[i], arr[i + 1]);
            }
        }
    }
}