namespace ArraysOneDimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[2];
            arr1[0] = 1;
            arr1[1] = 2;

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"{arr1[i]}");
            }
            int[] arr2 = { 1, 2, 3};

            foreach (int el in arr2)
            {
                Console.WriteLine(el);
            }

                int[] arr3 = new int[] { 1, 2, 3 };

                int[] arr4 = [1, 2, 3, 4];
            }
        public static bool IsSymmetric(int[] arr)
        {
   
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[arr.Length - i])
                    {
                return false;
            }return true;
            }
        }
        }
    }
