namespace ArraysTwoDimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int MAX = 6;
            const int MIN = 1;


            int[,] grid = new int[3, 4];
            int[,] grid2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.WriteLine($"{grid2[i,j]}");
                 
                }
                Console.WriteLine();
            }
            for (int i = 0;i < grid2.GetLength(0); i++)
            {
                for(int j = 0;j < grid2.GetLength(1); j++)
                {
                    grid2[i, j] = random.Next(MAX - MIN + 1) + MIN;
                }
            }
        }
        
    }
}
