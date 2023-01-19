using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }

    static public int MaximumWealth(int[][] accounts)
    {
        int maxWealth = 0;

        for (int customer = 0; customer < accounts.Length; customer++)
        {
            int currentCustomerWealth = 0;

            currentCustomerWealth = accounts[customer].Sum();
            
            if (maxWealth < currentCustomerWealth)
            {
                maxWealth = currentCustomerWealth;
            }
        }

        return maxWealth;
    }
}
