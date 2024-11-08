﻿namespace ArgsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3) 
        {
                Console.WriteLine("Error in parameters count");
                Environment.Exit(1);
            }
            Console.WriteLine($"{args[0]}, {args[1]}, {args[2]}");
        }
    }
}
