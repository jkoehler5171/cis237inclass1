using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();

            myEmployee.FirstName = "Jordan";
            myEmployee.LastName = "Koehler";
            myEmployee.WeeklySalary = 200.00m;

            Console.WriteLine(myEmployee.FirstName);
            Console.WriteLine(myEmployee);

            Employee[] employees = new Employee[10];

            employees[0] = new Employee("Bob", "Jenkins", 500.00m);
            employees[1] = new Employee("Bill", "Jenkins", 570.00m);
            employees[2] = new Employee("Ben", "Jenkins", 506.00m);
            employees[3] = new Employee("Bull", "Jenkins", 502.00m);
            employees[4] = new Employee("Betty", "Jenkins", 504.00m);
            employees[5] = new Employee("Barbara", "Jenkins", 520.00m);
            employees[6] = new Employee("Butch", "Jenkins", 50.00m);

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString() + " " + employee.YearlySalary());
                }
            }

        }
    }
}
