using Xunit;
using AverageCalculator;

namespace Tests;

public class Calculator_Tests
{
    
    [Fact]
    public void Count_Returns_Zero_When_no_Elements_Added()
    {
        var AverageCalculator = new AverageCalculator();
        int result = AverageCalculator.Count();
        Assert.Equal(0, result); 
    }
}