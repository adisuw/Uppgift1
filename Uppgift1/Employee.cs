using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Uppgift1.Utils;

namespace Uppgift1
{
    /// <summary>
    /// Employee class is our model class which contains states and behavior of the Employee
    /// only holds the object the value with some validation 
    /// </summary>
    class Employee
    {
        private string name;
        private double salary;
        private int id;
        public Employee(string name, double salary, int id)
        {
            Name = name;//validate first then, assign
            Salary = salary;
            Id = id;
        }

        public int Id { get; set; }
        public string Name
        {
            get => this.name;
            set
            {
                if (!value.Equals(""))
                {
                    this.name = value;
                }
            }
        }

        public double Salary
        {
            get => this.salary;
            set {
                if (UserInputReader.IsValidDouble(value))
                {
                    this.salary = value;
                }
            }
        }
    }
}
