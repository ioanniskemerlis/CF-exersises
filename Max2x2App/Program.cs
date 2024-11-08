using System.Diagnostics.CodeAnalysis;

namespace Max2x2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int maxsum = int.MinValue;
            int row = 0;
            int column = 0;
            int[,] matrix =
            {
                {1,2,3,4,5,6},
                {2,3,4,5,6,7},
                {3,4,5,6,7,8},
                {3,4,5,6,8,9}
            };
            for (int i = 0; i < matrix.GetLength(0) - 1 ; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1 ; j++)
                {
                    sum = matrix[i,j] + matrix[i,j+1] + matrix[i +1,j] + matrix[i+1, j+1];
                    if (sum > maxsum)
                    {
                        maxsum = sum;
                        row = i;
                        column = j;
                    }
                }
            }
            Console.WriteLine($"Max sum: {maxsum}, Row: {row}, Column: {column}");
        }
    }
}