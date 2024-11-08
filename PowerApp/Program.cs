using System.Numerics;

namespace PowerApp
{
    /// <summary>
    /// ypologizei to b^power
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
        int mybase = 2;
        int power = 10;
        BigInteger result = 1;

        for (int i = 1; i<= power; i++)
        {
        result = result * mybase;
        }
        Console.WriteLine($"{mybase} ^ {power} = {result}");
        }
    }
}
