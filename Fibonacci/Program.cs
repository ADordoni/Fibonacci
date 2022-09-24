using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 0;
            Console.WriteLine("Ingrese un número:");
            int k = int.Parse(Console.ReadLine());
            while (i < k)
            {
                Console.WriteLine(i);
                int l = i + j;
                j = i;
                i = l;
            }
        }
    }
}
