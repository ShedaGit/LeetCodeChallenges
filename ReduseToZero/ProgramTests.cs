using Xunit;
namespace ReduseToZero;

public class ProgramTests
{
    [Fact]
    public void PassingMaximumWealth()
    {
        Assert.Equal(6, Program.NumberOfSteps(14));
        Assert.Equal(4, Program.NumberOfSteps(8));
        Assert.Equal(12, Program.NumberOfSteps(123));
    }

    [Fact]
    public void FailingMaximunWealth()
    {
        Assert.NotEqual(3, Program.NumberOfSteps(14));
        Assert.NotEqual(6, Program.NumberOfSteps(8));
    }
}