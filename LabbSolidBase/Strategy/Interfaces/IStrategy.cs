namespace LabbSolidBase.Strategy.Interfaces;

/// <summary>
/// Interface for all sorting algorithm strategies
/// </summary>
public interface ISortStrategy
{
    void DoSort(ref int[] arr);
}