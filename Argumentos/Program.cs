using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop for the arguments
            for(int i = 0; i < args.Length ; i++)
            {
                // Prints each argument
                Console.WriteLine(args[1]);
            }
        }
    }
}
