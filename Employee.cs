using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Employee
    {
        public int Hours { get; set; }
        public int Salary { get; set; }
        public int GetInfo(int salary, int hours)
        {
            this.Hours = hours;
            this.Salary = salary;
            return salary;
        }
        public int AddSalary()
        { 
            if (Salary < 5200)
            {
                Salary += 100;
            }
            return Salary;
        }
        public int AddWork()
        {
            if (Hours > 5)
            {
                Salary += 5;
            }
            return Salary;
        }
    }
}
