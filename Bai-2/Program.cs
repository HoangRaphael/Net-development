using System;

namespace RetirementDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập họ tên nhân viên nam: ");
            string name = Console.ReadLine();

            Console.Write("Nhập ngày sinh nhân viên nam (dd/mm/yyyy): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            int retirementAge = 60;
            DateTime retirementDate = birthdate.AddYears(retirementAge);

            Console.WriteLine("Ngày về hưu của nhân viên nam {0} là: {1}", name, retirementDate.ToString("dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}
