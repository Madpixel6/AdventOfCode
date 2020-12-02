using AdventOfCode2020.Common;

namespace AdventOfCode2020.Day1;

public class DayOneProblem : IProblemSolution<HashSet<int>, int>
{
    public const int SumDestination = 2020;
    
    public int PartOne(HashSet<int> input)
        => input
            .Select(x => new {x, y = SumDestination - x})
            .Where(t => input.Contains(t.y))
            .Select(t => t.x * t.y)
            .FirstOrDefault();

    public int PartTwo(HashSet<int> input)
        => input
            .SelectMany(x => input, (x, y) => new {x, y})
            .Select(t => new {t, z = SumDestination - t.x - t.y})
            .Where(t => input.Contains(t.z))
            .Select(t => t.t.x * t.t.y * t.z)
            .FirstOrDefault();
}