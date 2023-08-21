using System;

namespace TaxiFare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập họ tên khách hàng: ");
            string name = Console.ReadLine();

            Console.Write("Nhập số km đã đi: ");
            double distance = double.Parse(Console.ReadLine());

            double fare;
            if (distance <= 1)
                fare = 11000;
            else
                fare = 11000 + (distance - 1) * 9000;

            Console.WriteLine("Số tiền phải trả của khách hàng {0} là: {1}đ", name, fare);
            Console.ReadKey();
        }
    }
}
