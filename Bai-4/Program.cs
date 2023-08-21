using System;

namespace CountDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            while (n > 0)
            {
                count++;
                n /= 10;
            }

            Console.WriteLine("Số chữ số thập phân đơn lẻ của n là: {0}", count);
            Console.ReadKey();
        }
    }
}
