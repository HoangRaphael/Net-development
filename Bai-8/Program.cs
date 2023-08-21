using System;

namespace TriangleNumbersIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số hàng n: ");
            int n = int.Parse(Console.ReadLine());

            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", count);
                    count++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
