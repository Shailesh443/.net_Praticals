using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratical_2
{
    
        // Interface
        interface IPayroll
        {
            void CalculateSalary();
        }

        // Base Class
        class Employee
        {
            protected int empId;
            protected string empName;
            protected double basicSalary;

            public Employee(int id, string name, double salary)
            {
                empId = id;
                empName = name;
                basicSalary = salary;
            }

            public virtual void Display()
            {
                Console.WriteLine("\n------ Employee Details ------");
                Console.WriteLine("Employee ID   : " + empId);
                Console.WriteLine("Employee Name : " + empName);
                Console.WriteLine("Basic Salary  : " + basicSalary);
            }
        }

        // Derived Class
        class FullTimeEmployee : Employee, IPayroll
        {
            public FullTimeEmployee(int id, string name, double salary)
                : base(id, name, salary)
            {
            }

            // Interface Method
            public void CalculateSalary()
            {
                double hra = basicSalary * 0.20;
                double da = basicSalary * 0.10;
                double totalSalary = basicSalary + hra + da;

                Console.WriteLine("HRA           : " + hra);
                Console.WriteLine("DA            : " + da);
                Console.WriteLine("Total Salary  : " + totalSalary);
            }

            // Polymorphism (Method Overriding)
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Employee Type : Full Time");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter Employee ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                // Object Creation
                FullTimeEmployee emp = new FullTimeEmployee(id, name, salary);

                // Display Details
                emp.Display();

                // Calculate Salary
                emp.CalculateSalary();

                Console.WriteLine("\nPayroll Generated Successfully!");

                Console.ReadKey();
            }
        }
    }

