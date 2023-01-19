namespace ReduseToZero;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static public int NumberOfSteps(int number)
    {
        int steps = 0;

        while (number != 0)
        {
            number = number % 2 == 1 ? number - 1 : number / 2;
            steps++;
        }
        
        return steps;
    }
}
