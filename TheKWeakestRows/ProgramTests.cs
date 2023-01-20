using Xunit;

public class ProgramTests
{
    private int[][] arr1 = new int[][]
    {
            new int[] {1,1,0,0,0},
            new int[] {1,1,1,1,0},
            new int[] {1,0,0,0,0},
            new int[] {1,1,0,0,0},
            new int[] {1,1,1,1,1}
    };
    private int[][] arr2 = new int[][]
    {
            new int[] {1,0,0,0},
            new int[] {1,1,1,1},
            new int[] {1,0,0,0},
            new int[] {1,0,0,0},
    };

    [Fact]
    public void PassingWeakestRows()
    {
        int[] expected1 = new int[] {2, 0, 3};
        int[] actual1 = Program.KWeakestRows(arr1, 3);

        for (int i = 0; i < expected1.Length; i++)
        {
            Assert.Equal(expected1[i], actual1[i]);
        }

        int[] expected2 = new int[] {0, 2};
        int[] actual2 = Program.KWeakestRows(arr2, 2);

        for (int i = 0; i < expected2.Length; i++)
        {
            Assert.Equal(expected2[i], actual2[i]);
        }
    }
}