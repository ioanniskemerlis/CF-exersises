namespace RightTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPSILON = 0.000005;
            double a = 0.0;
            double b = 0.0;
            double c = 0.0;
            bool isRight = false;

            Console.WriteLine("Please enter a,b,c");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Format error. a must be double");
            }
            if (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Format error. b must be double");
            }
            if (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Format error. c must be double");
            }
            isRight = Math.Abs(a * a - b * b - c * c) <= EPSILON;
            Console.WriteLine($"The triangle is {0}right", (isRight) ? " " : " not ");
        }
    }
}
