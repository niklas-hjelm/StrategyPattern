namespace LabbSolidBase.Strategy.Interfaces;
/// <summary>
/// Interface for a Strategy Context
/// </summary>
public interface IContext
{
    /// <summary>
    ///  Sets the active strategy within the context
    /// </summary>
    /// <param name="strat">Desired strategy</param>
    void SetStrategy(ISortStrategy strat);

    /// <summary>
    /// Executes the active strategy algorithm
    /// </summary>
    /// <param name="arr"> The array of numbers to be sorted</param>
    void Execute(ref int[] arr);
}