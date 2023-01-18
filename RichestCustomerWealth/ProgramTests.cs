using Xunit;

public class ProgramTests
{
    private int[][] arr1 = new int[][]
    {
            new int[] {1,2,3},
            new int[] {3,2,1}
    };
    private int[][] arr2 = new int[][]
    {
            new int[] {1,5},
            new int[] {7,3},
            new int[] {3,5}
    };
    private int[][] arr3 = new int[][]
    {
            new int[] {2,8,7},
            new int[] {7,1,3},
            new int[] {1,9,5}
    };

    [Fact]
    public void PassingMaximumWealth()
    {
        Assert.Equal(6, Program.MaximumWealth(arr1));
        Assert.Equal(10, Program.MaximumWealth(arr2));
        Assert.Equal(17, Program.MaximumWealth(arr3));
    }

    [Fact]
    public void FailingMaximunWealth()
    {
        Assert.NotEqual(3, Program.MaximumWealth(arr1));
        Assert.NotEqual(6, Program.MaximumWealth(arr2));
    }
}
