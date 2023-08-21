using System;

namespace MaxMinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số phần tử n: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("Phần tử lớn nhất trong mảng là: {0}", max);
            Console.WriteLine("Phần tử nhỏ nhất trong mảng là: {0}", min);
            Console.ReadKey();
        }
    }
}
