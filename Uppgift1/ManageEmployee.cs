using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift1.Utils;

namespace Uppgift1
{
    /// <summary>
    /// ManageEmployee class is used mainly to add, display and delete employee information from the list
    /// The class is also used as an entry point to the application with its Start() method.
    /// </summary>
    class ManageEmployee
    {
        private List<Employee> employees = new List<Employee>();
        public void Start()
        {
            do
            {
                Console.WriteLine("============Welcome to Employee Management Program============\n ");
                Console.WriteLine(
                    "To Register new Employee press R\n" +
                    "To List Available Employee press L\n " +
                    "To Delete a registered Employee press D\n" +
                    "To exit press any key\n");
                Console.WriteLine("============================================================== ");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "R":
                    case "r":
                    {
                        var emp = new Employee(UserInputReader.ReadString(), UserInputReader.ReadDouble(),
                            UserInputReader.ReadInt());
                        AddEmployee(emp);
                        break;
                    }
                    case "L":
                    case "l":
                        DisplayEmployees();
                        break;
                    case "D":
                    case "d":
                    {
                        //Console.Write("Please enter the employee Id: ");
                        var id = UserInputReader.ReadInt();
                        DeleteEmployee(id);
                        break;
                    }
                       
                    default:
                    {
                        Console.WriteLine("Exiting the Program...");
                        Environment.Exit(1);
                        break;
                    }
                }
                
            } while (true);


        }

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public void DisplayEmployees()
        {
            if (employees != null)
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Employee Name: {employee.Name} \n" +
                                      $"Employee Salary: {employee.Salary} \n" +
                                      $"Employee Id: {employee.Id}");
                
                }
            }
            else
            {
                Console.WriteLine("Ops.. the List is Empty!");
            }
            
        }

        public void DeleteEmployee(int id)
        {
            Employee toBeRemoved = null;
            bool removed = false;

            if (employees == null)
            {
                Console.WriteLine("The list is empty!");
                return;
            }
            foreach (var emp in employees)
            {
                if (!emp.Equals(null) && (emp.Id == id))
                {
                    toBeRemoved = emp;
                    removed = true;
                    //employees.Remove(emp);
                    
                }
                else
                {
                    Console.WriteLine("There is no such employee with this Id!");
                }
            }

            if (!removed) return;
            employees.Remove(toBeRemoved);
            Console.WriteLine("The information is deleted Successfully!");
        }
    }
}
