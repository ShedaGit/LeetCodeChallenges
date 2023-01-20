class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hi there!");
    }

    public static int[] KWeakestRows(int[][] mat, int k)
    {
        int[] result = new int[k];

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < mat.Length; i++)
        {
            int numberOfSoldiers = 0;

            for (int j = 0; j < mat[i].Length; j++)
            {
                if (mat[i][j] == 0)
                {
                    continue;
                }

                numberOfSoldiers++;
            }

            dict[i] = numberOfSoldiers;
        }

        var sortedDict = dict.OrderBy(x => x.Value).ToList();

        for (int i = 0; i < result.Length; i++)
        {
            result[i] = sortedDict[i].Key;
        }

        return result;
    }
}