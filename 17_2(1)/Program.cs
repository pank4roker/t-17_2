using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("Ливанов", 1500, 1.5));
            employees.Add(new Engineer("Андрей", 7000, 2.5, 15));

            foreach (var empl in employees)
            {
                empl.ShowInfo();
            }

            ReadKey();
        }
    }
}
