namespace AdventOfCode2020.Common;

public interface IProblemSolution<in TInput, out TResult>
{
    public TResult PartOne(TInput input);
    public TResult PartTwo(TInput input);
}