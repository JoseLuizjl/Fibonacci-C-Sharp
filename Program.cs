using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, num2 = 1, result = 0;

            Console.WriteLine("How many values:");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fibonacci sequence with {value} values:");

            for (int i = 0; i < value; i++)
            {
                Console.Write(num);

                if (i < value - 1)
                {
                    Console.Write(", ");
                }

                result = num + num2;
                num = num2;
                num2 = result;
            }

            Console.ReadKey();
        }
    }
}
