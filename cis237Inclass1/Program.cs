using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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


            ImportCSV("employees.csv", employees);


            UserInterface ui = new UserInterface();



            //int choice = ui.GetUserInput();

            int choice = StaticUserInterface.GetUserInput();

            while (choice != 2)
            {
                if (choice == 1)
                {
                    string allOutput = "";

                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            allOutput += employee.ToString() + " " + employee.YearlySalary() + Environment.NewLine;
                        }
                    }

                    ui.PrintAllOutput(allOutput);

                    choice = ui.GetUserInput();

                }
            }

        }

        static bool ImportCSV(string pathToCsvFile, Employee[] employees)
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(pathToCsvFile);

                int counter = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    ProcessLine(line, employees, counter++);
                }

                return true;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
                   
        }

        static void ProcessLine(string line, Employee[] employees, int index)
        {
            string[] parts = line.Split(',');

            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            employees[index] = new Employee(firstName, lastName, salary);
        }

    }
}
