using System;
namespace ConsoleApp25
{
    class Program
    {
        public static void Main (string[] args)
        {
            Employee employee = new Employee();
            employee.GetInfo(7000, 7);
            employee.AddSalary();
            employee.AddWork();
            Console.WriteLine(employee.Salary);
        }
    }
}