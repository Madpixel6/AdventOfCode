using AdventOfCode2020.Day1;
using Xunit;

namespace AdventOfCode2020.UnitTests;

public class DayOneUnitTests
{
    private readonly DayOneProblem _problem = new();
    
    [Fact]
    public void GivenValidTestDataPartOneShouldReturnExpectedResult()
    {
        const int expectedResult = 983619;
        var testData = new HashSet<int>
        {
            1721,
            1981,
            2001,
            819,
            1201,
            944,
            11
        };
        var result = _problem.PartOne(testData);
        
        Assert.True(result == expectedResult);
    }
    [Fact]
    public void GivenValidTestDataPartTwoShouldReturnExpectedResult()
    {
        const int expectedResult = 241861950;
        var testData = new HashSet<int>
        {
            979,
            366,
            675,
            819,
            1201,
            944,
            11
        };
        var result = _problem.PartTwo(testData);
        
        Assert.True(result == expectedResult);
    }
}