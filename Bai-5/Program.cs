using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số hàng n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
