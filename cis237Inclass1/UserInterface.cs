using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class UserInterface
    {

        //Public Methods

        public int GetUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine();

            while(input != "1" && input != "2")
            {
                Console.WriteLine("Invalid entry");
                Console.WriteLine("Please Try Again");
                Console.WriteLine();

                this.PrintMenu();

                input = Console.ReadLine();
            }

            return Int32.Parse(input);

        }

        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");

        }

    }
}
