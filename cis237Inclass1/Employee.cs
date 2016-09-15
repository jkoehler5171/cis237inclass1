using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Employee
    {

        // Backing Fields

        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        // Properties

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        //Public Methods

        public override string ToString()  //using the override will override the default method that is created alongside all objects
        {

            //.this refers to the current class
            return _firstName + " " + _lastName;
        }

        public decimal YearlySalary()
        {
            return this._weeklySalary * 52;
        }
        
        //Constructor

        public Employee(string firstName, string lastName, decimal weeklySalary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _weeklySalary = weeklySalary;
        }

        public Employee()
        {

        }
    }
}
