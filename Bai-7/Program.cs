﻿using System;

namespace EquilateralTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số hàng n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
