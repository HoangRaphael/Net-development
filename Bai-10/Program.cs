using System;

namespace SortArray
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

            Array.Sort(arr);

            Console.WriteLine("Mảng sau khi sắp xếp theo thứ tự tăng dần:");
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", arr[i]);

            Console.ReadKey();
        }
    }
}
