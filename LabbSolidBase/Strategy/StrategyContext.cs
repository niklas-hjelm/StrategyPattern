using System.Windows.Media;
using LabbSolidBase.Strategy.Interfaces;

namespace LabbSolidBase.Strategy;

public class StrategyContext : IContext
{
    private ISortStrategy _sortStrategy;

    public StrategyContext(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void SetStrategy(ISortStrategy strat)
    {
        _sortStrategy = strat;
    }

    public void Execute(ref int[] arr)
    {
        _sortStrategy.DoSort(ref arr);
    }
}