using System;

namespace FirstLastDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên n có 3 chữ số: ");
            int n = int.Parse(Console.ReadLine());

            int firstDigit = n / 100;
            int lastDigit = n % 10;

            Console.WriteLine("Chữ số đầu tiên của n là: {0}", firstDigit);
            Console.WriteLine("Chữ số cuối cùng của n là: {0}", lastDigit);
            Console.ReadKey();
        }
    }
}
