namespace OutputApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10123153;
            int num2 = 20000123;

            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            Console.WriteLine("Num1: " + num1);
            Console.WriteLine("Num1: {0,6:N2} Num2: {1,C2}", num1, num2);
            Console.WriteLine($"Num1: {num1,6:N0} Num2: {num2,8:N0} ");

        }
    }
}
