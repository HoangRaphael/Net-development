using System;

namespace EmployeeAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập họ tên nhân viên: ");
            string name = Console.ReadLine();

            Console.Write("Nhập ngày sinh nhân viên (dd/mm/yyyy): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - birthdate.Year;
            if (DateTime.Now.DayOfYear < birthdate.DayOfYear)
                age--;

            Console.WriteLine("Tuổi của nhân viên {0} là: {1}", name, age);
            Console.ReadKey();
        }
    }
}
